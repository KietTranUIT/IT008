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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string id = idTbox.Text;

            if(id == "")
            {
                MessageBox.Show("MSSV khong hop le!");
                return;
            }

            string query = $"SELECT * FROM SINHVIEN WHERE id='{id}'";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                class_idTbox.Text = reader["class_id"].ToString();
                nameTbox.Text = reader["name"].ToString();
                mathTbox.Text = reader["math"].ToString();
                literatetureTbox.Text = reader["literateture"].ToString();
                englishTbox.Text = reader["english"].ToString();

            }
            reader.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            double average = (double.Parse(mathTbox.Text) + double.Parse(literatetureTbox.Text) + double.Parse(englishTbox.Text)) / 3;
            string updateStudentCommand = $"UPDATE SET id='{idTbox.Text}', class_id='{class_idTbox.Text}', name='{nameTbox.Text}', math='{mathTbox.Text}', literature='{literatetureTbox.Text}', english='{englishTbox.Text}', average='{average}' FROM SINHVIEN ";
            
            try
            {
                MySqlCommand command = new MySqlCommand(updateStudentCommand, Database.conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Chỉnh sửa thành công");

            } catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void UpdateStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentManagement st = new StudentManagement();
            st.Show();
        }
    }
}
