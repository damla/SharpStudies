using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Once initialize ettirdigimiz icin gorselde olan yapilara eklediklerimiiz
            //ilk eklenir
            cmbLecturer.Items.Add("Adem Karahoca"); //En son bunlar eklenir.
            cmbLecturer.Items.Add("Alper Tunga");

            cmbLecturer.SelectedIndex = 0; // Sifiri secili ayarlattik.
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbLecturer.SelectedIndex == -1)
                return; //?

            //listCourses.Items.Add(listCourses.Items.Count + "--" + txtName.Text + "-" + txtEmail.Text + "-" + cmbLecturer.SelectedItem.ToString());
            //txtEmail.setText("");
            //bu sekilde de set edebiliriz ama object yontemi cok daha iyi

            //course classi yaratip ona ozellikler atiyoruz.
            Course c = new Course();
            c.COURSENAME = txtCourse.Text;
            c.COURSEMAIL = txtEmail.Text;
            c.COURSELECTURER = cmbLecturer.SelectedItem.ToString();

            c.COURSENUMBER = txtCourseNo.Text;
            if (c.COURSENUMBER.Equals("Invalid"))
                MessageBox.Show("Please enter an integer as course number!");
            
                

            listCourses.Items.Add(c); //Course eklendiginde direk tostring calistirarak yazar o yuzden toString override ettik.
            //burada objeye ulasamadiginda hata verebilir. (ornek gostermisti hoca)
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listCourses.SelectedIndex == -1)
                MessageBox.Show("HATA");
             else   
            listCourses.Items.RemoveAt(listCourses.SelectedIndex);
        }

        private void dUPLICATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listCourses.SelectedIndex == -1)
                return;
            listCourses.Items.Add(listCourses.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
