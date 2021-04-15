using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class Home : Form
    {

        //Global variables and objects
        //------------------------------
        List<WeatherModel> weath = new List<WeatherModel>();//lists to store the relevent data
        UserModel gUser = new UserModel(); //user model that will be used to filter the data and display the correct forecasts
        string currentCity, previousCity = ""; //These strings will be used to store the changed cities when the user wants to see the next city
        string unit;
        //-----------------------------

        public Home(UserModel user)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            changeTime(); //Set the time whenever this page is loaded
            PreferedData(user); //Find the suer's specified forecast and display it
            gUser = user; //Save the passed in user model to this form
            currentCity = user._homeCity; // set the starting city display to the users home city
        }

        //Begin helper methods
        //---------------------------------

        //method to set information according to the users preffered city
        public void PreferedData(UserModel gUser, bool nextCity = false)
        {
            JSONconnection js = new JSONconnection(); //Create a connection to the JSON class
            weath = js.readWeatherFile(); //Get all the forecasts and store them in a list of weather models

            if (weath != null) //if the weather file is not empty attempt to populate the user's preffered information
            {
                if (gUser != null)  //If the user is not found is not a null value attempt to populate the display with correct info
                {
                    // Variable to store the weatehr values
                    string city;
                    double min;
                    double max;
                    double precip;
                    double humidity;
                    int cloud;
                    string userCity = "";

                    if (nextCity == false) //If the user wants to see thy're home city
                    {
                        userCity = gUser._homeCity;
                    }
                    else //If the user has not specified that they want to see the next stored city
                    {
                        foreach (string item in gUser.prefferedCities)
                        {
                            if (!currentCity.Equals(item) && !previousCity.Equals(item))
                            {
                                userCity = item;//store the user's city as the next extra city
                                previousCity = currentCity;
                                currentCity = item;
                                break;
                            }
                        }
                    }
                    //Check the user's preferred temperature unit
                    if (gUser.IsCelsius)
                    {
                        unit = "C";
                    }
                    else
                    {
                        unit = "F";
                    }

                    foreach (WeatherModel w in weath)
                    {
                        if (w.City.Equals(userCity) && w.Date == DateTime.Today)
                        {
                            w.convertUnit(gUser.IsCelsius); //Convert the unit of emasure if they user's and the weather file do not correspond
                            city = w.City;
                            max = w.Max;
                            min = w.Min;
                            precip = w.Precipitation;
                            humidity = w.Humidity;
                            cloud = w.CloudCover;

                            //set the display based on the corresponding values found in the weather file
                            lblCity.Text = "Weather in " + city + " today";
                            lblMax.Text = Convert.ToString(max) + "°" + unit;
                            lblMin.Text = Convert.ToString(min) + "°" + unit;
                            lblPrecip.Text = Convert.ToString(precip) + "%";
                            lblHumidity.Text = Convert.ToString(humidity) + "%";

                            //set the picture box based on the value that i9s found in the weather file
                            if (cloud == 1)
                            {
                                pBoxSunny.Visible = true;
                                pBoxPartlyCloudy.Visible = false;
                                pBoxCloudy.Visible = false;
                                pBoxStormy.Visible = false;
                                lblCloudCover.Text = "Sunny";
                            }
                            else if (cloud == 2)
                            {
                                pBoxSunny.Visible = false;
                                pBoxPartlyCloudy.Visible = true;
                                pBoxCloudy.Visible = false;
                                pBoxStormy.Visible = false;
                                lblCloudCover.Text = "Partly Cloud";
                            }
                            else if (cloud == 3)
                            {
                                pBoxSunny.Visible = false;
                                pBoxPartlyCloudy.Visible = false;
                                pBoxCloudy.Visible = true;
                                pBoxStormy.Visible = false;
                                lblCloudCover.Text = "Full Cloud Cover";
                            }
                            else if (cloud == 4)
                            {
                                pBoxSunny.Visible = false;
                                pBoxPartlyCloudy.Visible = false;
                                pBoxCloudy.Visible = false;
                                pBoxStormy.Visible = true;
                                lblCloudCover.Text = "Thunder Showers";
                            }
                        }
                    }
                }
            }
            else //If there is no weather data send the user back to the landing page
            {
                MessageBox.Show("There is no weather data to display. Please create weather data if you are a forecaster. If you are not please contact/" +
                    "send an email to the developer", "Weather Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Landing ld = new Landing();
                ld.Show();
                this.Close();
            }

        }

        //set the current time and date
        private void changeTime()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        //End helper methods
        //---------------------------------

        //Begin click events 
        //----------------------------------
        //Go the extended forecast page
        private void btnGoToForcasts_Click(object sender, EventArgs e)
        {
            PreferedData(gUser, true); //Open the next city the user ahs on his/her profile
        }
        //End click events
        //---------------------------------
    }
}
