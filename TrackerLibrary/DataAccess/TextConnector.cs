using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//---Planning section----





namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        //TODO - Wire up the CreatePrize method for Text Files.
        public void CreatePrize(PrizeModel model)
        {

            // Load the Text File and Convert the Text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //We don't pass any value into the methods because they take the first value (PrizesFile) as reference.
            // This happens because we are using refferences methods.

            // Find the max ID

            int currentId = 0 + 1; // In case the the file is empty.

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(prize => prize.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new recored with the new ID (max + 1)
            prizes.Add(model);


            // Convert the Prize to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile();

        }

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int CurrentId = 1;
            if (people.Count > 0)
            {
               CurrentId = people.OrderByDescending(person => person.Id).First().Id + 1;
            }

            model.Id = CurrentId;
            people.Add(model);

            people.SaveToPersonFile();

        }

        public void CreateTeam(TeamModel model)
        {


            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int CurrentId = 1;

            if (teams.Count > 0)
            {
                CurrentId = teams.OrderByDescending(team => team.Id).First().Id + 1;
            }

            model.Id = CurrentId;

            teams.Add(model);

            teams.SaveToTeamFile();

        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

            int CurrentId = 1;

            if (tournaments.Count > 0)
            {
                CurrentId = tournaments.OrderByDescending(team => team.Id).First().Id + 1;
            }

            model.Id = CurrentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);

            //return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        }       
        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

           
            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }



}
