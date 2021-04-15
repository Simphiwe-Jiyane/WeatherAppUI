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
    public partial class MultiCityReport : Form
    {
        //Globals
        //-------------------

        UserModel fUser = new UserModel(); //user model object to save a copy of the user on this form
        string unit; //string variable to display the temeprature unit

        //end of globals
        //----------------

        public MultiCityReport(UserModel user,List<string> selectedCities,DateTime start,DateTime end)
        {
            InitializeComponent();
            fUser = user;
            getCity(selectedCities);
            setDegrees(user.IsCelsius);
            SetdgvReport1(getWeatherData(), selectedCities, start, end); 
            SetdgvReport2(getWeatherData(), selectedCities, start, end); 
        }

        //start of hellper methods
        //-------------------------

        private List<WeatherModel> getWeatherData()
        {
            JSONconnection js = new JSONconnection();

            List<WeatherModel> list = new List<WeatherModel>();
            list = js.readWeatherFile();
            foreach (WeatherModel item in list)
            {
                item.convertUnit(fUser.IsCelsius);
            }
            return list;
        }

        public void setDegrees(bool isCelsius) //set the symbol used for the temperature
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

        private void getCity(List<string> cities)
        {
            foreach (string item in cities)
            {
                lstBoxCities.Items.Add(item);
            }
        }

        //Create the datagrid view for the multiple city per city
        public void SetdgvReport1(List<WeatherModel> vals,List<string> cities,DateTime start, DateTime end)
        {

            foreach (string w in cities) //cycle through the list
            {
                foreach (WeatherModel v in vals)
                {
                    if (w.Equals(v.City))
                    {

                        if (v.Date >= start && v.Date <= end)
                        {
                            int n = dgvReportPerCity.Rows.Add(); //create a new row and populate the appropraite cell with data for the report

                            dgvReportPerCity.Rows[n].Cells[0].Value = Convert.ToString(v.City);
                            dgvReportPerCity.Rows[n].Cells[1].Value = Convert.ToString(v.Date.ToShortDateString());
                            dgvReportPerCity.Rows[n].Cells[2].Value = Convert.ToString(Math.Round(v.Max) + unit);//call the mthod for the unit of measure
                            dgvReportPerCity.Rows[n].Cells[3].Value = Convert.ToString(Math.Round(v.Min) + unit);
                            dgvReportPerCity.Rows[n].Cells[4].Value = Convert.ToString(v.Humidity) + " %";
                            dgvReportPerCity.Rows[n].Cells[5].Value = Convert.ToString(v.Precipitation) + " %";
                            dgvReportPerCity.Rows[n].Cells[6].Value = Convert.ToString(Math.Round(v.Wind)+" Km/h");//call the mthod for the unit of measur 
                        } 
                    }
                }
            }

        }

        //Create the datagrid view for the multiple city per city
        public void SetdgvReport2(List<WeatherModel> vals, List<string> cities, DateTime start, DateTime end)
        {
            DateTime date = start;
            bool add = false;
            double max = 0, humid = 0, precip = 0, wind = 0;
            double min = 200;

            while(date >= start && date <= end) //Might not need  this
            {
                foreach (WeatherModel item in vals)
                {
                    if(date == item.Date && date <= end)
                    {
                        int n = dgvReportPerDay.Rows.Add(); //create a new row and populate the appropraite cell with data for the report
                        dgvReportPerDay.Rows[n].Cells[0].Value = Convert.ToString(item.Date.ToShortDateString());

                        foreach (WeatherModel v in vals)
                        {

                            foreach (string cit in cities)
                            {

                                if (cit.Equals(v.City) && date == v.Date)
                                {
                                    //get the highest max
                                    if (max <= v.Max)
                                        max = v.Max;

                                    //get the lowest min
                                    if (min >= v.Min)
                                        min = v.Min;

                                    //get the highest humidity
                                    if (humid <= v.Humidity)
                                        humid = v.Humidity;

                                    //get the highest precipitaion
                                    if (precip <= v.Precipitation)
                                        precip = v.Precipitation;

                                    //get the highest wind speed
                                    if (wind <= v.Wind)
                                        wind = v.Wind;

                                    add = true;  
                                }
                            } 
                        }


                        //set the rest of the row
                        if (add)
                        {
                            dgvReportPerDay.Rows[n].Cells[1].Value = Convert.ToString(Math.Round(max)+unit);
                            dgvReportPerDay.Rows[n].Cells[2].Value = Convert.ToString(Math.Round(min)+unit);//call the mthod for the unit of measure
                            dgvReportPerDay.Rows[n].Cells[3].Value = Convert.ToString(Math.Round(humid)+" %");
                            dgvReportPerDay.Rows[n].Cells[4].Value = Convert.ToString(Math.Round(precip)+" %");
                            dgvReportPerDay.Rows[n].Cells[5].Value = Convert.ToString(Math.Round(wind)+" Km/h");

                        }
                        //reset all the highlight variable
                        max = 0;
                        min = 200;
                        humid = 0;
                        precip = 0;
                        wind = 0;
                        date = date.AddDays(1);
                    }
                }
            }

        }


        //End of helper methods
        //------------------------------

        //start of click events
        //-----------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ForecasterMenu fm = new ForecasterMenu(fUser);
            fm.Show();
            this.Hide();
        }

        //End of click events
        //----------------------------
    }
}
