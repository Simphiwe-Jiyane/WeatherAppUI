namespace WeatherAppUI
{
    partial class UpdateDelete
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
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOldMax = new System.Windows.Forms.Label();
            this.lblOldUv = new System.Windows.Forms.Label();
            this.lblOldCloud = new System.Windows.Forms.Label();
            this.lblOldWind = new System.Windows.Forms.Label();
            this.lblOldPrecip = new System.Windows.Forms.Label();
            this.lblOldHumd = new System.Windows.Forms.Label();
            this.lblOldMin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboUvIndex = new System.Windows.Forms.ComboBox();
            this.cboCloud = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
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
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.captureError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.dtpDeleteDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cboDeleteCity = new System.Windows.Forms.ComboBox();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnCapture);
            this.pnlUpdate.Controls.Add(this.btnCancel);
            this.pnlUpdate.Controls.Add(this.lblOldMax);
            this.pnlUpdate.Controls.Add(this.lblOldUv);
            this.pnlUpdate.Controls.Add(this.lblOldCloud);
            this.pnlUpdate.Controls.Add(this.lblOldWind);
            this.pnlUpdate.Controls.Add(this.lblOldPrecip);
            this.pnlUpdate.Controls.Add(this.lblOldHumd);
            this.pnlUpdate.Controls.Add(this.lblOldMin);
            this.pnlUpdate.Controls.Add(this.label11);
            this.pnlUpdate.Controls.Add(this.label10);
            this.pnlUpdate.Controls.Add(this.cboUvIndex);
            this.pnlUpdate.Controls.Add(this.cboCloud);
            this.pnlUpdate.Controls.Add(this.dtpDate);
            this.pnlUpdate.Controls.Add(this.label9);
            this.pnlUpdate.Controls.Add(this.label8);
            this.pnlUpdate.Controls.Add(this.label7);
            this.pnlUpdate.Controls.Add(this.label6);
            this.pnlUpdate.Controls.Add(this.label5);
            this.pnlUpdate.Controls.Add(this.label4);
            this.pnlUpdate.Controls.Add(this.label3);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Controls.Add(this.txtWind);
            this.pnlUpdate.Controls.Add(this.txtPrecip);
            this.pnlUpdate.Controls.Add(this.txtHumid);
            this.pnlUpdate.Controls.Add(this.txtMin);
            this.pnlUpdate.Controls.Add(this.txtMax);
            this.pnlUpdate.Controls.Add(this.label1);
            this.pnlUpdate.Controls.Add(this.cboCity);
            this.pnlUpdate.Location = new System.Drawing.Point(36, 32);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(905, 458);
            this.pnlUpdate.TabIndex = 0;
            // 
            // btnCapture
            // 
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Location = new System.Drawing.Point(369, 421);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(77, 25);
            this.btnCapture.TabIndex = 59;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(476, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOldMax
            // 
            this.lblOldMax.AutoSize = true;
            this.lblOldMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldMax.Location = new System.Drawing.Point(709, 121);
            this.lblOldMax.Name = "lblOldMax";
            this.lblOldMax.Size = new System.Drawing.Size(33, 21);
            this.lblOldMax.TabIndex = 57;
            this.lblOldMax.Text = "n/a";
            // 
            // lblOldUv
            // 
            this.lblOldUv.AutoSize = true;
            this.lblOldUv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldUv.Location = new System.Drawing.Point(709, 378);
            this.lblOldUv.Name = "lblOldUv";
            this.lblOldUv.Size = new System.Drawing.Size(33, 21);
            this.lblOldUv.TabIndex = 56;
            this.lblOldUv.Text = "n/a";
            // 
            // lblOldCloud
            // 
            this.lblOldCloud.AutoSize = true;
            this.lblOldCloud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldCloud.Location = new System.Drawing.Point(709, 333);
            this.lblOldCloud.Name = "lblOldCloud";
            this.lblOldCloud.Size = new System.Drawing.Size(33, 21);
            this.lblOldCloud.TabIndex = 55;
            this.lblOldCloud.Text = "n/a";
            // 
            // lblOldWind
            // 
            this.lblOldWind.AutoSize = true;
            this.lblOldWind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldWind.Location = new System.Drawing.Point(709, 286);
            this.lblOldWind.Name = "lblOldWind";
            this.lblOldWind.Size = new System.Drawing.Size(33, 21);
            this.lblOldWind.TabIndex = 54;
            this.lblOldWind.Text = "n/a";
            // 
            // lblOldPrecip
            // 
            this.lblOldPrecip.AutoSize = true;
            this.lblOldPrecip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPrecip.Location = new System.Drawing.Point(709, 244);
            this.lblOldPrecip.Name = "lblOldPrecip";
            this.lblOldPrecip.Size = new System.Drawing.Size(33, 21);
            this.lblOldPrecip.TabIndex = 53;
            this.lblOldPrecip.Text = "n/a";
            // 
            // lblOldHumd
            // 
            this.lblOldHumd.AutoSize = true;
            this.lblOldHumd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldHumd.Location = new System.Drawing.Point(709, 205);
            this.lblOldHumd.Name = "lblOldHumd";
            this.lblOldHumd.Size = new System.Drawing.Size(33, 21);
            this.lblOldHumd.TabIndex = 52;
            this.lblOldHumd.Text = "n/a";
            // 
            // lblOldMin
            // 
            this.lblOldMin.AutoSize = true;
            this.lblOldMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldMin.Location = new System.Drawing.Point(709, 160);
            this.lblOldMin.Name = "lblOldMin";
            this.lblOldMin.Size = new System.Drawing.Size(33, 21);
            this.lblOldMin.TabIndex = 51;
            this.lblOldMin.Text = "n/a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 21);
            this.label11.TabIndex = 50;
            this.label11.Text = "Enter new values here:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 21);
            this.label10.TabIndex = 49;
            this.label10.Text = "Current value:";
            // 
            // cboUvIndex
            // 
            this.cboUvIndex.FormattingEnabled = true;
            this.cboUvIndex.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboUvIndex.Location = new System.Drawing.Point(461, 378);
            this.cboUvIndex.Name = "cboUvIndex";
            this.cboUvIndex.Size = new System.Drawing.Size(163, 21);
            this.cboUvIndex.TabIndex = 48;
            // 
            // cboCloud
            // 
            this.cboCloud.FormattingEnabled = true;
            this.cboCloud.Items.AddRange(new object[] {
            "Sunny",
            "Partly Cloudy",
            "Full Cloud Cover",
            "Thunder Showers"});
            this.cboCloud.Location = new System.Drawing.Point(461, 334);
            this.cboCloud.Name = "cboCloud";
            this.cboCloud.Size = new System.Drawing.Size(163, 21);
            this.cboCloud.TabIndex = 47;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(463, 51);
            this.dtpDate.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(269, 25);
            this.dtpDate.TabIndex = 46;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 30);
            this.label9.TabIndex = 45;
            this.label9.Text = "Select the cloud cover:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 30);
            this.label8.TabIndex = 44;
            this.label8.Text = "Enter the maximum temperature:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Enter the minimum temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 30);
            this.label6.TabIndex = 42;
            this.label6.Text = "Enter the humidity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Enter the precipitation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Enter the windspeed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Select the UV Index:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select the date:";
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(461, 287);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(163, 20);
            this.txtWind.TabIndex = 37;
            // 
            // txtPrecip
            // 
            this.txtPrecip.Location = new System.Drawing.Point(461, 243);
            this.txtPrecip.Name = "txtPrecip";
            this.txtPrecip.Size = new System.Drawing.Size(163, 20);
            this.txtPrecip.TabIndex = 36;
            // 
            // txtHumid
            // 
            this.txtHumid.Location = new System.Drawing.Point(461, 200);
            this.txtHumid.Name = "txtHumid";
            this.txtHumid.Size = new System.Drawing.Size(163, 20);
            this.txtHumid.TabIndex = 35;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(461, 158);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(163, 20);
            this.txtMin.TabIndex = 34;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(461, 118);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(163, 20);
            this.txtMax.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select a city to update:";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(463, 8);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(269, 21);
            this.cboCity.TabIndex = 31;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // captureError
            // 
            this.captureError.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Controls.Add(this.btnCancelDelete);
            this.pnlDelete.Controls.Add(this.dtpDeleteDate);
            this.pnlDelete.Controls.Add(this.label28);
            this.pnlDelete.Controls.Add(this.label29);
            this.pnlDelete.Controls.Add(this.cboDeleteCity);
            this.pnlDelete.Location = new System.Drawing.Point(48, 12);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(905, 458);
            this.pnlDelete.TabIndex = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(362, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 25);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDelete.Location = new System.Drawing.Point(485, 323);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(77, 25);
            this.btnCancelDelete.TabIndex = 58;
            this.btnCancelDelete.Text = "Cancel";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            this.btnCancelDelete.Click += new System.EventHandler(this.btnCancelDelete_Click);
            // 
            // dtpDeleteDate
            // 
            this.dtpDeleteDate.Enabled = false;
            this.dtpDeleteDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeleteDate.Location = new System.Drawing.Point(461, 189);
            this.dtpDeleteDate.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dtpDeleteDate.Name = "dtpDeleteDate";
            this.dtpDeleteDate.Size = new System.Drawing.Size(269, 25);
            this.dtpDeleteDate.TabIndex = 46;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(111, 182);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(156, 30);
            this.label28.TabIndex = 38;
            this.label28.Text = "Select the date:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(111, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(216, 30);
            this.label29.TabIndex = 32;
            this.label29.Text = "Select a city to delete:";
            // 
            // cboDeleteCity
            // 
            this.cboDeleteCity.FormattingEnabled = true;
            this.cboDeleteCity.Location = new System.Drawing.Point(461, 123);
            this.cboDeleteCity.Name = "cboDeleteCity";
            this.cboDeleteCity.Size = new System.Drawing.Size(269, 21);
            this.cboDeleteCity.TabIndex = 31;
            this.cboDeleteCity.SelectedIndexChanged += new System.EventHandler(this.cboDeleteCity_SelectedIndexChanged);
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(996, 502);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlUpdate);
            this.Name = "UpdateDelete";
            this.Text = "UpdateDelete";
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblOldMax;
        private System.Windows.Forms.Label lblOldUv;
        private System.Windows.Forms.Label lblOldCloud;
        private System.Windows.Forms.Label lblOldWind;
        private System.Windows.Forms.Label lblOldPrecip;
        private System.Windows.Forms.Label lblOldHumd;
        private System.Windows.Forms.Label lblOldMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUvIndex;
        private System.Windows.Forms.ComboBox cboCloud;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtPrecip;
        private System.Windows.Forms.TextBox txtHumid;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ErrorProvider captureError;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.DateTimePicker dtpDeleteDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboDeleteCity;
    }
}