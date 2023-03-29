using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// for the team competing against eachother
        /// </summary>
        public TeamModel TeamCompeting { get; set; }


        /// <summary>
        /// the score that each team acquires
        /// </summary>
        public double score { get; set; }


        /// <summary>
        /// for the team that wins their previous match and are paired up against eachother
        /// </summary>
        public MatchUpModel ParentMatchUp { get; set; }

    }
}
