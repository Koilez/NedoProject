using Project.model_data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class WindowAddData : Form
    {
        public Person person { get; set; }
        public WindowAddData(Person person)
        {
            InitializeComponent();
            enterData(person);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterData(Person person)
        {
            if(person.Id != null)
            {
                textBoxFirsName.Text = person.FirstName;
                textBoxSurname.Text = person.Lastname;
                textBoxAge.Text = person.Age.ToString();
                comboBoxIsALive.Text = person.IsAlive.ToString();
                textBoxCity.Text = person.AddressesList[0].City;
                textBoxStreet.Text = person.AddressesList[0].Street;
                textBoxNumberHouse.Text = person.AddressesList[0].HouseNumber.ToString();
            }
            
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            person = new Person
            {
                FirstName = textBoxFirsName.Text,
                Lastname = textBoxSurname.Text,
                Age = Int32.Parse(textBoxAge.Text),
                IsAlive = Boolean.Parse(comboBoxIsALive.Text),
                AddressesList = new List<Address>
                {
                    new Address {City = textBoxCity.Text, Street = textBoxStreet.Text, HouseNumber =Int32.Parse(textBoxNumberHouse.Text) }
                }
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
