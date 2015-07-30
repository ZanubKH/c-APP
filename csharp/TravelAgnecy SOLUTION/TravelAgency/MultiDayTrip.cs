using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    [Serializable] 
    class MultiDayTrip:SimpleTrip
    {       
       public int NrDays { get; set; }
       public int NrFreeRooms { get; set; }

        public MultiDayTrip(string dest, decimal pr, int days, int free) : base( dest, pr)
        {  NrDays = days;
           NrFreeRooms = free;
        }

        public override string ToString()
        {
            return base.ToString() + ", for " + NrDays + " days";
        }
          

        public override bool Book(string name)
        {
            if (this.NrFreeRooms > 0)
            {
                base.Book(name);
                NrFreeRooms--;
                return true;
            }
            else return false;

        }       
    }
}
