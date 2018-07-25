namespace TemperatureConverter
{
    partial class Form1
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
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.btnCONVERT = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.txtCELSIUS = new System.Windows.Forms.TextBox();
            this.txtFAHRENHEIT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(175, 30);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(521, 45);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Temperature Convereter";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(191, 115);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(105, 36);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(536, 115);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(149, 36);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // btnCONVERT
            // 
            this.btnCONVERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONVERT.Location = new System.Drawing.Point(183, 291);
            this.btnCONVERT.Name = "btnCONVERT";
            this.btnCONVERT.Size = new System.Drawing.Size(137, 35);
            this.btnCONVERT.TabIndex = 1;
            this.btnCONVERT.Text = "CONVERT";
            this.btnCONVERT.UseVisualStyleBackColor = true;
            this.btnCONVERT.Click += new System.EventHandler(this.btnCONVERT_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(400, 291);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(118, 35);
            this.btnCLEAR.TabIndex = 1;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(591, 291);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(92, 35);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCELSIUS
            // 
            this.txtCELSIUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCELSIUS.ForeColor = System.Drawing.Color.Red;
            this.txtCELSIUS.Location = new System.Drawing.Point(197, 175);
            this.txtCELSIUS.Name = "txtCELSIUS";
            this.txtCELSIUS.Size = new System.Drawing.Size(100, 38);
            this.txtCELSIUS.TabIndex = 2;
            this.txtCELSIUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFAHRENHEIT
            // 
            this.txtFAHRENHEIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFAHRENHEIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFAHRENHEIT.Location = new System.Drawing.Point(546, 175);
            this.txtFAHRENHEIT.Name = "txtFAHRENHEIT";
            this.txtFAHRENHEIT.Size = new System.Drawing.Size(100, 38);
            this.txtFAHRENHEIT.TabIndex = 2;
            this.txtFAHRENHEIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFAHRENHEIT);
            this.Controls.Add(this.txtCELSIUS);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnCONVERT);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Button btnCONVERT;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox txtCELSIUS;
        private System.Windows.Forms.TextBox txtFAHRENHEIT;
    }
}

