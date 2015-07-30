namespace exam2015
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
            this.btShowAllTimes = new System.Windows.Forms.Button();
            this.tbIdNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btShowBest5 = new System.Windows.Forms.Button();
            this.lbBest5 = new System.Windows.Forms.ListBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btAddTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btCompareAverage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btShowLinkedList = new System.Windows.Forms.Button();
            this.btCheckNames = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btAddRunner = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btShowAllTimes
            // 
            this.btShowAllTimes.BackColor = System.Drawing.Color.Lime;
            this.btShowAllTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowAllTimes.Location = new System.Drawing.Point(29, 16);
            this.btShowAllTimes.Name = "btShowAllTimes";
            this.btShowAllTimes.Size = new System.Drawing.Size(194, 43);
            this.btShowAllTimes.TabIndex = 1;
            this.btShowAllTimes.Text = "SHOW ALL TIMES OF ALL RUNNERS";
            this.btShowAllTimes.UseVisualStyleBackColor = false;
            this.btShowAllTimes.Click += new System.EventHandler(this.btShowAllTimes_Click);
            // 
            // tbIdNr
            // 
            this.tbIdNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdNr.Location = new System.Drawing.Point(70, 20);
            this.tbIdNr.Name = "tbIdNr";
            this.tbIdNr.Size = new System.Drawing.Size(78, 20);
            this.tbIdNr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID NR:";
            // 
            // btShowBest5
            // 
            this.btShowBest5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btShowBest5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowBest5.Location = new System.Drawing.Point(19, 19);
            this.btShowBest5.Name = "btShowBest5";
            this.btShowBest5.Size = new System.Drawing.Size(125, 58);
            this.btShowBest5.TabIndex = 4;
            this.btShowBest5.Text = "1. SHOW  BEST5 \r\n";
            this.btShowBest5.UseVisualStyleBackColor = false;
            this.btShowBest5.Click += new System.EventHandler(this.btShowBest5_Click);
            // 
            // lbBest5
            // 
            this.lbBest5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBest5.FormattingEnabled = true;
            this.lbBest5.ItemHeight = 16;
            this.lbBest5.Location = new System.Drawing.Point(161, 19);
            this.lbBest5.Name = "lbBest5";
            this.lbBest5.Size = new System.Drawing.Size(79, 116);
            this.lbBest5.TabIndex = 5;
            // 
            // tbTime
            // 
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTime.Location = new System.Drawing.Point(69, 56);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(79, 20);
            this.tbTime.TabIndex = 7;
            // 
            // btAddTime
            // 
            this.btAddTime.BackColor = System.Drawing.Color.Lime;
            this.btAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddTime.Location = new System.Drawing.Point(29, 72);
            this.btAddTime.Name = "btAddTime";
            this.btAddTime.Size = new System.Drawing.Size(194, 43);
            this.btAddTime.TabIndex = 9;
            this.btAddTime.Text = "ADD NEW TIME TO ONE LIST";
            this.btAddTime.UseVisualStyleBackColor = false;
            this.btAddTime.Click += new System.EventHandler(this.btAddTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TIME:";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(544, 22);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(169, 43);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "   2: SEARCH IN BEST5";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btCompareAverage
            // 
            this.btCompareAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCompareAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompareAverage.Location = new System.Drawing.Point(544, 81);
            this.btCompareAverage.Name = "btCompareAverage";
            this.btCompareAverage.Size = new System.Drawing.Size(169, 43);
            this.btCompareAverage.TabIndex = 13;
            this.btCompareAverage.Text = "   4: COMPARE AVERAGES";
            this.btCompareAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCompareAverage.UseVisualStyleBackColor = false;
            this.btCompareAverage.Click += new System.EventHandler(this.btCompareAverage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btShowBest5);
            this.panel1.Controls.Add(this.btShowLinkedList);
            this.panel1.Controls.Add(this.lbBest5);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 150);
            this.panel1.TabIndex = 14;
            // 
            // btShowLinkedList
            // 
            this.btShowLinkedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btShowLinkedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowLinkedList.Location = new System.Drawing.Point(19, 83);
            this.btShowLinkedList.Name = "btShowLinkedList";
            this.btShowLinkedList.Size = new System.Drawing.Size(125, 56);
            this.btShowLinkedList.TabIndex = 6;
            this.btShowLinkedList.Text = "5: SHOW LINKED LIST\r\n";
            this.btShowLinkedList.UseVisualStyleBackColor = false;
            this.btShowLinkedList.Click += new System.EventHandler(this.btShowLinkedList_Click);
            // 
            // btCheckNames
            // 
            this.btCheckNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCheckNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckNames.Location = new System.Drawing.Point(732, 36);
            this.btCheckNames.Name = "btCheckNames";
            this.btCheckNames.Size = new System.Drawing.Size(79, 79);
            this.btCheckNames.TabIndex = 21;
            this.btCheckNames.Text = "       6: \r\n   CHECK\r\n   NAMES";
            this.btCheckNames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckNames.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btAddRunner);
            this.panel5.Controls.Add(this.btAddTime);
            this.panel5.Controls.Add(this.btShowAllTimes);
            this.panel5.Location = new System.Drawing.Point(542, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 196);
            this.panel5.TabIndex = 22;
            // 
            // btAddRunner
            // 
            this.btAddRunner.BackColor = System.Drawing.Color.Lime;
            this.btAddRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRunner.Location = new System.Drawing.Point(29, 127);
            this.btAddRunner.Name = "btAddRunner";
            this.btAddRunner.Size = new System.Drawing.Size(194, 46);
            this.btAddRunner.TabIndex = 16;
            this.btAddRunner.Text = "ADD NEW RUNNER\r\n";
            this.btAddRunner.UseVisualStyleBackColor = false;
            this.btAddRunner.Click += new System.EventHandler(this.btAddRunner_Click);
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(26, 114);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 20);
            this.tbName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NAME:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.tbIdNr);
            this.panel6.Controls.Add(this.tbName);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.tbTime);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(305, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 148);
            this.panel6.TabIndex = 12;
            // 
            // lbAll
            // 
            this.lbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAll.FormattingEnabled = true;
            this.lbAll.HorizontalScrollbar = true;
            this.lbAll.ItemHeight = 16;
            this.lbAll.Location = new System.Drawing.Point(12, 12);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(514, 164);
            this.lbAll.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 390);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.btCheckNames);
            this.Controls.Add(this.btCompareAverage);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShowAllTimes;
        private System.Windows.Forms.TextBox tbIdNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowBest5;
        private System.Windows.Forms.ListBox lbBest5;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btAddTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btCompareAverage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btShowLinkedList;
        private System.Windows.Forms.Button btCheckNames;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btAddRunner;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lbAll;
    }
}

