using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace library
{
    public partial class Form1 : Form
    {   
        //exercise 2a
        private List<Item> libList = new List<Item>();
        public Form1()
        {
            InitializeComponent();
            //exercise 2a
            libList.Add(new Book(1,"the da vinci code","Dan Brown"));
            libList.Add(new Magazine(2,"Donald duck",100));            
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            //exercise 2b
            lbItems.Items.Clear();
            foreach (Item item in libList)
            {
                if ((item is Book && cbBooks.Checked) || (item is Magazine && cbMagazines.Checked))
                    lbItems.Items.Add(item);
            }
        }

        private void btBorrow_Click(object sender, EventArgs e)
        {
            try
            {    //exercise 3a
                DateTime dt = dateTimePicker1.Value;
                int id = Convert.ToInt32(tbIdNr.Text);
                bool found = false;
                foreach (Item item in libList)
                {
                    if (item.IdNr == id)
                    {
                        found = true;
                        item.Borrow(dt);
                        if (item is Book)
                            tbTitleOrName.Text = ((Book)item).Title;
                        else tbTitleOrName.Text = ((Magazine)item).Name;
                    }
                }
                if (!found)
                    throw new Exception();
            }
            //exercise 3c
            catch (BorrowException be)
            { MessageBox.Show(be.Message); }
            catch (Exception ex)
            { MessageBox.Show("FIRST SELECT A CORRECT ITEM"); }

        }

        private void btHandIn_Click(object sender, EventArgs e)
        {   //exercise 4b
            decimal d;
            Item item = (Item)lbItems.SelectedItem;
            DateTime dt = dateTimePicker1.Value;
            d = item.CalcFine(item.BorrowDate, dt);
            item.HandIn(dt);
            tbFine.Text = Convert.ToString(d);
        }     

        private void btLoad_Click(object sender, EventArgs e)
        {
                // exercise 5
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream("catalog.txt", FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string s = sr.ReadLine();
                    while (s != "end")
                    {
                        if (s == "book")
                        {
                            int i = Convert.ToInt32(sr.ReadLine());
                            string t = sr.ReadLine();
                            string a = sr.ReadLine();
                            Book b = new Book(i, t, a);
                            libList.Add(b);
                        }
                        if (s == "magazine")
                        {
                            int i = Convert.ToInt32(sr.ReadLine());
                            string t = sr.ReadLine();
                            int a = Convert.ToInt32(sr.ReadLine());
                            Magazine b = new Magazine(i, t, a);
                            libList.Add(b);
                        }
                        s = sr.ReadLine();
                    }
                }
                catch (IOException)
                { MessageBox.Show("Error reading file"); }
                finally
                { if (sr != null) sr.Close(); }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {   //exercise 6
            List<Magazine> tempM = new List<Magazine>();
            foreach (Item item in libList)
            {
                if (item is Magazine && item.Present && (((Magazine)item).IssueNr < 25))
                {
                    tempM.Add(item as Magazine);
                }
            }

            lbItems.Items.Clear();
            foreach (Magazine mag in tempM)
            {
                lbItems.Items.Add(mag);
                libList.Remove(mag);
            }
        }       
    }
}
