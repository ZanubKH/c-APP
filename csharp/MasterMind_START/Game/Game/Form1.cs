using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        SecretCombi mycomb = new SecretCombi();
        int terms = 0;
        int credits = 100;
        public int[] MyArray;
        public Form1()
        {
            InitializeComponent();
            MyArray = new int[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (terms < 10)
            {
                MyArray[0] = Convert.ToInt32(textBox1.Text);
                MyArray[1] = Convert.ToInt32(textBox2.Text);
                MyArray[2] = Convert.ToInt32(textBox3.Text);
                MyArray[3] = Convert.ToInt32(textBox4.Text);
                int RScore;
                int LScore;
                if (mycomb.Guess(MyArray, out RScore, out LScore,ref credits) == true)
                {
                    listBox1.Items.Add("You Won  !!!!!!  Our number was   ");
                    
                }
                else
                {
                    foreach (int p in MyArray)
                    {
                        listBox1.Items.Add("" + p + ",");
                    }
                    listBox1.Items.Add("Score1: " + RScore + " Score2: " + LScore + "ÿOUR credits "  + credits);
                }
                terms++;
            }
            else
            {
                listBox1.Items.Add(" You lost Number was ");
                foreach (int p in mycomb.Array)
                {
                    listBox1.Items.Add("" + p + "\t");
                }
            }

        }

    }
}