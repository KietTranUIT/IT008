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
    public partial class StudentManagement : Form
    {
        public List<Student> ls = new List<Student>();
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addStudent st = new addStudent();
            st.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveStudent rm = new RemoveStudent();
            rm.Show();
        }

        private void StudentManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            UpdateStudent st = new UpdateStudent();
            st.Show();
            this.Hide();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SINHVIEN";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["class_id"].ToString());
                item.SubItems.Add(reader["id"].ToString());
                item.SubItems.Add(reader["name"].ToString());
                item.SubItems.Add(reader["math"].ToString());
                item.SubItems.Add(reader["literateture"].ToString());
                item.SubItems.Add(reader["english"].ToString());

                listView1.Items.Add(item);
            }
            reader.Close();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT * FROM SINHVIEN";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["class_id"].ToString());
                item.SubItems.Add(reader["id"].ToString());
                item.SubItems.Add(reader["name"].ToString());
                item.SubItems.Add(reader["math"].ToString());
                item.SubItems.Add(reader["literateture"].ToString());
                item.SubItems.Add(reader["english"].ToString());

                listView1.Items.Add(item);
            }
            reader.Close();
        }
    }
}
