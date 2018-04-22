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
            Button btn = (Button)sender; //buttona tiklandiginda senderdan info alinmis oluyor. Bu panel1 de bulunuyor.

            Control[] txts = panel2.Controls.Find(btn.Name.Replace("btn", "txt"), true); //true butun childrenlari search etmesi icin. Burada amac controller icerisinde ismi btn olanlari txt ile degistirip o uyumda var mi kontrol etmek.
                                                                                         //buldugunda da arraye o texti ekliyoruz.
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

            for(int i=0; i< panel2.Controls.Count; i++) //hepsini toplamasi icin kontrol sayisi kadar
            {
                TextBox txt = (TextBox)panel2.Controls[i]; //yeni txt yaratip controller icerisindeki sayilari cekiyoruz.
                sum += Convert.ToInt32(txt.Text); // bu sayilar string formatinda oldugu icin toplarken integera ceviirmeyi unutmuyoruz.
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
            txt.Size = new System.Drawing.Size (40, 25); //bu sekilde de yazilabiliyor.
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
/* --DYNAMIC BUTTON KULLANIMI--
 * Oncelikle button1 methodunda button1'e tiklandiginda neler olacagini ayarliyoruz.
 * Ardindan button1'de yaratilmis olan dynamic buttonlar icin method olusturuyoruz. Boylece onlara da tiklandiginda neler olacagini belirlemis olduk.
 * Ardindan link labellarimiz olan calculate ve clear'a ait methodlar yazdik. Boylece calculate'e tiklandiginda toplama, clear'a tiklandiginda silme islemi yapilacaktir.
 * 
 * Button1: Bu method icersinde ilk olarak btn isimli bir button objesi olusturduk. Bu objeye isim, ustunde yazacak olan text, size, location ve tiklandiginda ne olacagini atadik(dynamic
 * methoda gidecek).Location'in her button yaratildiginda degismesi icin x ve y degiskenleri en basindan 0 olarak tanimlandi. Boylece koordinat olarak (0,0) belirlemis olduk. Atanan isimlerin hepsinin
 * birbirinden farkli olmasi icin x ve y koordinatlariyla ismi kombinledik. Button'a tiklanildiginda dynamic methodumuzun calisabilmesi icin EventHandler olarak methodumuzu belirledik.
 * Ardindan txt adinda TextBox objemizi yarattik ve ayni sekilde ona isim, size, location ve text atadik fakat textimizi String cinsinden 100'e kadar random sayilar olarak atadik.
 * En son panel1'e butonumuzu panel2'ye ise textimizi ekledik. (Controls.add). Ardindan x+1 yaptik. Burada artis kontrolu olarak 1 satirda 5 item olmasi amaclandigi icin x=5 oldugunda x=0 yapip
 * y+1 yapiyoruz. Boylece koordinatlarimiz asagiya inip satir basina gelmis oluyor.
 * 
 * DynamicButton: Bu methodumuzda button1 de sonradan yaratilmis olan buttonlarimizin ne yapacagini belirliyoruz. Bizden istenen bu button'a tiklandiginda messageBox olarak o button ile baglantili olan
 * textBox icerisindeki sayiyi yazdirmasidir. bunun icin once btn isimli bir button yaratiyoruz fakat bunu sender ile button1 methodumuzdaki buttonu cekerek yaratiyoruz. Ardindan Controls arrayi olusturuyoruz.
 * Bunun icerisine panel2 de bulunan, 
 *
 */