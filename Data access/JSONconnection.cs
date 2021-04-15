using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace WeatherAppUI
{
    public class JSONconnection
    {
        //Globals
        //----------------------------------

        string weatherPath = "weatherdata.json"; //weather data file path
        string userPath = "Users.json"; //user data file path

        //end of globals
        //----------------------------------

        /// <summary>
        /// Checks if a the files exist and if not they will be created
        /// </summary>
        public void createFiles()
        {
            try
            {
                if (!File.Exists(userPath)) //check if the users file exists
                {
                    FileStream fs = new FileStream(userPath, FileMode.Create, FileAccess.ReadWrite); //create it if it does not exist
                    fs.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (!File.Exists(weatherPath)) //check if the weather file exists
                {
                    FileStream fs = new FileStream(weatherPath, FileMode.Create, FileAccess.ReadWrite); //create it if does not exist
                    fs.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        ///  Method to validate an existing user
        /// </summary>
        /// <param name="password">Accepts a password form the control calling this method</param>
        /// <returns>Returns true if useer is found else the user does not exists</returns>
        public UserModel login(string username, string pwd)
        {

            string strUsers = File.ReadAllText(userPath); //read all the data from the users file

            UserModel user = new UserModel(); //create an instance of the usermodel class

            List<UserModel> wam = new List<UserModel>(); //create a list to store the values from the users file

            wam = JsonConvert.DeserializeObject<List<UserModel>>(strUsers); // deserialize the json data into the list

            if (wam == null) //check if the file has no data
            {
                user.FName = "no users available"; //set the first name as no users available to let the calling object know there is no data
                user.SName = "";
                user.SName = null;
                user.UserName = "";

                return user; //return the empty user
            }

            else // else search for the user using the credemtials passed
            {
                foreach (UserModel item in wam)
                {
                    if (username.ToLower().Equals(item.UserName) && pwd.Equals(item.Password)) //if the credentials match a user, return that user
                    {
                        user = item;
                        break; //end the search
                    }
                }

                return user; //return the found user
            }
        }

        /// <summary>
        /// This method adds a new forecaster/general user to their respective files user to the 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="username"></param>
        /// <param name="fName"></param>
        /// <param name="sName"></param>
        /// <param name="password"></param>
        /// <param name="isCelsius"></param>
        /// <param name="homeCity"></param>
        /// <param name="prefCity"></param>
        /// <returns>Returns true if the user was added successfully</returns>
        public bool signUp(int type, string username, string fName, string sName, string password, bool isCelsius, string homeCity, List<string> prefCity = null)
        {
            bool valid = false; // this method will control whether all the data is valid and allow the method to proceed or end it
            bool found = false; // this bool checks if there is a user file
            bool unique = false; //this will be used to determine whether a user's USername is unique or not
            List<UserModel> newList = new List<UserModel>(); //List to store the new values written to the file
            List<UserModel> oldList = new List<UserModel>(); //this will be used to store the original values

            string conv = "";

            if (File.Exists(userPath)) //check if the file exist
            {
                found = true; //file is found
            }

            if (found) //if the file exists
            {
                string revList = "";

                try
                {
                    revList = File.ReadAllText(userPath); //read trhe file 
                }
                catch
                { }
                UserModel User = new UserModel();//create a user model to write to the file


                oldList = JsonConvert.DeserializeObject<List<UserModel>>(revList); //deserialize the json objects into a list

                if (oldList != null) //if the list is not empty
                {
                    foreach (UserModel item in oldList)
                    {
                        newList.Add(item); //add the old values to the new values list
                    }
                }

                int count = 0; //if the count is greater than 0 then a user with the same username has been found

                foreach (UserModel item in newList)
                {
                    if (username.ToLower().Equals(item.UserName.ToLower()))
                    {
                        count = 1;
                        break;
                    }
                }

                if (count == 1)
                {
                    unique = false; // username is not unique
                }
                else
                {
                    unique = true; // username is unique
                }

                if (unique) //continue if the username is unique
                {
                    if (type == 0) //if the user type is of general user
                    {
                        //set the values of the general user object
                        User.UserName = username.ToLower();
                        User.Password = password;
                        User.Type = "general user";
                        User.FName = fName;
                        User.SName = sName;
                        User.IsCelsius = isCelsius;
                        User._homeCity = homeCity;
                        User.prefferedCities = prefCity;
                        newList.Add(User);
                    }
                    else //if the user type is a forecaster
                    {
                        //set the values of the forecaster object
                        User.UserName = username.ToLower();
                        User.Password = password;
                        User.Type = "forecaster";
                        User.FName = fName;
                        User.SName = sName;
                        User._homeCity = homeCity;
                        User.IsCelsius = isCelsius;
                        newList.Add(User);
                    }
                    try
                    {
                        conv = JsonConvert.SerializeObject(newList); // convert the object into a JSON object
                        valid = true; // the values are all valid and can be written to the file
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false; //the object could not be converted into a json object
                    }
                    if (valid == true)
                    {
                        try
                        {
                            File.WriteAllText(userPath, conv); //write the json object to the file

                            return true;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message); //the json object could not be written to the file
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oops...Something went wrong");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Username already exist. Please create a different one", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("There was an error opening/creating the the file", "File opne/create error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Method to change the user's password
        /// </summary>
        /// <param name="username">Accepts the username</param>
        /// <param name="NewPwd">Accepts the new password</param>
        /// <returns>returns true if password successfully changed</returns>
        public bool changePassword(string username, string NewPwd)
        {
            string conv = File.ReadAllText(userPath); //read all the data from the file
            bool changed = false; // bool tha will be returned if the password was changed



            List<UserModel> newList = new List<UserModel>();
            List<UserModel> oldList = new List<UserModel>();

            oldList = JsonConvert.DeserializeObject<List<UserModel>>(conv); //deserialize the json data into a list

            if (oldList != null)
            {
                foreach (UserModel i in oldList)
                {
                    newList.Add(i);
                }
            }

            foreach (UserModel item in newList)
            {
                if (username.Equals(item.UserName)) //find the user using the credentials passed
                {
                    item.Password = NewPwd; //change the password
                    changed = true; //password was changed
                    break; //stop the search
                }
            }
            conv = JsonConvert.SerializeObject(newList); //convert the updated users into a json object
            File.WriteAllText(userPath, conv); //write the data to the file
            return changed;
        }

        /// <summary>
        /// Method to change a user's preferred temperature unit
        /// </summary>
        /// <param name="user"></param>
        /// <returns>returns true if the unit was successfully changed</returns>
        public bool changeUserPreference(UserModel user)
        {
            string conv = File.ReadAllText(userPath); //read the data from the file
            bool changed = false; // bool tha will be returned if the unit was changed

            List<UserModel> newList = new List<UserModel>();
            List<UserModel> oldList = new List<UserModel>();

            oldList = JsonConvert.DeserializeObject<List<UserModel>>(conv); //deserialize the json data into a list

            if (oldList != null)
            {
                foreach (UserModel i in oldList)
                {
                    newList.Add(i);
                }
            }

            foreach (UserModel item in newList)
            {
                if (user.UserName.Equals(item.UserName) && user.Password.Equals(item.Password)) //find the user using the credentials passed
                {
                    item.IsCelsius = user.IsCelsius;
                    changed = true;
                    break;
                }
            }
            conv = JsonConvert.SerializeObject(newList);
            File.WriteAllText(userPath, conv);
            return changed;
        }

        /// <summary>
        /// This method will check if a file exists. If it does exiist, the data will be read from the file else the user will be prompted to create a  new one or teminate the save process
        /// </summary>
        /// <returns>Returns a List of the weather data</returns>
        public List<WeatherModel> readWeatherFile()
        {
            string conv = string.Empty;
            List<WeatherModel> weatherdata = new List<WeatherModel>();
            conv = File.ReadAllText(weatherPath);

            weatherdata = JsonConvert.DeserializeObject<List<WeatherModel>>(conv);

            return weatherdata;
        }

        /// <summary>
        /// This method will check if a file exists. If it does exiist, the data will be wittten to the file else the user will be prompted to create a  new one or teminate the save process
        /// </summary>
        /// <param name="data">Accepts a List to be stored to the file</param>
        /// <returns>Returns true if the data was successfully stored</returns>
        public void writeWeatherFile(List<WeatherModel> data)
        {
            bool valid = false;
            string conv = "";
            try
            {
                conv = File.ReadAllText(weatherPath); //read all weather data from file
            }
            catch
            {

            }
            finally
            {
                conv = File.ReadAllText(weatherPath);
            }

            string write = string.Empty;

            // create the lists to hold the data to be written to the file
            List<WeatherModel> oldList = new List<WeatherModel>();
            List<WeatherModel> newList = new List<WeatherModel>();

            oldList = JsonConvert.DeserializeObject<List<WeatherModel>>(conv);  //deserialize the old list

            if (oldList != null)
            {
                foreach (WeatherModel item in oldList)
                {
                    newList.Add(item);
                }
            }

            foreach (WeatherModel d in data) // add the data to the list here
            {
                try
                {
                    newList.Add(d);
                    valid = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    valid = false;
                }
            }

            if (valid == true) // if the data was added to a list write it to the file
            {
                write = JsonConvert.SerializeObject(newList);
                File.WriteAllText(weatherPath, write);
                MessageBox.Show("Information Added successfully");
            }
            else
            {
                MessageBox.Show("Operation was canceled due to errors");// let the user know the data could not be added
            }
        }

        /// <summary>
        /// //This method will overwrite the existing weather data
        /// </summary>
        /// <param name="obj"></param>
        public bool overwriteFile(WeatherModel obj)
        {
            string conv = File.ReadAllText(weatherPath);//read all data from the file
            string write = string.Empty;

            List<WeatherModel> List = new List<WeatherModel>();

            List = JsonConvert.DeserializeObject<List<WeatherModel>>(conv);

            foreach (WeatherModel item in List)
            {
                if (item.City.Equals(obj.City) && item.Date == obj.Date)
                {
                    item.Max = obj.Max;
                    item.Min = obj.Min;
                    item.Humidity = obj.Humidity;
                    item.Precipitation = obj.Precipitation;
                    item.UvIndex = obj.UvIndex;
                    item.Wind = obj.Wind;
                    item.CloudCover = obj.CloudCover;
                    item.IsCelsius = obj.IsCelsius;
                }
            }

            try
            {
                write = JsonConvert.SerializeObject(List);
                File.WriteAllText(weatherPath, write);
                return true;
            }
            catch
            {
                MessageBox.Show("Could not overwrite the data");
                return false;
            }
        }

        /// <summary>
        /// This method deletes the selected weathe object from the file
        /// </summary>
        /// <param name="weather">Accepts the weather object to delete</param>
        /// <returns>True if object if the object was removed</returns>
        public bool deleteWeather(WeatherModel weather)
        {
            string conv = File.ReadAllText(weatherPath);
            string write = string.Empty;

            List<WeatherModel> oldList = new List<WeatherModel>();

            oldList = JsonConvert.DeserializeObject<List<WeatherModel>>(conv);

            foreach (WeatherModel item in oldList)
            {
                if (item.City.Equals(weather.City) && item.Date == weather.Date)
                {

                    oldList.Remove(item);
                    break;
                }
            }

            try
            {
                write = JsonConvert.SerializeObject(oldList);
                File.WriteAllText(weatherPath, write);
                MessageBox.Show("Data deleted");
                return true;
            }
            catch
            {
                MessageBox.Show("Could not delete the data");
                return false;
            }
        }


        //End of file
        //------------------------
    }
}
