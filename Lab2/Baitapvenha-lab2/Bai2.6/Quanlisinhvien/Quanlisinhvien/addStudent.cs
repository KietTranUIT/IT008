using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quanlisinhvien
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LOPHOC";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["id"].ToString());
            }
            reader.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string class_id = "";
            if(listBox1.SelectedIndex != -1)
            {
                class_id = listBox1.SelectedItem.ToString();
            } else
            {
                MessageBox.Show("Chua chon ma lop!");
                return;
            }

            string id = idTbox.Text;
            string name = nameTbox.Text;
            double math;
            double literature;
            double english;

            if(id == "" || name == "" || !double.TryParse(mathTbox.Text, out math) || !double.TryParse(literatureTbox.Text, out literature) || !double.TryParse(englishTbox.Text, out english))
            {
                MessageBox.Show("Nhap chua du thong tin!");
                return;
            }

            Student student = new Student(class_id);
            student.StudentId = id;
            student.FullName = name;
            student.MathScore = math;
            student.LiteratureScore = literature;
            student.EnglishScore = english;

            string insertStudentCommand = $"INSERT INTO SINHVIEN VALUES ('{student.StudentId}', '{student.Class_id}','{student.FullName}', '{student.MathScore}', '{student.LiteratureScore}', '{student.EnglishScore}', '{student.CalculateAverageScore()}')";
            string updateClassCommand = $"UPDATE LOPHOC SET number_of_student=number_of_student+1 WHERE id='{student.Class_id}'";

            try
            {
                MySqlCommand command = new MySqlCommand(insertStudentCommand, Database.conn);
                command.ExecuteNonQuery();

                command = new MySqlCommand(updateClassCommand, Database.conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Them sinh vien thanh cong!");
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Them sinh vien that bai! Sinh vien da ton tai!");
                    return;
                }
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
