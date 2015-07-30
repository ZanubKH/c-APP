using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
   public class Guests
    {
        public int guestid { get; set;}
        public int tentid { get; set; }
        public int hostid { get; set; }
        public Guests(int gu, int tent, int host)
        {
            guestid = gu;
            tentid = tent;
            hostid = host;
        }
        public string InfoString()
        {
            return "" + guestid + tentid + hostid;
        }
        public override string ToString()
        {
            return " In Tent " + tentid + " With Host " + hostid;
        }
    }
}
