using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
  public  class Tent
    {
        public int Tentno { get; set; }
        public int Noofpeople { get; set; }
        public string Location { get; set; }
        public decimal Rent { get; set; }
        public int Isful { get; set; }
        public Tent(int tent, int no, string loc, decimal rent,int full)
        {
            Tentno = tent;
            Noofpeople = no;
            Location = loc;
            Rent = rent;
            Isful = full;
        }
        public override string ToString()
        {
            if (Isful == 0)
            {
                return " Tent number:  " + Tentno + "  Number of People:  " + Noofpeople + " Location: " + Location + " RENT : $" + Rent + " Not Full ";
            }
            else
            {
                return " Tent number " + Tentno + "  Number of People  " + Noofpeople + " Location " + Location + " RENT : $" + Rent + "  Full ";
           
            }
        }

    }
}
