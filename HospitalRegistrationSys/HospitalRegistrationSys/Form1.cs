using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistrationSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validName = txtName.Text.All(Char.IsLetter); //Checking if user enters number in name.
            bool validClinic = txtClinic.Text.All(Char.IsLetter);

            if (txtName.Text.Equals("") && txtAge.Text.Equals("") && txtClinic.Text.Equals(""))
                MessageBox.Show("Make sure that you fill given fields.");
            else if (!validName)
                MessageBox.Show("Enter the Name of patient properly.");
            else if (!validClinic)
                MessageBox.Show("Enter the clinic information properly.");
            //Wrote validateAge() method for age control.
            else if (!validateAge())
                MessageBox.Show("Age should be a number.");
            else if (lbPatients.Items.Contains(txtName.Text + " " + txtAge.Text + " " + txtClinic.Text))
            {
                MessageBox.Show("This patient is already added to the list.");
                //remove method wrote for clearing the fields.
                removeTextBoxes();
            }
            else //everything is okay, add it to the list
            {
                lbPatients.Items.Add(txtName.Text + " " + txtAge.Text + " " + txtClinic.Text);
                removeTextBoxes(); //Clear the fields.
            }
        }
        private bool validateAge()
        {
            int parsed;
            if (!int.TryParse(txtAge.Text, out parsed))
                return false;
            else
                return true;
        }

        private void removeTextBoxes()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtClinic.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbPatients.SelectedIndex >= 0)
                lbPatients.Items.RemoveAt(lbPatients.SelectedIndex); //If the list is not empty, delete.
            else
                MessageBox.Show("Select item first!");
        }
    }
}
