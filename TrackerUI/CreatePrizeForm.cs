using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        

        public CreatePrizeForm(IPrizeRequester caller) ////Dependency Injection => In the constructor we are informing the Dependencies for this Class
        {
            InitializeComponent();
            callingForm = caller; //The caller variable is only visible within the scope of this method
           
            //this action is necessary so it can be accessible to the whole class
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameTextBox.Text, 
                                                  placeNumberTextBox.Text, 
                                                  prizeAmountTextBox.Text, 
                                                  prizePercentageTextBox.Text);


                GlobalConfig.Connection.CreatePrize(model); // To assign the return of this method is not necessary because it's a Reference Type
                //Whoever call this method it's like "Here is the model you asked for".

                callingForm.PrizeComplete(model); //Method responsible for data transportation?
                

                this.Close();


                //Cleaning up the form

                //placeNameTextBox.Text = "";
                //placeNumberTextBox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTextBox.Text = "0";


            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check them and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                //Another way to do it is instead of seting output to false, 
                //to return false here and return true after all the validations.
                //This would avoid all the other validations instead this point is false.
                //However if we did this we wouldn't be able to point out all the invalid values.
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameTextBox.Text.Length < 0)
            {
                output = false;
            }

            decimal prizeAmout = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmout);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizeAmountValid == false)
            {
                output = false;
            }

            if (prizeAmout <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
