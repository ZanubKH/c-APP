using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2015
{
    public partial class Form1 : Form
    {
        private List<Runner> runners;

        public Form1()
        {
            InitializeComponent();
            runners = new List<Runner>();
            Runner runner = new Runner("Bianca Williams");
           runner.NewRecords += new Runner.NewRecord(Handler1);
            runners.Add(runner);

            runner = new Runner("Dafne Schippers");
           runner.NewRecords += new Runner.NewRecord(Handler1);
            runners.Add(runner);

            runner = new Runner("Carl Lewis");
            runner.NewRecords += new Runner.NewRecord(Handler1);
            runners.Add(runner);

            runner = new Runner("Trijntje Sprinter");
           runner.NewRecords += new Runner.NewRecord(Handler1);
            runners.Add(runner);

           
            AddFakeTimes();          
        }

        public void AddFakeTimes()
        {
            runners[0].AddNewTIme(100);
            runners[0].AddNewTIme(115);
            runners[0].AddNewTIme(113);
            runners[0].AddNewTIme(122);
            runners[0].AddNewTIme(108);
            runners[0].AddNewTIme(98);
            runners[0].AddNewTIme(100);
            runners[0].AddNewTIme(108);

            runners[1].AddNewTIme(114);
            runners[1].AddNewTIme(130);
            runners[1].AddNewTIme(118);
            runners[1].AddNewTIme(112);
            runners[1].AddNewTIme(114);

            runners[2].AddNewTIme(114);

            runners[3].AddNewTIme(124);
            runners[3].AddNewTIme(97);
            runners[3].AddNewTIme(100);
            runners[3].AddNewTIme(132);
        }

        //returns runner with the given idnr (or null if idnr doesn't exist
        public Runner FindRunner(int idnr)
        {
            foreach (Runner r in runners)
                if (r.IdNr == idnr)
                    return r;
            return null;
        }

        private void btShowAllTimes_Click(object sender, EventArgs e)
        {
            lbAll.Items.Clear();
            foreach (Runner runner in runners)
                lbAll.Items.Add(runner);
        }

        private void btAddTime_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = Convert.ToInt32(tbIdNr.Text);
                Runner r = FindRunner(nr);
                int time = Convert.ToInt32(tbTime.Text);
                if (r!=null)
                      r.AddNewTIme(time);
                r.NewRecords += new Runner.NewRecord(Handler1);
                     
            }
            catch (FormatException)
            { MessageBox.Show("tbTime and tbIdNr must contain correct values"); }
        }
        private void Handler1(Runner r, int newtime)
        {
            MessageBox.Show("Time " + newtime + "is added in record of " + r.Name );
            r.FillBest5();

           
        }
        private void btAddRunner_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            { MessageBox.Show("tbName doesn't contain a correct name-value"); }
            else
            {
                string name = tbName.Text;
                Runner r = new Runner(name);
                r.NewRecords += new Runner.NewRecord(Handler1);
                runners.Add(r);                
            }
        }
      
        private void btShowBest5_Click(object sender, EventArgs e)
        {
            lbBest5.Items.Clear();
            Runner s = FindRunner(Convert.ToInt32(tbIdNr.Text));
            s.FillBest5();
            foreach (int i in s.Best5)
            {
                lbBest5.Items.Add("" + i);
            }
            

     

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            foreach (Runner r in runners)
            {
                r.FillBest5();
                if (r.SearhInBest5(Convert.ToInt32(tbTime.Text)) == true)
                {
                    lbAll.Items.Add(r.Name + "  " + Convert.ToInt32(tbTime.Text));
                }
            }
        }
        public void CompareAverages(out double best, out double secondbest, out string bestname, out string secondname)
        {
             best = 100000;
            secondbest = 10000000;
            bestname = null;
            secondname = null;
            foreach (Runner r in runners)
            {
                int sum = 0;
                foreach (int i in r.MyTimes)
                {
                    sum = sum + i;

                }
                double avg = Convert.ToDouble(sum / r.MyTimes.Count);
                if (avg < best)
                {
                    best = avg;
                    bestname = r.Name;
                }
                else
                {
                    if (avg < secondbest)
                    {
                        secondbest = avg;
                        secondname = r.Name;
                    }
                }
            }

        }

        private void btCompareAverage_Click(object sender, EventArgs e)
        {
           double best;
           double secondbest;
          string  bestname ;
          string  secondname ;
          CompareAverages(out best, out secondbest, out bestname, out secondname);
          MessageBox.Show(" best is " + best + " with name " + bestname + " second is " + secondbest + " swith name " + secondname);
        }

        private void btShowLinkedList_Click(object sender, EventArgs e)
        {
            lbBest5.Items.Clear();
            Runner s = FindRunner(Convert.ToInt32(tbIdNr.Text));
            s.FillBest5();
            s.L.ConvertBest5ToLinkedList(s.Best5);
            foreach (int i in s.L.GetAll())
            {
                lbBest5.Items.Add("" + i);
            }
            
        }

    }
}
