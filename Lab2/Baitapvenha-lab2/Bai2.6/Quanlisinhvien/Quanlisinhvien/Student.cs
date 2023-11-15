using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien
{
    public class Student
    {
        public Student(string malop = "")
        {
            this.class_id = malop;
            student_id = "";
            full_name = "";
            math_score = 0;
            literature_score = 0;
            english_score = 0;
            average_score = 0;
        }

        public void Print()
        {
            Console.Write(class_id + "\t" + student_id + "\t" + full_name.PadRight(20) + "\t" + math_score + "\t" + literature_score + "\t" + english_score + "\t" + average_score);
        }

        public double CalculateAverageScore()
        {
            return Math.Round((math_score + english_score + literature_score) / 3, 2);
        }

        public void InputStudent()
        {
            Console.Write("Nhap ma so sinh vien: ");
            student_id = Console.ReadLine();

            Console.Write("Nhap ho ten sinh vien: ");
            full_name = Console.ReadLine();

        input_toan:
            Console.Write("Nhap diem toan: ");
            if (!double.TryParse(Console.ReadLine(), out math_score) || (math_score < 0 && math_score > 10))
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai!");
                goto input_toan;
            }

        input_van:
            Console.Write("Nhap diem van: ");
            if (!double.TryParse(Console.ReadLine(), out literature_score) || (literature_score < 0 && literature_score > 10))
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai!");
                goto input_van;
            }

        input_anh:
            Console.Write("Nhap diem anh: ");
            if (!double.TryParse(Console.ReadLine(), out english_score) || (english_score < 0 && english_score > 10))
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai!");
                goto input_anh;
            }

            average_score = CalculateAverageScore();
        }

        private string class_id;
        private string student_id;
        public string StudentId
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public string Class_id
        {
            get { return class_id; }
        }

        private string full_name;
        public string FullName
        {
            get { return full_name; }
            set { full_name = value; }
        }

        private double math_score;
        public double MathScore
        {
            get { return math_score; }
            set { math_score = value; }
        }

        private double literature_score;
        public double LiteratureScore
        {
            get { return literature_score; }
            set { literature_score = value; }
        }

        private double english_score;
        public double EnglishScore
        {
            get { return english_score; }
            set { english_score = value; }
        }

        private double average_score;
        public double AverageScore
        {
            get { return average_score; }
            set { AverageScore = value; }
        }
    }
}
