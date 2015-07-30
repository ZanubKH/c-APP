namespace AirlinesWorkDivision
{
    partial class FormAirlines
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxPilots = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFlightDuration = new System.Windows.Forms.TextBox();
            this.lblAverageFlightHours = new System.Windows.Forms.Label();
            this.lbxPilotsOfAge = new System.Windows.Forms.ListBox();
            this.btnShowPilotsOfAge = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAvgHours = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUpperLimit = new System.Windows.Forms.TextBox();
            this.tbLowerLimit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIncreaseAge = new System.Windows.Forms.Button();
            this.tbPilotNumber = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbxPilots);
            this.panel4.Controls.Add(this.btnSort);
            this.panel4.Location = new System.Drawing.Point(4, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 179);
            this.panel4.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pilots:";
            // 
            // lbxPilots
            // 
            this.lbxPilots.FormattingEnabled = true;
            this.lbxPilots.Location = new System.Drawing.Point(4, 24);
            this.lbxPilots.Name = "lbxPilots";
            this.lbxPilots.Size = new System.Drawing.Size(296, 121);
            this.lbxPilots.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(69, 150);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(142, 23);
            this.btnSort.TabIndex = 17;
            this.btnSort.Text = "2. sort high -> low number";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "flight duration:";
            // 
            // tbFlightDuration
            // 
            this.tbFlightDuration.Location = new System.Drawing.Point(79, 18);
            this.tbFlightDuration.Name = "tbFlightDuration";
            this.tbFlightDuration.Size = new System.Drawing.Size(86, 20);
            this.tbFlightDuration.TabIndex = 16;
            this.tbFlightDuration.Text = "tbFlightDuration";
            // 
            // lblAverageFlightHours
            // 
            this.lblAverageFlightHours.AutoSize = true;
            this.lblAverageFlightHours.BackColor = System.Drawing.SystemColors.Info;
            this.lblAverageFlightHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageFlightHours.Location = new System.Drawing.Point(6, 60);
            this.lblAverageFlightHours.Name = "lblAverageFlightHours";
            this.lblAverageFlightHours.Size = new System.Drawing.Size(112, 15);
            this.lblAverageFlightHours.TabIndex = 19;
            this.lblAverageFlightHours.Text = "lblAverageFlightHours";
            // 
            // lbxPilotsOfAge
            // 
            this.lbxPilotsOfAge.FormattingEnabled = true;
            this.lbxPilotsOfAge.Location = new System.Drawing.Point(164, 60);
            this.lbxPilotsOfAge.Name = "lbxPilotsOfAge";
            this.lbxPilotsOfAge.Size = new System.Drawing.Size(305, 108);
            this.lbxPilotsOfAge.TabIndex = 18;
            // 
            // btnShowPilotsOfAge
            // 
            this.btnShowPilotsOfAge.Location = new System.Drawing.Point(164, 30);
            this.btnShowPilotsOfAge.Name = "btnShowPilotsOfAge";
            this.btnShowPilotsOfAge.Size = new System.Drawing.Size(84, 23);
            this.btnShowPilotsOfAge.TabIndex = 1;
            this.btnShowPilotsOfAge.Text = "5. show pilots";
            this.btnShowPilotsOfAge.UseVisualStyleBackColor = true;
            this.btnShowPilotsOfAge.Click += new System.EventHandler(this.btnShowPilotsOfAge_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Controls.Add(this.tbFlightDuration);
            this.panel1.Location = new System.Drawing.Point(318, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 90);
            this.panel1.TabIndex = 22;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(13, 49);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(136, 25);
            this.btnAddFlight.TabIndex = 9;
            this.btnAddFlight.Text = "3. add flight to pilot";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblAverageFlightHours);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAvgHours);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbxPilotsOfAge);
            this.panel3.Controls.Add(this.tbUpperLimit);
            this.panel3.Controls.Add(this.btnShowPilotsOfAge);
            this.panel3.Controls.Add(this.tbLowerLimit);
            this.panel3.Location = new System.Drawing.Point(4, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 177);
            this.panel3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "upper age:";
            // 
            // btnAvgHours
            // 
            this.btnAvgHours.Location = new System.Drawing.Point(3, 30);
            this.btnAvgHours.Name = "btnAvgHours";
            this.btnAvgHours.Size = new System.Drawing.Size(141, 23);
            this.btnAvgHours.TabIndex = 5;
            this.btnAvgHours.Text = "1. show average flight hours";
            this.btnAvgHours.UseVisualStyleBackColor = true;
            this.btnAvgHours.Click += new System.EventHandler(this.btnAvgHours_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "lower age:";
            // 
            // tbUpperLimit
            // 
            this.tbUpperLimit.Location = new System.Drawing.Point(228, 2);
            this.tbUpperLimit.Name = "tbUpperLimit";
            this.tbUpperLimit.Size = new System.Drawing.Size(80, 20);
            this.tbUpperLimit.TabIndex = 7;
            this.tbUpperLimit.Text = "tbUpperLimit";
            // 
            // tbLowerLimit
            // 
            this.tbLowerLimit.Location = new System.Drawing.Point(64, 5);
            this.tbLowerLimit.Name = "tbLowerLimit";
            this.tbLowerLimit.Size = new System.Drawing.Size(80, 20);
            this.tbLowerLimit.TabIndex = 6;
            this.tbLowerLimit.Text = "tbLowerLimit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnIncreaseAge);
            this.panel2.Controls.Add(this.tbPilotNumber);
            this.panel2.Location = new System.Drawing.Point(319, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 83);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "pilot number:";
            // 
            // btnIncreaseAge
            // 
            this.btnIncreaseAge.Location = new System.Drawing.Point(12, 41);
            this.btnIncreaseAge.Name = "btnIncreaseAge";
            this.btnIncreaseAge.Size = new System.Drawing.Size(136, 23);
            this.btnIncreaseAge.TabIndex = 10;
            this.btnIncreaseAge.Text = "4. increase age";
            this.btnIncreaseAge.UseVisualStyleBackColor = true;
            this.btnIncreaseAge.Click += new System.EventHandler(this.btnIncreaseAge_Click);
            // 
            // tbPilotNumber
            // 
            this.tbPilotNumber.Location = new System.Drawing.Point(75, 11);
            this.tbPilotNumber.Name = "tbPilotNumber";
            this.tbPilotNumber.Size = new System.Drawing.Size(73, 20);
            this.tbPilotNumber.TabIndex = 11;
            this.tbPilotNumber.Text = "tbPilotNumber";
            // 
            // FormAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 386);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormAirlines";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxPilots;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFlightDuration;
        private System.Windows.Forms.Label lblAverageFlightHours;
        private System.Windows.Forms.ListBox lbxPilotsOfAge;
        private System.Windows.Forms.Button btnShowPilotsOfAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAvgHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUpperLimit;
        private System.Windows.Forms.TextBox tbLowerLimit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIncreaseAge;
        private System.Windows.Forms.TextBox tbPilotNumber;

    }
}

