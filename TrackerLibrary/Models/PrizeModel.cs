using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    //either prizepercentage or we just use the sum
    public class PrizeModel
    {
        /// <summary>
        /// the ID key in the data base
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// the position a team finished in
        /// </summary>
        public int PlaceNumber { get; set; }


        /// <summary>
        /// the position a team finished in 
        /// </summary>
        /// <example>
        /// this team finished in 3rd place or 2nd 
        /// </example>
        public string PlaceName { get; set; }

        /// <summary>
        /// the amount of money in the prize pool i.e that exact amount
        /// </summary>
        public decimal PrizeAmount { get; set; }


        /// <summary>
        /// the percentage each team get from the prize pool
        /// </summary>
        public double PrizePercentage { get; set; }

        /// <summary>
        /// ctor for the class
        /// </summary>
        public PrizeModel()
        {

        }


        /// <summary>
        /// ctor for the class so that it allows string on the go and bring it here to be constructed overloading the ctor 
        /// </summary>
        /// <param name="placeNumber">this will be converted into an int</param>
        /// <param name="placeName">this will remain a string</param>
        /// <param name="prizeAmount">this will be converted into an decimal</param>
        /// <param name="prizePercentage">this will be converted into a double</param>
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            //converting placeNumber
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            //converting prizeAmount
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            //converting prizePercentage
            double prizePercentagValue = 0;
            double.TryParse(prizePercentage, out prizePercentagValue);
            PrizePercentage = prizePercentagValue;



        }
    }


}
