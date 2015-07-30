using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        Form1Camp FC;
        Form1CheckingIn FCH;
        Form1Shop FSH;
        FormLending FL;
        public Form1()
        {
            InitializeComponent();
             FC = new Form1Camp();
             FCH = new Form1CheckingIn();
             FSH = new Form1Shop();
             FL = new FormLending();
             try
             {
                 myRFIDReader = new RFID();


             }
             catch (PhidgetException) { MessageBox.Show("error at start-up."); }
             try
             {
                 myRFIDReader.open();
                 myRFIDReader.waitForAttachment(3000);
                 MessageBox.Show("an RFID-reader is found and opened.");
                 myRFIDReader.Antenna = true;
                 myRFIDReader.LED = true;
             }
             catch (PhidgetException) { MessageBox.Show("no RFID-reader opened."); }
        
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ++number;
            switch (number)
            {
                case 1:
                    button1.Text = "Click To Close";
                    this.myRFIDReader.Tag += new TagEventHandler(FC.SayHello);
                    FC.Show();

                    break;
                case 2:
                    button1.Text = "Camping";
                    FC.Visible = false;
                    this.myRFIDReader.Tag -= new TagEventHandler(FC.SayHello);
                    number = 0;
                    break;
            }
           
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.myRFIDReader.Tag += new TagEventHandler(SayHello);
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++number;
            switch (number)
            {
                case 1:
                    button2.Text = "Click To Close";
                    this.myRFIDReader.Tag += new TagEventHandler(FCH.CheckWithRfid);
                    FCH.Show();

                    break;
                case 2:
                    button2.Text = "Checking In";
                    FCH.Visible = false;
                    this.myRFIDReader.Tag -= new TagEventHandler(FCH.CheckWithRfid);
                    number = 0;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ++number;
            switch (number)
            {
                case 1:
                    button4.Text = "Click To Close";
                    this.myRFIDReader.Tag += new TagEventHandler(FL.CheckWithRfid);
                    FL.Show();

                    break;
                case 2:
                    button4.Text = "Lending";
                    FL.Visible = false;
                    this.myRFIDReader.Tag -= new TagEventHandler(FL.CheckWithRfid);
                    number = 0;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ++number;
            switch (number)
            {
                case 1:
                    button3.Text = "Click To Close";
                    this.myRFIDReader.Tag += new TagEventHandler(FSH.CheckWithRfid);
                    FSH.Show();

                    break;
                case 2:
                    button3.Text = "Shop";
                    FSH.Visible = false;
                    this.myRFIDReader.Tag -= new TagEventHandler(FSH.CheckWithRfid);
                    number = 0;
                    break;
            }
        }
    }
}
