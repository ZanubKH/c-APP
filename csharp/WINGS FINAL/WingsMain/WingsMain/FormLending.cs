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
    public partial class FormLending : Form
    {
        private DataHelperLend dh;
        public List<Article> Computers;
        public List<Article> Chargers;
        public List<Article> USBS;

        public FormLending()
        {
            InitializeComponent();
            dh = new DataHelperLend();
            Computers = new List<Article>();
            Chargers = new List<Article>();
            USBS = new List<Article>();
            dh.fillArticles();
            foreach (Article a in dh.Products)
            {
                if (a.Name == "computer")
                { Computers.Add(a); }
                if (a.Name == "charger")
                { Chargers.Add(a); }
                if (a.Name == "usb")
                { USBS.Add(a); }
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {


         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        private void button9_Click(object sender, EventArgs e)
        {


            // int id = Convert.ToInt32(textBox1.Text);
            // if (find(id) == true)
            // textBox2.Text = ""+dh.SearchMoney(id);

        }
        public void CheckWithRfid(object sender, TagEventArgs e)
        {

            string value = e.Tag.ToString();
            int CUST = dh.GetCustomerId(value);
            textBox1.Text = CUST.ToString();
            if (find(Convert.ToInt32(textBox1.Text)) == true)
            {

                textBox2.Text = "" + dh.SearchMoney(Convert.ToInt32(textBox1.Text));
            }




        }
        public bool CheckListBox(Article a)
        {
            foreach (Article s in Borrowed_Items.Items)
            {
                if (s == a)
                { return false; }
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (dh.GetLended(Convert.ToInt32(textBox1.Text)).Count != 0)
            {
                foreach (Article A in dh.GetLended(Convert.ToInt32(textBox1.Text)))
                {
                    if (CheckListBox(A) == true)
                    { Borrowed_Items.Items.Add(A); }
                }
            }
            else { MessageBox.Show("Nothing has been borrowed yet"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            // button1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dh.fillArticles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void UpdateArticle(int art)
        {
            foreach (Article l in Computers)
            {
                if (l.Article_id == art)
                {
                    if (l.Exist == 1)
                    {
                        l.Exist = 0;
                    }
                    else
                        l.Exist = 1;
                }
            }
            foreach (Article l in Chargers)
            {
                if (l.Article_id == art)
                {
                    if (l.Exist == 1)
                    {
                        l.Exist = 0;
                    }
                    else
                        l.Exist = 1;
                }
            }
            foreach (Article l in USBS)
            {
                if (l.Article_id == art)
                {
                    if (l.Exist == 1)
                    {
                        l.Exist = 0;
                    }
                    else
                        l.Exist = 1;
                }
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

         
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void Items_To_Be_Borrowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Article SE = (Article)Items_To_Be_Borrowed.SelectedItem;
            try
            {
                if (textBox1.Text == null) { MessageBox.Show("Scan your Rfid "); }
                else
                {
                    if (dh.SearchArticle(SE.Article_id) == true)
                    {
                        if (dh.SearchMoney(Convert.ToInt32(textBox1.Text)) > SE.Price)
                        {
                            UpdateArticle(SE.Article_id);
                            dh.UpdateAccount(Convert.ToInt32(textBox1.Text), SE.Price);
                            dh.UpdateArticleLend(SE.Article_id);
                            dh.InserCustomer(Convert.ToInt32(textBox1.Text), SE.Article_id, SE.Price);
                            Items_To_Be_Borrowed.Items.Remove(Items_To_Be_Borrowed.SelectedItem);

                            MessageBox.Show("you borrowed " + SE.ToString());

                        }
                        else
                        { MessageBox.Show("You don't have sufficient money to borrow this item"); }
                    }
                    else
                    { MessageBox.Show("Product is not available"); }

                }

            }
            catch (Exception ex)
            { MessageBox.Show("Scan Your ID first"); }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ///dh.fillArticles();
            Items_To_Be_Borrowed.Items.Clear();
            // dh.fillArticles();
            if (Chargers.Count != 0)
            {
                foreach (Article a in Chargers)
                {
                    if (a.Exist == 0)


                    { Items_To_Be_Borrowed.Items.Add(a); }
                }
            }
            else
            {
                Items_To_Be_Borrowed.Items.Add("No Charger is available");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Items_To_Be_Borrowed.Items.Clear();
            //dh.fillArticles();
            if (Computers.Count != 0)
            {
                foreach (Article a in Computers)
                {
                    if (a.Exist == 0)


                    { Items_To_Be_Borrowed.Items.Add(a); }
                }
            }
            else
            {
                Items_To_Be_Borrowed.Items.Add("No laptop is available yet");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dh.GetLended(Convert.ToInt32(textBox1.Text)).Count != 0)
            {
                foreach (Article A in dh.GetLended(Convert.ToInt32(textBox1.Text)))
                {
                    if (CheckListBox(A) == true)
                    { Borrowed_Items.Items.Add(A); }
                }
            }
            else { MessageBox.Show("Nothing has been borrowed yet"); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Article SE = (Article)Borrowed_Items.SelectedItem;
            if (dh.SearchArticle(SE.Article_id) == false)
            {
                UpdateArticle(SE.Article_id);
                dh.UpdateArticleReturn(SE.Article_id);
                dh.UpdateCustomer(Convert.ToInt32(textBox1.Text), SE.Article_id);
                Borrowed_Items.Items.Remove(Borrowed_Items.SelectedItem);
                MessageBox.Show("you return " + SE.ToString());
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            Items_To_Be_Borrowed.Items.Clear();
            Borrowed_Items.Items.Clear();
            button5.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int CUST = 0;

            if (find(Convert.ToInt32(textBox1.Text)) == true)
            {
               
                textBox2.Text = "" + dh.SearchMoney(Convert.ToInt32(textBox1.Text));
                CUST = Convert.ToInt32(textBox1.Text);
            }
        }

    }
}
