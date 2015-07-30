using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    [Serializable] 
    public class BusTrip : SimpleTrip, ICancelation
    {
        public int MaxGroupSize { get; set; }

        public BusTrip(string dest, decimal pr,int size): base(dest, pr)
        {
           MaxGroupSize = size;
        }

        public override string ToString()
        {    
            return  base.ToString()+ ", by bus with " + MaxGroupSize+ " seats in total";
         }

   
        public override bool Book(string name)
        {
           base.Book(name);
           if (Travelers.Count > MaxGroupSize)
                return false;
            else return true;
        }


       

        public void Cancel(string s)
        {
            while  (Travelers.Contains(s))
            {
                Travelers.Remove(s);              
            }
            
        }     
    }
}
