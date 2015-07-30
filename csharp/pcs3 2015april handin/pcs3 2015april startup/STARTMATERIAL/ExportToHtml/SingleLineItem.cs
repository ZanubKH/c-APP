using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportToHtml
{
    class SingleLineItem:Item
    {
        public string Text { get; set; }
        public SingleLineItem(int idnr, string title, string person, string date, string text)
            : base(idnr, title, person, date)
        {
            Text = text;
        }
        public override List<string> ToHtml()
        {
            List<string> strings = new List<string>();
            string S = "<h2>" + Title + "</h2>";
            S += "\n<p> " + Text + " </p> ";
            S += "\n<h5>Posted by:   " + PersonName + "  ,  " + DatePosted + "</h5><hr>"; strings.Add(S);
            return strings;
        }
    }
}
