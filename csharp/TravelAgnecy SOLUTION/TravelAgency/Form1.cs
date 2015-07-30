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
using System.Runtime.Serialization.Formatters.Binary;

namespace TravelAgency
{
    public partial class Form1 : Form
    {    
        //exercise 1 b
        private List<SimpleTrip> trips = new List<SimpleTrip>();

        public Form1()
        {
            InitializeComponent();
            //exercise 1 b
            trips.Add(new BusTrip("Paris",100, 10));
            trips.Add(new SimpleTrip("Kos",200));
            trips.Add(new MultiDayTrip("Riga",1000, 10,5));
            trips.Add(new SimpleTrip("Tokio",1200.50M));
            trips.Add(new BusTrip("Rome",500.50M,20));
            trips.Add(new MultiDayTrip("Oslo", 1000, 4, 10));               
        }
        
        //exercise 1 c
        private void btShowAllTrips_Click(object sender, EventArgs e)
        {
             lbAllTrips.Items.Clear();
             foreach (SimpleTrip t in trips)
             {
                lbAllTrips.Items.Add(t);
             } 
        }

        //exercise 2
        private void btBook_Click(object sender, EventArgs e)
        {
            bool b = false;
            string dest = tbDestination.Text;
            foreach (SimpleTrip t in trips)
            {
                if (t.Destination == dest)
                { b = t.Book(tbName.Text); }
            }
            if (!b)
                MessageBox.Show("not possible");
        }
   
        //exercise 3
        private void btFreeRooms_Click(object sender, EventArgs e)
        {
            foreach (SimpleTrip t in trips)
            {
                if (t is MultiDayTrip)
                {
                    MultiDayTrip m = (MultiDayTrip)t;
                    if (((MultiDayTrip)t).NrFreeRooms > 0)
                        lbFreeRooms.Items.Add("to " + m.Destination + " still " + m.NrFreeRooms + " rooms free");
                }
            }
        }
      
        //exercise 4
        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleTrip t;
                t = (SimpleTrip)lbAllTrips.SelectedItem;     
            //   OR:  
            //    int i = lbAllTrips.SelectedIndex;
            //    t = trips[i];
           

                string s = tbCancelName.Text;
                if (t is BusTrip)
                {
                    ((BusTrip)t).Cancel(s);
                }
                else
                    throw new Exception("not a bustrip");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
      
        //exercise 5
        private void btSave_Click(object sender, EventArgs e)
        {
            FileStream fse = null, fsf = null;
            BinaryFormatter bf;
            try
            {
                fse = new FileStream("UnBookedTrips.bin", FileMode.Create, FileAccess.Write);
                fsf = new FileStream("BookedTrips.bin", FileMode.Create, FileAccess.Write);

                bf = new BinaryFormatter();
                foreach (SimpleTrip t in trips)
                {
                    if (t.Travelers.Count == 0)
                        bf.Serialize(fse, t);
                    else
                        bf.Serialize(fsf, t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fse.Close();
                fsf.Close();
            }
        }

       
        //for testing
        private void btRead_Click(object sender, EventArgs e)
        {
            FileStream fse = null;
            BinaryFormatter bf;
            try
            {
                fse = new FileStream("UnBookedTrips.bin", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                while (fse.Position < fse.Length)
                {
                    SimpleTrip t;
                    t = (SimpleTrip)bf.Deserialize(fse);
                    trips.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//"Agnecy file probelms");
            }
            finally
            {
                fse.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

       

       

      
     }
}
