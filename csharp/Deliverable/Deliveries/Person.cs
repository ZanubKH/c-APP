using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
   public  class Person
    {
//        ///+ string name {readonly}
//+ string street {readonly}
//+ int houseNumber {readonly}
//+ string postalCode {readonly}
//+ string city {readonly}///

        public string Name { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public Person(string name, string pc,string ci , int hnum,string str)
          {
              Name = name;
              PostCode = pc;
              City = ci;
              HouseNumber = hnum;
              Street = str;
           }
        public override string ToString()
        {
            return " Name " + Name + " Postcode " + PostCode + "   " + HouseNumber+ "  " + Street + " City " + City;
        }

    }
}
