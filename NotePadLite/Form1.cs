using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadLite
{
    public partial class Form1 : Form
    {

        bool isBold = false;
        bool isIralic = false;
        bool isUnderline = false;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (isUnderline) {

                this.isUnderline = false;
                toNormaize();
            } else {
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline
                  | richTextBox.SelectionFont.Style);
                this.isUnderline = true;
            }
            
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (isIralic)
            {

                this.isIralic = false;
                toNormaize();
            }
            else
            {
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic
                  | richTextBox.SelectionFont.Style);
                this.isIralic = true;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (isBold)
            {

                this.isBold = false;
                toNormaize();
            }
            else
            {
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold
                  | richTextBox.SelectionFont.Style);
                this.isBold = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toNormaize()
        {
        
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular);
            if(isBold)
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold);
            if (isIralic)
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic);
            if (isUnderline)
                this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline);
        }

    }
}
