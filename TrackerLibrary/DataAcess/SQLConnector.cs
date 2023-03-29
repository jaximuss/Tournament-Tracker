using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess
{

//   @PlaceNumber int,
//@PlaceName nvarchar(100),
//@PrizeAmount money,
//   @PrizePercentage float,
//@ID int = 0 output
    public class SQLConnector : IDataConnection
    {

        /// <summary>
        /// creates a new prize into the database or textfile
        /// </summary>
        /// <param name="model">the prize information</param>
        /// <returns>the prize identification and the prize information </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {



            //we are using the using keyword here to make sure when the appplication starts it closes when we reach the last bracket so as to not allow memory leak
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("tournaments")))
            {
                //adding the values to the DB
                var p = new DynamicParameters();
                p.Add("@PlaceNumber" ,model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@ID",0 , dbType: DbType .Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_insert" , p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");

                return model;

            }


        }
    }
}
