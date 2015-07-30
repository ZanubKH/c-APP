using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportToHtml
{
    abstract class Item
    {
        public int Idnr{get; set;}
        public string Title{get; set;}
        public string PersonName{get; set;}
        public string DatePosted{get; set;}
        public Item(int idnr, string title, string person, string date)
        {
            Idnr = idnr;
            Title = title;
            PersonName = person;
            DatePosted = date;

        }
        public abstract List<string> ToHtml();


     
    }
}
