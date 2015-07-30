using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportToHtml
{
    class MultiLineItem :Item
    {
        public List<string> lines;
         public MultiLineItem(int idnr, string title, string person, string date)
            : base(idnr, title, person, date)
        {
            lines = new List<string>();
        }
         public override List<string> ToHtml()
         {
           
             List<String> stringsM = new List<String>();
             string S = "<h2>" + Title + "</h2>";
             S+= "\n<p><ul>";
             foreach (string p in lines)
             {
                 S += "\n<li>   " +p+ "  </li>";
             }
             S += "</ul></p>";
             S += "\n<h5>Posted by:   " + PersonName + "  ,  " + DatePosted + "</h5><hr>";
             stringsM.Add(S);
             return stringsM;
         }
         public void AddLine(string aLine)
         {

             lines.Add(aLine);
         }
         //public List<string> GetAllLines()
         //{
         
         //    return lines;
         //}
    }
}
