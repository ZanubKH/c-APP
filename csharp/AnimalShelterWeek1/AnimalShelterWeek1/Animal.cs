using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Animal
    {
        public string Regnumber { get; set; }
        public DateTime Datebrought { get; set; }
        public string Name { get; set; }
        public string NameNewOwner { get; set; }
        public Animal(string regno, DateTime datebr, string name)
        {
            this.Regnumber = regno;
            this.Datebrought = datebr;
            this.Name = name;
            this.NameNewOwner = null;

        }
        public void RegisterNewOwner(string OwnerName)
        {
            this.NameNewOwner = OwnerName;
        }
        public bool IsAdopted()
        {
            if (NameNewOwner == null) { return false; }
            else
                return true;
        }
        public virtual string ShowInfo()
        {
            if (IsAdopted() == false)
            {
                string info = "" + Regnumber + "\t" + Datebrought + "\t" +
                             Name + "\tNot reseverd";
                return info;
            }
            else
            {
                string info = "" + Regnumber + "\t\t" + Datebrought + "\t\t" +
                            Name + "\t \treseverd\t\t" + NameNewOwner;
          return info;  
            }


            
        }
    }
}
