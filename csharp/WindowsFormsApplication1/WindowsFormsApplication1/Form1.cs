using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.panel1.BackColor = this.colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Sorry, you clicked on CANCEL");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.panel2.BackColor = this.colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Sorry, you clicked on CANCEL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionFont = new Font("Ariel", 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.rtb.SaveFile("d://FLUPKE.RTF");
        }
    }
}
