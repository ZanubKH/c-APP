using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Truck : Vehicle
    {
        private int maxload;

        public Truck(String brand, int mileage, int maxload)
            :base(brand, mileage)
        {
            this.maxload = maxload;
        }

        public int GetMaxload()
        {
            return this.maxload;
        }

        public String AsAString()
        {
            return "TRUCK: " + base.AsAString()
                + " and my maxload is "+ this.maxload.ToString();
        }

    }
}
