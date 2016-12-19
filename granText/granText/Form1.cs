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
        public static class Globals
        {
            public static Int32 formHeight;
            public static Int32 formWidth;
        }
        public Form1()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
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
            mainTextBox.ShortcutsEnabled = true;
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

        private void hideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            if(this.Height > 63)
            {
                Globals.formHeight = this.Height;
                Globals.formWidth = this.Width;
                this.Width = 214;
                this.Height = 63;
                this.Opacity = 0.3;
            }

            else
            {
                this.Width = Globals.formWidth;
                this.Height = Globals.formHeight;
                this.Opacity = 1.0;
            }
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog MyDialog = new ColorDialog();
            // Allows the user to select or edit a custom color.
            MyDialog.AllowFullOpen = true;
            // Assigns an array of custom colors to the CustomColors property

            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = this.BackColor;
            MyDialog.ShowDialog();
            this.BackColor = MyDialog.Color;

            Console.WriteLine(MyDialog.Color);

            mainTextBox.ForeColor = MyDialog.Color;
        }


    }
}
