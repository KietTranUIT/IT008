using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._4
{
    public partial class Form1 : Form
    {
        private Random r1, r2;
        private string paintTxt;
        private Point paintLoc;
        public Form1()
        {
            InitializeComponent();
        }

       

        protected override void OnMouseClick(MouseEventArgs e)
        {
            paintLoc = new Point(r1.Next(0, Width), r2.Next(0, Height));
            Graphics g = this.CreateGraphics();
            Font v = new Font("Time New Roman", 22);
            Brush b = Brushes.Black;
            g.DrawString(paintTxt, v, b, paintLoc);
            g.Dispose();
            //Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r1 = new Random();
            r2 = new Random();
            paintTxt = "Paint Event";
            paintLoc = new Point(0, 0);
        }
    }
}
