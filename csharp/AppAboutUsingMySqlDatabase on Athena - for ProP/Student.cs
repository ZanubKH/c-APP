using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
    public class Student
    {
        private int number;
        private String name;
        private int credits;

        public Student(int number, String name, int credits)
        {
            this.number = number;
            this.name = name;
            this.credits = credits;
        }


        public String getInfo()
        {
            return this.number.ToString() + " - " + this.name + " - " + this.credits.ToString();
        }
    }
}
