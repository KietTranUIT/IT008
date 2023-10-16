using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public class Rectangle:Shape
    {
        public Rectangle()
        {
            name = "Rectangle - Hinh chu nhat";
            feature = "1. Hinh chu nhat co bon goc vuong (goc 90 do)\n" +
                      "2. Hinh chu nhat co bon canh, hai canh song song co cung do dai va hai canh con lai cung co cung do dai\n" +
                      "3. Hinh chu nhat co hai truc doi xung, moi truc di qua trung diem cua hai canh song song\n";
        }
        public override void Input()
        {
            Console.WriteLine("Nhap toa do diem goc ben trai tren cung cua hinh chu nhat");
            top_left_corner = new Coordinate();

        input_width:
            Console.Write("Nhap chieu rong: ");
            if(!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Nhap chieu rong khong hop le! Vui long nhap lai!");
                goto input_width;
            }

        input_length:
            Console.Write("Nhap chieu dai: ");
            if(!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Nhap chieu dai khong hop le! Vui long nhap lai!");
                goto input_length;
            }

            Console.WriteLine("Nhap du lieu thanh cong!");
        }

        public override double Area()
        {
            return width * length;
        }

        public override void Draw()
        {
            Console.WriteLine("* Ten hinh: " + name);
            Console.WriteLine("* Vi tri: ");
            Console.WriteLine("Goc tren ben trai: " + top_left_corner.Print());
            Console.WriteLine("Goc tren ben phai: " + "(" + (top_left_corner.X + length) + ", " + top_left_corner.Y + ")");
            Console.WriteLine("Goc duoi ben trai: " + "(" + top_left_corner.X + ", " + (top_left_corner.Y - width) + ")");
            Console.WriteLine("Goc duoi ben phai: " + "(" + (top_left_corner.X + length) + ", " + (top_left_corner.Y - width) + ")");
            Console.WriteLine("* Tinh chat: ");
            Console.Write(feature);

        }

        protected Coordinate top_left_corner;
        private double width, length;

    }
}
