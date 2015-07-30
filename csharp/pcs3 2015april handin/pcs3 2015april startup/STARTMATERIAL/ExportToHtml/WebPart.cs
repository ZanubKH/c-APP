using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportToHtml
{
    class WebPart
    {
        public List<Item> myItemList;
        public string Title { get; set; }
        public WebPart(string title)
        {
            Title = title;
            myItemList = new List<Item>();
        }
        public List<Item> GetAllItem()
        {
            return myItemList;
        }
        public Item GetItem(int id) 
        {
            if (myItemList != null)
            {
                foreach (Item a in myItemList)
                { if (a.Idnr == id) { return a; } }

                return null;
            }
            else

                return null;
        }
        public bool AddItem(Item i)
        {
            if (myItemList != null)
            {
                foreach (Item a in myItemList)
                { if (a.Idnr == i.Idnr) { return false; } }
                myItemList.Add(i);
                return true;

            }
            else myItemList.Add(i);
            return true;
        }
        public List<Item> GetAllSingleItem()
        {
            List<Item> singles = new List<Item>();
            if (myItemList != null)
            {
                foreach (Item a in myItemList)
                { if (a is SingleLineItem) { singles.Add(a); } }

                return singles;
            }
            else
                return null;
        }
    }
}
