using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchUpModel
    {

        /// <summary>
        /// teams that have entered into the tournament
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();


        /// <summary>
        /// team that won the tournament
        /// </summary>
        public TeamModel winner { get; set; }


        /// <summary>
        /// the round that the match was played!@
        /// </summary>
        public int MatchUpRound { get; set; }


    }
}
