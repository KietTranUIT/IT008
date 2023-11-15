using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form 1 is loading...!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form 1 is closed!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form 1 is closing!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Hide();
        }
    }
}
