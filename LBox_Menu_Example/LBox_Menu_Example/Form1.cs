using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBox_Menu_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int number = r.Next(100, 500); //[100,500)
            listNumbers.Items.Add(number); //Adding the random number into the list when button clicked.
        }

        private void listNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(listNumbers.SelectedItem);
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is third lecture of ms c#");
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listNumbers.SelectedIndex != -1) //Checking if nothing is selected
                listNumbers.Items.RemoveAt(listNumbers.SelectedIndex);
        }
        object o; //object created to save info.

        private void cUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listNumbers.SelectedIndex != -1)
            {
                o = listNumbers.SelectedItem; //copied the item to o object.
                listNumbers.Items.RemoveAt(listNumbers.SelectedIndex); //deleted the item.
            }
        }
        private void cOPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o = listNumbers.SelectedItem;
        }

        private void pASTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (o != null)
            listNumbers.Items.Add(o);
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNumbers();
            Application.Exit();
            
        }
        public void SaveNumbers()
        {
            if (listNumbers.Items.Count > 0)
            {
                DialogResult r = MessageBox.Show("Do you want to save the list?", "Save?", MessageBoxButtons.YesNoCancel); //Ask the user to save first
                if (r == System.Windows.Forms.DialogResult.No)
                    listNumbers.Items.Clear();
                else if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                }
            }
        }
        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listNumbers.Items.Count<=0)
                MessageBox.Show("Can not save empty list.");
            else
            SaveNumbers();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNumbers();
            listNumbers.Items.Clear(); //reset the list
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNumbers();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }
    }
}
