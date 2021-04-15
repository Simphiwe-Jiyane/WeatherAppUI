namespace WeatherAppUI
{
    partial class tempChange
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
            this.btnApply = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(126, 121);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 29);
            this.btnApply.TabIndex = 83;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.radFahrenheit);
            this.panel12.Controls.Add(this.radCelsius);
            this.panel12.Location = new System.Drawing.Point(41, 42);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(303, 44);
            this.panel12.TabIndex = 82;
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
            // tempChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 195);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel12);
            this.Name = "tempChange";
            this.Text = "tempChange";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.RadioButton radCelsius;
    }
}