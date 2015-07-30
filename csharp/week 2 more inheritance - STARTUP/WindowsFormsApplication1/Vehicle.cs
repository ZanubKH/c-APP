using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Vehicle
    {
        private String brand;
        private int mileage;

        public Vehicle(String brand, int mileage)
        {
            this.brand = brand; this.mileage = mileage;
            
        }

        public String GetBrand() { return brand; }
        public int GetMileage()    { return this.mileage; }

        public String AsAString()
        {
            return "My brand is " + this.brand + " and so far I drove " + this.mileage.ToString() + " kilometers";
        }
    }
}
