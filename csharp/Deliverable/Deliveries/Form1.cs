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
namespace Deliveries
{
    public partial class Form1 : Form
    {
        List<Person> Persons = new List<Person>();
        List<Deliverable> Deliverables = new List<Deliverable>();
        List<Deliverable> DeliverableToShow = new List<Deliverable>();

        public Form1()
        {
            InitializeComponent();
        }
        public delegate int CompareDeliverables(Deliverable d,Deliverable s);
        public CompareDeliverables stringChange;
        public void SortBy(CompareDeliverables s1)
        {
            stringChange += s1;
            for (int i = 0; i < Deliverables.Count; i++)
            {
                int indexOfSmallest=i;
                for (int j = i + 1; j < Deliverables.Count; j++)
                {

                    int index = stringChange(Deliverables[indexOfSmallest], Deliverables[j]);
                    if (index > 0)
                    {


                        indexOfSmallest = j;
                    }
                }

                   Swap(indexOfSmallest,i);
                
            }

        }
        public int ComparePostMan(Deliverable s, Deliverable d)
        {
            if (s.Buyer.Street.CompareTo(d.Buyer.Street) == 1)
            {
                return 1;
            }
            if (s.Buyer.Street.CompareTo(d.Buyer.Street) == -1)
            {
                return -1;
            }
            if (d.Buyer.Street.CompareTo(s.Buyer.Street) == 0)
            {
                return 0;
            }
            return 0;
  
        }
        public int CompareAddress(Deliverable s, Deliverable d)
        {
            if (s.Buyer.Name.CompareTo(d.Buyer.Name) == 1)
            {
                return 1;
            }
            if (s.Buyer.Name.CompareTo(d.Buyer.Name) == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
           

        }

        private void LoadPersons()
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream("persons.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s = sr.ReadLine();
                while (s != null)
                {
                    if (s != "**********")
                    {
                        string name = s;
                        string street = sr.ReadLine();
                        int hounu = Convert.ToInt32(sr.ReadLine());
                        string city = sr.ReadLine();
                        string postcode = sr.ReadLine();
                        
                        Person p = new Person(name, postcode, city, hounu, street);
                        Persons.Add(p);

                        s = sr.ReadLine();

                    }
                    else { s = sr.ReadLine(); }
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) sr.Close(); }
        }
        private Person find(int index)
        {
            Person newper = null;
            foreach (Person p in Persons)
            {
                if (Persons.IndexOf(p) == index)
                {
                    newper = p;
                }
            

            }
            return newper;
           
        }
        private void LoadDeliverables()
        {
 
            string [] words;
             FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream("deliverables.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s = sr.ReadLine();
                while (s != null)
                {
                    words = s.Split(' ');
                    int index = Convert.ToInt32(words[2]);
                   Person newper= find(index);
                    

                    Deliverable d = new Deliverable(Convert.ToInt32(words[0]), Convert.ToInt32(words[1]), newper);
                    Deliverables.Add(d);
                    s = sr.ReadLine();
                }

            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
                finally
                { if (sr != null) sr.Close(); }


        }
        private void LoadDeliverablesImmediately()
        {

            string[] words;
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream("deliverables.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s = sr.ReadLine();
                while (s != null)
                {
                    words = s.Split(' ');
                    int index = Convert.ToInt32(words[2]);
                    Person newper = find(index);


                    Deliverable d = new Deliverable(Convert.ToInt32(words[0]), Convert.ToInt32(words[1]), newper);
                    int indexOfSmallest = Deliverables.Count;
                    if (Deliverables.Count != 0)
                    {

                        for (int j = Deliverables.Count; j < 0; j--)
                        {
                            if (Deliverables[j].Weight > d.Weight)
                            {
                                indexOfSmallest = j;
                            }
                        }
                        Deliverables.Insert(indexOfSmallest, d);
                    }

                    else
                    { Deliverables.Add(d); }
                    s = sr.ReadLine();
                }

            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) sr.Close(); }


        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadPersons();
            LoadDeliverables();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
            
        }
        private int IndexOfTheSmallestOfTheRest(int firstIndexOfRest)
        {
            int indexOfSmallest = firstIndexOfRest;

            for (int j = firstIndexOfRest + 1; j <Deliverables.Count; j++)
            {
                if (Deliverables[j].Weight < Deliverables[indexOfSmallest].Weight)
                {
                    indexOfSmallest = j;
                }
            }
            return indexOfSmallest;
        }
        private int SmallestNameIndex(int firstIndexOfRest)
        {
            int indexOfSmallest = firstIndexOfRest;

            for (int j = firstIndexOfRest + 1; j < Deliverables.Count; j++)
            {
                string s = (Deliverables[j].Buyer.Name);
                string m = Deliverables[indexOfSmallest].Buyer.Name;
                if (m.CompareTo(s)==1)
                {
                    indexOfSmallest = j;
                }
            }
            
            return indexOfSmallest;
        }
        private int SmallestPostIndex(int firstIndexOfRest)
        {
            int indexOfSmallest = firstIndexOfRest;
            

            for (int j = firstIndexOfRest + 1; j < Deliverables.Count; j++)
            {
                string s = (Deliverables[j].Buyer.Street);
                string m = Deliverables[indexOfSmallest].Buyer.Street;
                if (m.CompareTo(s) == 1)
                {
                    indexOfSmallest = j;
                }
                if (m.CompareTo(s)==0)
                {
                    
                       
                            if (((Deliverables[j].Buyer.HouseNumber % 2 == 0) && (Deliverables[indexOfSmallest].Buyer.HouseNumber % 2 == 0)))
                            {
                                if (Deliverables[indexOfSmallest].Buyer.HouseNumber.CompareTo(Deliverables[j].Buyer.HouseNumber) == 1)
                                {
                                    indexOfSmallest = j;
                                }
                            }
                            if (((Deliverables[j].Buyer.HouseNumber % 2 != 0) && (Deliverables[indexOfSmallest].Buyer.HouseNumber % 2 != 0)))
                            {
                                if (Deliverables[j].Buyer.HouseNumber.CompareTo(Deliverables[indexOfSmallest].Buyer.HouseNumber) == 1)
                                {
                                    indexOfSmallest = j;
                                }
                            }
                            if (((Deliverables[j].Buyer.HouseNumber % 2 != 0) && (Deliverables[indexOfSmallest].Buyer.HouseNumber % 2== 0)))
                            {
                               
                                    indexOfSmallest = indexOfSmallest;
                                
                            }
                            if (((Deliverables[j].Buyer.HouseNumber % 2 == 0) && (Deliverables[indexOfSmallest].Buyer.HouseNumber % 2 != 0)))
                            {

                                indexOfSmallest = j;

                            }

                        
                    
                }
            }
            
            return indexOfSmallest;
        }

        
        private void Swap(int i, int j)
        {
            Deliverable temp = Deliverables[i];
            Deliverables[i] = Deliverables[j];
            Deliverables[j] = temp;
            
           
                                  
        }
            

