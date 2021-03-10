using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3in1
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";

        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog1.FileName;
            string text = File.ReadAllText(filename2);
            richTextBox1.Text = text;
            MessageBox.Show("Файл открыт");
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}