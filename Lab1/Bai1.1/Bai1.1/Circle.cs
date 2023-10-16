using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public class Circle:Shape
    {
        public Circle()
        {
            name = "Circle - Hinh tron";
            feature = "1. Hinh tron co mot duong vien dong tam, tuc la cac diem tren duong vien cach tam cua hinh tron cung mot khoang cach\n" +
                      "2. Hinh tron co mot tam doi xung la diem nam o trung tam cua no\n";
                      
        }
        public override void Input()
        {
            Console.WriteLine("Nhap toa do tam cua hinh tron");
            center = new Coordinate();

        input_radius:
            Console.WriteLine("Nhap ban kinh: ");
            if(!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Nhap ban kinh khong hop le! Vui long nhap lai!");
                goto input_radius;
            }

            Console.WriteLine("Nhap du lieu thanh cong!");
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine("* Ten hinh: " + name);
            Console.WriteLine("* Vi tri: ");
            Console.WriteLine("Tam cua hinh tron " + center.Print() + " voi ban kinh la: " + radius);
            Console.WriteLine("* Tinh chat: ");
            Console.Write(feature);
        }

        private Coordinate center;
        private double radius;
    }
}
