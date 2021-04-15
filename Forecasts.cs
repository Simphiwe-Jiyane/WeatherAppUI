using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class Forecasts : Form
    {
        public Forecasts(UserModel gUser)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            //Check the user's prefered temperature unit
            if (gUser.IsCelsius)
            {
                unit = "C";
            } //TODO the opposite is being shown
            else
            {
                unit = "F";
            }

            PreferedData(gUser); //Set the user's preferred data on the display
            user = gUser; //Save a copy of the user model in this form
            #region //set the default state of the panels to false here.
            pnlThreeDayView.Visible = false;
            pnlTomorrow.Visible = false;
            pnlSevenDayView.Visible = false;
            btnPreviousDay.Visible = false;
            lblPreviousDay.Visible = false;
            #endregion   
            count = 0; //set the count to zero for the next day indicators
        }

        //Globals
        //---------------------------------
        List<WeatherModel> weath = new List<WeatherModel>(); //Create a list that will store the weather data
        JSONconnection js = new JSONconnection(); //Create a connection to the JSON class
        UserModel user = new UserModel();//user model that will be used to filter the data and display the correct forecasts
        string unit; //string to change the display of the temperature symbol based on the user's preferrence
        int count; //count to control the next day indicator buttons
        //End globals
        //---------------------------

        //Begin helper methods
        //---------------------------

        //Method to set the active button based on the page the user is on 
        private void SetActiveButton(Button btn)
        {
            DoubleBuffered = true;
            //Set the default backcolr to transparent
            btnTomorrow.BackColor = Color.Transparent;
            btnThreeDays.BackColor = Color.Transparent;
            btnSevenDays.BackColor = Color.Transparent;
            btn.BackColor = Color.FromArgb(189, 189, 189); //Change the background of the active button
        }

        //Method to change the state of the panels based on the panel chosen 
        private void setActivePanel(Panel active)
        {
            DoubleBuffered = true;
            //Set all the panels visibilty to false
            pnlContainer.Visible = false;
            pnlCurrentDay.Visible = false;
            pnlThreeDayView.Visible = false;
            pnlTomorrow.Visible = false;
            pnlSevenDayView.Visible = false;
            //set the active panel to visible
            active.Visible = true;
        }

        //method to set the display according to the users preffered city
        private void PreferedData(UserModel gUser)
        {
            weath = js.readWeatherFile(); //Get all the forecasts and store them in a list of weather models

            string city;
            double min;
            double max;
            double precip;
            double humidity;
            int cloud;
            string uv;
            double wind;
            string userCity = "";

            userCity = gUser._homeCity; //Store the user's city

            foreach (WeatherModel w in weath)
            {
                if (w.City.Equals(userCity) && w.Date == DateTime.Today) // enter if the user's city corresponds with weather model
                {
                    w.convertUnit(gUser.IsCelsius); // Convert the temperature unit to user's preferrence
                    //store the corresponding data
                    city = w.City;
                    max = w.Max;
                    min = w.Min;
                    precip = w.Precipitation;
                    humidity = w.Humidity;
                    cloud = w.CloudCover;
                    wind = w.Wind;
                    uv = w.UvIndex;

                    //display the data on form
                    lblCity.Text = "Weather in " + city;
                    lblMax.Text = Convert.ToString(max) + "°" + unit;
                    lblMin.Text = Convert.ToString(min) + "°" + unit;
                    lblPrecipitaion.Text = Convert.ToString(precip) + "%";
                    lblHumidity.Text = Convert.ToString(humidity) + "%";
                    lblWindSpeed.Text = Convert.ToString(wind) + "km/h";
                    lblUvIndex.Text = uv;

                    //determine which cloud icon to display in the picture boxes
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
                        lblCloudCover.Text = "Full CLoud Cover";
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

        //This method will create a seven day report
        private void SevenDayReport(UserModel User)
        {
            weath = js.readWeatherFile(); //Get all the forecasts and store them in a list of weather models
            string userCity = User._homeCity; ;//String to store the user's city
            DateTime day = DateTime.Today.AddDays(1); //Date time set to the enxt day so that the report sttarts on the next day


            //Cycle through the list of weather models to find the corressponding data
            foreach (WeatherModel w in weath)
            {
                if (w.City.Equals(userCity))
                {
                    w.convertUnit(User.IsCelsius); //Convert temperature unit to the user's preferrence
                    if (day >= DateTime.Today.AddDays(1) && day <= DateTime.Today.AddDays(4)) //Keep the report between the two dates
                    {
                        //begin finding and displaying the data on the form
                        if (day == w.Date) //when the corressponding date is found for each date 
                        {
                            lblSevenDayDate1.Text = w.Date.ToShortDateString();
                            lblSevenDayMax1.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin1.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip1.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny1.Visible = true;
                                pBoxSevenDayPartlyCloudy1.Visible = false;
                                pBoxSevenDayCloudy1.Visible = false;
                                pBoxSevenDayStormy1.Visible = false;
                                lblCloudCoverSevenDay1.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny1.Visible = false;
                                pBoxSevenDayPartlyCloudy1.Visible = true;
                                pBoxSevenDayCloudy1.Visible = false;
                                pBoxSevenDayStormy1.Visible = false;
                                lblCloudCoverSevenDay1.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny1.Visible = false;
                                pBoxSevenDayPartlyCloudy1.Visible = false;
                                pBoxSevenDayCloudy1.Visible = true;
                                pBoxSevenDayStormy1.Visible = false;
                                lblCloudCoverSevenDay1.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny1.Visible = false;
                                pBoxSevenDayPartlyCloudy1.Visible = false;
                                pBoxSevenDayCloudy1.Visible = false;
                                pBoxSevenDayStormy1.Visible = true;
                                lblCloudCoverSevenDay1.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(1) == w.Date)
                        {
                            lblSevenDayDate2.Text = w.Date.ToShortDateString();
                            lblSevenDayMax2.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin2.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip2.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny2.Visible = true;
                                pBoxSevenDayPartlyCloudy2.Visible = false;
                                pBoxSevenDayCloudy2.Visible = false;
                                pBoxSevenDayStormy2.Visible = false;
                                lblCloudCoverSevenDay2.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny2.Visible = false;
                                pBoxSevenDayPartlyCloudy2.Visible = true;
                                pBoxSevenDayCloudy2.Visible = false;
                                pBoxSevenDayStormy2.Visible = false;
                                lblCloudCoverSevenDay2.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny2.Visible = false;
                                pBoxSevenDayPartlyCloudy2.Visible = false;
                                pBoxSevenDayCloudy2.Visible = true;
                                pBoxSevenDayStormy2.Visible = false;
                                lblCloudCoverSevenDay2.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny2.Visible = false;
                                pBoxSevenDayPartlyCloudy2.Visible = false;
                                pBoxSevenDayCloudy2.Visible = false;
                                pBoxSevenDayStormy2.Visible = true;
                                lblCloudCoverSevenDay2.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(2) == w.Date)
                        {
                            lblSevenDayDate3.Text = w.Date.ToShortDateString();
                            lblSevenDayMax3.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin3.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip3.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny3.Visible = true;
                                pBoxSevenDayPartlyCloudy3.Visible = false;
                                pBoxSevenDayCloudy3.Visible = false;
                                pBoxSevenDayStormy3.Visible = false;
                                lblCloudCoverSevenDay3.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny3.Visible = false;
                                pBoxSevenDayPartlyCloudy3.Visible = true;
                                pBoxSevenDayCloudy3.Visible = false;
                                pBoxSevenDayStormy3.Visible = false;
                                lblCloudCoverSevenDay3.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny3.Visible = false;
                                pBoxSevenDayPartlyCloudy3.Visible = false;
                                pBoxSevenDayCloudy3.Visible = true;
                                pBoxSevenDayStormy3.Visible = false;
                                lblCloudCoverSevenDay3.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny3.Visible = false;
                                pBoxSevenDayPartlyCloudy3.Visible = false;
                                pBoxSevenDayCloudy3.Visible = false;
                                pBoxSevenDayStormy3.Visible = true;
                                lblCloudCoverSevenDay3.Text = "Thunder Showers";
                            }

                        }

                        if (day.AddDays(3) == w.Date)
                        {
                            lblSevenDayDate4.Text = w.Date.ToShortDateString();
                            lblSevenDayMax4.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin4.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip4.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny4.Visible = true;
                                pBoxSevenDayPartlyCloudy4.Visible = false;
                                pBoxSevenDayCloudy4.Visible = false;
                                pBoxSevenDayStormy4.Visible = false;
                                lblCloudCoverSevenDay4.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny4.Visible = false;
                                pBoxSevenDayPartlyCloudy4.Visible = true;
                                pBoxSevenDayCloudy4.Visible = false;
                                pBoxSevenDayStormy4.Visible = false;
                                lblCloudCoverSevenDay4.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny4.Visible = false;
                                pBoxSevenDayPartlyCloudy4.Visible = false;
                                pBoxSevenDayCloudy4.Visible = true;
                                pBoxSevenDayStormy4.Visible = false;
                                lblCloudCoverSevenDay4.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny4.Visible = false;
                                pBoxSevenDayPartlyCloudy4.Visible = false;
                                pBoxSevenDayCloudy4.Visible = false;
                                pBoxSevenDayStormy4.Visible = true;
                                lblCloudCoverSevenDay4.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(5) == w.Date)
                        {
                            lblSevenDayDate5.Text = w.Date.ToShortDateString();
                            lblSevenDayMax5.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin5.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip5.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny5.Visible = true;
                                pBoxSevenDayPartlyCloudy5.Visible = false;
                                pBoxSevenDayCloudy5.Visible = false;
                                pBoxSevenDayStormy5.Visible = false;
                                lblCloudCoverSevenDay5.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny5.Visible = false;
                                pBoxSevenDayPartlyCloudy5.Visible = true;
                                pBoxSevenDayCloudy5.Visible = false;
                                pBoxSevenDayStormy5.Visible = false;
                                lblCloudCoverSevenDay5.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny5.Visible = false;
                                pBoxSevenDayPartlyCloudy5.Visible = false;
                                pBoxSevenDayCloudy5.Visible = true;
                                pBoxSevenDayStormy5.Visible = false;
                                lblCloudCoverSevenDay5.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny5.Visible = false;
                                pBoxSevenDayPartlyCloudy5.Visible = false;
                                pBoxSevenDayCloudy5.Visible = false;
                                pBoxSevenDayStormy5.Visible = true;
                                lblCloudCoverSevenDay5.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(6) == w.Date)
                        {
                            lblSevenDayDate6.Text = w.Date.ToShortDateString();
                            lblSevenDayMax6.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblSevenDayMin6.Text = Convert.ToString(w.Min) + "°" + unit;
                            lblSevenDayPrecip6.Text = Convert.ToString(w.Precipitation) + "%";
                            if (w.CloudCover == 1)
                            {
                                pBoxSevenDaySunny6.Visible = true;
                                pBoxSevenDayPartlyCloudy6.Visible = false;
                                pBoxSevenDayCloudy6.Visible = false;
                                pBoxSevenDayStormy6.Visible = false;
                                lblCloudCoverSevenDay6.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBoxSevenDaySunny6.Visible = false;
                                pBoxSevenDayPartlyCloudy6.Visible = true;
                                pBoxSevenDayCloudy6.Visible = false;
                                pBoxSevenDayStormy6.Visible = false;
                                lblCloudCoverSevenDay6.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBoxSevenDaySunny6.Visible = false;
                                pBoxSevenDayPartlyCloudy6.Visible = false;
                                pBoxSevenDayCloudy6.Visible = true;
                                pBoxSevenDayStormy6.Visible = false;
                                lblCloudCoverSevenDay6.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBoxSevenDaySunny6.Visible = false;
                                pBoxSevenDayPartlyCloudy6.Visible = false;
                                pBoxSevenDayCloudy6.Visible = false;
                                pBoxSevenDayStormy6.Visible = true;
                                lblCloudCoverSevenDay6.Text = "Thunder Showers";
                            }
                        }
                        //end finding and displaying the data
                    }
                }
            }
        }

        //This method will create a three day report
        private void ThreeDayReport(UserModel User)
        {
            weath = js.readWeatherFile();  //Get all the forecasts and store them in a list of weather models
            string userCity = User._homeCity;
            ArrayList vals = new ArrayList();
            DateTime day = DateTime.Today.AddDays(1);

            //Cycle through the list of weather models to find the corressponding data
            foreach (WeatherModel w in weath)
            {
                if (w.City.Equals(userCity))
                {
                    w.convertUnit(User.IsCelsius); //Convert temperature unit to the user's preferrence
                    if (day >= DateTime.Today.AddDays(1) && day <= DateTime.Today.AddDays(4))
                    {
                        //begin finding and displaying the data on the form
                        if (day == w.Date) //when the corressponding date is found for each date
                        {
                            lblDate1.Text = w.Date.ToShortDateString();
                            lblMax1.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblMin1.Text = Convert.ToString(w.Min) + "°" + unit;
                            if (w.CloudCover == 1)
                            {
                                pBox1Sunny.Visible = true;
                                pBox1PartlyCloudy.Visible = false;
                                pBox1Cloudy.Visible = false;
                                pBox1Stormy.Visible = false;
                                lblCloudCover1.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBox1Sunny.Visible = false;
                                pBox1PartlyCloudy.Visible = true;
                                pBox1Cloudy.Visible = false;
                                pBox1Stormy.Visible = false;
                                lblCloudCover1.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBox1Sunny.Visible = false;
                                pBox1PartlyCloudy.Visible = false;
                                pBox1Cloudy.Visible = true;
                                pBox1Stormy.Visible = false;
                                lblCloudCover1.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBox1Sunny.Visible = false;
                                pBox1PartlyCloudy.Visible = false;
                                pBox1Cloudy.Visible = false;
                                pBox1Stormy.Visible = true;
                                lblCloudCover1.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(1) == w.Date)
                        {
                            lblDate2.Text = w.Date.ToShortDateString();
                            lblMax2.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblMin2.Text = Convert.ToString(w.Min) + "°" + unit;
                            day = DateTime.Today.AddDays(1);
                            if (w.CloudCover == 1)
                            {
                                pBox2Sunny.Visible = true;
                                pBox2PartlyCloudy.Visible = false;
                                pBox2Cloudy.Visible = false;
                                pBox2Stormy.Visible = false;
                                lblCloudCover2.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBox2Sunny.Visible = false;
                                pBox2PartlyCloudy.Visible = true;
                                pBox2Cloudy.Visible = false;
                                pBox2Stormy.Visible = false;
                                lblCloudCover2.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBox2Sunny.Visible = false;
                                pBox2PartlyCloudy.Visible = false;
                                pBox2Cloudy.Visible = true;
                                pBox2Stormy.Visible = false;
                                lblCloudCover2.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBox2Sunny.Visible = false;
                                pBox2PartlyCloudy.Visible = false;
                                pBox2Cloudy.Visible = false;
                                pBox2Stormy.Visible = true;
                                lblCloudCover2.Text = "Thunder Showers";
                            }
                        }

                        if (day.AddDays(2) == w.Date)
                        {
                            lblDate3.Text = w.Date.ToShortDateString();
                            lblMax3.Text = Convert.ToString(w.Max) + "°" + unit;
                            lblMin3.Text = Convert.ToString(w.Min) + "°" + unit;

                            if (w.CloudCover == 1)
                            {
                                pBox3Sunny.Visible = true;
                                pBox3PartlyCloudy.Visible = false;
                                pBox3Cloudy.Visible = false;
                                pBox3Stormy.Visible = false;
                                lblCloudCover3.Text = "Sunny";
                            }
                            else if (w.CloudCover == 2)
                            {
                                pBox3Sunny.Visible = false;
                                pBox3PartlyCloudy.Visible = true;
                                pBox3Cloudy.Visible = false;
                                pBox3Stormy.Visible = false;
                                lblCloudCover3.Text = "Partly Cloud";
                            }
                            else if (w.CloudCover == 3)
                            {
                                pBox3Sunny.Visible = false;
                                pBox3PartlyCloudy.Visible = false;
                                pBox3Cloudy.Visible = true;
                                pBox3Stormy.Visible = false;
                                lblCloudCover3.Text = "Full Cloud Cover";
                            }
                            else if (w.CloudCover == 4)
                            {
                                pBox3Sunny.Visible = false;
                                pBox3PartlyCloudy.Visible = false;
                                pBox3Cloudy.Visible = false;
                                pBox3Stormy.Visible = true;
                                lblCloudCover3.Text = "Thunder Showers";
                            }
                        }
                    }
                }
                //end finding and displaying the data

            }

        }

        //Method to generate the tomorrow report
        private void TomorrowReport(DateTime date, UserModel User)
        {
            weath = js.readWeatherFile(); //Get all the forecasts and store them in a list of weather models
            string userCity = User._homeCity;

            DateTime day = date;

            foreach (WeatherModel w in weath)//Cycle through the list of weather models to find the corressponding data
            {
                if (w.City.Equals(userCity))
                {
                    w.convertUnit(User.IsCelsius);//Convert temperature unit to the user's preferrence
                    //begin finding and displaying the data on the form
                    if (day == w.Date)
                    {
                        lblDateTomorrow.Text = day.ToShortDateString();
                        lblMaxTomorrow.Text = Convert.ToString(w.Max) + "°" + unit;
                        lblMinTomorrow.Text = Convert.ToString(w.Min) + "°" + unit;
                        lblPrecipTomorrow.Text = Convert.ToString(w.Precipitation) + "%";
                        lblWindSpeedTomorrow.Text = Convert.ToString(w.Wind) + "Km/h";
                        lblHumidityTomorrow.Text = Convert.ToString(w.Humidity) + "%";
                        lblUvTomorrow.Text = w.UvIndex;

                        if (w.CloudCover == 1)
                        {
                            pBoxSunnyTomorrow.Visible = true;
                            pBoxPartCloudyTomorrow.Visible = false;
                            pBoxCloudyTomorrow.Visible = false;
                            pBoxStormyTomorrow.Visible = false;
                            lblCloudTomorrow.Text = "Sunny";
                        }
                        else if (w.CloudCover == 2)
                        {
                            pBoxSunnyTomorrow.Visible = false;
                            pBoxPartCloudyTomorrow.Visible = true;
                            pBoxCloudyTomorrow.Visible = false;
                            pBoxStormyTomorrow.Visible = false;
                            lblCloudTomorrow.Text = "Partly Cloud";
                        }
                        else if (w.CloudCover == 3)
                        {
                            pBoxSunnyTomorrow.Visible = false;
                            pBoxPartCloudyTomorrow.Visible = false;
                            pBoxCloudyTomorrow.Visible = true;
                            pBoxStormyTomorrow.Visible = false;
                            lblCloudTomorrow.Text = "Full Cloud Cover";
                        }
                        else if (w.CloudCover == 4)
                        {
                            pBoxSunnyTomorrow.Visible = false;
                            pBoxPartCloudyTomorrow.Visible = false;
                            pBoxCloudyTomorrow.Visible = false;
                            pBoxStormyTomorrow.Visible = true;
                            lblCloudTomorrow.Text = "Thunder Showers";
                        }
                    }
                    //End cycling through the list
                }
            }
        }

        //end helper methods
        //---------------------------

        //Click events start
        //---------------------------

        //generate the three day report
        private void btnThreeDays_Click(object sender, EventArgs e)
        {
            setActivePanel(pnlThreeDayView);
            SetActiveButton(btnThreeDays);
            ThreeDayReport(user);
        }

        //generate the report for the next day
        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today.AddDays(1);
            setActivePanel(pnlTomorrow);
            SetActiveButton(btnTomorrow);
            TomorrowReport(date, user);
        }


        //generate a report for the next day when the forward icon is clicked
        private void btnGoTomorrow_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Today;
            if (count < 4)
            {
                count++; //invrement count so that the day moves to the next
            }

            TomorrowReport(date.AddDays(count), user);
            btnPreviousDay.Visible = true;
            lblPreviousDay.Visible = true;
            if (count == 4)
            {
                btnGoTomorrow.Visible = false;
                lblGoTomorrow.Visible = false;
            }
        }

        //generate a report for the previous day when the back icon is clicked
        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            if (count > 1)
            {
                count--; //decrement the count so that the day moves to the previous
            }
            TomorrowReport(date.AddDays(count), user);
            btnGoTomorrow.Visible = true;
            // btnGoTomorrow.Enabled = true;
            lblGoTomorrow.Visible = true;
            if (count == 1)
            {
                btnPreviousDay.Visible = false;
                lblPreviousDay.Visible = false;
            }
        }

        //generate the seven day report
        private void btnSevenDays_Click(object sender, EventArgs e)
        {
            setActivePanel(pnlSevenDayView);
            SetActiveButton(btnSevenDays);
            SevenDayReport(user);
        }

        //End click events
        //---------------------------
    }
}
