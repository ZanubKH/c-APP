using System;
using System.Collections.Generic;
using System.Text;

namespace WingsClientApp
{
   public class Count
    {
        public int TRerve { get; set; }
        public int TEntree { get; set; }
        public int TOut{ get; set; }
        public int TMoney { get; set; }
        
        public Count(int r, int e, int o ,  int m ) 
        {
            TRerve = r;
            TEntree = e;
            TOut = o;
            TMoney = m;
            
        }
        

    }
}
