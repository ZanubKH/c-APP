using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student:Person
    {
        public string Country { get; set; }
        public int Ecs { get; set; }
        public bool Module { get; set; }
        public Student(string name, int age, int pcn, string country, int ec,bool module)
            : base(name, age, pcn)
        {
            Country = country;
            Ecs = ec;
            Module = module;
        }
        public override string InfoString()
        {
            return base.InfoString() + "\nCountry\t" + Country + "\nEcs\t" + Ecs.ToString();
        }

        public void AddOneModuleEC()
        {
            if (Module == true) { Ecs = Ecs + 3; }
            else Ecs = Ecs + 0;
        }
    }
}
