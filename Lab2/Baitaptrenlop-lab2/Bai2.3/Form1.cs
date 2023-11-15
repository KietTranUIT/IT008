using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._3
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

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            dialog.Color = this.BackColor;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dialog.Color;
            }
        }
    }
}