        private void btSortByWaight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <Deliverables.Count; i++)
            {
                //find where is the smallest number of the rest
                int index = IndexOfTheSmallestOfTheRest(i);

                //swap it with the first of the rest
                Swap(index, i);
            }
            listBox1.Items.Clear();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Deliverables.Count; i++)
            {
                //find where is the smallest number of the rest
                int index = SmallestNameIndex(i);

                //swap it with the first of the rest
                Swap(index, i);
            }
            listBox1.Items.Clear();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Deliverables.Count; i++)
            //{
            //    //find where is the smallest number of the rest
            //    int index = SmallestPostIndex(i);

            //    //swap it with the first of the rest
            //    Swap(index, i);
            //}
            SortBy(new CompareDeliverables(ComparePostMan));
            listBox1.Items.Clear();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
        }

        private void btSortById_Click(object sender, EventArgs e)
        {

        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Deliverables.Count; i++)
            //{
            //    //find where is the smallest number of the rest
            //    int index = SmallestNameIndex(i);

            //    //swap it with the first of the rest
            //    Swap(index, i);
            //}
            SortBy(new CompareDeliverables(CompareAddress));
            listBox1.Items.Clear();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            LoadPersons();
            LoadDeliverablesImmediately();
            foreach (Deliverable D in Deliverables)
            {
                listBox1.Items.Add(D);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeliverableToShow.Clear();
            listBox2.Items.Clear();
            List<Deliverable> Toshow = Deliverable.SearchPerson(Deliverables, DeliverableToShow, textBox1.Text, 0, Deliverables.Count);
            if (Toshow != null)
            {
                foreach (Deliverable d in Toshow)
                {
                    listBox2.Items.Add("" + d.ToString());
                }
            }
            else 
            {
                MessageBox.Show("Not Found");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
