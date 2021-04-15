using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class SingleCityReport : Form
    {
        //Globals
        //---------------------
        double max = 0, min = 1000, humid = 0, precip = 0, wind = 0; //set base values to store highlisghts
        string unit;
        UserModel fUser = new UserModel();
        //end globals
        //---------------------

        public SingleCityReport(UserModel user,string city,DateTime start, DateTime end)
        {
            InitializeComponent();
            fUser = user; //Save a copy of the user in this form
            getCity(city); //get the selected city from the previous form
            setDegrees(user.IsCelsius); //Set the temperature unit to be diplayed
            setGridValues(getWeatherData(), city, start, end); //populate the datagrid
        }
        
        //Start of helper methods
        //--------------------------

        //This method will get all the weather data from the file
        private List<WeatherModel> getWeatherData()
        {
            JSONconnection js = new JSONconnection(); //create an instance of the weather class

            List<WeatherModel> list = new List<WeatherModel>(); // to store the weather data
            list = js.readWeatherFile(); //retrieve all the weather data and store inside the list
            foreach (WeatherModel item in list)
            {
                item.convertUnit(fUser.IsCelsius); //Convert the data to the user's preferred temperature unit
            }
            return list; //return the weather data
        }

        private void setDegrees(bool isCelsius) //set the symbol used for the temperature
        {

            if (isCelsius == true)
            {
                unit = " °C"; // Celsius
            }
            else
            {
                unit = " °F"; //Fahrenheit
            }
        }

        public void getCity(string city) //get the selected city name
        {
            txtCity.Text = city;
        }

        public void getMaxTemp(List<WeatherModel> list) //get the highest max temp
        {


            foreach (WeatherModel w in list)
            {
                if (max < w.Max)
                {
                    max = w.Max;
                }
            }

            txtMax.Text = Convert.ToString(Math.Round(max)) + unit;
        }

        public void getMinTemp(List<WeatherModel> list) //get thenlowest minimum temp
        {

            foreach (WeatherModel w in list)
            {
                if (min > w.Min)
                {
                    min = w.Min;
                }
            }

            txtMin.Text = Convert.ToString(Math.Round(min)) + unit;
        }

        public void getMaxHumid(List<WeatherModel> list) //get the highest humidity
        {

            foreach (WeatherModel w in list)
            {
                if (humid < w.Humidity)
                {
                    humid = w.Humidity;
                }
            }

            txtHumid.Text = Convert.ToString(humid) + " %";
        }

        public void getMaxPrecip(List<WeatherModel> list) //get the highest precipitaion
        {


            foreach (WeatherModel w in list)
            {
                if (precip < w.Precipitation)
                {
                    precip = w.Precipitation;
                }
            }

            txtPrecip.Text = Convert.ToString(precip) + " %";
        }

        public void getMaxWind(List<WeatherModel> list) //get the highest wind speed
        {

            foreach (WeatherModel w in list)
            {
                if (wind < w.Wind)
                {
                    wind = w.Wind;
                }
            }

            txtWind.Text = Convert.ToString(Math.Round(wind)) + "Km/h";
        }

        public void setGridValues(List<WeatherModel> list, string city, DateTime d1, DateTime d2) //display the values on the data grid view
        {
            List<WeatherModel> weather = new List<WeatherModel>();

            foreach (WeatherModel w in list) //cycle through the list
            {
                if (city.Equals(w.City))
                {
                    if (w.Date >= d1 && w.Date <= d2)
                    {
                        weather.Add(w); //add the object to the list that will be passed  to the report
                    }
                }
            }

            //Create all of the highlights
            getMaxTemp(weather);
            getMinTemp(weather);
            getMaxHumid(weather);
            getMaxPrecip(weather);
            getMaxWind(weather);


            foreach (WeatherModel v in weather)
            {
                int n = dgvReport.Rows.Add(); //create a new row and add the relevant information to the appropriate cell

                dgvReport.Rows[n].Cells[0].Value = Convert.ToString(v.City);
                dgvReport.Rows[n].Cells[1].Value = Convert.ToString(v.Date.ToShortDateString());
                dgvReport.Rows[n].Cells[2].Value = Convert.ToString(Math.Round(v.Max)) + " " + unit;
                dgvReport.Rows[n].Cells[3].Value = Convert.ToString(Math.Round(v.Min)) + " " + unit;
                dgvReport.Rows[n].Cells[4].Value = Convert.ToString(v.Humidity) + " %";
                dgvReport.Rows[n].Cells[5].Value = Convert.ToString(v.Precipitation) + " %";
                dgvReport.Rows[n].Cells[6].Value = Convert.ToString(Math.Round(v.Wind)) + "Km/h";
            }
        }

        //End of helper methods
        //-----------------------------

        //start of click events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ForecasterMenu fm = new ForecasterMenu(fUser);
            fm.Show();
            this.Hide();
        }
        //end of click events
    }
}
