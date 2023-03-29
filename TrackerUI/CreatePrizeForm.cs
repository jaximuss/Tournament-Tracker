using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAcess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //lets validate the data that has been stoered or inputed by the user
                if (ValidateData())
                    {
                    PrizeModel model = new PrizeModel
                        (
                        PlaceNumberTextBox.Text,
                        PlaceNameTextBox.Text,
                        PrizeAmountTextBox.Text,
                        PrizePercentageTextBox.Text
                        );

                //after that if the validation is true then lets store the model
                //it will store it in the sql first then store in the text file

                //foreach (IDataConnection DB in GlobalConfig.connections)
                //{
                //    DB.CreatePrize(model);
                //}

                IDataConnection DB = GlobalConfig.connections;
                DB.CreatePrize(model);


                //CLEAR AFTER ITS DONE
                    PlaceNumberTextBox.Text = "";
                    PlaceNameTextBox.Text = "";
                    PrizeAmountTextBox.Text = "0";
                    PrizePercentageTextBox.Text ="0";
            }
            else
            {
                MessageBox.Show("INVALID FORM!! PLEASE INPUT THE CORRECT INFORMATION AND TRY AGAIN.");
            }
         
        }

        /// <summary>
        /// check if the data in the textboxes are correct
        /// </summary>
        /// <returns>either true or false</returns>
        private bool ValidateData()
        {
            bool output = true;
            int placeNumber  = 0;

            bool plaveValueValidator = int.TryParse(PlaceNumberTextBox.Text, out placeNumber);

            if (!plaveValueValidator)
            {
                output= false;
            }
           
            if (placeNumber < 1) 
            
            { 
                output = false; 
            }

            if (PlaceNumberTextBox.Text.Length == 0) 
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValidator = decimal.TryParse(PrizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValidator = double.TryParse(PrizePercentageTextBox.Text, out prizePercentage);



            if (!prizeAmountValidator || !prizePercentageValidator)
            {
                output = false;
            }

            if (prizeAmount <=0 && prizePercentage <=0)

            {
                output = false;
            }

            if (PrizePercentageTextBox.Text.Length < 0 || PrizePercentageTextBox.Text.Length > 100)
            {
                output = false;
            }


            return output;
        }

        
    }
}
