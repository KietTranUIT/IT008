using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int seed = now.Millisecond;
            Random random = new Random(seed);
            int randomNumber = random.Next(1, 10);

            switch(randomNumber)
            {
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    break;
                case 4:
                    this.BackColor = Color.Yellow;
                    break;
                case 5:
                    this.BackColor = Color.Lime;
                    break;
                case 6:
                    this.BackColor = Color.LightGray;
                    break;
                case 7:
                    this.BackColor = Color.Black;
                    break;
                case 8:
                    this.BackColor = Color.Crimson;
                    break;
                case 9:
                    this.BackColor = Color.Azure;
                    break;
                case 10:
                    this.BackColor = Color.Aqua;
                    break;
            }
        }
    }
}
