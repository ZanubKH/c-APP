using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Vehicle myCar;
        //private Truck myTruck;
        //private ETruck et;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            myCar = new Vehicle(this.textBox1.Text, Convert.ToInt32(this.textBox2.Text));
        }


        private void btnCreateTruck_Click(object sender, EventArgs e)
        {
            myCar = new Truck(this.textBox1.Text,
                Convert.ToInt32(this.textBox2.Text),
                Convert.ToInt32(this.textBox3.Text)
                );           
        }

        private void btnCreateETruck_Click(object sender, EventArgs e)
        {
            myCar = new ETruck(this.textBox1.Text,
                Convert.ToInt32(this.textBox2.Text),
                Convert.ToInt32(this.textBox3.Text),
               77
                );
        }

        private void btnCreateBus_Click(object sender, EventArgs e)
        {
            myCar = new Bus(this.textBox1.Text,
                           Convert.ToInt32(this.textBox2.Text),
                           Convert.ToInt32(this.textBox3.Text)
                           );
        }
        
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            this.label1.Text = myCar.AsAString();
        }



    }
}
