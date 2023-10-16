using System;
using System.Collections.Generic;

namespace Bai1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

        input_n:
            Console.Write("Nhap n: ");
            if(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Nhap n khong hop le! Vui long nhap lai!");
                goto input_n;
            }

            List<Shape> shapes = new List<Shape>();
            int rand_number;
            Random random = new Random((int)DateTime.Now.Ticks);
            for(int i = 0; i < n; i++)
            {
                rand_number = random.Next(1, 5);
                Shape shape;
                switch (rand_number)
                {
                    case 1:
                        shape = new Rectangle();
                        shape.Input();
                        shapes.Add(shape);
                        break;
                    case 2:
                        shape = new Square();
                        shape.Input();
                        shapes.Add(shape);
                        break;
                    case 3:
                        shape = new Circle();
                        shape.Input();
                        shapes.Add(shape);
                        break;
                    case 4:
                        shape = new Triangle();
                        shape.Input();
                        shapes.Add(shape);
                        break;
                }
            }

            int count = 0;
            foreach(Shape shape in shapes)
            {
                Console.WriteLine("----------Hinh thu " + (++count) + "-------------");
                shape.Draw();
                Console.WriteLine("Dien tich: " + shape.Area());
            }
        }
    }
}
