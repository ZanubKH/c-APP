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
    public partial class FormMyPerson : Form
    {

        Person myPerson;
        private List<Person> persons = new List<Person>();
        



        public FormMyPerson()
        {
            InitializeComponent();
        }


      
        private void LogPersonChange(string changeName)
        {
            this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** " + changeName);
            

          
          
        }
        private bool contain(int pcn)
        {
            foreach (Person p in persons)
        {      if (p.PCN == pcn) { return true; } 
        }
            return false;
        }
        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            Person s = (Person)(listBox1.SelectedItem);
            s.AnotherSchoolYear();
            LogPersonChange( "year at Fontys");
            labelMyPersonInfo.Text = ((Person)listBox1.SelectedItem).InfoString();
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            Person s = (Person)(listBox1.SelectedItem);
            s.CelebrateBirthDay();
            LogPersonChange( "birthday");
            labelMyPersonInfo.Text = s.InfoString();
        }
       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int pcn = Convert.ToInt32(this.textBoxPCN.Text);
            int age = Convert.ToInt32(this.textBoxAge.Text);

            if (radioButtonPerson.Checked)
            {
               myPerson = new Person(name, pcn, age);
               if (contain(pcn) == false)
               {
                   persons.Add(myPerson);
                   listBox1.Items.Add(myPerson);
                   LogPersonChange("CREATED PERSON :");
               }
               }
                
               

            
            if (radioButtonTeacher.Checked)
            {
               
                myPerson = new Teacher(name,pcn,age, JobPosition.DOCENT_2, Convert.ToDouble(textBoxSalary.Text));
                persons.Add( new Teacher(name, age, pcn, JobPosition.DOCENT_2, Convert.ToDouble(textBoxSalary.Text)));
                
                if (contain(pcn) == false)
                {
                    listBox1.Items.Add((Teacher)myPerson);

                    LogPersonChange("CREATED Teacher :");
                }
                
            }
            if (radioButtonStudent.Checked)
            {
                myPerson = new Student(name,pcn,age, textBoxCountry.Text, 0, true);
                if (contain(pcn) == false)
                {
                    persons.Add((Student)myPerson);

                    listBox1.Items.Add(((Student)myPerson));


                    LogPersonChange("CREATED Student :");
                }

            }

            

        }

        private void FormMyPerson_Load(object sender, EventArgs e)
        {

        }

        private void Promote_Click(object sender, EventArgs e)
        {

            Person s = (Person)(listBox1.SelectedItem);
            if (s is Teacher && radioButtonTeacher.Checked)
            {
                ((Teacher)s).Promote();
                labelMyPersonInfo.Text = ((Person)listBox1.SelectedItem).InfoString();

            }
            else MessageBox.Show("Not possible");
            
                

            
           
            
        }

        private void AddECs_Click(object sender, EventArgs e)
        {
            Person s = (Person)(listBox1.SelectedItem);
            if (s is Student)
            {
                ((Student)s).AddOneModuleEC();
                labelMyPersonInfo.Text = ((Person)listBox1.SelectedItem).InfoString();

            }
            else MessageBox.Show("Not possible");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Person heSelecedPerson;
            labelMyPersonInfo.Text = ((Person)listBox1.SelectedItem).InfoString();
            this.richTextBoxActivityLogMyPerson.AppendText(((Person)listBox1.SelectedItem).InfoString());
            


       
       

        }

    }
}
