using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterWeek1
{
    public partial class AnimalShelterForm : Form
    {
        Animal animal;
        
        public AnimalShelterForm()
        {
            InitializeComponent();
            
        }

        private void AnimalShelterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            animal = new Animal("a23", new DateTime(1999, 6, 1), "Max");


        }

        private void btnShowInfoAnimal_Click(object sender, EventArgs e)
        {
            animal = new Animal("a23", new DateTime(1999, 6, 1), "Max");
            labelAnimalInfo.Text = animal.ShowInfo();
        }





        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            animal = new Dog("d44", new DateTime(2000, 7, 4), "pup", new DateTime(2007, 9, 6));
        }

        private void btnShowInfoDog_Click(object sender, EventArgs e)
        {
            animal = new Dog("d44", new DateTime(2000, 7, 4), "pup", ((Dog)animal).LastWalk );
            labelDogInfo.Text = animal.ShowInfo();
        }

        private void btnDogWalk_Click(object sender, EventArgs e)
        {
            Dog s = (Dog)animal;
           s.TakeForWalk();

        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            animal = new Cat("c55", new DateTime(1999, 9, 1), "kat","string" );
        }

        private void btnShowInfoCat_Click(object sender, EventArgs e)
        {
            //cat.BadHabits = "smell";
            
            labelCatInfo.Text = animal.ShowInfo();
          

        }

        private void btnCatBadHabbit_Click(object sender, EventArgs e)
        {
            //cat.AddBadHabits(tbCatBadHabbit.Text);
            //Cat c = (Cat)animal;
            //c.AddBadHabits(tbCatBadHabbit.Text);
            
            
            
            
            
            ((Cat)animal).AddBadHabits(tbCatBadHabbit.Text);
        }


    }
}
                                                                                                                                                                                                      