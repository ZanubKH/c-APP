namespace DatabaseConnection
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
            this.btnAddAStudent = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnNrOfStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.btnLoadAllStudents = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbNrOfCredits = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAStudent
            // 
            this.btnAddAStudent.Location = new System.Drawing.Point(27, 76);
            this.btnAddAStudent.Name = "btnAddAStudent";
            this.btnAddAStudent.Size = new System.Drawing.Size(223, 42);
            this.btnAddAStudent.TabIndex = 3;
            this.btnAddAStudent.Text = "Add a student";
            this.btnAddAStudent.UseVisualStyleBackColor = true;
            this.btnAddAStudent.Click += new System.EventHandler(this.btnAddAStudent_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(85, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(91, 26);
            this.tbName.TabIndex = 4;
            // 
            // btnNrOfStudents
            // 
            this.btnNrOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNrOfStudents.Location = new System.Drawing.Point(25, 381);
            this.btnNrOfStudents.Name = "btnNrOfStudents";
            this.btnNrOfStudents.Size = new System.Drawing.Size(134, 35);
            this.btnNrOfStudents.TabIndex = 5;
            this.btnNrOfStudents.Text = "Nr of students";
            this.btnNrOfStudents.UseVisualStyleBackColor = true;
            this.btnNrOfStudents.Click += new System.EventHandler(this.btnNrOfStudents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // listbox1
            // 
            this.listbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 20;
            this.listbox1.Location = new System.Drawing.Point(148, 14);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(336, 184);
            this.listbox1.TabIndex = 7;
            // 
            // btnLoadAllStudents
            // 
            this.btnLoadAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAllStudents.Location = new System.Drawing.Point(19, 12);
            this.btnLoadAllStudents.Name = "btnLoadAllStudents";
            this.btnLoadAllStudents.Size = new System.Drawing.Size(105, 186);
            this.btnLoadAllStudents.TabIndex = 8;
            this.btnLoadAllStudents.Text = "Load all students";
            this.btnLoadAllStudents.UseVisualStyleBackColor = true;
            this.btnLoadAllStudents.Click += new System.EventHandler(this.btnLoadAllStudents_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(6, 32);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(59, 26);
            this.tbNumber.TabIndex = 9;
            // 
            // tbNrOfCredits
            // 
            this.tbNrOfCredits.Location = new System.Drawing.Point(182, 32);
            this.tbNrOfCredits.Name = "tbNrOfCredits";
            this.tbNrOfCredits.Size = new System.Drawing.Size(68, 26);
            this.tbNrOfCredits.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.tbNrOfCredits);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.btnAddAStudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadAllStudents);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNrOfStudents);
            this.Name = "Form1";
            this.Text = "Example How to access a database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAStudent;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnNrOfStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button btnLoadAllStudents;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbNrOfCredits;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

