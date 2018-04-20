using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableStudy
{
    public partial class Form2 : Form
    {
        ListView lv;
        int index;
        public Form2(ListView lv, int index) //1. constructor
        {
            InitializeComponent();

            this.lv = lv;
            this.index = index;

            textBox1.Text = lv.Items[index].SubItems[0].Text; //name'i cektik.
            textBox2.Text = lv.Items[index].SubItems[1].Text; //address cektik.
            textBox3.Text = lv.Items[index].SubItems[2].Text; //age cektik.
        }
        public Form2(String s, String add, String age)
        {
            InitializeComponent();

            this.Text = "WELCOME " + s.ToUpper();

            textBox1.Text = s;
            textBox2.Text = add;
            textBox3.Text = age;//?
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv.Items[index].SubItems[0].Text = textBox1.Text;
            lv.Items[index].SubItems[1].Text = textBox2.Text;
            lv.Items[index].SubItems[2].Text = textBox3.Text; //hepsini updatelemis olduk.
        }


    }
}

/*
 * lv ve update edilecek indexi cektik.
 * ilk constructorda text boxlarin icine degistirecegimiz satirdaki bilgileri getirmesini sagladik.
 * Update Button: TextBoxlara yazilan yeni verilerin yerlestirilmesini sagliyoruz.
 */