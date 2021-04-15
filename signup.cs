using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherAppUI
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            radCelsius.Checked = true; //Set the celsius radio button checked by default
        }

        //Globals
        //---------------------------
        List<string> cities = new List<string>(); //Create a list to store the cities the user picks
        List<string> towns = new List<string>()
            {
                "Johannesburg",
                "Pretoria",
                "Durban",
                "Polokwane",
                "cape Town"
            }; //This list will feed the combo box and be altered as the users enters more cities
        //end of globals
        //--------------------------


        //Begin events
        //-------------------------------

        //Begin sign up event
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Error check begin
            if (errorCheck(txtFname))
            {
                if (errorCheck(txtSname))
                {
                    if (errorCheck(txtUsername))
                    {
                        if (cboCity.SelectedIndex != -1)
                        {
                            if (cboUserType.SelectedIndex != -1) //Error check end
                            {
                                JSONconnection js = new JSONconnection(); //Create instance of the JSON class to use the JSON methods

                                //Begin collecting the user info from the textboxes,combo boxes and radio buttons
                                string username = txtUsername.Text;
                                string fName = txtFname.Text;
                                string sName = txtSname.Text;
                                string pass = txtPassword.Text;
                                string homeCity = cboCity.Text;
                                int userType = cboUserType.SelectedIndex;
                                bool isCelsius;

                                if (radCelsius.Checked == true)
                                    isCelsius = true;
                                else
                                    isCelsius = false;
                                //End of collection of user information

                                if (js.signUp(userType, username, fName, sName, pass, isCelsius, homeCity, cities)) //Send all the collected information to the sign up method, return true if the user was successfully signed up
                                {
                                    MessageBox.Show(fName + " " + sName + " has been added as " + username);//Tell the user that the sign up was successful
                                    login lg = new login(); //Open the login page so that they can now login
                                    this.Hide();
                                    lg.Show();
                                }
                                else
                                {
                                    MessageBox.Show("User Could not be added... Please try again"); //Let the uwser that there was a problem with the registration, The error has already been displayed to them
                                    //Clear all fields
                                    txtFname.Clear();
                                    txtSname.Clear();
                                    txtPassword.Clear();
                                    txtUsername.Clear();
                                    lstboxCities.Items.Clear();
                                    cboCity.SelectedIndex = -1;
                                    cboUserType.SelectedIndex = -1;
                                    cboExtraCity.SelectedIndex = -1;
                                }
                            }
                            else
                            {
                                captureError.SetError(cboCity, "Please select a user type"); //Display error message if the user type was not selected
                            }
                        }
                        else
                        {
                            captureError.SetError(cboCity, "Please select a city"); //Display error message if the home town was not selected
                        }
                    }
                }
            }
        }


        //begin Landing page event
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to go back to the starter page. Are you sure you want to quit?", "confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Landing ld = new Landing();
                ld.Show();
                this.Hide();
            }
        }


        //Begin the add extra city event
        private void btnAddcity_Click(object sender, EventArgs e)
        {
            string city = cboCity.Text;
            string extraCity = cboExtraCity.Text;
            lstboxCities.Visible = true;

            foreach (string cit in towns)
            {
                if (!city.Equals(cit) && !cit.Equals(extraCity))
                {
                    lstboxCities.Items.Add(extraCity);
                    cboExtraCity.Items.Remove(extraCity);
                    cities.Add(extraCity);
                    cboExtraCity.SelectedIndex = -1;
                    break;
                }
            }


        }


        //Begin the login link 
        private void linkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }


        //Begin the exit application event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExtraCityCombo();
        }

        //End of events
        //--------------------------------




        //start method helpers
        //---------------------------


        //Method to check the controls for errors
        private bool errorCheck(TextBox txt) //Accept the control to be checked
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Clear();
                captureError.SetError(txt, "This cannot be empty");
                return false; //Display error message for the control and return false
            }
            else
            {
                return true; //return true when the data is valid
            }
        }

        //method that will load the combo box of the extra cities
        private void loadExtraCityCombo()
        {
            cboExtraCity.Items.Clear();

            foreach (string item in towns)
            {
                if (!item.Equals(cboCity.Text))
                {
                    cboExtraCity.Items.Add(item);
                }
            }
        }

        //End of method helpers
        //----------------------------

    }
}
