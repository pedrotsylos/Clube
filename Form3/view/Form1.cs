using Form3.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 novaform = new Form2();
            novaform.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form3 novaform = new Form3();
            novaform.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form4 novaform = new Form4();
            novaform.Show();
        }
    }
}
