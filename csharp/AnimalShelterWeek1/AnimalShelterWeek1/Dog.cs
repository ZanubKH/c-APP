using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Dog:Animal
    {
        public DateTime LastWalk { get; set; }
        public Dog(string regno, DateTime datebr, string name, DateTime lastwalk)
            : base(regno, datebr, name)
        {
            LastWalk = lastwalk;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\t" + LastWalk;
        }
        public void TakeForWalk()
        {
            LastWalk = System.DateTime.Now;
        }

    }
}
