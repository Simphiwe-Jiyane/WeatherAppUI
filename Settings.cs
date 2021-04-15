using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class Settings : Form
    {
        public Settings(UserModel user)
        {
            gUser = user; //Save a copy of the user model in this form
            InitializeComponent();
            //set  the default state of the radio buttons to what the user's preferred temperature unit is
            if (user.IsCelsius == true)
            {
                radCelsius.Checked = true;
            }
            else
            {
                radFahrenheit.Checked = true;
            }

            loadBoxes(); //Load the combo boxes with combo boxes with all the cities related to the user
            pnlCityOptions.Visible = false; //set the default state of the panel to false
        }

        //Global variables and objects
        //-----------------------------------
        UserModel gUser = new UserModel();
        string userPath = "Users.json";

        //End Global variable and objects
        //----------------------------------

        //Helper methods begin
        //---------------------------------
        private void loadBoxes()
        {
            cboCity.Items.Remove(gUser._homeCity);

            foreach (string item in gUser.prefferedCities)
            {
                cboExtraCity.Items.Remove(item);
            }

            foreach (string item in gUser.prefferedCities)
            {
                lstboxCities.Items.Add(item);
            }
        }

        //Helper methods end
        //---------------------------------

        //Start events
        //---------------------------------

        //Event that change the user's password
        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text; //String to store the password entered in the textbox
            string username = gUser.UserName; //String to store the username of the user logged in

            //Perform error check on the text box
            if (string.IsNullOrEmpty(txtPassword.Text)) //check if the field is empty
            {
                MessageBox.Show("Please enter a password first", "Password empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //If there are no error 
            {
                JSONconnection js = new JSONconnection(); // create an instance of JSON class to use JSON methods

                if (js.changePassword(username, password)) // call the change username password, if trure is returned the password has been successfuly changed
                {
                    MessageBox.Show("Password successfully changed");
                }
                else //The password could not be changed
                {
                    MessageBox.Show("Password change unsuccessful. Please try again", "Password change error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Event that changes the user's preferred temperature unit
        private void btnApply_Click(object sender, EventArgs e)
        {
            JSONconnection js = new JSONconnection(); //Instance of the JSONconnection class to user JSON methods
            if (radCelsius.Checked == true)//if the celsius button is checked change the user's preference to celsius
            {
                gUser.IsCelsius = true;
            }
            else //if the fahrenheit button is checked change the user's preferrence to fahrenheit
            {
                gUser.IsCelsius = false;
            }

            if (js.changeUserPreference(gUser)) //Save this changes to the file
            {
                MessageBox.Show("User preference successfully changed");
                Dashboard ds = new Dashboard(gUser);
                ds.Refresh();
            }
            else
            {
                MessageBox.Show("User preference could not be changed, please try again", "Change error");
            }

        }

        //This event opens city options panel
        private void btnChangeCityInfo_Click(object sender, EventArgs e)
        {
            pnlCityOptions.Visible = true; //open the panel with city settings
        }

        //This method changes the user's home city
        private void btnChangeHome_Click(object sender, EventArgs e)
        {
            string city = cboCity.Text; //Store the city in the combobox in a string variable
            string conv = File.ReadAllText(userPath); //Read the file into a string variable

            List<UserModel> newList = new List<UserModel>(); // List to store the the new list
            List<UserModel> oldList = new List<UserModel>(); // List to store the original values in the list

            if (cboCity.SelectedIndex != -1) // Check if the combobox is not an empty value
            {
                oldList = JsonConvert.DeserializeObject<List<UserModel>>(conv); // deserialize the json file and store the values in a list

                if (oldList != null) //if the list is not empty
                {
                    foreach (UserModel i in oldList)
                    {
                        newList.Add(i); //Add all the original values into a new list
                    }
                }

                foreach (UserModel item in newList)
                {
                    if (gUser.UserName.Equals(item.UserName) && gUser.Password.Equals(item.Password)) //find the user that matches with credentials 
                    {
                        item._homeCity = city; //change the user's city
                        gUser = item; //save the new user in a user object that will be passed to other forms
                        break; //End the search for the user
                    }
                }
                try
                {
                    conv = JsonConvert.SerializeObject(newList); //Serialize the list into a json format
                    File.WriteAllText(userPath, conv); // now write the values to the json file
                    MessageBox.Show("Home city changed successfully, restart the application to apply the changes"); // Let the user know the change was succesful. In rder for the change to show, the application must restart
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not change home city");
                }
            }
            else
            {
                MessageBox.Show("Please select a city first", "Empty city", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event to add the selected city from the combo box
        private void btnAddcity_Click(object sender, EventArgs e)
        {
            string city = cboExtraCity.Text; //Store the city in the combobox in a string variable
            string conv = File.ReadAllText(userPath); // Read the file into a string variable

            List<UserModel> newList = new List<UserModel>(); // List to store the the new list
            List<UserModel> oldList = new List<UserModel>(); // List to store the original values in the list

            if (cboExtraCity.SelectedIndex != -1) // Check if the combobox is not an empty value
            {
                oldList = JsonConvert.DeserializeObject<List<UserModel>>(conv);  // deserialize the json file and store the values in a list

                if (oldList != null)  //if the list is not empty
                {
                    foreach (UserModel i in oldList)
                    {
                        newList.Add(i);  //Add all the original values into a new list
                    }
                }

                foreach (UserModel item in newList)
                {
                    if (gUser.UserName.Equals(item.UserName) && gUser.Password.Equals(item.Password))
                    {
                        item.prefferedCities.Add(city); //change the user's preferrred cities
                        gUser = item; //save the new user in a user object that will be passed to other forms
                        break; //End the search for the user
                    }
                }
                try
                {
                    conv = JsonConvert.SerializeObject(newList);  //Serialize the list into a json format
                    File.WriteAllText(userPath, conv); // now write the values to the json file
                    MessageBox.Show("Preferred cities changed successfully, restart the application to apply the changes");  // Let the user know the change was succesful. In rder for the change to show, the application must restart
                    this.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not change preferred cities");
                }
            }
            else
            {
                MessageBox.Show("Please select a city first", "Empty city", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //event that deletes the selected city
        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            string city = lstboxCities.Text;  //Store the city in the combobox in a string variable
            string conv = File.ReadAllText(userPath); //Read the file into a string variable

            List<UserModel> newList = new List<UserModel>();
            List<UserModel> oldList = new List<UserModel>();

            oldList = JsonConvert.DeserializeObject<List<UserModel>>(conv);

            if (oldList != null)
            {
                foreach (UserModel i in oldList)
                {
                    newList.Add(i);
                }
            }

            foreach (UserModel item in newList)
            {
                if (gUser.UserName.Equals(item.UserName) && gUser.Password.Equals(item.Password))
                {
                    item.prefferedCities.Remove(city);
                    gUser = item;
                    break;
                }
            }
            try
            {
                conv = JsonConvert.SerializeObject(newList);
                File.WriteAllText(userPath, conv);
                MessageBox.Show("Extra city deleted changed successfully, restart the application to apply the changes");
                this.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not delete extra city");
            }
        }

        //End Events
        //----------------------------------

    }
}
