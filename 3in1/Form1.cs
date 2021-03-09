using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.Show();
        }
    }
}
