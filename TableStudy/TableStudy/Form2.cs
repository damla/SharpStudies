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
        public Form2(String s)
        {
            InitializeComponent();
            this.Text = "WELCOME" + s.ToUpper(); // buyuk harfle stringi yazdirdik.
                                                 // this.text kisminda this formu, text ise onun paneldeki 
                                                 // text kismina yazilacagi temsil ediyor.
        }
    }
}
