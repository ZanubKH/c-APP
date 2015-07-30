using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidgets;
using Phidgets.Events;

namespace DatabaseConnection
{
    

    public partial class Form1CheckingIn : Form
    {

        private RFID myRFIDReader;
      
        private DataHelperCheckingIn dh;
        private DataHelperCamp dhCamp;
        public List<String> RFIDS = new List<string>();
       
        public int Temp = -1;

        public Form1CheckingIn()
        {
            InitializeComponent();
            dh = new DataHelperCheckingIn();
            dhCamp = new DataHelperCamp();
            RFIDS.Add("28007b75ef");

            try
            {
                myRFIDReader = new RFID();


            }
            catch (PhidgetException) { MessageBox.Show("error at start-up."); }
        
            
        }
        public Login Getuser(int id)
        {

            foreach (Login l in dh.filllog())
            {
                if (l.Customerid == id)
                {
                    return l;
                }
            }
            return null;


        }
        public string value;
        public void CheckWithRfid(object sender, TagEventArgs e)
        {
            
        value = e.Tag.ToString();

        MessageBox.Show("ONE RFID is assigned");
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dh.CheckIfExists(Convert.ToInt32(textBox1.Text)) == true)
            {
                if (dh.CheckRfid(value) != false)
                {
                    if (dh.CheckIfExistsInChecking(Convert.ToInt32(textBox1.Text)) == "Not exists")
                    {
                        if (dh.InserCheckin(Convert.ToInt32(textBox1.Text), value) > 0)
                        {   //int i = dh.Tent(Temp);
                            string s = " WelCome to our Event !!!!!!!  " + Getuser(Convert.ToInt32(textBox1.Text)).ToString();
                            button1.Text = "Check In";
                            MessageBox.Show(s);
                        }
                    }
                    
                }
                else
                {
                    if (dh.CheckIfExistsInChecking(Convert.ToInt32(textBox1.Text)) == "ALready checked in")
                    {
                        if (dh.CheckLending(Convert.ToInt32(textBox1.Text)) == true && dh.Accout(Convert.ToInt32(textBox1.Text)) == 1)
                        {
                            if (dh.UpdateCheckOut(Convert.ToInt32(textBox1.Text)) == 1)
                            {
                                MessageBox.Show("Checked out");
                                button1.Text = "Check In";
                            }
                        }
                        else
                        {
                            if (dh.CheckLending(Convert.ToInt32(textBox1.Text)) == false)
                            {
                                MessageBox.Show("Return first our stuff");
                            }
                            else
                            {
                                if (dh.Accout(Convert.ToInt32(textBox1.Text)) < 0)
                                {
                                    MessageBox.Show("Pay the Loan");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dh.UpdateCheckin(Convert.ToInt32(textBox1.Text)) > 0)
                        { MessageBox.Show("Checked In"); button1.Text = "Check OUT"; }
                        else
                        { MessageBox.Show("Sorry !!! You are using wrong ID"); }
                    }
                   
                }


            }
            else
                MessageBox.Show("Please press button 2 to get loan");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag += new TagEventHandler(CheckWithRfid);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dh.InserLoan(Convert.ToInt32(textBox1.Text)) > 0 && dh.InserConfirm(Convert.ToInt32(textBox1.Text)) > 0)
            {
                MessageBox.Show("loan has been retrieves");
            }
            else { MessageBox.Show("error"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dh.UpdateAccout(Convert.ToInt32(textBox1.Text)) > 0)
            {
                MessageBox.Show("Your Money has been sent successfully");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dh.CheckIfExists(Convert.ToInt32(textBox2.Text)) == true)
            {

                if (dh.CheckIfExistsInChecking(Convert.ToInt32(textBox2.Text)) == "Not exists")
                {
                    if (dh.InserCheckin1(Convert.ToInt32(textBox2.Text)) > 0)
                    {   //int i = dh.Tent(Temp);
                        string s = " WelCome to our Event !!!!!!!  " + Getuser(Convert.ToInt32(textBox2.Text)).ToString();
                        button1.Text = "Check In";
                        MessageBox.Show(s);
                    }
                }


                else
                {
                    if (dh.CheckIfExistsInChecking(Convert.ToInt32(textBox2.Text)) == "ALready checked in")
                    {
                        if (dh.CheckLending(Convert.ToInt32(textBox2.Text)) == true && dh.Accout(Convert.ToInt32(textBox2.Text)) == 1)
                        {
                            if (dh.UpdateCheckOut(Convert.ToInt32(textBox2.Text)) == 1)
                            {
                                MessageBox.Show("Checked out");
                                button1.Text = "Check In";
                            }
                        }
                        else
                        {
                            if (dh.CheckLending(Convert.ToInt32(textBox2.Text)) == false)
                            {
                                MessageBox.Show("Return first our stuff");
                            }
                            else
                            {
                                if (dh.Accout(Convert.ToInt32(textBox2.Text)) < 0)
                                {
                                    MessageBox.Show("Pay the Loan");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dh.UpdateCheckin(Convert.ToInt32(textBox2.Text)) > 0)
                        { MessageBox.Show("Checked In"); button1.Text = "Check OUT"; }
                        else
                        { MessageBox.Show("Sorry !!! You are using wrong ID"); }
                    }

                }


            }
            else
                MessageBox.Show("Please press button 2 to get loan");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dh.InserLoan(Convert.ToInt32(textBox2.Text)) > 0 && dh.InserConfirm(Convert.ToInt32(textBox2.Text)) > 0)
            {
                MessageBox.Show("loan has been retrieves");
            }
            else { MessageBox.Show("error"); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dh.UpdateAccout(Convert.ToInt32(textBox2.Text)) > 0)
            {
                MessageBox.Show("Your Money has been sent successfully");
            }
        }
    }
}
