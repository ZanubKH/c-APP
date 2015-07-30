using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1StatusChecking : Form
    {
        private DataHelper dh;

      
        public Form1StatusChecking()
        {
            InitializeComponent();
            dh = new DataHelper();
            foreach (string s in dh.ListOfProduct())
            {
                comboBox1.Items.Add(s);
            }
            foreach (string s in dh.ListOfShops())
            {
                comboBox2.Items.Add(s);
            }
        }

        private void btnLoadAllStudents_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnAddAStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNrOfStudents_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               Count IS =     dh.NumberOfReservation();
               Item My = dh.Nuberofcheckinusers();
           label1.Text ="Total reservatin is  "  + IS.TRerve.ToString();
            
            label2.Text = "Number of checked in users  is " + IS.TEntree.ToString();
            
            label3.Text = "Number of checked out users  is " + IS.TOut.ToString();
          
            label4.Text = "Total bank balance transferred is " +IS.TMoney.ToString() +" euros";

            int d = My.TInvoice + dh.TotalmoneypaidbyuserLending();

            label5.Text = "Total money paid by user " + Convert.ToString(d) + " euros";

            label6.Text = "Total booked customers " + My.TCamping.ToString();

            label7.Text = "Total rent " + My.TRent.ToString() + " euros";
            label10.Text = "Total free tents " + My.TCapacity.ToString();
            

            




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Total units sold  " + dh.TotalUnitsOfProductSold(comboBox1.SelectedItem.ToString()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = " Total money " + dh.TotalMoneySoldByShops(comboBox2.SelectedItem.ToString()).ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "Total units sold  " + dh.TotalUnitsOfProductSold(comboBox1.SelectedItem.ToString()).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = " Total money " + dh.TotalMoneySoldByShops(comboBox2.SelectedItem.ToString()).ToString();
        }

 
       
    }
}