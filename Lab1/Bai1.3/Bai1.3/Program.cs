using System;

namespace Bai1._3
{
    class Program
    {
        static int MaxInt(int[] int_numbers)
        {
            if(int_numbers.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for(int i = 0; i < int_numbers.Length; i++)
            {
                if(int_numbers[index] < int_numbers[i])
                {
                    index = i;
                }
            }
            return index;
        }

        static int MinInt(int[] int_numbers)
        {
            if (int_numbers.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for (int i = 0; i < int_numbers.Length; i++)
            {
                if (int_numbers[index] > int_numbers[i])
                {
                    index = i;
                }
            }
            return index;
        }

        static int MaxDouble(double[] double_numbers)
        {
            if (double_numbers.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for (int i = 0; i < double_numbers.Length; i++)
            {
                if (double_numbers[index] < double_numbers[i])
                {
                    index = i;
                }
            }
            return index;
        }

        static int MinDouble(double[] double_numbers)
        {
            if (double_numbers.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for (int i = 0; i < double_numbers.Length; i++)
            {
                if (double_numbers[index] > double_numbers[i])
                {
                    index = i;
                }
            }
            return index;
        }

        static int MaxString(string[] strs)
        {
            if (strs.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[index].Length < strs[i].Length)
                {
                    index = i;
                }
            }
            return index;
        }

        static int MinString(string[] strs)
        {
            if (strs.Length == 0)
            {
                return -1;
            }

            int index = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[index].Length > strs[i].Length)
                {
                    index = i;
                }
            }
            return index;
        }


        static void Main(string[] args)
        {
            int[] int_numbers;
            int n_integer;

            input_n_integer:
            Console.Write("Nhap so phan tu mang so nguyen: ");
            if(!int.TryParse(Console.ReadLine(), out n_integer))
            {
                Console.WriteLine("Nhap khong hop le! Vui long nhap lai!");
                goto input_n_integer;
            }
            int_numbers = new int[n_integer];

            Console.WriteLine("Nhap phan tu cho mang so nguyen: ");
            for(int i = 0; i < n_integer; i++)
            {
                int_numbers[i] = int.Parse(Console.ReadLine());
            }

            int max_int = MaxInt(int_numbers);
            Console.WriteLine("So lon nhat trong day so nguyen la: " + int_numbers[max_int]);
            int min_int = MinInt(int_numbers);
            Console.WriteLine("So nho nhat trong day so nguyen la: " + int_numbers[min_int]);

            double[] double_numbers;
            int n_double;

        input_n_double:
            Console.Write("Nhap so phan tu mang so thuc: ");
            if (!int.TryParse(Console.ReadLine(), out n_double))
            {
                Console.WriteLine("Nhap khong hop le! Vui long nhap lai!");
                goto input_n_double;
            }
            double_numbers = new double[n_integer];
            Console.WriteLine("Nhap phan tu cho mang so thuc: ");
            for (int i = 0; i < n_double; i++)
            {
                double_numbers[i] = double.Parse(Console.ReadLine());
            }
            int max_double = MaxDouble(double_numbers);
            Console.WriteLine("So lon nhat trong day so thuc la: " + double_numbers[max_double]);
            int min_double = MinDouble(double_numbers);
            Console.WriteLine("So nho nhat trong day so thuc la: " + double_numbers[min_double]);

            string[] strs;
            int n_string;

        input_n_string:
            Console.Write("Nhap so phan tu mang chuoi: ");
            if (!int.TryParse(Console.ReadLine(), out n_string))
            {
                Console.WriteLine("Nhap khong hop le! Vui long nhap lai!");
                goto input_n_string;
            }
            strs = new string[n_string];
            Console.WriteLine("Nhap phan tu cho mang chuoi: ");
            for (int i = 0; i < n_string; i++)
            {
                strs[i] = Console.ReadLine();
            }
            int max_string = MaxString(strs);
            Console.WriteLine("Chuoi dai nhat trong day chuoi la: " + strs[max_string]);
            int min_string = MinString(strs);
            Console.WriteLine("Chuoi ngan nhat trong day chuoi la: " + strs[min_string]);
        }
    }
}
