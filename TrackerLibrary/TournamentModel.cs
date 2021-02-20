using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee for each team
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of teams entered
        /// in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represent the list of prizes
        /// the tournament has
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents all the rounds the tournament has
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
