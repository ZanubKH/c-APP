using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ETruck : Truck
    {

        private int batteryPower;

        public ETruck(String brand, int mileage, int maxload, int bp)
        :base(brand, mileage,maxload)
        {
            this.batteryPower = bp;
        }

        public String AsAString()
        {
            return "E-TRUCK: " + base.AsAString() + "  " + this.batteryPower;
        }
    }
}
