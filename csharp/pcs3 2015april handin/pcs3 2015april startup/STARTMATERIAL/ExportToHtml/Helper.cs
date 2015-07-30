using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExportToHtml
{
    class Helper
    {
        public string FileName { get; set; }
        public Helper() { }

        public string ItemToString(Item item)  ///This is for converting the Item into string ///
        {
            if (item is SingleLineItem)
            {
                SingleLineItem s = (SingleLineItem)item;

                string S = "<h2>" + s.Title + "</h2>";
                S += "\n<p> " + s.Text + " </p> ";
                S += "\n<h5>Posted by:   " + s.PersonName +"  ,  "+  s.DatePosted + "</h5><hr>";
                return S;
            }
            if (item is MultiLineItem)
            {
                MultiLineItem s = (MultiLineItem)item;
                string S = "<h2>" + s.Title + "</h2>";
                S += "\n<p><ul>";
                foreach (string p in s.lines)
                {
                    S += "\n<li>   " + p + "  </li>";
                }
                S += "</ul></p>";
                S += "\n<h5>Posted by:   " + s.PersonName + "  ,  " + s.DatePosted + "</h5><hr>";
                return S;

            }
            else
                return null;
        }
        public void SaveToString(List<Item> lines)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            List<string> re = new List<string>();
            foreach (Item p in lines)
            {
                string s = ItemToString(p);
                re.Add(s);
            }

            try
            {
                fs = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                sw = new StreamWriter(fs);
                foreach (string l in re)
                {

                    sw.WriteLine(l + "\n");
                }
            }
            catch (Exception)
            {
              
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }



        }


    }
}
