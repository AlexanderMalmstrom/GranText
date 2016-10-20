//Version 0.1
//Date 2016-10-21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace granText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = String.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            float currentSize = mainTextBox.Font.Size;
            currentSize += 2.0F;
            mainTextBox.Font = new Font(mainTextBox.Font.Name, currentSize, mainTextBox.Font.Style, mainTextBox.Font.Unit);
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            float currentSize = mainTextBox.Font.Size;
            currentSize -= 2.0F;
            mainTextBox.Font = new Font(mainTextBox.Font.Name, currentSize, mainTextBox.Font.Style, mainTextBox.Font.Unit);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.ForeColor = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.ForeColor = Color.Blue;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.ForeColor = Color.Pink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
