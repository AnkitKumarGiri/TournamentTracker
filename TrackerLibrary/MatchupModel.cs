using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Stores the entries for the current Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the Winner of the current matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the Matchup Round number the current Matchup
        /// is in
        /// </summary>
        public int MatchupRound { get; set; }
    }
}