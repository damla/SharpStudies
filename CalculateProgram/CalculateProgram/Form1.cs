using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dynamicButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //buttona tiklandiginda senderdan info alinmis oluyor.

            Control[] txts = panel2.Controls.Find(btn.Name.Replace("btn", "txt"), true); //obje olarak ismi btn olani txt olarak degistir.
            // MessageBox.Show(((TextBox)txts[0]).Text);
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                TextBox txt = (TextBox)panel2.Controls[i];
                if (txt.Name == btn.Name.Replace("btn", "txt"))
                {
                    MessageBox.Show(txt.Text);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int sum = 0;

            for(int i=0; i< panel2.Controls.Count; i++)
            {
                TextBox txt = (TextBox)panel2.Controls[i];
                sum += Convert.ToInt32(txt.Text);
            }
            MessageBox.Show("the sum is: " + sum); //controllerin icindeki textleri cekip integera pars edip topladi.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            x = y = 0; //konumlari da sifirlams olduk.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x = 0, y = 0;
        private void button1_Click(object sender, EventArgs e) //button1'e tiklanildiginda bu ozelliklere sahip button ve textBox olusturuyor.
        {
            Button btn = new Button(); //btn adli button objesii
            btn.Text = "click!"; //Ustunde yazan click!
            btn.Name = "btn_" + x + "_" + y; //ismi konumuna gore degisiyor
            btn.Size = new Size(40, 25); //boyutu sabit 
            btn.Location = new Point(x * 50, y * 30); // konumu x ve y degerlerinin katlari seklinde belirlendiki surekli degisim saglasin.
            btn.Click += new System.EventHandler(dynamicButtonClick); //yaratilan buttona tiklandgnda ilk method olan dynamicbutton'a yolluyoruz.
                                                                      //bu buttona tiklandiginda hedef buttonun baglantili oldugu sayiyi gostermesi.

            TextBox txt = new TextBox();
            txt.Text = new Random().Next(100).ToString(); //100'e kadar sayi secildi. Tusa her tiklanildiginda bu sayede icine random sayilar konulacak. (String olduklarini unutma!)
            txt.Name = "txt_" + x + "_" + y; //isim kordinata gore
            txt.Size = new System.Drawing.Size (40, 25); //textbox olmasindan dolayi drawing.size kutuphanesi kullandildi.
            txt.Location = new Point(x * 50, y * 30); //yine location x ve y degerlerine gore ayarlanacak.

            panel1.Controls.Add(btn); //button brinci panele eklendi.
            panel2.Controls.Add(txt); //txt ikinci panele eklendi.
            x++; //x her button1 e tiklanildiginda artiyor.
            if (x == 5) //5'e esitlendiginde alt satira gecmesi icin y artiyor ve x sifirlaniyorki satir basina gelsin.
            {
                y++;
                x = 0;
            }
        }    
    }
}
/*
 * DynamicButton methodu ile sonradan olusan buton methodu olusturduk.
 * Button1'e tiklandiginda bu methodumuz calisacak.
 */