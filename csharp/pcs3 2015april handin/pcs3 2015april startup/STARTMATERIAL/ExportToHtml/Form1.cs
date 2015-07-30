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

namespace ExportToHtml
{
    public partial class Form1 : Form
    {
        private WebPart myWebPart;
        Item item;
        Helper help = new Helper();
        public Form1()
        {
            InitializeComponent();
            myWebPart = new WebPart("Pinkpop 2015, latest news");

        //    PutSomeTestingStuffInTheWebPart();
        }

        //private void PutSomeTestingStuffInTheWebPart()
        //{
        //    SingleLineItem sli;
        //    MultiLineItem mli;

        //    sli = new SingleLineItem(9, "Will Miley Cyrus be on Pinkpop?", "Most probably she will perform at Pinkpop.", "Carla", "24-2-2015");
        //    myWebPart.AddItem(sli);

        //    mli = new MultiLineItem(4, "About the line-up: Pharrell: yes ; Katy: still doubting.", "Vince", "3-3-2015");
        //    mli.AddLine("I'm happy: Pharrell Williams will be the top act on Friday. Come and see him. It's all about the hat.");
        //    mli.AddLine("Miley Cyrus canceled since she did not pay attention when the wrecking ball chain broke.");
        //    mli.AddLine("We are still negotiating with Katy Perry. We still believe she will be one of the top acts this year.");
        //    myWebPart.AddItem(mli);

        //    sli = new SingleLineItem(22, "Katy Perry, still no decision.", "Sorry folks, not 100% sure Katy will roar for you at Pinkpop!", "Arthur", "13-3-2015");
        //    myWebPart.AddItem(sli);

        //    sli = new SingleLineItem(27, "Finally Katy sais YES, she will come to Pinkpop.", "Good news: today we contracted Katy Perry. Are you ready? She promissed to enter the stage riding a dark horse!", "Carla", "28-3-2015");
        //    myWebPart.AddItem(sli);
        //}

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(myWebPart.Title);
            foreach (Item s in myWebPart.GetAllItem())
            {
                foreach (string st in s.ToHtml())
                {
                    listBox1.Items.Add(st);
                }
            }
        }

        private void btnAddAnItem_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tbId.Text);
            string ti = tbTitle.Text;
            string by = tbPostedBy.Text;
            string da = tbDateOfPost.Text;
            if (rbSingleLineItem.Checked)
            {
                string tex = tbLineOfText.Text;
                item = new SingleLineItem(i, ti, by, da, tex);
                if (myWebPart.AddItem(item) == true)
                {
                    MessageBox.Show("One Single is ADDED");
                }
                else
                { MessageBox.Show("No"); }
           }
            if (rbMultiLineItem.Checked)
            {
                item = new MultiLineItem(i, ti,by, da);
                if (myWebPart.AddItem(item) == true)
                {
                    MessageBox.Show("One multi is ADDED");
                }
                else
                { MessageBox.Show("No"); }
            }
        }

        private void btnAddALineToAMultilineItem_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tbId.Text);
            string s = tbLineOfText.Text;
            foreach (Item im in myWebPart.GetAllItem())
            {
                if (im.Idnr == i)
                {
                    if (im is MultiLineItem)
                    {
                        MultiLineItem m = (MultiLineItem)im;
                        m.AddLine(s);
                        MessageBox.Show("Added ");
                    }
                }
                
            }
            MessageBox.Show("Not Exists");
           

        }

        private void btnShowAllSinglelineItems_Click(object sender, EventArgs e)
        {
            foreach (Item it in myWebPart.GetAllSingleItem())
            {
                foreach (string st in it.ToHtml())
                {
                    listBox1.Items.Add(st);
                }
            }
        }


        private void btnExportToHtml_Click(object sender, EventArgs e)
        {
           
            
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                //richTextBox1.AppendText(fdlg.FileName);
                help.FileName = fdlg.FileName;
                help.SaveToString(myWebPart.GetAllItem());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
