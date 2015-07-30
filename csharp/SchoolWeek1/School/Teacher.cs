using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    enum Function { JUNIOR_DOCENT, DOCENT_1, DOCENT_2, INTERNSHIP_COORDINATOR, TEAM_LEADER, DIRECTOR }

    class Teacher:Person
    {

           // how many years the teacher works at Fontys 
        private Function function;     // function. E,g, DOCENT_1, DOCENT_2, TEAM_LEADER, ...
        private double salary;         // monthly salary 
        public int i;
      

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Function Function
        {
            get { return function; }
            set { function = value; }
        }

        /// <summary>
        /// The only constructor.</summary>
        /// <param name="name">Initial name of the teacher.</param>
        /// <param name="pcn">Personal Fontys number of the teacher.</param>
        /// <param name="age">Age of the teacher.</param>
        /// <param name="function">Function of the teacher.</param>
        /// <param name="salary">Monthly salary of the teacher.</param>
        public Teacher(string name, int age, int pcn, Function function, int salary):base(name,age,pcn)
        {
            
            this.Function = function;
            this.Salary = salary;
            i = 0;
        }

        /// <summary>
        /// Increases property YearsAtFontys by 1. 
        /// </summary>
       
        /// <summary>
        /// Promotes the teacher by one function. 
        /// For example, DOCENT_1 is promoted into DOCENT_2.
        /// </summary>
        public void Promote()
        {
            if (function < Function.DIRECTOR)
                function++;
        }
        public override string InfoString()
        {
            return base.InfoString() + "\nFuntion\t" + Function.ToString() + "\nSalary\t" + Salary.ToString();
        }
        public override void AnotherSchoolYear()
        {
              
            if (i >= 2) { i = 0; Salary = Salary + (0.1 * Salary ); } 
            else
            {  i++; }
            base.AnotherSchoolYear();
        }

      



    }
}
