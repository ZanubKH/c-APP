using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    [Serializable] 
    public class SimpleTrip
    {
        public List<String> Travelers { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
              
        public  SimpleTrip( string dest, decimal pr)
        {
            Travelers = new List<String>();
            Destination = dest;
            Price=pr;
        }
        public override string ToString()
        {
            return "trip to: " + Destination + ", with " + Travelers.Count + " travelers";
        }

        public virtual bool Book(String p)
        {
            Travelers.Add(p);
            return true;            
        }
     
    }
}
