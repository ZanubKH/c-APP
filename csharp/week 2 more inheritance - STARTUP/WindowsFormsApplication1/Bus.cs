using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Bus : Vehicle
    {
        private int nrOfSeats;

        public Bus(String brand, int mileage, int nrOfSeats)
            :base(brand, mileage)
        {
            this.nrOfSeats = nrOfSeats;
        }

        public int GetNrOfSeats() { return this.nrOfSeats; }

        public  String AsAString()
        {
            return "BUS: "+ base.AsAString()
                + " and there is room for " + this.nrOfSeats.ToString() + "passengers";
        }
    }
}
