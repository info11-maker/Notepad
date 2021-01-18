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

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Unitled.txt";
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Document(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open.FileName;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                this.Text = save.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                this.Text = save.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() ==DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A elaborat Mihalachi A.");
        }
    }
}
