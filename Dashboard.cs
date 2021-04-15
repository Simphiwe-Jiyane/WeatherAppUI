using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherAppUI
{
    public partial class Dashboard : Form
    {

        static UserModel gUser = new UserModel();//User model that will be passed to the other forms

        public Dashboard(UserModel user)
        {
            gUser = user;
            InitializeComponent();
            activeIndicator(pnlHomeIndicator); //set the active indicator on the nav
            //on opening the app open the home page form as well in side the parent container
            #region
            lblUsername.Text = $"{user.FName} {user.SName}";
            lblUserType.Text = user.Type.ToUpper();
            Home fr = new Home(user);
            fr.TopLevel = false;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            pnlParent.Controls.Add(fr);
            pnlParent.Tag = fr;
            fr.BringToFront();
            fr.Show();
            #endregion       
        }

        //Start helper methods

        //Method to open a child form inside the parent form. The parent form will always be the dashboard form
        public void openChildForm(Form childForm, Form activeForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlParent.Controls.Add(childForm);
                pnlParent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        //Method to change the active indicators
        public void activeIndicator(Panel active)
        {
            pnlHomeIndicator.BackColor = Color.FromArgb(205, 205, 192); //set all indicators to thr defualt colour
            pnlForecastIndicator.BackColor = Color.FromArgb(205, 205, 192);
            pnlSettingIndicator.BackColor = Color.FromArgb(205, 205, 192);

            active.BackColor = Color.FromArgb(221, 188, 149); //change the active indicator to the acive colour
        }

        //End helper methods

        //start events

        //Event to open the home page form if clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            activeIndicator(pnlHomeIndicator); //Change the active indicator
            Dashboard ds = new Dashboard(gUser); //Open the parent form and pass in the user model to use his/her info
            Home fc = new Home(gUser); //open the home form and pass in the user model
            openChildForm(fc, ds); // open the child form inside the parent form
        }

        //Event to open the forecaster page
        private void btnForecast_Click(object sender, EventArgs e)
        {
            activeIndicator(pnlForecastIndicator); //Change the active indicator
            Dashboard ds = new Dashboard(gUser);
            Forecasts fc = new Forecasts(gUser);
            openChildForm(fc, ds); //Open the child form inside the parent form
        }

        //Event to open the settings page
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            activeIndicator(pnlSettingIndicator); //Change the active indicator
            Settings st = new Settings(gUser);
            Dashboard ds = new Dashboard(gUser);
            openChildForm(st, ds); //Open the child form inside the parent form
        }

        //If the signout icon is clicked sign the user out if they choose to
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you would like to sign out?", "Sign out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK) //If yes sign the user oput and send back to the landing page
            {
                Landing ld = new Landing();
                ld.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
