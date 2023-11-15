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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form2 is shown event!");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form2 is closed!");
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form2 is closing...!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
