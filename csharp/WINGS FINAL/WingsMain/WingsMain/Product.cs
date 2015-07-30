using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
  public  class Product
  {
      public string Productid { get; set; }
      public string Name { get; set; }
      public double Price { get; set; }
      public Product(string product, string name, double price)
      {
          Productid = product;
          Name = name;
          Price = price;
      }
      public override string ToString()
      {
          string s;
          s = "" + Name+"," + "  " + Price;
          return s;
      }
      }


    }

