using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        private Teacher teacher;
        private Student student;

        public Form1()
        {
            InitializeComponent();
            teacher = new Teacher("Edna Krabappel", 111111, 36, Function.DOCENT_1, 1500); // create a teacher
            student = new Student("Zanub", 20, 298536, "Pakistan", 0, true);
            LogTeacherChange("start");
            LogStudentChange("start");
            
           
        }


        private void LogTeacherChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n"+teacher.InfoString());
        }
        private void LogStudentChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n" + student.InfoString());
        }


        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            teacher.AnotherSchoolYear();
            LogTeacherChange("another school year");
            labelTeacher.Text = teacher.InfoString();
        }

        private void buttonBirthdayTeacher_Click(object sender, EventArgs e)
        {
            teacher.CelebrateBirthDay();
            LogTeacherChange("birthday");
            labelTeacher.Text = teacher.InfoString();
        }

        private void buttonPromote_Click(object sender, EventArgs e)
        {
            teacher.Promote();
            LogTeacherChange("promotion");
            labelTeacher.Text = teacher.InfoString();
        }

        private void buttonSchoolYearStudent_Click(object sender, EventArgs e)
        {
            student.AnotherSchoolYear();
            LogStudentChange("another school year");
            labelStudent.Text = student.InfoString();
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            student.CelebrateBirthDay();
            LogStudentChange("birthday");
            labelStudent.Text = student.InfoString();
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {

            student.AddOneModuleEC();
            LogStudentChange("EC'S");
            labelStudent.Text = student.InfoString();
        }

        private void labelTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
