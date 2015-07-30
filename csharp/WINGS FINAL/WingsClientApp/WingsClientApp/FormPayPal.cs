using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingsClientApp
{
    public partial class FormPayPal : Form
    {
        private DataHelperPaypal dh;

        public FormPayPal()
        {
            InitializeComponent();
            dh = new DataHelperPaypal("ss");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = (fdlg.FileName);
                dh.Filename = fdlg.FileName;
            }
            foreach (string s in dh.GetAllStudents())
            {
                listBox1.Items.Add(s);
            }
         
        }

        private void btnAddAStudent_Click(object sender, EventArgs e)
        {
            int nrAdded = dh.AddAStudent();
            if (nrAdded > 0)
            {
                MessageBox.Show("Succesfully added to the database");
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
