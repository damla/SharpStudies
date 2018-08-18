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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] columns = { "name-" + lvInfo.Items.Count, "address", "age" }; // count otomatik olarak item sayisimi dokuyor. (her cagrildiginda artacak)
                                                                                   // burada ekleyeceklerimiz colon olarak ekleniyor.

            ListViewItem row = new ListViewItem(columns); // ListViewItem olusturduk. Her satir(row) ekledigimizde columns 
                                                          // string arrayindeki stringleri sira ile cagiracak.

            lvInfo.Items.Add(row); // ListView'imiza eklemis olduk.
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = lvInfo.SelectedIndices.Count - 1; i >= 0; i--) // -1 olmasinin sebebi bize index lazim yani sifira kadar gidebilmeli.
            {
                lvInfo.Items.RemoveAt(lvInfo.SelectedIndices[i]); // sectigi index kadarini sildik.
            }
        }

        private void dUPLICATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] cols = new String[3];
            for (int i = 0; i < lvInfo.SelectedItems.Count; i++)
            {
                cols[0] = lvInfo.SelectedItems[i].SubItems[0].Text; // Yeni yaratilan sutunlarimizin herbiri icin sirasiyla kopyaladigimiz name'leri cektik.
                cols[1] = lvInfo.SelectedItems[i].SubItems[1].Text; // addressleri cektik.
                cols[2] = lvInfo.SelectedItems[i].SubItems[2].Text; // ageleri cektik.

                ListViewItem lvi = new ListViewItem(cols);
                lvInfo.Items.Add(lvi);
            }
        }

        int index = -1;
        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; // update'e tikladigimiz gibi groupBox1 gorunur olucak.

            textBox1.Text = lvInfo.SelectedItems[0].SubItems[0].Text; // textboxtan name aldik [aciklamaya bak]
            textBox2.Text = lvInfo.SelectedItems[0].SubItems[1].Text; // address aldik.
            textBox3.Text = lvInfo.SelectedItems[0].SubItems[2].Text; // age aldik.
              index = lvInfo.SelectedIndices[0]; // indexi update edilene kadar -1 tuttuk. Edilince de secilen ilk itemin
                                               // indexine esitledik.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            lvInfo.Items[index].SubItems[0].Text = textBox1.Text; // Name updatelendi.
            lvInfo.Items[index].SubItems[1].Text = textBox2.Text; // Address updatelendi.
            lvInfo.Items[index].SubItems[2].Text = textBox3.Text; // Age updatelendi.
        }

        private void lOGINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = lvInfo.SelectedItems[0].SubItems[0].Text; // ilk secilen itemin(cunku tek kisi login edilebilir)
                                                                    // name subitemini cektik.
            Form2 f = new Form2(name); // name'i yerlestirdik.
            f.ShowDialog();
            //f.Visible = true; da yapilabilir ama bu sekilde Form1 disable olmuyor.
        }
    }
}

/* Listbox bunun scrollable halidir.
 * 
 * GroupBox1'i invisible yaotik. Ilerde update fonksiyonu cagrildiginda visible'a donucek.
 * 
 * button1 click methodunda oncelikle colonlarimizda olucak bilgileri yazip atdindan onlari list view
 * itemi yaratip icine ekledik. Daha sonra bu itemi list viewimize ekledik. Itemi satir(row) olarak dusunebiliriz.
 * 
 * Bu asamalardan sonra listview sag ustundeki oktan ayarini details'e cevirdik. Daha sonra Sutunlarini(column)
 * ekledik. (NAME|ADDRESS|AGE)
 * 
 * Listview icin ozelliklerden gorunum kismindaki GridLines(cizgiler) ve FullRowSelect(butun satiri seciyor) ayarlarini true yaptik.
 * Simdi update,login ve delete gibi ayarlarin yapilabilmesi icin context menu strip ekliyoruz.
 * 
 * DELETE: Burada birden fazla item silinebilecegi dusunulerek silerken ilk index kaymasini engellemek icin
 * sondan basa dogru for dongusunu saydirarak siliyoruz. 0. indexe kadar gelebilmesi icin sayisi -1 yaptik.
 * 
 * DUPLICATE: Yeni koyacagimiz sutunlari temsilen cols adinda bir 3 elemanli string arrayi olusturduk.
 * Daha sonra neyi sectiysek onu duplicate edip yerlestirebilmemiz icin for dongusu olusturduk. Satir 
 * sayisi yine 1'den fazla olabilecegi icin selected items'a(selected indices'de kullanilabilir) kadar saydirdik. 
 * DIKKAT! Burada selected indices degil items kullandik cunku itemlarin icindeki stringleri kopyalayacagiz. 
 * Cols yani yeni columnlarimizi olusturacak string dizimize tek tek kopyaladiklarimizi eklemeye basliyoruz.
 * ornek: cols[0]=lvInfo.SelectedItems[i].SubItems[0].Text; derken ilk sutun olan name sutununu yaratiyoruz.
 * SelectedItems[i].SubItems[0] dedigimizde, 0.indexten baslayarak secilen itemleri dolasip icindeki 0. subitemleri buluyoruz.
 * Yani, secilen butun listview itemlerinin 0.columnuna denk gelen rowlarini cekiyoruz. String arrayimize bunlari
 * cektikten sonra listview itemi olusturup icine cols koyduk ardindan o itemi listview'imiza ekledik.
 * 
 * UPDATE: Indeximizi method disinda -1 olarak olusturduk. Tiklandiginda gorunur olabilmesi icin basta false ayarladigimiz
 * group box1'in visibilitysini true yaptik. Burada digerlerinden farkli olarak tek bir item update etmesine izin
 * veriyoruz. O sebeple selectedItemsin sifirinci indeksini sadece aldiriyoruz. Olusturdugumuz indexi update edene 
 * kadar -1 tutuyoruz. Update edilme sirasinda secilen indexlerin ilk elemaninin indeksini ona setliyoruz. Bu sekilde
 * button 2'ye bastigimizda update etmesini saglayacagiz. Eger birsey secili degilse -1 oldugu icin guncelleyemeyecektir.
 * Textboxlara suanda bulunan itemleri yazdirdik. Buttona basinca yenileri yazicaz.
 * 
 * btnUpdate:groupBox gorunurlugunu yine false yapiyoruz cunku sadece ustune sag tiklayip contextStripten UPDATE sectigimizde
 * bu textboxlarin gorunur olmasi gerekiyor. Button'tiklandiginda eger index -1'se hicbirseyi updateleyemeyecek.  Fakat eger index
 * guncellenecek iteme gore set edildiyse, indexteki item secilecek ve textBoxtaki yeni yazilan bilgileri yine sub itemlere atayacak.
 * Bu arada items[index] seklinde tek bir itemin indexini secmemiz yeterli oldu cunku bitek o degistirilecek.
 * 
 * LOGIN: [Sinava dahil degil] name adinda bi string olusturup hangi iteme tikladiysak onun name sub itemini cektik. Daha sonra yeni 
 * form yaratip onun parametre kismina string ekledik boylece olusurken direk name yazip yeni acilan pencerede giris yapan kisminin ismi 
 * yazacak. En son f.ShowDialog(); methodu ile formu gosterdik ve alttaki formu disable ettik.
 */
