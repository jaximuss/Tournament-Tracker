using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// this goes into the app.config file and looks for appsettings then we give it the key to find the value we want
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FullFilePath(this string fileName) //prizemodels.csv
        {

            //C:\Users\chidi\OneDrive\Desktop\Tournament Application\textfile\\{fileName}; 
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PrizeModel P = new PrizeModel();

                P.ID = int.Parse(columns[0]);

                P.PlaceNumber = int.Parse(columns[1]);

                P.PlaceName = columns[2];

                P.PrizeAmount = decimal.Parse(columns[3]);

                P.PrizePercentage = double.Parse(columns[4]);


                output.Add(P);


            }
            return output;

        }
    }
} 
