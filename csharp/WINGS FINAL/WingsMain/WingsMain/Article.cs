using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
   public  class Article
    {
        public int Article_id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public int Exist { get; set; }
        public string Description { get; set; }
        public Article(int art,string namem,string comp,int pri,int ex,string des)
    {
        Article_id = art;
        Name = namem;
        Company = comp;
        Price = pri;
        Exist = ex;
        Description = des;
     
    }
        public  string AsString()
        {
            return "Article Name : " + Name + "From   " + Company + "  Price  " + Price;
        }
        public override string ToString()
        {
            return Name + "   " + Company + "   " + Description + "  Price  " + Price;
        }
    }
}
