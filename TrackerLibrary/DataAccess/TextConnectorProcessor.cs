using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//---Planning section (Strategy)----
// * Load the Text File
// * Convert the Text to List<PrizeModel>
// Find the new ID
// Add the new recored with the new ID (max + 1)
// Convert the Prize to List<string>
// Save the List<string> to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            // C:\CSharp24hCourseProject\data\PrizeModels.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }



        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = int.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }


        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }

            return output;

        }

        public static void SaveToPersonFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }
            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }


        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {

            //3,Corinthians,1|3|4|8

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (var id in personIds)
                {
                    t.TeamMembers.Add(people.Where(person => person.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {

            List<string> lines = new List<string>();

            foreach (var t in models)
            {

                List<string> membersId = new List<string>();

                foreach (var member in t.TeamMembers)
                {
                    membersId.Add(member.Id.ToString());
                }


                lines.Add($"{ t.Id },{ t.TeamName },{ string.Join("|", membersId) }");

            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model)
        {
            //Loop through each round
            //Loop through each matchup
            //Get the id of the new matchup and save the record
            //Loop through each Matchup entry, get the id and save it.

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    //Load all of the matchups from the file
                    //Get the top id and add 1
                    //Store the id
                    //Save the natchup record.

                    matchup.saveMatchupFile();

                    
                }
            }
        }


        public static List<MatchUpEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchUpEntryModel> output = new List<MatchUpEntryModel>();

            foreach (string line in lines)
            {
                //id = 0, TeamCompeting = 1, Score = 2, ParentMatchup = 3;
                string[] cols = line.Split(',');

                MatchUpEntryModel me = new MatchUpEntryModel();
                me.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookUpTeamById(int.Parse(cols[1]));
                }

                
                me.Score = double.Parse(cols[2]);

                int parentId = 0;

                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookUpMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }

                output.Add(me);
            }

            return output;
        }

        public static List<MatchUpEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchUpEntryModel> output = new List<MatchUpEntryModel>();
            //List<MatchUpEntryModel> entres = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            List<string> entres = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entres)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }

        public static TeamModel LookUpTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels().First();
                }
            }

            return null;
        }

        public static MatchupModel LookUpMatchupById (int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);

                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }

            return null;
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //Id = 0 , Entries = 1(ids delimited by pipe), winner = 2, matchupRound = 3
            List<MatchupModel> output = new List<MatchupModel>();
            //List<MatchUpEntryModel> matchups = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel m = new MatchupModel();
                m.Id = int.Parse(cols[0]);
                m.Entries = ConvertStringToMatchupEntryModels(cols[1]);

                if (cols[2].Length == 0)
                {
                    m.Winner = null;
                }
                else
                {
                    m.Winner = LookUpTeamById(int.Parse(cols[2]));
                }
                
                m.MatchupRound = int.Parse(cols[3]);
                

                output.Add(m);
            }

            return output;
        }

        public static void saveMatchupFile(this MatchupModel matchup)
        {

            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int CurrentId = 1;

            if (matchups.Count > 0)
            {
                CurrentId = matchups.OrderByDescending(m => m.Id).First().Id + 1;
            }

            matchup.Id = CurrentId;

            matchups.Add(matchup);


            foreach (MatchUpEntryModel entry in matchup.Entries)
            {
                entry.saveEntryToFile();
            }

            //save to file------
            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                List<string> entryIds = new List<string>();

                foreach (MatchUpEntryModel e in m.Entries)
                {
                    entryIds.Add(e.Id.ToString());
                }

                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ string.Join("|", entryIds) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
            //---End Save to File -------
        }

        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();

            //We are going to replace a metchup for the new one

            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);

            matchups.Add(matchup); // <=


            foreach (MatchUpEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            //save to file------
            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                List<string> entryIds = new List<string>();

                foreach (MatchUpEntryModel e in m.Entries)
                {
                    entryIds.Add(e.Id.ToString());
                }

                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ string.Join("|", entryIds) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
            //---End Save to File -------
        }

        public static void saveEntryToFile(this MatchUpEntryModel entry)
        {
            //1 = id, 2 = teamCompeting, 3 = score, 4 = parentMatchup

            List<MatchUpEntryModel> entries = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int CurrentId = 1;

            if (entries.Count > 0)
            {
                CurrentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = CurrentId;
            entries.Add(entry);

            //Save to file-----------
            List<string> lines = new List<string>();

            foreach (MatchUpEntryModel e in entries)
            {
                string parent = "";

                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }

                string teamCompiting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompiting = e.TeamCompeting.Id.ToString();
                }

                lines.Add($"{ e.Id },{ teamCompiting },{ e.Score },{ parent }");
            }

            File.WriteAllLines(GlobalConfig.MatchUpEntryFile.FullFilePath(), lines);

            //------------------------

        }

        public static void UpdateEntryToFile(this MatchUpEntryModel entry)
        {
            //1 = id, 2 = teamCompeting, 3 = score, 4 = parentMatchup

            List<MatchUpEntryModel> entries = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchUpEntryModel OldEntry = new MatchUpEntryModel();

            foreach (MatchUpEntryModel e in entries)
            {
                if (e.Id == entry.Id)
                {
                    OldEntry = e;
                }
            }
            entries.Remove(OldEntry);

            entries.Add(entry);

            //Save to file-----------
            List<string> lines = new List<string>();

            foreach (MatchUpEntryModel e in entries)
            {
                string parent = "";

                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }

                string teamCompiting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompiting = e.TeamCompeting.Id.ToString();
                }

                lines.Add($"{ e.Id },{ teamCompiting },{ e.Score },{ parent }");
            }

            File.WriteAllLines(GlobalConfig.MatchUpEntryFile.FullFilePath(), lines);

            //------------------------
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            //Id, TournamentName, EntryFee, (id|id|id| - List of EnteredTeams), (id|id|id| - List of Prizes), (Rounds - id^id^id|id^id^id|id^id^id)

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teamModels = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizeModels = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel t = new TournamentModel();
                t.Id = int.Parse(cols[0]);
                t.TournamentName = cols[1];
                t.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string teamId in teamIds)
                {
                    t.EnteredTeams.Add(teamModels.Where(tm => tm.Id == int.Parse(teamId)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string prizeId in prizeIds)
                    {
                        t.Prizes.Add(prizeModels.Where(pz => pz.Id == int.Parse(prizeId)).First());
                    } 
                }

                //Capture rounds Information.

                string[] rounds = cols[5].Split('|');
                

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();

                    foreach (string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }

                    t.Rounds.Add(ms);
                }

                

                output.Add(t);
            }

            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            //(Rounds - id^id^id|id^id^id|id^id^id)

            List<string> lines = new List<string>();

            foreach (TournamentModel t in models)
            {
                List<string> teamIds = new List<string>();
                List<string> prizeIds = new List<string>();
                List<string> rounds = new List<string>();

                foreach (TeamModel team in t.EnteredTeams)
                {
                    teamIds.Add(team.Id.ToString());
                }

                foreach (PrizeModel prize in t.Prizes)
                {
                    prizeIds.Add(prize.Id.ToString());
                }


                
                foreach (var round in t.Rounds)
                {
                    List<string> matches = new List<string>();
                    
                    foreach (var match in round)
                    {
                        matches.Add(match.Id.ToString());
                    }

                    rounds.Add(string.Join("^", matches));

                }


                lines.Add($"{ t.Id },{ t.TournamentName },{ t.EntryFee },{ string.Join("|", teamIds) },{ string.Join("|", prizeIds) },{ string.Join("|", rounds) }");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }

    }
}
