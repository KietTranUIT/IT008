using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public class Triangle:Shape
    {
        public Triangle()
        {
            name = "Triangle - Hinh tam giac";
            feature = "1. Hinh tam giac co ba canh, moi canh noi hai diem cua hinh tam giac\n" +
                      "2. Hinh tam giac co ba diem, moi diem la dinh giao nhau cua hai canh hinh tam giac\n" +
                      "3. Tong cac goc trong hinh tam giac bang 180 do\n";
        }
        public override void Input()
        {
            Console.WriteLine("Nhap toa do diem thu nhat");
            a = new Coordinate();

            Console.WriteLine("Nhap toa do diem thu hai");
            b = new Coordinate();

            Console.WriteLine("Nhap toa do diem thu ba");
            c = new Coordinate();

            Console.WriteLine("Nhap du lieu thanh cong!");
        }

        public override double Area()
        {
            return 0.5 * Math.Abs(a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y));
        }

        public override void Draw()
        {
            Console.WriteLine("* Ten hinh: " + name);
            Console.WriteLine("* Vi tri: ");
            Console.WriteLine("Toa do diem thu nhat la: " + a.Print());
            Console.WriteLine("Toa do diem thu hai la: " + b.Print());
            Console.WriteLine("Toa do diem thu ba la: " + c.Print());
            Console.WriteLine("* Tinh chat:");
            Console.Write(feature);

        }

        private Coordinate a, b, c;
    }
}
