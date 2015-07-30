using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace DatabaseConnection
{
    public partial class Form1Camp : Form
    {
        private RFID myRFIDReader;
        private DataHelperCamp dh;
        public List<String> RFIDS = new List<string>();
        public int Cust;
        public int Temp=-1;
       
        public Form1Camp()
        {
            InitializeComponent();
            dh = new DataHelperCamp();

            RFIDS.Add("28007b75ef");
            RFIDS.Add("5c005e6bec");


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
        public Tent GetTent(int tentno)
        {
            foreach (Tent l in dh.fillTent() )
            {
                if (l.Tentno == tentno)
                {
                    return l;
                }
            }
            return null;

        }
     

       

       

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SayHello(object sender, TagEventArgs e)
        {
            
            string g = e.Tag.ToString();
            Cust = dh.GetCustomerId(g);
           
            if (dh.CheckIfExists(Cust) =="no host")
            {
                int i = dh.Tent(Cust);
                string s = "" + Getuser(Cust).ToString() + GetTent(i).ToString();
                MessageBox.Show(s);


            }
            if (dh.CheckIfExists(Cust) == "hosts")
            {
                listBox1.Visible = true;
                label2.Visible = true;
                //label1.Visible = true;
                List<Guests> SO = dh.GetHosts(Cust);
                foreach (Guests p in SO)
                {
                    listBox1.Items.Add(p);
                    listBox1.Items.Add(" Hoster Name " + Getuser(p.hostid).Firstname);
                }



            }
           
           if (dh.CheckIfExists(Cust) == "alchin")
                {
                    MessageBox.Show("Already check in");
                }
           if (dh.CheckIfExists(Cust) == "not")
                {
                    MessageBox.Show("error 'Not paid for ticket!!!!'");
                }
            
            //MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
            //    ".\nWelcome at our event ! ! !");

            
            
            
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

       
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag += new TagEventHandler(SayHello);
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guests g = (Guests)listBox1.SelectedItem;
            textBox2.Visible = true;
            textBox2.Text = "HOST NAME " + Getuser(g.hostid).Firstname;

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Customer = Convert.ToInt32(textBox1.Text);
            ///Cust = dh.GetCustomerId(g);

            if (dh.CheckIfExists(Customer) == "no host")
            {
                int i = dh.Tent(Customer);
                string s = "" + Getuser(Customer).ToString() + GetTent(i).ToString();
                MessageBox.Show(s);


            }
            if (dh.CheckIfExists(Customer) == "hosts")
            {
                listBox1.Visible = true;
                label2.Visible = true;
                //label1.Visible = true;
                List<Guests> SO = dh.GetHosts(Customer);
                foreach (Guests p in SO)
                {
                    listBox1.Items.Add(p);
                   
                }



            }

            if (dh.CheckIfExists(Customer) == "alchin")
            {
                MessageBox.Show("Already check in");
            }
            if (dh.CheckIfExists(Customer) == "not")
            {
                MessageBox.Show("error 'Not paid for ticket!!!!'");
            }

            //MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
            //    ".\nWelcome at our event ! ! !");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Guests g = (Guests)listBox1.SelectedItem;
            List<Guests> guests = new List<Guests>();
            foreach (Guests d in dh.GetHosts(Cust))
            {
                if (d.hostid != g.hostid) { guests.Add(d); }
            }
            dh.InserPending(guests);

            if (dh.Accout(g.hostid) > 0)
            {
                dh.UpdateConfirm(g.hostid, g.guestid);
                dh.UpdateHostAccout(g.hostid);
                string q = "" + Getuser(g.guestid) + GetTent(g.tentid);
                foreach (Guests d in dh.GetHosts(g.guestid))
                {
                    if (d.tentid != g.tentid) { dh.UpdateTents(d.tentid); }
                }

                MessageBox.Show(q);
                listBox1.Items.Clear();
                listBox1.Visible = false;
                label2.Visible = false;
                //label1.Visible = false;
            }
            else
            {
                dh.UpdateConfirm(g.hostid, g.guestid);
                dh.UpdateHostAccout(g.hostid);
                string q = "" + Getuser(g.guestid) + GetTent(g.tentid);

                foreach (Guests d in dh.GetHosts(g.guestid))
                {
                    if (d.tentid != g.tentid) { dh.UpdateTents(d.tentid); }
                }



                MessageBox.Show(q + "   You Host has not sufficient money");
            }


        }
    }
}