using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Cat : Animal
    {
        public string BadHabits { get; set; }

        public Cat(string regno, DateTime datebr, string name, string badhabits)
            : base(regno, datebr, name)
        {
            BadHabits = badhabits;
        }
        public override string ShowInfo()
        {
            if (BadHabits != null)
            { return base.ShowInfo() + "\t" + BadHabits; }
            else { return base.ShowInfo() + "No bad habit"; }
        }
        public void AddBadHabits(string habit)
        {
            string temp = BadHabits;
            BadHabits = temp + "," + habit;
            
        }
    }
}