using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public class Square:Rectangle
    {
        public Square()
        {
            name = "Square - Hinh vuong";
            feature = "1. Hinh vuong co bon canh co do dai bang nhau\n" +
                      "2. Hinh vuong co bon goc vuong\n";
        }

        public override void Input()
        {
            Console.WriteLine("Nhap toa do diem goc ben trai tren cung cua hinh vuong");
            top_left_corner = new Coordinate();

        input_side:
            Console.Write("Nhap canh: ");
            if (!double.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Nhap canh khong hop le! Vui long nhap lai!");
                goto input_side;
            }

            Console.WriteLine("Nhap du lieu thanh cong!");
        }

        public override double Area()
        {
            return side * side;
        }

        public override void Draw()
        {
            Console.WriteLine("* Ten hinh: " + name);
            Console.WriteLine("* Vi tri: ");
            Console.WriteLine("Goc tren ben trai: " + top_left_corner.Print());
            Console.WriteLine("Goc tren ben phai: " + "(" + (top_left_corner.X + side) + ", " + top_left_corner.Y + ")");
            Console.WriteLine("Goc duoi ben trai: " + "(" + top_left_corner.X + ", " + (top_left_corner.Y - side) + ")");
            Console.WriteLine("Goc duoi ben phai: " + "(" + (top_left_corner.X + side) + ", " + (top_left_corner.Y - side) + ")");
            Console.WriteLine("* Tinh chat: ");
            Console.Write(feature);
        }

        private double side;
    }
}
