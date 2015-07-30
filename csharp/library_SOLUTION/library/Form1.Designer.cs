namespace library
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btBorrow = new System.Windows.Forms.Button();
            this.cbBooks = new System.Windows.Forms.CheckBox();
            this.cbMagazines = new System.Windows.Forms.CheckBox();
            this.btHandIn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitleOrName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbFine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdNr = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(14, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(542, 173);
            this.lbItems.TabIndex = 0;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(705, 219);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 32);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "LOAD";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(24, 14);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 32);
            this.btShow.TabIndex = 2;
            this.btShow.Text = "SHOW";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btBorrow
            // 
            this.btBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrow.Location = new System.Drawing.Point(122, 57);
            this.btBorrow.Name = "btBorrow";
            this.btBorrow.Size = new System.Drawing.Size(97, 32);
            this.btBorrow.TabIndex = 3;
            this.btBorrow.Text = "BORROW";
            this.btBorrow.UseVisualStyleBackColor = true;
            this.btBorrow.Click += new System.EventHandler(this.btBorrow_Click);
            // 
            // cbBooks
            // 
            this.cbBooks.AutoSize = true;
            this.cbBooks.Checked = true;
            this.cbBooks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBooks.Location = new System.Drawing.Point(55, 52);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(80, 28);
            this.cbBooks.TabIndex = 4;
            this.cbBooks.Text = "books";
            this.cbBooks.UseVisualStyleBackColor = true;
            // 
            // cbMagazines
            // 
            this.cbMagazines.AutoSize = true;
            this.cbMagazines.Checked = true;
            this.cbMagazines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMagazines.Location = new System.Drawing.Point(55, 76);
            this.cbMagazines.Name = "cbMagazines";
            this.cbMagazines.Size = new System.Drawing.Size(120, 28);
            this.cbMagazines.TabIndex = 5;
            this.cbMagazines.Text = "magazines";
            this.cbMagazines.UseVisualStyleBackColor = true;
            // 
            // btHandIn
            // 
            this.btHandIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHandIn.Location = new System.Drawing.Point(69, 14);
            this.btHandIn.Name = "btHandIn";
            this.btHandIn.Size = new System.Drawing.Size(97, 32);
            this.btHandIn.TabIndex = 6;
            this.btHandIn.Text = "HAND IN";
            this.btHandIn.UseVisualStyleBackColor = true;
            this.btHandIn.Click += new System.EventHandler(this.btHandIn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title/Name borrowed:";
            // 
            // tbTitleOrName
            // 
            this.tbTitleOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleOrName.Location = new System.Drawing.Point(18, 121);
            this.tbTitleOrName.Name = "tbTitleOrName";
            this.tbTitleOrName.Size = new System.Drawing.Size(327, 26);
            this.tbTitleOrName.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btShow);
            this.panel1.Controls.Add(this.cbBooks);
            this.panel1.Controls.Add(this.cbMagazines);
            this.panel1.Location = new System.Drawing.Point(577, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 132);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(12, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 219);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select a date:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.tbFine);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btHandIn);
            this.panel4.Location = new System.Drawing.Point(392, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 107);
            this.panel4.TabIndex = 13;
            // 
            // tbFine
            // 
            this.tbFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFine.Location = new System.Drawing.Point(113, 63);
            this.tbFine.Name = "tbFine";
            this.tbFine.Size = new System.Drawing.Size(92, 26);
            this.tbFine.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fine to pay:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btBorrow);
            this.panel3.Controls.Add(this.tbTitleOrName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbIdNr);
            this.panel3.Location = new System.Drawing.Point(10, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 158);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select an id nr:";
            // 
            // tbIdNr
            // 
            this.tbIdNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdNr.Location = new System.Drawing.Point(155, 14);
            this.tbIdNr.Name = "tbIdNr";
            this.tbIdNr.Size = new System.Drawing.Size(100, 26);
            this.tbIdNr.TabIndex = 11;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(690, 278);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(117, 49);
            this.btRefresh.TabIndex = 14;
            this.btRefresh.Text = "REFRESH COLLECTION";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(819, 418);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btBorrow;
        private System.Windows.Forms.CheckBox cbBooks;
        private System.Windows.Forms.CheckBox cbMagazines;
        private System.Windows.Forms.Button btHandIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitleOrName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdNr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbFine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRefresh;
    }
}

