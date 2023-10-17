using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bai1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool exit = false;
            //while (!exit)
            //{
            //    Console.WriteLine("1. Random nhiet do.");
            //    Console.WriteLine("0. Thoat.");
            //    string s = Console.ReadLine();
            //    switch (s)
            //    {
            //        case "1":
            //            nhietke n = new nhietke();
            //            manhinh m = new manhinh();
            //            Random r = new Random();
            //            n.tchanged += m.Innhietdo;
            //            n.T = r.Next(1, 101);
            //            n.tchanged += m.Innhietdo;
            //            break;

            //        case "0":
            //            exit = true;
            //            break;
            //}
            //}

            int i = 0;
            Random r = new Random((int)DateTime.Now.Ticks);
            while (true)
            {
                nhietke n = new nhietke();
                manhinh m = new manhinh();
                
                //n.T = r.Next(1, 101);
                n.tchanged += m.Innhietdo;
                n.T = r.Next(1, 101);
                i++;
                Thread.Sleep(2000);
            }
            
        }
    }
}