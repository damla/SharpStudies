﻿using System;
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
 */