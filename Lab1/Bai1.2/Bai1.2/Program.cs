using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._2
{
        public static class Program
        {
            public static void Main()
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Menu :");
                    Console.WriteLine("1. Tinh toan +, -, *, / 2 phan so. ");
                    Console.WriteLine("2. Doi phan so sang so thuc.");
                    Console.WriteLine("3. Sap xep 1 mang phan so.");
                    Console.WriteLine("0. Thoat.");
                    Console.WriteLine("Nhap lua chon cua ban");
                    string select = Console.ReadLine();
                    switch (select)
                    {
                        case "1":
                            PhanSo a = new PhanSo();
                            PhanSo b = new PhanSo();
                            Console.WriteLine("Nhap phan so thu I:");
                            a.Nhap();
                            Console.WriteLine("Nhap phan so thu II:");
                            b.Nhap();
                            Console.WriteLine("Ket qua:");

                            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + "{0}", a + b);
                            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + "{0}", a - b);
                            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + "{0}", a * b);
                            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + "{0}", a / b);
                            break;

                        case "2":
                            PhanSo c = new PhanSo();
                            Console.WriteLine("Nhap phan so can doi");
                            c.Nhap();
                            Console.WriteLine((double)c);
                            break;

                        case "3":
                            int l;
                            Console.WriteLine("Nhap so phan tu cua mang:");
                            l = int.Parse(Console.ReadLine());
                            PhanSo[] d = new PhanSo[l];
                            int i = 0;
                            while (i < l)
                            {
                                Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                                d[i] = new PhanSo();
                                d[i].Nhap();
                                i++;
                            }
                            Console.WriteLine("Sap xep mang.....");
                            Console.WriteLine("Ket qua");
                            Array.Sort(d);
                            foreach (PhanSo x in d)
                            {
                                Console.WriteLine(x.ToString());
                            }
                            break;

                        case "0":
                            Console.WriteLine("Thoat chuong trinh");
                        exit = true;
                            break;

                        default:
                            Console.WriteLine("Lua chon khong hop le, vui long chon lai.");
                            break;
                    }
                }
            }
        }
    }
