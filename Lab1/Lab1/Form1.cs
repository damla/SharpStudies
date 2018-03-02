using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] arrList = new String[6]; //girilen bilgileri bu arraye kaydediyoruz.

            arrList[0] = txtName.Text;
            arrList[1] = txtSurname.Text;

            String gender = "";
            if (radioBtnMale.Checked) //eger male secildiyse onun textini atiyoruz.
                gender = radioBtnMale.Text;
            else
                gender = radioBtnFemale.Text;
            arrList[2] = gender;

            String ageInterval = "";
            if (radioBtnAge1.Checked)
                ageInterval = radioBtnAge1.Text;
            else
                ageInterval = radioBtnAge2.Text;
            arrList[3] = ageInterval;

            arrList[4] = cmbBoxCity.Text;

            String cook = checkBoxCook.Checked ? checkBoxCook.Text : "";
            String dance = checkBoxDance.Checked ? checkBoxDance.Text : "";
            String music = checkBoxMusic.Checked ? checkBoxMusic.Text : "";
            arrList[5] = cook + " " + dance + " " + music;

            MessageBox.Show("Saved Properties:\nName: " + arrList[0] + "\nSurname: " +
                arrList[1] + "\n" +
                arrList[2] + "\n" +
                arrList[3] + "\n" +
                arrList[4] + "\n" +
                arrList[5] + "\n" );

                }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "<Enter Your Name>";
            txtSurname.Text = "<Enter Your Surname";

            radioBtnFemale.Checked = false;
            radioBtnMale.Checked = false;

            radioBtnAge1.Checked = false;
            radioBtnAge2.Checked = false;

            cmbBoxCity.SelectedIndex = -1;
            checkBoxCook.Checked = false;
            checkBoxDance.Checked = false;
            checkBoxMusic.Checked = false;
        }

        private void cmbBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
