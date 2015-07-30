namespace TravelAgency
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
            this.btShowAllTrips = new System.Windows.Forms.Button();
            this.lbAllTrips = new System.Windows.Forms.ListBox();
            this.btBook = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCancelName = new System.Windows.Forms.TextBox();
            this.btFreeRooms = new System.Windows.Forms.Button();
            this.lbFreeRooms = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btShowAllTrips
            // 
            this.btShowAllTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowAllTrips.Location = new System.Drawing.Point(12, 268);
            this.btShowAllTrips.Name = "btShowAllTrips";
            this.btShowAllTrips.Size = new System.Drawing.Size(153, 30);
            this.btShowAllTrips.TabIndex = 0;
            this.btShowAllTrips.Text = "show all trips\r\n";
            this.btShowAllTrips.UseVisualStyleBackColor = true;
            this.btShowAllTrips.Click += new System.EventHandler(this.btShowAllTrips_Click);
            // 
            // lbAllTrips
            // 
            this.lbAllTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllTrips.FormattingEnabled = true;
            this.lbAllTrips.ItemHeight = 16;
            this.lbAllTrips.Location = new System.Drawing.Point(12, 12);
            this.lbAllTrips.Name = "lbAllTrips";
            this.lbAllTrips.Size = new System.Drawing.Size(371, 228);
            this.lbAllTrips.TabIndex = 1;
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(78, 76);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(75, 23);
            this.btBook.TabIndex = 2;
            this.btBook.Text = "BOOK";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(78, 55);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "CANCEL\r\n";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(113, 9);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(100, 20);
            this.tbDestination.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(63, 20);
            this.tbName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "destination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "name:";
            // 
            // tbCancelName
            // 
            this.tbCancelName.Location = new System.Drawing.Point(113, 14);
            this.tbCancelName.Name = "tbCancelName";
            this.tbCancelName.Size = new System.Drawing.Size(63, 20);
            this.tbCancelName.TabIndex = 11;
            // 
            // btFreeRooms
            // 
            this.btFreeRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFreeRooms.Location = new System.Drawing.Point(25, 242);
            this.btFreeRooms.Name = "btFreeRooms";
            this.btFreeRooms.Size = new System.Drawing.Size(149, 30);
            this.btFreeRooms.TabIndex = 13;
            this.btFreeRooms.Text = "show free rooms\r\n\r\n";
            this.btFreeRooms.UseVisualStyleBackColor = true;
            this.btFreeRooms.Click += new System.EventHandler(this.btFreeRooms_Click);
            // 
            // lbFreeRooms
            // 
            this.lbFreeRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFreeRooms.FormattingEnabled = true;
            this.lbFreeRooms.ItemHeight = 16;
            this.lbFreeRooms.Location = new System.Drawing.Point(12, 18);
            this.lbFreeRooms.Name = "lbFreeRooms";
            this.lbFreeRooms.Size = new System.Drawing.Size(243, 196);
            this.lbFreeRooms.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.tbDestination);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btBook);
            this.panel1.Location = new System.Drawing.Point(393, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 108);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tbCancelName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Location = new System.Drawing.Point(393, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 94);
            this.panel2.TabIndex = 11;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(393, 268);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 30);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "save all";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(526, 268);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(110, 30);
            this.btRead.TabIndex = 18;
            this.btRead.Text = "read all\r\n\r\n";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lbFreeRooms);
            this.panel3.Controls.Add(this.btFreeRooms);
            this.panel3.Location = new System.Drawing.Point(652, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 291);
            this.panel3.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 310);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAllTrips);
            this.Controls.Add(this.btShowAllTrips);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btShowAllTrips;
        private System.Windows.Forms.ListBox lbAllTrips;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCancelName;
        private System.Windows.Forms.Button btFreeRooms;
        private System.Windows.Forms.ListBox lbFreeRooms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Panel panel3;
    }
}

