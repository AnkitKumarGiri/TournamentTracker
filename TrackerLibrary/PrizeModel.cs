using System.Collections.Generic;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place/rank of the prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name for the current prize
        /// like champion/runner up
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }

}