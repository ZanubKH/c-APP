using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //because we are using files
namespace PCS23_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextFileHelper textfile = new TextFileHelper("../../myTest.txt");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<string> temp = new List<string>();

            temp.Add(richTextBox1.Text);
        

            textfile.SaveToString(temp);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string s in textfile.LoadFromFile())
            {
                listBox1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.AppendText(fdlg.FileName);
                textfile.FileName = fdlg.FileName;
            }

        }
    }
}
