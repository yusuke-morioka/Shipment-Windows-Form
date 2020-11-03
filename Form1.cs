using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            end1 e1 = new end1();
            e1.ShowDialog();
            this.Close();
        }
    }
}
