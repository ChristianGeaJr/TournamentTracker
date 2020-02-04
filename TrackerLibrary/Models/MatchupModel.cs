using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();
       
        /// <summary>
        /// The ID from the Database that is going to be used identify the Winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// The winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Wich round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchUpEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Machup not yet determined.";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
