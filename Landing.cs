using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class Landing : Form
    {
        public Landing()
        {
            js.createFiles(); //On Opening the application, check if the the files exist else create them
            InitializeComponent();
        }

        //Global variables and object
        //----------------------------
        List<WeatherModel> weath = new List<WeatherModel>(); //Create an object to store weather values if the test data button has been pressed
        JSONconnection js = new JSONconnection(); //Create an instance f the JSON class to use the JSON methods
        //----------------------------

        //Begin helper methods
        //-------------------------------

        //Method to create the test data
        private void SetTestValues()
        {
            //This is only to recreate the test data
            //--------------------
            File.Delete("weatherdata.json");
            js.createFiles();
            //-------------------


            DateTime d1 = DateTime.Today;
            DateTime d2 = DateTime.Today.AddDays(1);
            DateTime d3 = DateTime.Today.AddDays(2);
            DateTime d4 = DateTime.Today.AddDays(3);
            DateTime d5 = DateTime.Today.AddDays(4);


            string[] cit = { "Johannesburg", "Pretoria", "Durban", "Polokwane", "Cape Town", "Johannesburg", "Pretoria", "Durban", "Polokwane", "Cape Town", "Johannesburg", "Pretoria", "Durban", "Polokwane", "Cape Town", "Johannesburg", "Pretoria", "Durban", "Polokwane", "Cape Town", "Johannesburg", "Pretoria", "Durban", "Polokwane" };
            DateTime[] dates = { d1, d1, d1, d1, d1, d2, d2, d2, d2, d2, d3, d3, d3, d3, d3, d4, d4, d4, d4, d4, d5, d5, d5, d5, d5 };
            double[] maxes = { 25, 27, 30, 32, 24, 21, 23, 33, 20, 20, 28, 29, 31, 19, 17, 34, 22, 37, 29, 26, 23, 19, 10, 32, 24 };
            double[] mins = { 18, 17, 20, 12, 14, 12, 11, 10, 17, 19, 10, 9, 20, 21, 13, 14, 19, 22, 23, 18, 19, 7, 2, 1, 4 };
            double[] humids = { 10, 7, 3, 32, 4, 1, 27, 33, 12, 44, 18, 17, 33, 92, 24, 30, 27, 13, 52, 84, 40, 8, 33, 22, 64 };
            double[] precips = { 23, 38, 2, 4, 10, 6, 76, 43, 52, 44, 20, 34, 24, 55, 24, 14, 56, 25, 32, 46, 67, 35, 35, 32, 4 };
            double[] winds = { 32, 47, 11, 51, 13, 30, 7, 3, 35, 23, 10, 17, 11, 45, 43, 60, 37, 41, 23, 32, 33, 77, 91, 65, 3 };
            int[] CloudCover = { 1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2 };
            string[] uvIndex = { "Low", "High", "Medium", "High", "Medium", "Low", "High", "Medium", "High", "Medium", "Low", "High", "Medium", "High", "Medium", "Low", "High", "Medium", "High", "Medium", "Low", "High", "Medium", "High", "Medium" };

            for (int index = 0; index < cit.Length; index++)
            {
                WeatherModel hu = new WeatherModel();
                hu.City = cit[index];
                hu.Date = dates[index];
                hu.Max = maxes[index];
                hu.Min = mins[index];
                hu.Precipitation = precips[index];
                hu.Humidity = humids[index];
                hu.Wind = winds[index];
                hu.CloudCover = CloudCover[index];
                hu.UvIndex = uvIndex[index];
                hu.IsCelsius = true;
                weath.Add(hu);
            }
            js.writeWeatherFile(weath); //write the test values to the file

        }

        //End helper methods
        //---------------------------------

        //begin click event methods
        //--------------------------
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            signup sg = new signup(); //Open the sign up form if this option was chosen
            this.Hide();
            sg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login lg = new login(); //Open the login form if this option was chosen
            this.Hide();
            lg.Show();
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            SetTestValues(); //Create the test values if the test data button was clicked. 
        }
        //End click event methods
        //-------------------------
    }
}
