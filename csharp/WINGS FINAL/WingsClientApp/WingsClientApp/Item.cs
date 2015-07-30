using System;
using System.Collections.Generic;
using System.Text;

namespace WingsClientApp
{
   public  class Item
    {public int TInvoice { get; set; }
        public int TLending { get; set; }
        public int TCamping { get; set; }
        public int TRent { get; set; }
        public int TCapacity { get; set; }
        public Item(int i, int c, int re, int cp)
        {
            TInvoice = i;
           
            TCamping = c;
            TRent = re;
            TCapacity = cp;
        }

    }
}
