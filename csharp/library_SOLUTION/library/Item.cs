using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    abstract class Item
    {
        public int IdNr  { get; set; }
        public bool Present { get; set; }
        public  DateTime HandInDate  { get; set; }
        public  DateTime BorrowDate  { get; set; }

        public Item(int id)
        { IdNr=id;
          Present=true;
        }

        public void Borrow(DateTime dt)
        {   //exercise 3c
            if (Present == false)
                throw new BorrowException("item not present");
            if (dt < this.HandInDate)
                throw new BorrowException("wrong date");
            //exercise 1
            Present = false;
            BorrowDate = dt;
        }

        public  void  HandIn(DateTime dt)
        {
            Present = true;
            HandInDate = dt;           
        }
       
        public override string ToString()
        {   
            string str="id="+IdNr;
            if (!Present)
                str = str + ", NOT PRESENT, last borrowed on   " + BorrowDate.Date.ToString("d")+" ";
            else str = str + ", PRESENT, last handed in on \t" + HandInDate.Date.ToString("d") + "  ";
            return str;
        }

        //exercise 4b
        public abstract Decimal CalcFine(DateTime dtOut, DateTime dtIn);
    }
}
