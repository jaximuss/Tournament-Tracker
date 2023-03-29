using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// this is every team member in every team we are making this a class because 
    /// </summary>
    public class PersonModel
    {

        /// <summary>
        /// first name of each player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// last name of each player
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// email address of each
        /// </summary>
        public int EmailAddress { get; set; }


        /// <summary>
        /// cellphone number of each person in the tournament
        /// </summary>
        public int CellphoneNumber { get; set; }

    }

}
