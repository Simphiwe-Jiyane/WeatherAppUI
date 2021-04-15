namespace WeatherAppUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCloudCover = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBoxStormy = new System.Windows.Forms.PictureBox();
            this.pBoxCloudy = new System.Windows.Forms.PictureBox();
            this.pBoxSunny = new System.Windows.Forms.PictureBox();
            this.pBoxPartlyCloudy = new System.Windows.Forms.PictureBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnGoToForcasts = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStormy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPartlyCloudy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(731, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "View next city";
            // 
            // lblCloudCover
            // 
            this.lblCloudCover.AutoSize = true;
            this.lblCloudCover.BackColor = System.Drawing.Color.Transparent;
            this.lblCloudCover.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloudCover.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCloudCover.Location = new System.Drawing.Point(675, 148);
            this.lblCloudCover.Name = "lblCloudCover";
            this.lblCloudCover.Size = new System.Drawing.Size(111, 25);
            this.lblCloudCover.TabIndex = 40;
            this.lblCloudCover.Text = "cloud cover";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pBoxStormy);
            this.panel3.Controls.Add(this.pBoxCloudy);
            this.panel3.Controls.Add(this.pBoxSunny);
            this.panel3.Controls.Add(this.pBoxPartlyCloudy);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(577, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 100);
            this.panel3.TabIndex = 39;
            // 
            // pBoxStormy
            // 
            this.pBoxStormy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxStormy.Image = global::WeatherAppUI.Properties.Resources.Stormy_new;
            this.pBoxStormy.Location = new System.Drawing.Point(0, 0);
            this.pBoxStormy.Name = "pBoxStormy";
            this.pBoxStormy.Size = new System.Drawing.Size(92, 100);
            this.pBoxStormy.TabIndex = 3;
            this.pBoxStormy.TabStop = false;
            // 
            // pBoxCloudy
            // 
            this.pBoxCloudy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxCloudy.Image = global::WeatherAppUI.Properties.Resources.Partly_cloudy_new;
            this.pBoxCloudy.Location = new System.Drawing.Point(0, 0);
            this.pBoxCloudy.Name = "pBoxCloudy";
            this.pBoxCloudy.Size = new System.Drawing.Size(92, 100);
            this.pBoxCloudy.TabIndex = 2;
            this.pBoxCloudy.TabStop = false;
            // 
            // pBoxSunny
            // 
            this.pBoxSunny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxSunny.Image = global::WeatherAppUI.Properties.Resources.shapes_and_symbols;
            this.pBoxSunny.Location = new System.Drawing.Point(0, 0);
            this.pBoxSunny.Name = "pBoxSunny";
            this.pBoxSunny.Size = new System.Drawing.Size(92, 100);
            this.pBoxSunny.TabIndex = 1;
            this.pBoxSunny.TabStop = false;
            // 
            // pBoxPartlyCloudy
            // 
            this.pBoxPartlyCloudy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxPartlyCloudy.Image = global::WeatherAppUI.Properties.Resources.sky;
            this.pBoxPartlyCloudy.Location = new System.Drawing.Point(0, 0);
            this.pBoxPartlyCloudy.Name = "pBoxPartlyCloudy";
            this.pBoxPartlyCloudy.Size = new System.Drawing.Size(92, 100);
            this.pBoxPartlyCloudy.TabIndex = 0;
            this.pBoxPartlyCloudy.TabStop = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHumidity.Location = new System.Drawing.Point(845, 271);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(39, 47);
            this.lblHumidity.TabIndex = 38;
            this.lblHumidity.Text = "0";
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecip.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecip.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecip.Location = new System.Drawing.Point(620, 271);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(39, 47);
            this.lblPrecip.TabIndex = 36;
            this.lblPrecip.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(751, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Humidity:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMin.Location = new System.Drawing.Point(375, 271);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(39, 47);
            this.lblMin.TabIndex = 35;
            this.lblMin.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMax.Location = new System.Drawing.Point(126, 271);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(39, 47);
            this.lblMax.TabIndex = 34;
            this.lblMax.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(488, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precipitation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(259, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Min Temp:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(589, 53);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 25);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(589, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Max Temp:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCity.Location = new System.Drawing.Point(27, 53);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(327, 37);
            this.lblCity.TabIndex = 28;
            this.lblCity.Text = "Weather in city right now";
            // 
            // btnGoToForcasts
            // 
            this.btnGoToForcasts.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToForcasts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToForcasts.BackgroundImage")));
            this.btnGoToForcasts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoToForcasts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnGoToForcasts.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGoToForcasts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGoToForcasts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGoToForcasts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToForcasts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToForcasts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoToForcasts.Location = new System.Drawing.Point(840, 396);
            this.btnGoToForcasts.Name = "btnGoToForcasts";
            this.btnGoToForcasts.Size = new System.Drawing.Size(70, 27);
            this.btnGoToForcasts.TabIndex = 41;
            this.btnGoToForcasts.UseVisualStyleBackColor = false;
            this.btnGoToForcasts.Click += new System.EventHandler(this.btnGoToForcasts_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoToForcasts);
            this.Controls.Add(this.lblCloudCover);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPrecip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCity);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStormy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPartlyCloudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCloudCover;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pBoxStormy;
        private System.Windows.Forms.PictureBox pBoxCloudy;
        private System.Windows.Forms.PictureBox pBoxSunny;
        private System.Windows.Forms.PictureBox pBoxPartlyCloudy;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnGoToForcasts;
    }
}