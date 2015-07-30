using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesWorkDivision
{
    public class Pilot: IComparable<Pilot>
    {
        public delegate void FullCapacity(Pilot pilot, int overHours);
        public event FullCapacity OnFullCapacity;

        private const int capacityHoursPerMonth = 200; // maximum flight hours per month

        private static int nextPilotNumber = 100;  // for automated generation of unique pilot numbers

        public int PilotNumber { get; private set; } // unique identification number 
        public string Name { get; set; }             // full name 
        public int Age { get; set; }                 // age  

        private int flightHours;                     // achieved flight hours
        public int FlightHours                       
        {
            get { return flightHours; }
            private set
            {
                if (value >= 0)
                {
                    flightHours = value;
                }
            }
        }

        private int nrFlights;                       // achieved number of flights  
        public int NumberOfFlights
        {
            get { return nrFlights; }
            private set
            {
                if (value >= 0)
                { nrFlights = value; }
            }
        }      
        
        /// <summary>
        /// The only construtor. Initializes name and age to given values. 
        /// All other properties are initlaized to their default values.
        /// </summary>
        /// <param name="name">Full name of the pilot.</param>
        /// <param name="age">Age of the pilot.</param>
        public Pilot(string name, int age)
        {
            this.PilotNumber = nextPilotNumber++;
            this.Name = name;
            this.Age = age;
            this.FlightHours = 0;
            this.NumberOfFlights = 0;
        }

        /// <summary>
        /// Adds one flight to the pilot.
        /// </summary>
        /// <param name="flightDuration">Flight duration in whole hours.</param>
        public void AddFlight(int flightDuration)
        {
            if (flightDuration > 0)
            {
                this.FlightHours += flightDuration;
                this.NumberOfFlights++;
                if (OnFullCapacity != null)
                {
                    if (FlightHours >= capacityHoursPerMonth)
                    {
                        int overCapacity = FlightHours - capacityHoursPerMonth;
                        OnFullCapacity(this, overCapacity);
                    }
                }
            }
        }
        /// <summary>
        /// Returns information about the pilot in a nice string format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return PilotNumber + "\t" + Name  + " (" + Age + " years)\t" + NumberOfFlights + " flights\t" + FlightHours+" hours";
        }

        public int CompareTo(Pilot pilot)
        {
           
            
            if (this.PilotNumber < pilot.PilotNumber)
                return 1;
            else
               
                return 0;
        }

    }
}
