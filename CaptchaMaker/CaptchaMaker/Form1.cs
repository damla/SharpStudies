using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCaptcha(); //Initialize ettikten sonra direk gelmesi icin burada cagiriyoruz.
        }

        public void LoadCaptcha() //captcha olusturma methodu
        {
            //Bitmap olustururken width ve heightlari otomatik pictureBoxtan almasi icin int olarak w,h tanimliyoruz.
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Bitmap bmp = new Bitmap(w, h); //bitmapi generate ediyoruz. Bu alana graphics ile cizecegiz.
            Graphics pen = Graphics.FromImage(bmp);
            Random r = new Random();

            String s = "";
            s += (char)r.Next(65, 'Z' + 1); //a(65) dan z ye kadar demek z dahil olsun diye +1 (bu ilk char)
            s += r.Next(0, 10); //2. char yerine 0'dan 9'a kadar int randomize ediliyor.
            s += (char)r.Next(65, 'Z' + 1);
            s += r.Next(0, 10);
            s = s.ToLower();
            pen.DrawString(s, new Font(FontFamily.Families[r.Next(FontFamily.Families.Length)], 20, FontStyle.Bold | FontStyle.Italic |FontStyle.Strikeout | FontStyle.Underline), Brushes.MediumOrchid, 20, 20);

            pen.DrawRectangle(new Pen(Color.Black, 8),0,0,w,h);
            pen.DrawLine(new Pen(Color.BurlyWood, 3), 0, 0, w, h); 
            pen.DrawLine(new Pen(Color.BlueViolet, 3),w,0,0,h);
         // pen.DrawEllipse(new Pen(Color.OrangeRed, 5), 0, 0, w, h);
         // ellipse birsuru random edicez.
            for(int i=0; i<10; i++)
            {
                pen.DrawEllipse(new Pen(Color.Coral), r.Next(0, w - 5), r.Next(0, h - 5), 5, 5);
            }

            pictureBox1.Image = bmp; //image olarak bmp ayarladik.
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCaptcha();
        }
    }
}


/*
 * Neler yaptik?
 * -Load captcha methodu olusturduk.
 * -Widht ve heightini setleyerek bitmap olusturduk. 
 * -Bu bitmapi graphics kullarak cizim alanina donusturduk.
 * -Random methodu kullanarak 4 basamakli 2 char 2 rakamdan olusan string elde ettik.
 * -Random ederken char icin 65 A'nin decimal yazimini temsil ediyor. A'dan Z'ye kadar demis olduk.
 * -Hepsini toLower diyerek kucuk harfe cevirdik.
 * -graphics objesi olarak yarattigimiz pens'in icine draw string methodunu kullanarak random yarattigimiz stringi ekledik.
 * -draw string methodunda once neyi yazdiracagimizi daha sonra fontunu (onu randomize ediyoruz), boyutunu? , Style'ini(burada hepsini bir arada uyguluyor o yuzden hem ustu cizik hem alti)
 * ve en son brushini secip konumlarini? belirtiyoruz.
 * Draw rectangle da rengini, kalinligini ve konumunu belirliyoruz.
 * draw lineda ayni mantikla ilerliyor ama capraz atiyor.
 * 
 * Pen documentation;
 * pen
 * Type: System.Drawing.Pen
 * Pen that determines the color, width, and style of the ellipse.
 * 
 * x
 * Type: System.Int32
 * The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
 * 
 * y
 * Type: System.Int32
 * The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
 * 
 * width
 * Type: System.Int32
 * Width of the bounding rectangle that defines the ellipse.
 * 
 * height
 * Type: System.Int32
 * Height of the bounding rectangle that defines the ellipse.
 */
