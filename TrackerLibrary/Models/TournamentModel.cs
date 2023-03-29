using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {

        /// <summary>
        /// the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// probably tournament number  might edit this later
        /// </summary>
        public decimal EntryName { get; set; }


        /// <summary>
        /// teams that have entered the tournament 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// prizes for the tournament
        /// either its money or just gifts
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();


        /// <summary>
        /// how many rounds will be in the tournament tho this will be done randomly
        /// </summary>
        public List<List<MatchUpModel>> rounds { get; set; } = new List<List<MatchUpModel>>();
    }

}
