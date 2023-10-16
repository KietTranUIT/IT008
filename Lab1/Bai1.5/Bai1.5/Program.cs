using System;
using System.IO;

namespace Bai1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao duong dan den thu muc: ");
            string path = Console.ReadLine();

            try
            {
                string[] files = Directory.GetFiles(path);

                Console.WriteLine("Danh sach tep tin trong thu muc " + path + ":");
                for(int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(++i + ". " + files[i]);
                }
            } catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Thu muc '" + path + "' khong ton tai!");
            }
        }
    }
}
