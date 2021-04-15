using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppUI
{
    public class WeatherModel
    {
        //Properties for a weather object
        public DateTime Date { get; set; } //forecast date
        public double Max { get; set; } // forcast maximum temperature
        public double Min { get; set; } //forecast minimum temperature
        public double Humidity { get; set; } //forecat humdity
        public double Wind { get; set; } //foreacast wind speed
        public string UvIndex { get; set; } //forecast UV index
        public int CloudCover { get; set; } // forecast cloud cover
        public string City { get; set; } //forecast's city
        public double Precipitation { get; set; } // foreacast precipitation
        public bool IsCelsius { get; set; } //forecasts temperature unit
        public void convertUnit(bool isCelsius) //This method converts the data if the unit of measure has been changed
        {

            if (isCelsius == true && this.IsCelsius == false)//convert from fahr
            {
                this.Max = (this.Max - 32) * 5 / 9;
                this.Min = (this.Min - 32) * 5 / 9;
              //  this.Wind = Convert.ToDouble(this.Wind * 1.60934); //comvert from mph
            }
            else if (isCelsius == false && this.IsCelsius == true)//convert from celc
            {
                this.Max = (this.Max * 9) / 5 + 32;
                this.Min = (this.Min * 9) / 5 + 32;
              //  this.Wind = Convert.ToDouble(this.Wind * 0.6214); //convert from kmh
            }
        }
    } 
}
