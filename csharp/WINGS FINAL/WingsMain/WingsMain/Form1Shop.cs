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
    public partial class Form1Shop : Form
    {
        private DataHelperShop dh;
        private RFID myRFIDReader;
        List<Invoice> invoice;

        public Form1Shop()
        {
            InitializeComponent();
            dh = new DataHelperShop();
            dh.fillProducts();
            try
            {
                myRFIDReader = new RFID();


            }
            catch (PhidgetException) { MessageBox.Show("error at start-up."); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            label5.Visible = false;
            Items.Items.Clear();
            foreach (Product d in dh.Chocklates)
            {
                Items.Items.Add(d);
            }
          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            label5.Visible = false;
            Items.Items.Clear();
            foreach (Product d in dh.Fish)
            {
                Items.Items.Add(d);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        public bool find(int id)
        {
            foreach (int i in dh.filllog())
            {
                if (i == id)
                    return true;
            }
            return false;
        }
        private void button7_Click(object sender, EventArgs e)
        {

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
            numericUpDown1.Visible = true;
            label5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == null) { MessageBox.Show("Scan your Rfid or Enter your Customer Id "); }
                else
                {
                    double sum = 0;


                    foreach (Invoice s in invoice)
                    {
                        sum = sum + s.totalprice();
                    }
                    textBox3.Text = sum.ToString();

                    if (dh.SearchMoney(Convert.ToInt32(textBox1.Text)) >= sum)
                    {
                        dh.Inserproduct(invoice, Convert.ToInt32(textBox1.Text), "S1");
                        dh.UpdateAccount(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox3.Text));

                        dh.InserInvoice(Convert.ToInt32(textBox1.Text), Convert.ToInt32(sum));
                        int I = dh.GetOrderNumber(Convert.ToInt32(textBox1.Text));
                        Selected_Items.Items.Add("Total Bill " +sum );

                        Selected_Items.Items.Add("*********YOUR ORDER NUMBER " + I + "*******************");

                       
                        MessageBox.Show("Thanks for your shopping  " + " Your Order number is " + I+ "Your Bill is " + sum);
                        Selected_Items.Items.Clear();
                        textBox3.Clear();

                    }
                    else { MessageBox.Show("You don't have sufficent money"); }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error"); }
        }
        public void CheckWithRfid(object sender, TagEventArgs e)
        {

            string value = e.Tag.ToString();
            int CUST = dh.GetCustomerId(value);
            textBox1.Text = CUST.ToString();
            if (find(Convert.ToInt32(textBox1.Text)) == true)
            {
                invoice = new List<Invoice>();
                textBox2.Text = "" + dh.SearchMoney(Convert.ToInt32(textBox1.Text));
            }

          



        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Product p = (Product)Items.SelectedItem;
            int qun = Convert.ToInt32(numericUpDown1.Value);

            Invoice IN = new Invoice(p, qun);
            invoice.Add(IN);
            Selected_Items.Items.Add(IN);
            //button5.Visible = true;
            button6.Visible = true;
            button8.Visible = false;
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Invoice s = (Invoice)(Selected_Items.SelectedItem);
            foreach (Invoice i in invoice)
            {
                if (i == s)
                {
                    if (i.Quantity == 1)
                    {
                        Selected_Items.Items.Remove(Selected_Items.SelectedItem);
                    }
                    else
                    { i.Quantity = i.Quantity - 1; }
                }

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            Items.Items.Clear();
            Selected_Items.Items.Clear();
            button8.Visible = false;
            
            //button5.Visible = false;
            button6.Visible = false;
           
        }

        private void button11_Click(object sender, EventArgs e)
        {


            int CUST = 0;
           
            if (find(Convert.ToInt32(textBox1.Text)) == true)
            {
                invoice = new List<Invoice>();
                textBox2.Text = "" + dh.SearchMoney(Convert.ToInt32(textBox1.Text));
                 CUST = Convert.ToInt32(textBox1.Text);
            }
        }
    }
}
