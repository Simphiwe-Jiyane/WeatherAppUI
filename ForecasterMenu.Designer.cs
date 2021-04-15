namespace WeatherAppUI
{
    partial class ForecasterMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecasterMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleCityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiCityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTemperatureUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCaptureData = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.cboUvIndex = new System.Windows.Forms.ComboBox();
            this.cboCloud = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtPrecip = new System.Windows.Forms.TextBox();
            this.txtHumid = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCity1 = new System.Windows.Forms.ComboBox();
            this.pnlSingleCityRange = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSingeCancel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cboCity2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.captureError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMultiCity = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPolokwane = new System.Windows.Forms.CheckBox();
            this.chkDurban = new System.Windows.Forms.CheckBox();
            this.chkCapeTown = new System.Windows.Forms.CheckBox();
            this.chkPretoria = new System.Windows.Forms.CheckBox();
            this.chkJoburg = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCaAncelMulti = new System.Windows.Forms.Button();
            this.btnGenerateMulti = new System.Windows.Forms.Button();
            this.dtpMultiEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpMultiStart = new System.Windows.Forms.DateTimePicker();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblIsCelsius = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblwelcomeName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlCaptureData.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlSingleCityRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureError)).BeginInit();
            this.pnlMultiCity.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureForecastToolStripMenuItem,
            this.updateForecastToolStripMenuItem,
            this.deleteForecastToolStripMenuItem,
            this.generateReportsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::WeatherAppUI.Properties.Resources.user;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // captureForecastToolStripMenuItem
            // 
            this.captureForecastToolStripMenuItem.Name = "captureForecastToolStripMenuItem";
            this.captureForecastToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.captureForecastToolStripMenuItem.Text = "Capture Forecast";
            this.captureForecastToolStripMenuItem.Click += new System.EventHandler(this.captureForecastToolStripMenuItem_Click);
            // 
            // updateForecastToolStripMenuItem
            // 
            this.updateForecastToolStripMenuItem.Name = "updateForecastToolStripMenuItem";
            this.updateForecastToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateForecastToolStripMenuItem.Text = "Update Forecast";
            this.updateForecastToolStripMenuItem.Click += new System.EventHandler(this.updateForecastToolStripMenuItem_Click);
            // 
            // deleteForecastToolStripMenuItem
            // 
            this.deleteForecastToolStripMenuItem.Name = "deleteForecastToolStripMenuItem";
            this.deleteForecastToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteForecastToolStripMenuItem.Text = "Delete Forecast";
            this.deleteForecastToolStripMenuItem.Click += new System.EventHandler(this.deleteForecastToolStripMenuItem_Click);
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleCityReportToolStripMenuItem,
            this.multiCityReportToolStripMenuItem});
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate reports";
            // 
            // singleCityReportToolStripMenuItem
            // 
            this.singleCityReportToolStripMenuItem.Name = "singleCityReportToolStripMenuItem";
            this.singleCityReportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.singleCityReportToolStripMenuItem.Text = "Single City Report";
            this.singleCityReportToolStripMenuItem.Click += new System.EventHandler(this.singleCityReportToolStripMenuItem_Click);
            // 
            // multiCityReportToolStripMenuItem
            // 
            this.multiCityReportToolStripMenuItem.Name = "multiCityReportToolStripMenuItem";
            this.multiCityReportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.multiCityReportToolStripMenuItem.Text = "Multi City Report";
            this.multiCityReportToolStripMenuItem.Click += new System.EventHandler(this.multiCityReportToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTemperatureUnitToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::WeatherAppUI.Properties.Resources.user;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeTemperatureUnitToolStripMenuItem
            // 
            this.changeTemperatureUnitToolStripMenuItem.Name = "changeTemperatureUnitToolStripMenuItem";
            this.changeTemperatureUnitToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.changeTemperatureUnitToolStripMenuItem.Text = "Change Temperature Unit";
            this.changeTemperatureUnitToolStripMenuItem.Click += new System.EventHandler(this.changeTemperatureUnitToolStripMenuItem_Click);
            // 
            // pnlCaptureData
            // 
            this.pnlCaptureData.BackColor = System.Drawing.Color.SlateGray;
            this.pnlCaptureData.Controls.Add(this.panel12);
            this.pnlCaptureData.Controls.Add(this.cboUvIndex);
            this.pnlCaptureData.Controls.Add(this.cboCloud);
            this.pnlCaptureData.Controls.Add(this.btnCapture);
            this.pnlCaptureData.Controls.Add(this.dtpDate);
            this.pnlCaptureData.Controls.Add(this.btnCancel);
            this.pnlCaptureData.Controls.Add(this.label9);
            this.pnlCaptureData.Controls.Add(this.label8);
            this.pnlCaptureData.Controls.Add(this.label7);
            this.pnlCaptureData.Controls.Add(this.label6);
            this.pnlCaptureData.Controls.Add(this.label5);
            this.pnlCaptureData.Controls.Add(this.label4);
            this.pnlCaptureData.Controls.Add(this.label3);
            this.pnlCaptureData.Controls.Add(this.label2);
            this.pnlCaptureData.Controls.Add(this.txtWind);
            this.pnlCaptureData.Controls.Add(this.txtPrecip);
            this.pnlCaptureData.Controls.Add(this.txtHumid);
            this.pnlCaptureData.Controls.Add(this.txtMin);
            this.pnlCaptureData.Controls.Add(this.txtMax);
            this.pnlCaptureData.Controls.Add(this.label1);
            this.pnlCaptureData.Controls.Add(this.cboCity1);
            this.pnlCaptureData.Location = new System.Drawing.Point(67, 27);
            this.pnlCaptureData.Name = "pnlCaptureData";
            this.pnlCaptureData.Size = new System.Drawing.Size(898, 479);
            this.pnlCaptureData.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.radFahrenheit);
            this.panel12.Controls.Add(this.radCelsius);
            this.panel12.Location = new System.Drawing.Point(739, 291);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(135, 100);
            this.panel12.TabIndex = 80;
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Location = new System.Drawing.Point(33, 52);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(100, 17);
            this.radFahrenheit.TabIndex = 78;
            this.radFahrenheit.TabStop = true;
            this.radFahrenheit.Text = "Fahrenheit (°F)";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Location = new System.Drawing.Point(33, 12);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(81, 17);
            this.radCelsius.TabIndex = 77;
            this.radCelsius.TabStop = true;
            this.radCelsius.Text = "Celsius (°C)";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // cboUvIndex
            // 
            this.cboUvIndex.FormattingEnabled = true;
            this.cboUvIndex.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboUvIndex.Location = new System.Drawing.Point(445, 370);
            this.cboUvIndex.Name = "cboUvIndex";
            this.cboUvIndex.Size = new System.Drawing.Size(269, 21);
            this.cboUvIndex.TabIndex = 30;
            // 
            // cboCloud
            // 
            this.cboCloud.FormattingEnabled = true;
            this.cboCloud.Items.AddRange(new object[] {
            "Sunny",
            "Partly Cloudy",
            "Full Cloud Cover",
            "Thunder Showers"});
            this.cboCloud.Location = new System.Drawing.Point(445, 326);
            this.cboCloud.Name = "cboCloud";
            this.cboCloud.Size = new System.Drawing.Size(269, 21);
            this.cboCloud.TabIndex = 29;
            // 
            // btnCapture
            // 
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Location = new System.Drawing.Point(445, 445);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(77, 25);
            this.btnCapture.TabIndex = 28;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(445, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(269, 25);
            this.dtpDate.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(552, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select the cloud cover:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Enter the maximum temperature:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Enter the minimum temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter the humidity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter the precipitation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter the windspeed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select the UV Index:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select a date:";
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(445, 279);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(269, 22);
            this.txtWind.TabIndex = 12;
            // 
            // txtPrecip
            // 
            this.txtPrecip.Location = new System.Drawing.Point(445, 235);
            this.txtPrecip.Name = "txtPrecip";
            this.txtPrecip.Size = new System.Drawing.Size(269, 22);
            this.txtPrecip.TabIndex = 10;
            // 
            // txtHumid
            // 
            this.txtHumid.Location = new System.Drawing.Point(445, 192);
            this.txtHumid.Name = "txtHumid";
            this.txtHumid.Size = new System.Drawing.Size(269, 22);
            this.txtHumid.TabIndex = 8;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(445, 150);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(269, 22);
            this.txtMin.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(445, 110);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(269, 22);
            this.txtMax.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a city:";
            // 
            // cboCity1
            // 
            this.cboCity1.FormattingEnabled = true;
            this.cboCity1.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Durban",
            "Polokwane",
            "Cape Town"});
            this.cboCity1.Location = new System.Drawing.Point(445, 19);
            this.cboCity1.Name = "cboCity1";
            this.cboCity1.Size = new System.Drawing.Size(269, 21);
            this.cboCity1.TabIndex = 0;
            // 
            // pnlSingleCityRange
            // 
            this.pnlSingleCityRange.BackColor = System.Drawing.Color.SlateGray;
            this.pnlSingleCityRange.Controls.Add(this.label12);
            this.pnlSingleCityRange.Controls.Add(this.label11);
            this.pnlSingleCityRange.Controls.Add(this.btnSingeCancel);
            this.pnlSingleCityRange.Controls.Add(this.btnReport);
            this.pnlSingleCityRange.Controls.Add(this.dtpEnd);
            this.pnlSingleCityRange.Controls.Add(this.dtpStart);
            this.pnlSingleCityRange.Controls.Add(this.cboCity2);
            this.pnlSingleCityRange.Controls.Add(this.label10);
            this.pnlSingleCityRange.Location = new System.Drawing.Point(51, 27);
            this.pnlSingleCityRange.Name = "pnlSingleCityRange";
            this.pnlSingleCityRange.Size = new System.Drawing.Size(931, 477);
            this.pnlSingleCityRange.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(540, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Select the end date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Select the start date";
            // 
            // btnSingeCancel
            // 
            this.btnSingeCancel.AccessibleName = "btnCancel";
            this.btnSingeCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnSingeCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnSingeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingeCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingeCancel.Location = new System.Drawing.Point(509, 350);
            this.btnSingeCancel.Name = "btnSingeCancel";
            this.btnSingeCancel.Size = new System.Drawing.Size(100, 38);
            this.btnSingeCancel.TabIndex = 5;
            this.btnSingeCancel.Text = "Cancel";
            this.btnSingeCancel.UseVisualStyleBackColor = true;
            this.btnSingeCancel.Click += new System.EventHandler(this.btnSingeCancel_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(297, 350);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 38);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(534, 261);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(175, 261);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // cboCity2
            // 
            this.cboCity2.FormattingEnabled = true;
            this.cboCity2.Location = new System.Drawing.Point(447, 113);
            this.cboCity2.Name = "cboCity2";
            this.cboCity2.Size = new System.Drawing.Size(224, 21);
            this.cboCity2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Select a city:";
            // 
            // captureError
            // 
            this.captureError.ContainerControl = this;
            // 
            // pnlMultiCity
            // 
            this.pnlMultiCity.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMultiCity.Controls.Add(this.panel1);
            this.pnlMultiCity.Controls.Add(this.label13);
            this.pnlMultiCity.Controls.Add(this.label14);
            this.pnlMultiCity.Controls.Add(this.btnCaAncelMulti);
            this.pnlMultiCity.Controls.Add(this.btnGenerateMulti);
            this.pnlMultiCity.Controls.Add(this.dtpMultiEnd);
            this.pnlMultiCity.Controls.Add(this.dtpMultiStart);
            this.pnlMultiCity.Location = new System.Drawing.Point(35, 46);
            this.pnlMultiCity.Name = "pnlMultiCity";
            this.pnlMultiCity.Size = new System.Drawing.Size(990, 475);
            this.pnlMultiCity.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkPolokwane);
            this.panel1.Controls.Add(this.chkDurban);
            this.panel1.Controls.Add(this.chkCapeTown);
            this.panel1.Controls.Add(this.chkPretoria);
            this.panel1.Controls.Add(this.chkJoburg);
            this.panel1.Location = new System.Drawing.Point(326, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 166);
            this.panel1.TabIndex = 14;
            // 
            // chkPolokwane
            // 
            this.chkPolokwane.AutoSize = true;
            this.chkPolokwane.Location = new System.Drawing.Point(140, 87);
            this.chkPolokwane.Name = "chkPolokwane";
            this.chkPolokwane.Size = new System.Drawing.Size(83, 17);
            this.chkPolokwane.TabIndex = 4;
            this.chkPolokwane.Text = "Polokwane";
            this.chkPolokwane.UseVisualStyleBackColor = true;
            // 
            // chkDurban
            // 
            this.chkDurban.AutoSize = true;
            this.chkDurban.Location = new System.Drawing.Point(256, 39);
            this.chkDurban.Name = "chkDurban";
            this.chkDurban.Size = new System.Drawing.Size(65, 17);
            this.chkDurban.TabIndex = 3;
            this.chkDurban.Text = "Durban";
            this.chkDurban.UseVisualStyleBackColor = true;
            // 
            // chkCapeTown
            // 
            this.chkCapeTown.AutoSize = true;
            this.chkCapeTown.Location = new System.Drawing.Point(19, 87);
            this.chkCapeTown.Name = "chkCapeTown";
            this.chkCapeTown.Size = new System.Drawing.Size(83, 17);
            this.chkCapeTown.TabIndex = 2;
            this.chkCapeTown.Text = "Cape Town";
            this.chkCapeTown.UseVisualStyleBackColor = true;
            // 
            // chkPretoria
            // 
            this.chkPretoria.AutoSize = true;
            this.chkPretoria.Location = new System.Drawing.Point(140, 39);
            this.chkPretoria.Name = "chkPretoria";
            this.chkPretoria.Size = new System.Drawing.Size(66, 17);
            this.chkPretoria.TabIndex = 1;
            this.chkPretoria.Text = "Pretoria";
            this.chkPretoria.UseVisualStyleBackColor = true;
            // 
            // chkJoburg
            // 
            this.chkJoburg.AutoSize = true;
            this.chkJoburg.Location = new System.Drawing.Point(19, 39);
            this.chkJoburg.Name = "chkJoburg";
            this.chkJoburg.Size = new System.Drawing.Size(100, 17);
            this.chkJoburg.TabIndex = 0;
            this.chkJoburg.Text = "Johannesburg";
            this.chkJoburg.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(588, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Select the end date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(236, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Select the start date";
            // 
            // btnCaAncelMulti
            // 
            this.btnCaAncelMulti.AccessibleName = "btnCancel";
            this.btnCaAncelMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnCaAncelMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnCaAncelMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaAncelMulti.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaAncelMulti.Location = new System.Drawing.Point(557, 375);
            this.btnCaAncelMulti.Name = "btnCaAncelMulti";
            this.btnCaAncelMulti.Size = new System.Drawing.Size(100, 38);
            this.btnCaAncelMulti.TabIndex = 11;
            this.btnCaAncelMulti.Text = "Cancel";
            this.btnCaAncelMulti.UseVisualStyleBackColor = true;
            this.btnCaAncelMulti.Click += new System.EventHandler(this.btnCaAncelMulti_Click);
            // 
            // btnGenerateMulti
            // 
            this.btnGenerateMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnGenerateMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGenerateMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateMulti.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMulti.Location = new System.Drawing.Point(345, 375);
            this.btnGenerateMulti.Name = "btnGenerateMulti";
            this.btnGenerateMulti.Size = new System.Drawing.Size(99, 38);
            this.btnGenerateMulti.TabIndex = 10;
            this.btnGenerateMulti.Text = "Generate";
            this.btnGenerateMulti.UseVisualStyleBackColor = true;
            this.btnGenerateMulti.Click += new System.EventHandler(this.btnGenerateMulti_Click);
            // 
            // dtpMultiEnd
            // 
            this.dtpMultiEnd.Location = new System.Drawing.Point(582, 286);
            this.dtpMultiEnd.Name = "dtpMultiEnd";
            this.dtpMultiEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpMultiEnd.TabIndex = 9;
            // 
            // dtpMultiStart
            // 
            this.dtpMultiStart.Location = new System.Drawing.Point(223, 286);
            this.dtpMultiStart.Name = "dtpMultiStart";
            this.dtpMultiStart.Size = new System.Drawing.Size(200, 22);
            this.dtpMultiStart.TabIndex = 8;
            this.dtpMultiStart.ValueChanged += new System.EventHandler(this.dtpMultiStart_ValueChanged);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.SlateGray;
            this.pnlHome.Controls.Add(this.lblIsCelsius);
            this.pnlHome.Controls.Add(this.label16);
            this.pnlHome.Controls.Add(this.label15);
            this.pnlHome.Controls.Add(this.lblwelcomeName);
            this.pnlHome.Location = new System.Drawing.Point(22, 46);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(853, 396);
            this.pnlHome.TabIndex = 33;
            // 
            // lblIsCelsius
            // 
            this.lblIsCelsius.AutoSize = true;
            this.lblIsCelsius.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsCelsius.Location = new System.Drawing.Point(374, 356);
            this.lblIsCelsius.Name = "lblIsCelsius";
            this.lblIsCelsius.Size = new System.Drawing.Size(91, 30);
            this.lblIsCelsius.TabIndex = 3;
            this.lblIsCelsius.Text = "isCelsius";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 351);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(336, 30);
            this.label16.TabIndex = 2;
            this.label16.Text = "Current preffered unit of measure: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(81, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(714, 224);
            this.label15.TabIndex = 1;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // lblwelcomeName
            // 
            this.lblwelcomeName.AutoSize = true;
            this.lblwelcomeName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcomeName.Location = new System.Drawing.Point(82, 30);
            this.lblwelcomeName.Name = "lblwelcomeName";
            this.lblwelcomeName.Size = new System.Drawing.Size(303, 30);
            this.lblwelcomeName.TabIndex = 0;
            this.lblwelcomeName.Text = "Welcome back forecasterName";
            // 
            // ForecasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1025, 527);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlSingleCityRange);
            this.Controls.Add(this.pnlCaptureData);
            this.Controls.Add(this.pnlMultiCity);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ForecasterMenu";
            this.Text = "Forecaster Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCaptureData.ResumeLayout(false);
            this.pnlCaptureData.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnlSingleCityRange.ResumeLayout(false);
            this.pnlSingleCityRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureError)).EndInit();
            this.pnlMultiCity.ResumeLayout(false);
            this.pnlMultiCity.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureForecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateForecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteForecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleCityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiCityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTemperatureUnitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCaptureData;
        private System.Windows.Forms.TextBox txtHumid;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCity1;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtPrecip;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUvIndex;
        private System.Windows.Forms.ComboBox cboCloud;
        private System.Windows.Forms.Panel pnlSingleCityRange;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboCity2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSingeCancel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ErrorProvider captureError;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlMultiCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCaAncelMulti;
        private System.Windows.Forms.Button btnGenerateMulti;
        private System.Windows.Forms.DateTimePicker dtpMultiEnd;
        private System.Windows.Forms.DateTimePicker dtpMultiStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDurban;
        private System.Windows.Forms.CheckBox chkCapeTown;
        private System.Windows.Forms.CheckBox chkPretoria;
        private System.Windows.Forms.CheckBox chkJoburg;
        private System.Windows.Forms.CheckBox chkPolokwane;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblwelcomeName;
        private System.Windows.Forms.Label lblIsCelsius;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.RadioButton radCelsius;
    }
}