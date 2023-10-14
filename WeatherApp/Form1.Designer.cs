namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(354, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labCondition.Location = new System.Drawing.Point(53, 339);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(121, 28);
            this.labCondition.TabIndex = 1;
            this.labCondition.Text = "Condition";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDetails.Location = new System.Drawing.Point(406, 339);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(90, 28);
            this.labDetails.TabIndex = 2;
            this.labDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labSunrise.Location = new System.Drawing.Point(179, 412);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(55, 28);
            this.labSunrise.TabIndex = 4;
            this.labSunrise.Text = "N/A";
            this.labSunrise.Click += new System.EventHandler(this.label5_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Inter Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TBCity.Location = new System.Drawing.Point(424, 157);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(233, 35);
            this.TBCity.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(663, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labSunset.Location = new System.Drawing.Point(179, 452);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(55, 28);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPressure.Location = new System.Drawing.Point(594, 452);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(55, 28);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(406, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labWindSpeed.Location = new System.Drawing.Point(594, 412);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(55, 28);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Inter SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(406, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(30, 225);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(165, 111);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 548);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

