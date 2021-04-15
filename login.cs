using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherAppUI
{
    public partial class login : Form
    {
        public login()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        //Start events

        //Exit and minimize button events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //End of Exit minimize and events

        //Event to send the user to the sign up page
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup sp = new signup();
            this.Hide();
            sp.Show();
        }

        //Method to handle the user login
        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            JSONconnection js = new JSONconnection(); //Onstance of the JSONConnection class to use the JSON methods

            UserModel user = new UserModel(); //User model that will be used to store the found user

            user = js.login(txtUsername.Text,txtPassword.Text); //Capture the username and password from the textboxes and pass them into the JSON login method

            if (user.FName != null) //If there there was a user found on the system
            {
                if(user.FName.Equals("no users available")) //This will determine if there are no users registered on the system
                {
                    DialogResult dr = MessageBox.Show("There are no users registered on the system. would you like to sign up?", "No Users", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes) //Send the user to the sign up page
                    {
                        signup sg = new signup();
                        sg.Show();
                        this.Hide();
                    }
                }
                else if (user.Type.Equals("general user")) //If the user found is a general user open the general user side of the application
                {
                    Dashboard ds = new Dashboard(user);
                    this.Hide();
                    ds.Show();
                }
                else //If the user found is a forecaster open the Forecaster side of the application
                {
                    ForecasterMenu fm = new ForecasterMenu(user);
                    this.Hide();
                    fm.Show();
                }
            }
            else // if the user credentials are incorrect display an error message and clear all fields
            {
                MessageBox.Show("User could not be found... Please check your credentials");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        //Click event to return the user to the landing page
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to go back to the starter page. Are you sure you want to quit?", "confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) //If the user confirms that they would like to return to the landing page open it and close the current
            {
                Landing ld = new Landing();
                ld.Show();
                this.Hide();
            }          
        }

        //Event to open the sign up page
        private void linkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup sg = new signup();
            sg.Show();
            this.Hide();
        }

        //End of events
    }
}
