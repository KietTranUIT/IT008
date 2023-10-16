using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public class Coordinate
    {
        private double x;
        public double X
        {
            get { return x;}
        }
        private double y;
        public double Y
        {
            get { return y; }
        }

        public Coordinate()
        {
            double x, y;

        input_x:
            Console.Write("Nhap vao x: ");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Nhap x khong hop le! Vui long nhap lai x");
                goto input_x;
            }

            this.x = x;

        input_y:
            Console.Write("Nhap vao y: ");
            if (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Nhap y khong hop le! Vui long nhap lai y");
                goto input_y;
            }

            this.y = y;
        }


        public string Print()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
