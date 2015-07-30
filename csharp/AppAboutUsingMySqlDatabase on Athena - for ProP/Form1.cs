using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        private DataHelper dh;
        

        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        private void btnLoadAllStudents_Click(object sender, EventArgs e)
        {
            List<Student> studentList;
            studentList = dh.GetAllStudents();

            listbox1.Items.Clear();
            foreach (Student student in studentList)
            {
                listbox1.Items.Add(student.getInfo());
            }
        }

        private void btnAddAStudent_Click(object sender, EventArgs e)
        {
            int number;
            String name;
            int cr;

            if (tbName.Text != "" && tbNumber.Text != "" && tbNrOfCredits.Text != "")
            {
                number = Convert.ToInt32(tbNumber.Text);
                name = tbName.Text;
                cr = Convert.ToInt32(tbNrOfCredits.Text);
                int nrAdded = dh.AddAStudent(number, name, cr);
                if (nrAdded>0)
                {
                    MessageBox.Show("Succesfully added to the database");
                }
                else
                {
                    MessageBox.Show("Error while adding a student to the database");
                }
            }
        }

        private void btnNrOfStudents_Click(object sender, EventArgs e)
        {
            int n = dh.NumberOfStudents();
            label1.Text = "Number of students is "+ Convert.ToString( n );
        }

 
       
    }
}