namespace WeatherAppUI
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnChangeCityInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCityOptions = new System.Windows.Forms.Panel();
            this.btnChangeHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboExtraCity = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnAddcity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstboxCities = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.pnlCityOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius/Fahrenheit Switch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change login pasword:";
            // 
            // btnChangeLogin
            // 
            this.btnChangeLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLogin.Location = new System.Drawing.Point(632, 144);
            this.btnChangeLogin.Name = "btnChangeLogin";
            this.btnChangeLogin.Size = new System.Drawing.Size(105, 29);
            this.btnChangeLogin.TabIndex = 55;
            this.btnChangeLogin.Text = "Change";
            this.btnChangeLogin.UseVisualStyleBackColor = true;
            this.btnChangeLogin.Click += new System.EventHandler(this.btnChangeLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(424, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 33);
            this.txtPassword.TabIndex = 58;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.radFahrenheit);
            this.panel12.Controls.Add(this.radCelsius);
            this.panel12.Location = new System.Drawing.Point(424, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(303, 44);
            this.panel12.TabIndex = 80;
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFahrenheit.Location = new System.Drawing.Point(154, 13);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(134, 25);
            this.radFahrenheit.TabIndex = 78;
            this.radFahrenheit.TabStop = true;
            this.radFahrenheit.Text = "Fahrenheit (°F )";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCelsius.Location = new System.Drawing.Point(3, 13);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(111, 25);
            this.radCelsius.TabIndex = 77;
            this.radCelsius.TabStop = true;
            this.radCelsius.Text = "Celsius (°C )";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(733, 41);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 29);
            this.btnApply.TabIndex = 81;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnChangeCityInfo
            // 
            this.btnChangeCityInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeCityInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeCityInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCityInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCityInfo.Location = new System.Drawing.Point(632, 245);
            this.btnChangeCityInfo.Name = "btnChangeCityInfo";
            this.btnChangeCityInfo.Size = new System.Drawing.Size(105, 29);
            this.btnChangeCityInfo.TabIndex = 88;
            this.btnChangeCityInfo.Text = "Change";
            this.btnChangeCityInfo.UseVisualStyleBackColor = true;
            this.btnChangeCityInfo.Click += new System.EventHandler(this.btnChangeCityInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Edit home city and extra city information:";
            // 
            // pnlCityOptions
            // 
            this.pnlCityOptions.Controls.Add(this.btnChangeHome);
            this.pnlCityOptions.Controls.Add(this.label9);
            this.pnlCityOptions.Controls.Add(this.cboExtraCity);
            this.pnlCityOptions.Controls.Add(this.cboCity);
            this.pnlCityOptions.Controls.Add(this.btnAddcity);
            this.pnlCityOptions.Controls.Add(this.btnDeleteCity);
            this.pnlCityOptions.Controls.Add(this.label4);
            this.pnlCityOptions.Controls.Add(this.lstboxCities);
            this.pnlCityOptions.Controls.Add(this.label6);
            this.pnlCityOptions.Location = new System.Drawing.Point(61, 31);
            this.pnlCityOptions.Name = "pnlCityOptions";
            this.pnlCityOptions.Size = new System.Drawing.Size(808, 352);
            this.pnlCityOptions.TabIndex = 91;
            // 
            // btnChangeHome
            // 
            this.btnChangeHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnChangeHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeHome.Location = new System.Drawing.Point(417, 64);
            this.btnChangeHome.Name = "btnChangeHome";
            this.btnChangeHome.Size = new System.Drawing.Size(115, 28);
            this.btnChangeHome.TabIndex = 112;
            this.btnChangeHome.Text = "Change";
            this.btnChangeHome.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 104;
            this.label9.Text = "Add extra cities:";
            // 
            // cboExtraCity
            // 
            this.cboExtraCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboExtraCity.FormattingEnabled = true;
            this.cboExtraCity.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Durban",
            "Cape Town",
            "Polokwane"});
            this.cboExtraCity.Location = new System.Drawing.Point(417, 108);
            this.cboExtraCity.Name = "cboExtraCity";
            this.cboExtraCity.Size = new System.Drawing.Size(200, 33);
            this.cboExtraCity.TabIndex = 105;
            // 
            // cboCity
            // 
            this.cboCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Durban",
            "Cape Town",
            "Polokwane"});
            this.cboCity.Location = new System.Drawing.Point(417, 25);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(200, 33);
            this.cboCity.TabIndex = 111;
            // 
            // btnAddcity
            // 
            this.btnAddcity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnAddcity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnAddcity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddcity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcity.Location = new System.Drawing.Point(417, 156);
            this.btnAddcity.Name = "btnAddcity";
            this.btnAddcity.Size = new System.Drawing.Size(115, 28);
            this.btnAddcity.TabIndex = 106;
            this.btnAddcity.Text = "Add City";
            this.btnAddcity.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnDeleteCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnDeleteCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCity.Location = new System.Drawing.Point(416, 290);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(115, 28);
            this.btnDeleteCity.TabIndex = 107;
            this.btnDeleteCity.Text = "Delete City";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 110;
            this.label4.Text = "Change home city:";
            // 
            // lstboxCities
            // 
            this.lstboxCities.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxCities.FormattingEnabled = true;
            this.lstboxCities.ItemHeight = 21;
            this.lstboxCities.Location = new System.Drawing.Point(213, 230);
            this.lstboxCities.Name = "lstboxCities";
            this.lstboxCities.Size = new System.Drawing.Size(198, 88);
            this.lstboxCities.TabIndex = 108;
            this.lstboxCities.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 109;
            this.label6.Text = "Select a city to delete";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(931, 415);
            this.Controls.Add(this.pnlCityOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChangeCityInfo);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnChangeLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnlCityOptions.ResumeLayout(false);
            this.pnlCityOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.RadioButton radCelsius;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChangeCityInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCityOptions;
        private System.Windows.Forms.Button btnChangeHome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboExtraCity;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnAddcity;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstboxCities;
        private System.Windows.Forms.Label label6;
    }
}