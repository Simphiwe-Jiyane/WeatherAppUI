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
    public partial class UpdateDelete : Form
    {
        //Globals
        //-------------------------

        List<WeatherModel> weath = new List<WeatherModel>(); //list to store weather data values from the file
        JSONconnection js = new JSONconnection(); //instance of the JSON connection class to use the json methods and access the file
        UserModel fUser = new UserModel(); //user model 
        //end of globals
        //-------------------------


        public UpdateDelete(UserModel user,bool active)
        {
            InitializeComponent();
            fUser = user;
            //set active panel
            #region
            if (active)
            {
                pnlUpdate.Visible = true;
                pnlDelete.Visible = false;
            }
            else
            {
                pnlUpdate.Visible = false;
                pnlDelete.Visible = true;
            }
            #endregion  
            loadComboBox(); //load the combo boxes with cities that have data
            dtpDate.MinDate = DateTime.Today;
            dtpDeleteDate.MinDate = DateTime.Today;
        }

        //start of helper methods
        //---------------------------
        private void loadComboBox()
        {
            List<string> cities = new List<string>();
            string city = "";
            weath = js.readWeatherFile();
            foreach (WeatherModel item in weath)
            {
                cities.Add(item.City);
            }

            cities.Sort();

            foreach (string ci in cities)
            {
                if (!city.Equals(ci)) 
                {
                    cboCity.Items.Add(ci);
                    cboDeleteCity.Items.Add(ci);
                    city = ci;
                }
            }
        }

        //this method checks the text boxes for errors
        private bool errorCheck(TextBox txt)
        {
            double num;
            if (string.IsNullOrWhiteSpace(txt.Text)) //check if the fields are empty
            {
                captureError.SetError(txt, "This cannot be empty");
                return false;
            }
            else
            {
                try
                {
                    num = Convert.ToDouble(txt.Text); //check if the value is a number
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

        //end of helper methods
        //--------------------------------

        //start of events
        //-----------------------------

        //this method will overwrite the data stored in the file with new values
        private void btnCapture_Click(object sender, EventArgs e)
        {

            WeatherModel weather = new WeatherModel();
            bool valid = true;

            weath = js.readWeatherFile();

            //check for errors
            #region
            if (errorCheck(txtMax) == false) // check if the control is a numeric value and check if it is not empty
            {
                valid = false;
                return;
            }


            if (errorCheck(txtMin) == false)
            {
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

            if(cboCloud.SelectedIndex == -1)
            {
                captureError.SetError(cboCloud, "Please select the cloud cover");
                valid = false;
            }

            if(cboUvIndex.SelectedIndex == -1)
            {
                captureError.SetError(cboUvIndex, "Please select the UV index");
                valid = false;
            }
            #endregion

            if (valid)
            {
                captureError.Clear();
                foreach (WeatherModel item in weath)
                {
                    if (item.City.Equals(cboCity.Text) && item.Date == dtpDate.Value.Date) //check if there is already a value with the same date
                    {
                        //if a value already exits for the this city and date, ask the user if they would like to overide
                        DialogResult dr = MessageBox.Show("are you sure you would like to overwrite the values?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            weather.City = cboCity.Text;
                            weather.Date = dtpDate.Value.Date;
                            weather.Max = Convert.ToDouble(txtMax.Text);
                            weather.Min = Convert.ToDouble(txtMin.Text);
                            weather.Humidity = Convert.ToDouble(txtHumid.Text);
                            weather.Precipitation = Convert.ToDouble(txtPrecip.Text);
                            weather.Wind = Convert.ToDouble(txtWind.Text);
                            weather.CloudCover = cboCloud.SelectedIndex;
                            weather.UvIndex = cboUvIndex.Text;


                            if (js.overwriteFile(weather))
                            {
                                MessageBox.Show("Data overwritten successfully");
                                ForecasterMenu fm = new ForecasterMenu(fUser);
                                this.Hide();
                                fm.Show();

                            }
                            else
                            {
                                MessageBox.Show("There was an error with the request", "Overwrite error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Operation cancelled", "Overwrite cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboCity.SelectedIndex = -1;
                            txtMax.Clear();
                            txtMin.Clear();
                            txtHumid.Clear();
                            txtPrecip.Clear();
                            txtWind.Clear();
                            cboCloud.SelectedIndex = -1;
                            cboUvIndex.SelectedIndex = -1;
                        }
                    }  
                }

            }
        }

        //this event will activate the date time picker only when a city is selected
        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCity.SelectedIndex != -1)
            {
                captureError.Clear();
                dtpDate.Enabled = true;
            }
            else
            {
                captureError.SetError(cboCity, "Please select a city");
            }
        }

        //this event will populate the fields with the current values so the user can see what is currently stored in the forecast
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            foreach (WeatherModel item in js.readWeatherFile())
            {
                if(dtpDate.Value.Date == item.Date && cboCity.Text.Equals(item.City))
                {
                    lblOldMax.Text = Convert.ToString(item.Max);
                    lblOldMin.Text = Convert.ToString(item.Min);
                    lblOldHumd.Text = Convert.ToString(item.Humidity);
                    lblOldPrecip.Text = Convert.ToString(item.Precipitation);
                    lblOldWind.Text = Convert.ToString(item.Wind);
                    lblOldUv.Text = item.UvIndex;

                    if(item.CloudCover == 1)
                    {
                        lblOldCloud.Text = "Sunny";
                    }
                    else if(item.CloudCover == 2)
                    {
                        lblOldCloud.Text = "Partly cloudy";
                    }
                    else if(item.CloudCover == 3)
                    {
                        lblOldCloud.Text = "Full Cloud Cover";
                    }
                    else
                    {
                        lblOldCloud.Text = "Thunder showers";
                    }
                    break;
                }
            }
        }

        //this event will activate the date time picker only when a city is selected
        private void cboDeleteCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDeleteCity.SelectedIndex != -1)
            {
                captureError.Clear();
                dtpDeleteDate.Enabled = true;
            }
            else
            {
                captureError.SetError(cboDeleteCity, "Please select a city");
            }
        }

        //this event will delete the selected city from the file
        private void btnDelete_Click(object sender, EventArgs e)
        {
            weath = js.readWeatherFile();
           
            foreach (WeatherModel item in weath)
            {
                if(item.Date == dtpDeleteDate.Value.Date && item.City.Equals(item.City))
                {
                    if (js.deleteWeather(item))
                    {
                        MessageBox.Show("Weather data removed successfully", "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }                  
        }

        //This will cancel the delete process and go back to the home page
        private void btnCancelDelete_Click(object sender, EventArgs e)
        {
            ForecasterMenu fm = new ForecasterMenu(fUser);
            fm.Show();
            this.Hide();
        }

        //This method will cancel the update process and go back to the home page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ForecasterMenu fm = new ForecasterMenu(fUser);
            fm.Show();
            this.Hide();
        }

        //end of events
        //-------------------------------------
    }
}
