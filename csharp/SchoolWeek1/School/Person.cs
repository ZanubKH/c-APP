using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
    {
        private string name;           // full name of the teacher
        private int pcn;               // personal pcn Fontyus number 
        private int age;               // age of the teacher
        private int yearsAtFontys;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// must be in range 111111  to 999999
        /// </summary>
        public int PCN
        {
            get { return pcn; }
            set
            {
                if (value >= 111111 && value <= 999999)
                    pcn = value;
                else
                {
                    if (value < 111111)
                        pcn = 11111;
                    else pcn = 999999;
                }
            }
        }

        /// <summary>
        /// Cannot be set outside this class.
        /// Must be more than 18
        /// </summary>
        public int Age
        {
            get { return age; }
            private set
            {
                if (value > 18)
                    age = value;
                else age = 18;
            }
        }

        /// <summary>
        /// Cannot be set outside this class.
        /// Cannot be a negative number.
        /// </summary>
        public int YearsAtFontys
        {
            get { return yearsAtFontys; }
            private set
            {
                if (value >= 0)
                {
                    yearsAtFontys = value;
                }
                else
                {
                    yearsAtFontys = 0;
                }
            }
        }
        ////constructor////////////
        public Person(string name, int age, int pcn)
        {
            Name = name;
            Age = age;
            PCN = pcn;
            YearsAtFontys = 0;
        }
        public virtual void AnotherSchoolYear()
        {
            YearsAtFontys++;
        }

        /// <summary>
        /// Increases property Age by 1. 
        /// </summary>
        public void CelebrateBirthDay()
        {
            Age++;
        }

        /// <summary>
        /// Returns values of all properties in the following string format:
        /// "John Doe (12456)
        ///  age 45, 15 years at Fontys
        ///  function: DOCENT_1
        ///  salary:   15000"
        /// </summary>
        public virtual string InfoString()
        {
            string info = "";
            info += this.Name + " (" + this.PCN.ToString() + ")";
            info += "\nage " + this.Age.ToString() + ", " + this.YearsAtFontys.ToString() + " years at Fontys";

            

            return info;
        }


    }
}
