using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list Randomly of teams
        // Check if it's big enough, if not, addi n byes // 2*2*2*2 2^4
        // Create our first round of matchups
        // Create every round after that: 8 matchups => 4 matchups => 2 matchups => 1 matchup

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeam = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeam.Count);
            int byes = NumberOfByes(rounds, randomizedTeam.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeam));

            CreateOtherRounds(model, rounds);

          

        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();

            List<MatchupModel> toScore = new List<MatchupModel>();
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if ( rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));

            int endingRound = model.CheckCurrentRound();

            if (endingRound > startingRound)
            {
                //Alert Users
                model.AlertUsersToNewRownd();
            }

         //// <=

        //GlobalConfig.Connection.UpdateMatchup(m);

        }

        public static void AlertUsersToNewRownd(this TournamentModel model)
        {
            int currentRoundNumber = CheckCurrentRound(model);
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (MatchupModel matchup in currentRound)
            {
                foreach (MatchUpEntryModel me in matchup.Entries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchUpEntryModel competitor)
        {

            if (string.IsNullOrWhiteSpace(p.EmailAddress))
            {
                return;
            }

            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();

            if (competitor != null)
            {
                subject = $"You have a new matchup with {competitor.TeamCompeting.TeamName}.";
                body.AppendLine("<h1>You have a new matchup</h1>");
                body.Append("<strong>Competitor: </strong>");
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a great time!!");
                body.AppendLine("~Tournament Tracker");
            }
            else
            {
                subject = $"You have a bye week this round.";
                body.AppendLine("Enjoy your week off.");
                body.AppendLine("~Tournament Tracker");
            }

            to = p.EmailAddress;

            EmalLogic.SendEmail(to, subject, body.ToString());
        }

        public static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;

            foreach (List<MatchupModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }
            //The tournament is complete.

            double finalScoreTeam1 = model.Rounds.Last().Last().Entries.First().Score;
            double finalScoreTeam2 = model.Rounds.Last().Last().Entries.Last().Score;

            if(finalScoreTeam1 > finalScoreTeam2)
            {
                model.Winner = model.Rounds.Last().Last().Entries.First().TeamCompeting;
            }
            else
            {
                model.Winner = model.Rounds.Last().Last().Entries.Last().TeamCompeting;
            }
           
            CompleteTournament(model);

            return output -1;
        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);
            TeamModel winners =  model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            PrizeModel firstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
            PrizeModel secondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();

            if (model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;

                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalculatePrizePayout(totalIncome);
                }
                if (secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CalculatePrizePayout(totalIncome);
                }
            }

            // Send email to all tournament.

            //string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();

            
                subject = $"In {model.TournamentName} {winners.TeamName} has won!";
                body.AppendLine("<h1>We have a WINNER!</h1>");
                body.Append("<P>Congratulations to our winner ou a great Tournament. </P>");
                body.AppendLine("<br/>");

            if (winnerPrize > 0)
            {
                body.AppendLine($"<p>The winnar {winners.TeamName} will receive ${winnerPrize}</p>");
            }
            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p>The runnerup {runnerUp.TeamName} will receive ${runnerUpPrize}</p>");
            }

                body.AppendLine("<p>Thanks for a great tournament!!</p>");
                body.AppendLine("~Tournament Tracker");

            List<string> bcc = new List<string>();

            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach (PersonModel p in t.TeamMembers)
                {
                    if (!string.IsNullOrWhiteSpace(p.EmailAddress))
                    {
                        bcc.Add(p.EmailAddress); 
                    }
                }
            }
            

            EmalLogic.SendEmail(new List<string>(), bcc, subject, body.ToString());

            //Complete Tournament
            model.CompleteTournament();
        }

        private static decimal CalculatePrizePayout(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;
            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output =  Decimal.Multiply(totalIncome, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }

        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchUpEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            //greateror lesser
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                //checks for bye week entry
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue; // => It continues the foreach at the next iteration.
                }

                //0 = false / low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in thei application.");
                    }
                }
                //1 = true / high score wins
                else
                {
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in thei application.");
                    }
                } 
            }

        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currentMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currentMatchup.Entries.Add(new MatchUpEntryModel() { ParentMatchup = match });

                    if (currentMatchup.Entries.Count > 1)
                    {
                        currentMatchup.MatchupRound = round;
                        currentRound.Add(currentMatchup);
                        currentMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currentRound);
                previousRound = currentRound;
                currentRound = new List<MatchupModel>();
                round += 1;
            }

        }

        // This method orgaizes the matchups and the matchupEntries of the first Round
        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currentMatchup = new MatchupModel();

            foreach (var team in teams)
            {
                currentMatchup.Entries.Add(new MatchUpEntryModel() { TeamCompeting = team });
                //currentMatchup.MatchupRound = 1; // Comment here

                if (byes > 0 || currentMatchup.Entries.Count > 1)
                {

                    // Condition 1 => There are byes to be assigned to the matches (Obs: They are not added as a matchpEntry)
                    // Condition 2 => If the matchup has the correct amount of teams (2  = (> 1))

                    currentMatchup.MatchupRound = 1;
                    output.Add(currentMatchup);
                    currentMatchup = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {

                output += 1;

                val *= 2; // val is going to grow to the power of two 2^n
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            //= cards.OrderBy(a => Guid.NewGuid()).ToList();
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
