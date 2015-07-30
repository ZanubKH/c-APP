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
    public partial class Form1 : Form
    {
        FormStatus F1;
        FormPayPal F2;
        public Form1()
        {
            InitializeComponent();
            F1 = new FormStatus();
            F2 = new FormPayPal();
        }
        public int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ++number;
            switch (number)
            {
                case 1:
                    button1.Text = "Click To Close";
                   
                    F1.Show();

                    break;
                case 2:
                    button1.Text = "Checking Status";
                    F1.Visible = false;
                   
                    number = 0;
                    break;
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ++number;
            switch (number)
            {
                case 1:
                    button2.Text = "Click To Close";

                    F2.Show();

                    break;
                case 2:
                    button2.Text = "PayPal APP";
                    F2.Visible = false;

                    number = 0;
                    break;
            }
           
        }
    }
}
