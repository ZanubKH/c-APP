using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Magazine:Item
    {   public string Name { get; set; }
        public int IssueNr  { get; set; }

        public Magazine(int id, string name, int nr): base(id)
        {
            Name = name;
            IssueNr = nr;
        }

        public override string ToString()
        {
            string str =  "MAGAINE: "+base.ToString();
            str +=  Name +",   "+IssueNr;
            return str;
        }

        // exercise 4a
        public override decimal CalcFine(DateTime dtOut, DateTime dtIn)
        {
            int days = (dtIn - dtOut).Days;
            if (days > 14)
            {
                days = days - 14;
                return 2 + ((days - 1) / 7) * 2;
            }
            else return 0;
        }
    }
}
