using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppUI
{
    public class UserModel
    {

        //general properties for a weather app user

        public string UserName { get ; set; } //username
        public string FName { get; set; } //first name
        public string SName { get; set; } //surname
        public string Password { get; set; } //user password
        public string Type { get; set; } //user type
        public bool IsCelsius { get; set; } //preferred temperature unit
        public string _homeCity { get; set; } //user home city
        public List<string> prefferedCities{ get; set; } //list of user's extra cities
    }
}
