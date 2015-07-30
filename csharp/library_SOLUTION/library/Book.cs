using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Book:Item
    {   public string Title { get; set; }
        public string Author  { get; set; }

        public Book(int id, string title, string a): base(id)
        {
            Title = title;
            Author = a;
        }

         public override string ToString()
        {
            string str =  "BOOK:       " +base.ToString();
            str += Title + ",   " + Author;
            return str;
        }

         // exercise 4a
         public override decimal CalcFine(DateTime dtOut, DateTime dtIn)
         {
             decimal fine = 0;
             int days = (dtIn.Date - dtOut.Date).Days;
             if (days > 10)
             {
                 days = days - 10;
                 fine = (decimal)(days * 0.50);
             }
             return fine;
         }
     }
}
