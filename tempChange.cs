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
    public partial class tempChange : Form
    {
        UserModel fUser = new UserModel();

        public tempChange(UserModel user)
        {
            InitializeComponent();
            if (user.IsCelsius)
            {
                radCelsius.Checked = true;
                radFahrenheit.Checked = false;
            }
            else
            {
                radCelsius.Checked = false;
                radFahrenheit.Checked = true;
            }

            fUser = user;
               
        }

        // Change the user's preferred temp unit then close this form
        private void btnApply_Click(object sender, EventArgs e)
        {
            JSONconnection js = new JSONconnection(); //Instance of the JSONconnection class to user JSON methods
            if (radCelsius.Checked == true)//if the celsius button is checked change the user's preference to celsius
            {
                fUser.IsCelsius = true;
            }
            else //if the fahrenheit button is checked change the user's preferrence to fahrenheit
            {
                fUser.IsCelsius = false;
            }

            if (js.changeUserPreference(fUser)) //Save this changes to the file
            {
                MessageBox.Show("User preference successfully changed");
                ForecasterMenu fm = new ForecasterMenu(fUser);
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("User preference could not be changed, please try again", "Change error");
            }
        }
    }
}
