using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace OpenFileDeleteFile
{
    public partial class FileInfo : UserControl
    {
        public FileInfo()
        {
            InitializeComponent();
        }

        private void FileInfo_Load(object sender, EventArgs e)
        {

        }
        public bool CHECKED
        {
            get { return checkBox1.Checked; } //checkboxin isaretli olup olmamasini ceviriyor
            set { checkBox1.Checked = value; } //checkboxin durumunu set ediyoruz.
        }

        public String FILENAME //secilen file ismi
        {
            get { return linkLabel3.Text; }
            set { linkLabel3.Text = value; }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel3.Text); //isme tiklandiginda o dizini acmasi icin

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void Delete()
        {
            File.Delete(linkLabel3.Text);
            checkBox1.Enabled=linkLabel1.Enabled
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this file?", "Sure?", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                Delete();
            }
        }
    }
}
