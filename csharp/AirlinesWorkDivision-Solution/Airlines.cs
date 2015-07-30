using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesWorkDivision
{
    public class Airlines
    {
        private List<Pilot> pilots; // list of pilots who are available for work scheduling

        public string Name { get; set; } // the name of the airlines company

        /// <summary>
        /// The only constructor, initializes the name of the company.
        /// </summary>
        /// <param name="name">The name of the airlines company</param>
        public Airlines(string name)
        {
            pilots = new List<Pilot>();
            Name = name;
        }

        /// <summary>
        /// Returns all avalable pilots.
        /// </summary>
        /// <returns>A list of pilots.</returns>
        public List<Pilot> GetPilots()
        {
            return pilots;
        }

        /// <summary>
        /// Add a new pilot to the airlines.
        /// </summary>
        /// <param name="pilot">The pilot that should be added.</param>
        public void AddPilot(Pilot pilot)
        {
            pilots.Add(pilot);
        }

        /// <summary>
        /// Removes one pilot for the airlines.
        /// </summary>
        /// <param name="pilot"></param>
        public void RemovePilot(Pilot pilot)
        {
            pilots.Remove(pilot);
        }

        /// <summary>
        /// Calculates the average flight time of pilots of a certain age in the airline. 
        /// </summary>
        /// <param name="lowerAge">Lower age of pilots who should be included in calculation.</param>
        /// <param name="upperAge">Upper age of pilots who should be included in calculation.</param>
        /// <param name="nrPilots">Number of processed pilots.</param>
        /// <param name="minHours">Minimum flight hours of processed pilots.</param>
        /// <param name="maxHours">Maximum flight hours of processed pilots.</param>
        /// <returns>The average flight time of pilots.</returns>
        public double GetAveragePilotFlightHours(int lowerAge, int upperAge, out int nrPilots, out double avgNumberOfFlights)
        {
            double sumPilotHours = 0;
            double sumPilotFlights = 0;
            nrPilots = 0;
            avgNumberOfFlights = -1;            

            foreach (Pilot pilot in pilots)
            {
                if (lowerAge <= pilot.Age && pilot.Age <= upperAge)
                {
                    nrPilots++;
                    sumPilotHours += pilot.FlightHours;
                    sumPilotFlights += pilot.NumberOfFlights;                    
                }
            }

            if (nrPilots == 0)
            {
                return -1;
            }
            else
            {
                avgNumberOfFlights = sumPilotFlights / nrPilots;
                return sumPilotHours / nrPilots;
            }
        }

        /// <summary>
        /// Searches for the pilot with the given pilot number. 
        /// </summary>
        /// <param name="pilotNumber">The number of the pilot that should be found.</param>
        /// <returns>If a pilot with the given pilot number is found, it returns that pilot. Otherwise, return null.</returns>
        public Pilot FindPilot(int pilotNumber)
        {
            Pilot pilot = null;
            int lowerLimit = 0;
            int upperLimit = pilots.Count - 1;
            int middlePoint = (lowerLimit + upperLimit + 1) / 2;

            do
            {
                Pilot middlePilot = pilots.ElementAt(middlePoint);
                if (middlePilot.PilotNumber == pilotNumber)
                {
                    pilot = middlePilot;
                }
                else
                {
                    if (middlePilot.PilotNumber < pilotNumber)
                    {
                        lowerLimit = middlePoint + 1;
                    }
                    else
                    {
                        upperLimit = middlePoint - 1;
                    }
                    middlePoint = (lowerLimit + upperLimit + 1) / 2;
                }
            } while ((lowerLimit <= upperLimit) && (pilot == null));

            return pilot;
        }

        /// <summary>
        /// Returns a list of pilots of a certain age.
        /// </summary>
        /// <param name="lowerAge">Lower age of pilots who should be returned.</param>
        /// <param name="upperAge">Upper age of pilots who should be returned.</param>
        /// <returns></returns>
        public MyListOfPilots GetPilotsOfAge(int lowerAge, int upperAge)
        {
            MyListOfPilots cityFlights = new MyListOfPilots();
            foreach (Pilot p in pilots)
            {
                if (p.Age >= lowerAge && p.Age <= upperAge)
                {
                    cityFlights.Add(p);
                }
            }
            return cityFlights;
        }

        public void SortPilots()
        {
            pilots.Sort();
        }
    }
}
