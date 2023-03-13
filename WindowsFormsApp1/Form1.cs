using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string fname = openFileDialog1.FileName;
            if (fname == "")
                return;

            ReadText(fname);
        }

        private void ReadText (string fname)
        {
            StreamReader str = File.OpenText(fname);
            string stroc = str.ReadLine();
            richTextBox1.Text = stroc;

            while (stroc != null)
            {
                stroc = str.ReadLine();
                richTextBox1.Text += stroc + "\n";
            }
            str.Close();
        }

    }
}
