using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien
{
    public class ClassRoom
    {
        private string class_id;
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        private int total_students;
        public int TotalStudent
        {
            get { return total_students; }
            set { total_students = value; }
        }
        private List<Student> students;

        public ClassRoom(string class_id = "")
        {
            this.class_id = class_id;
            total_students = 0;
            students = new List<Student>();
        }

        public void LoadDataFromFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Student student = new Student(class_id);

                        student.StudentId = sr.ReadLine();
                        student.FullName = sr.ReadLine();
                        student.MathScore = double.Parse(sr.ReadLine());
                        student.LiteratureScore = double.Parse(sr.ReadLine());
                        student.EnglishScore = double.Parse(sr.ReadLine());
                        student.AverageScore = student.CalculateAverageScore();
                        students.Add(student);
                        total_students++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Khong the doc file");
                Console.WriteLine(e);
            }
        }

        public void LoadDataIntoFile(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                //file.Create();
                using (StreamWriter sw = file.CreateText())
                {
                    foreach (Student student in students)
                    {
                        sw.WriteLine(student.StudentId);
                        sw.WriteLine(student.FullName);
                        sw.WriteLine(student.MathScore);
                        sw.WriteLine(student.LiteratureScore);
                        sw.WriteLine(student.EnglishScore);
                    }
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public Student SearchStudentFollowMSSV(string student_id)
        {
            foreach (Student student in students)
            {
                if (student_id == student.StudentId)
                {
                    return student;
                }
            }
            return null;
        }

        public List<Student> SearchStudentFollowName(string name)
        {
            List<Student> ls = new List<Student>();
            foreach (Student student in students)
            {
                if (student.FullName.Contains(name))
                {
                    ls.Add(student);
                }
            }
            return ls;
        }

        public List<Student> SearchStudentFollowDTB(double average)
        {
            List<Student> ls = new List<Student>();
            foreach (Student student in students)
            {
                if (student.AverageScore == average)
                {
                    ls.Add(student);
                }
            }
            return ls;
        }

        public bool AddStudent(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Student student = new Student(class_id);
                student.InputStudent();
                students.Add(student);
            }
            return true;
        }

        public int IndexStudent(string student_id)
        {
            int index = 0;
            foreach (Student student in students)
            {
                if (student.StudentId == student_id)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public void RemoveStudent(string student_id)
        {
            int index = -1;
            if ((index = IndexStudent(student_id)) == -1)
            {
                return;
            }


            students.RemoveAt(index);
        }

        public double MaxAverageScore()
        {
            double max_score = 0;
            foreach (Student student in students)
            {
                if (max_score < student.AverageScore)
                {
                    max_score = student.AverageScore;
                }
            }
            return max_score;
        }
    }
}
