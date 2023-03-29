using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAcess.TextHelpers; 

namespace TrackerLibrary.DataAcess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        // TODO - make the createprize save to the Textfile

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //PrizesFile.FullFilePath().LoadFile()
            return model;
        }
    }
}
