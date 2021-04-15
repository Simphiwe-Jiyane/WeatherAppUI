using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class ForecasterMenu : Form
    {
        //Globals
        //-----------------------------
        List<WeatherModel> weath = new List<WeatherModel>();
        UserModel fUser = new UserModel();
        //end globals
        //-----------------------------

        public ForecasterMenu(UserModel user)
        {
            InitializeComponent();
            loadUserData(user); 
            fUser = user;
            //Set the controls to a specified default state
            #region
            pnlCaptureData.Visible = false;
            pnlSingleCityRange.Visible = false;
            pnlMultiCity.Visible = false;
            pnlHome.Visible = true;
            dtpDate.MinDate = DateTime.Now;
            dtpStart.MinDate = DateTime.Now;
            dtpMultiStart.MinDate = DateTime.Now;
            #endregion
        }

        //Start of helper methods
        //----------------------------------

        //load the forecaster's temperature unit onto the form
        private void loadUserData(UserModel user)
        {
            if (user.IsCelsius == true)
                lblIsCelsius.Text = "°C";
            else
                lblIsCelsius.Text = "°F";

            lblwelcomeName.Text = $"Welcome back {user.FName} {user.SName} let's get started"; //set the user's name on the home page
        }

        //disable all panels and set the passed in panel's visibilty to true
        private void SetAcivePanel(Panel active)
        {
            //Set all panels to be invisible
            pnlCaptureData.Visible = false;
            pnlSingleCityRange.Visible = false;
            pnlMultiCity.Visible = false;
            pnlHome.Visible = false;
            active.Visible = true; //set the active panel to visible
        }

        ///load cities into the single city range combo box
        private void loadCities()
        {
            string city = ""; //variable to hold the current city

            JSONconnection js = new JSONconnection(); //Instance of the JSONconnection class to use the JSON methods

            List<WeatherModel> weath = new List<WeatherModel>(); //List to store all the weather data

            ArrayList cities = new ArrayList(); //Arraylist to hold the cities

            weath = js.readWeatherFile(); //use the json method to get all the weather data and store it in the list

            foreach (WeatherModel vals in weath) //cycle through list to find all the cities
            {
                string store = vals.City;
                cities.Add(store);
            }

            cities.Sort(); // sort the list in alphabetical order so that you can extract each city and not repeat a city


            foreach (string item in cities)
            {
                if (!city.Equals(item))
                {
                    city = item;
                    cboCity2.Items.Add(city); //add the items to the combo box
                }
            }
        }

        //check the selected cities for the multi city range
        private List<string> checkSelectedCities()
        {
            List<string> selectedCities = new List<string>();

            // Check if each tick box is checked or not, if checked add that box to the list of cities
            if (chkJoburg.Checked == true)
                selectedCities.Add("Johannesburg");

            if (chkPretoria.Checked == true)
                selectedCities.Add("Pretoria");

            if (chkDurban.Checked == true)
                selectedCities.Add("Durban");

            if (chkCapeTown.Checked == true)
                selectedCities.Add("Polokwane");

            if (chkCapeTown.Checked == true)
                selectedCities.Add("Cape Town");

            return selectedCities; //return all the selected cities
        }

        //This method will check for errors
        private bool errorCheck(TextBox txt)
        {
            double num; // variable to store the converted value in the text box
            if (string.IsNullOrWhiteSpace(txt.Text)) //check if the box is null or empty
            {
                captureError.SetError(txt, "This cannot be empty");
                return false;
            }
            else
            {
                try // check if the value is indeed a number
                {
                    num = Convert.ToDouble(txt.Text); 
                    captureError.Clear();
                    return true;
                }
                catch
                {
                    captureError.SetError(txt, "Please enter a numeric value");
                    return false;
                }
            }
        }

        //End of helper methods
        //---------------------------


        //Start of all click events
        //--------------------------

        // start of capture panel events
        //____________________
        #region
        //This event will make the capture data panel active
        private void captureForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAcivePanel(pnlCaptureData); // set the capture panel as the active panel
        }

        //This event will capture the weather forecast
        private void btnCapture_Click(object sender, EventArgs e)
        {
            JSONconnection js = new JSONconnection(); //create an object of the JSONconnection class in order to manipulate the JSON file

            WeatherModel w = new WeatherModel(); // create a weather object that will capture all the weather information

            weath = js.readWeatherFile(); // read all the values in the weather file into a list

            bool valid = false;

            if (cboCity1.SelectedIndex == -1) // only enter if an item has been selected
            {
                captureError.SetError(cboCity1, "Please select a city"); // if an item has not been selected display an error message
            }
            else
            {
                //check for errors first

                if (errorCheck(txtMax) == false) // check if the control is a numeric value and check if it is not empty
                {
                    valid = false; //if there is an error end the event here and return till the error is cleared
                    return;
                }


                if (errorCheck(txtMin) == false)
                {
                    valid = false;
                    return;
                }

                if (Convert.ToDouble(txtMin) > Convert.ToDouble(txtMax)) // ensure that the minimum temperature is not greater than the maximum
                {
                    captureError.SetError(txtMin, "The minimum temperature cannot be greater than the maximum temperature");
                    valid = false;
                    return;
                }

                if (errorCheck(txtHumid) == false)
                {
                    valid = false;
                    return;
                }

                if (errorCheck(txtMin) == false)
                {
                    valid = false;
                    return;
                }

                if (errorCheck(txtWind) == false)
                {
                    valid = false;
                    return;
                }

                //check the combobox controls for errors
                if (cboCloud.SelectedIndex == -1)
                {
                    captureError.SetError(cboCloud, "Please select the cloud cover");
                    valid = false;
                    return;
                }
                else
                    captureError.Clear(); //clear any errors that were created


                if (cboUvIndex.SelectedIndex == -1)
                {
                    captureError.SetError(cboUvIndex, "Please select the UV index");
                    valid = false;
                    return;
                }
                else
                {
                    captureError.Clear(); //clear any errors that were created
                    valid = true;
                }


                if (valid)
                {
                    captureError.Clear(); //clear any previous errors
                    foreach (WeatherModel v in weath)
                    {
                        //check if user wants to overwrite or continue with the operation

                        if (v.City.Equals(cboCity1.Text) && v.Date == dtpDate.Value.Date) //check if there is already a value with the same date
                        {
                            //if a value already exits for the this city and date, ask the user if they would like to overide
                            DialogResult dr = MessageBox.Show("Values already exits for this city on this day. Would you like to overwrite?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dr == DialogResult.Yes)
                            {
                                //Add all the values to the weather object
                                w.City = cboCity1.Text;
                                w.Date = dtpDate.Value.Date;
                                w.Max = Convert.ToDouble(txtMax.Text);
                                w.Min = Convert.ToDouble(txtMin.Text);
                                w.Humidity = Convert.ToDouble(txtHumid.Text);
                                w.Precipitation = Convert.ToDouble(txtPrecip.Text);
                                w.Wind = Convert.ToDouble(txtWind.Text);
                                w.CloudCover = cboCloud.SelectedIndex;
                                w.UvIndex = cboUvIndex.Text;
                                if (radCelsius.Checked == true)
                                    w.IsCelsius = true;
                                else
                                    w.IsCelsius = false;

                                if (js.overwriteFile(w)) //overwrite the existing value if the user has chosen to update
                                {
                                    MessageBox.Show("Data overwritten successfully");
                                    cboCity1.SelectedIndex = -1;
                                    txtMax.Clear();
                                    txtMin.Clear();
                                    txtHumid.Clear();
                                    txtPrecip.Clear();
                                    txtWind.Clear();
                                    cboCloud.SelectedIndex = -1;
                                    cboUvIndex.SelectedIndex = -1;

                                }
                                else
                                {
                                    MessageBox.Show("There was an error with the request", "Overwrite error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                valid = false;
                                break; //break the foreach
                            }
                            else
                            {
                                //if the user doesnt want to overwrite, clear all the fields
                                cboCity1.SelectedIndex = -1;
                                txtMax.Clear();
                                txtMin.Clear();
                                txtHumid.Clear();
                                txtPrecip.Clear();
                                txtWind.Clear();
                                cboCloud.SelectedIndex = -1;
                                cboUvIndex.SelectedIndex = -1;
                                valid = false; // set  valid to false to end this event
                                break; //break the foreach
                            }
                        }
                    }
                    //continue if there were no errors and no overwrite request
                    if (valid)
                    {
                        captureError.Clear(); //clear any previous errors

                        w.City = cboCity1.Text;
                        w.Date = Convert.ToDateTime(dtpDate.Value.ToShortDateString()); //input the date 
                        w.Max = Convert.ToDouble(txtMax.Text); //convert and input the max value                       
                        w.Min = Convert.ToDouble(txtMin.Text); //convert and input
                        w.Humidity = Convert.ToDouble(txtHumid.Text); //convert and input the data
                        w.Precipitation = Convert.ToDouble(txtPrecip.Text); //convert and input 
                        w.Wind = Convert.ToDouble(txtWind.Text); //convert the value and input it 
                        w.CloudCover = cboCloud.SelectedIndex; //convert the value and input it 
                        w.UvIndex = cboUvIndex.Text;

                        if (radCelsius.Checked == true)
                            w.IsCelsius = true;
                        else
                            w.IsCelsius = false;

                        weath.Add(w); // add the object to the list

                        DialogResult dg = MessageBox.Show("Would you like to add more values", "Enter More", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            //reset all the controls and return
                            cboCity1.SelectedIndex = -1;
                            txtMax.Clear();
                            txtMin.Clear();
                            txtHumid.Clear();
                            txtPrecip.Clear();
                            txtWind.Clear();
                            cboCloud.SelectedIndex = -1;
                            cboUvIndex.SelectedIndex = -1;
                            return;
                        }

                        else
                        {
                            js.writeWeatherFile(weath);

                            cboCity1.SelectedIndex = -1;
                            txtMax.Clear();
                            txtMin.Clear();
                            txtHumid.Clear();
                            txtPrecip.Clear();
                            cboCloud.SelectedIndex = -1;
                            cboUvIndex.SelectedIndex = -1;
                            SetAcivePanel(pnlHome);
                        }
                    }
                }
            }
        }

        //tHis event will cancel the capture data process
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCaptureData.Visible = false;
            cboCity1.SelectedIndex = -1;
            txtMax.Clear();
            txtMin.Clear();
            txtHumid.Clear();
            txtPrecip.Clear();
            txtWind.Clear();
            cboCloud.SelectedIndex = -1;
            cboUvIndex.SelectedIndex = -1;
        }

        //End of capture data events
        //_________________________

        #endregion

        //start of single city range panel events
        //_________________________
        #region
        // This event will generate a single city report
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date) //ensure the user enters valid dates
            {
                MessageBox.Show("End date cannot be lower than the start dae");
            }
            else
            {
                SingleCityReport scr = new SingleCityReport(fUser, cboCity2.Text, dtpStart.Value.Date, dtpEnd.Value.Date);
                scr.Show();
                this.Hide();
            }
        }

        // this will close the single city range panel and reopen the home page panel
        private void btnSingeCancel_Click(object sender, EventArgs e)
        {
            pnlSingleCityRange.Visible = false;
        }

        // this event will open the single city range picker to generate a single city report
        private void singleCityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCities();
            SetAcivePanel(pnlSingleCityRange);
        }

        //This event will set the minimum value of the end date time picker to be that of the start date time picker of the single city report
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.MinDate = dtpStart.Value.Date;
        }

        //End of single city range panel events
        //_______________________________________

        #endregion

        //start of multi city range panels
        //_________________________
        #region

        //This event will set the minimum value of the end date time picker to be that of the start date time picker of the multi city report
        private void dtpMultiStart_ValueChanged(object sender, EventArgs e)
        {
            dtpMultiEnd.MinDate = dtpMultiStart.Value.Date;
        }

        //This event will generate a multi city report
        private void btnGenerateMulti_Click(object sender, EventArgs e)
        {
            List<string> selectedCities = new List<string>();

            selectedCities = checkSelectedCities();

            MultiCityReport mcr = new MultiCityReport(fUser, selectedCities, dtpMultiStart.Value.Date, dtpMultiEnd.Value.Date);

            mcr.Show();

            this.Hide();
        }

        //this event will open the multi city range picker to generate a multi city report
        private void multiCityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAcivePanel(pnlMultiCity);
        }

        // this will close the multi city range panel and reopen the home page panel
        private void btnCaAncelMulti_Click(object sender, EventArgs e)
        {
            pnlMultiCity.Visible = false;
        }

        //End of multi city range panle events
        //_________________________
        #endregion

        //Start of update and delete form events
        //_________________________
        #region

        // This event will open the update and delete form but set the active panel as the update panel
        private void updateForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDelete ud = new UpdateDelete(fUser,true);
            this.Hide();
            ud.Show();
        }

        // This event will open the update and delete form but set the active panel as the delete panel
        private void deleteForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDelete ud = new UpdateDelete(fUser,false);
            this.Hide();
            ud.Show();
        }

        //End of update and delete form events
        //____________________________
        #endregion

        //start of temperature unit change event
        //_________________________
        private void changeTemperatureUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempChange tc = new tempChange(fUser);
        }

        // This event allows the user sign out of this application
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you would like to sign out?", "Sign out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Landing ld = new Landing();
                ld.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
     
        //End of click evnets
        //--------------------
    }
}
