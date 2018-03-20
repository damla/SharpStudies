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
            for (int i = 0; i <= lvInfo.SelectedItems.Count; i++)
            {
                cols[0] = lvInfo.SelectedItems[i].SubItems[0].Text; //Yeni yaratilan sutunlarimizin herbiri icin sirasiyla kopyaladigimiz name'leri cektik.
                cols[1] = lvInfo.SelectedItems[i].SubItems[1].Text;//addressleri cektik.
                cols[2] = lvInfo.SelectedItems[i].SubItems[2].Text;//ageleri cektik.

                ListViewItem lvi = new ListViewItem(cols);
                lvInfo.Items.Add(lvi);
            }
        }
    }
}

/* Listbox bunun scrollable halidir.
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
 */
