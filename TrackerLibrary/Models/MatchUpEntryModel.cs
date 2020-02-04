using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary> 
    /// Represents a team in this matchup
    /// </summary>

    public class MatchUpEntryModel
    {

        /// <summary>
        /// The unique identifier for the matchup entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the Team.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary> -- XML Comment (this comment also displays information abount the class member when it's being typed.)
        /// Represents the team in this matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score of this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The unique identifier for the parent matchup (team)
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        
    }
}
