using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesWorkDivision
{
    public partial class FormAirlines : Form
    {
        private Airlines airlines = new Airlines("KLM - Royal Dutch Airlines"); // an airlines object

        public FormAirlines()
        {
            InitializeComponent();
            this.Text = airlines.Name + "- Monthly work division"; // set the Text of the form
            this.CreateFakePilots(); 
            this.ShowPilots();
        }

        /// <summary>
        /// Creates several "fake" pilots and adds them to the airlines object.
        /// </summary>
        private void CreateFakePilots()
        {
            Pilot pilot = new Pilot("John Perry", 30);
         //   pilot.OnFullCapacity += this.PilotCapacityFull;
            pilot.AddFlight(110);
            pilot.AddFlight(60);
            airlines.AddPilot(pilot);

            pilot = new Pilot("Ann Smiths", 40);
           // pilot.OnFullCapacity += this.PilotCapacityFull;
            pilot.AddFlight(75);
            airlines.AddPilot(pilot);

            pilot = new Pilot("Joe Jefferson", 33);
          //  pilot.OnFullCapacity += this.PilotCapacityFull;
            pilot.AddFlight(120);
            airlines.AddPilot(pilot);

            pilot = new Pilot("Jack Gibbs", 45);
          //  pilot.OnFullCapacity += this.PilotCapacityFull;
            pilot.AddFlight(90);
            airlines.AddPilot(pilot);                          
         }

        /// <summary>
        /// Shows all pilots from the airlines object in a list box.
        /// </summary>
        private void ShowPilots()
        {
            lbxPilots.Items.Clear();
            List<Pilot> pilots = airlines.GetPilots();
            foreach (Pilot pilot in pilots)
            {
                lbxPilots.Items.Add(pilot);
            }
        }

        /// <summary>
        /// Adds flight to a pilot and refreshes the list box of pilots on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            Pilot pilot = (Pilot)lbxPilots.SelectedItem;
            int flightDuration = Convert.ToInt32(tbFlightDuration.Text);

            if (pilot != null)
            {
                pilot.AddFlight(flightDuration);
                pilot.OnFullCapacity += this.PilotCapacityFull;
                ShowPilots();
            }
        }

        private void btnAvgHours_Click(object sender, EventArgs e)
        {
            int lowerAge = Convert.ToInt32(tbLowerLimit.Text);
            int upperAge = Convert.ToInt32(tbUpperLimit.Text);

            int nrPilots;
            double avgNumberOfFlights;

            double averageHours = airlines.GetAveragePilotFlightHours(lowerAge, upperAge, out nrPilots, out avgNumberOfFlights);
            
            averageHours = Math.Round(averageHours, 2);
            avgNumberOfFlights = Math.Round(avgNumberOfFlights, 2);
            
            if (averageHours >= 0)
            {
                lblAverageFlightHours.Text = "pilot age: " + lowerAge + " to " + upperAge+" years\naverage flight hours = " + averageHours.ToString() + "\nnumber of pilots = " + nrPilots + "\naverage nr flights = "+ avgNumberOfFlights;
            }
            else
            {
               lblAverageFlightHours.Text = "There are no pilots of this age!";
            }
        }

        private void PilotCapacityFull(Pilot pilot, int overHours)
        {
            MessageBox.Show("Pilot "+ pilot.Name + " has full capacity and will be removed from the list!\nHe/she now has "  + pilot.FlightHours + " flight hours, and that is "+ overHours + " hours of over work!");
            airlines.RemovePilot(pilot);
            ShowPilots();
        }
        
        private void btnIncreaseAge_Click(object sender, EventArgs e)
        {
            int pilotNumber = Convert.ToInt32(tbPilotNumber.Text);
            Pilot pilot = airlines.FindPilot(pilotNumber);
            if (pilot != null)
            {
                pilot.Age++;
            }
            else
            {
                MessageBox.Show("There are no pilots with this number!");
            }
            ShowPilots();
        }

        private void btnShowPilotsOfAge_Click(object sender, EventArgs e)
        {
            int lowerAge = Convert.ToInt32(tbLowerLimit.Text);
            int upperAge = Convert.ToInt32(tbUpperLimit.Text);
            MyListOfPilots cityFlights = airlines.GetPilotsOfAge(lowerAge,upperAge);
            Node node = cityFlights.First;
            lbxPilotsOfAge.Items.Clear();
            while (node != null)
            {
                lbxPilotsOfAge.Items.Add(node.Pilot);
                node = node.Next;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            airlines.SortPilots();
            this.ShowPilots();
        }       
    }
}
