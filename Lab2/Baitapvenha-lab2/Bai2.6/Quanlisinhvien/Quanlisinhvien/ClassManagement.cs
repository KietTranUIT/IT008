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
    public partial class ClassManagement : Form
    {
        public List<ClassRoom> ls = new List<ClassRoom>();
        public ClassManagement()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddClass add = new AddClass();
            add.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveClass rm = new RemoveClass();
            rm.Show();
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LOPHOC";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ClassRoom cl = new ClassRoom();
                cl.ClassId = reader["id"].ToString();
                cl.TotalStudent = Convert.ToInt32(reader["number_of_student"]);
                ls.Add(cl);
            }
            reader.Close();

            foreach(ClassRoom cl in ls)
            {
                ListViewItem item = new ListViewItem(cl.ClassId);
                item.SubItems.Add(cl.TotalStudent.ToString());
                listView1.Items.Add(item);
            }

        }

        private void ClassManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ls.Clear();
            listView1.Items.Clear();
            string query = "SELECT * FROM LOPHOC";
            MySqlCommand command = new MySqlCommand(query, Database.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ClassRoom cl = new ClassRoom();
                cl.ClassId = reader["id"].ToString();
                cl.TotalStudent = Convert.ToInt32(reader["number_of_student"]);
                ls.Add(cl);
            }
            reader.Close();

            foreach (ClassRoom cl in ls)
            {
                ListViewItem item = new ListViewItem(cl.ClassId);
                item.SubItems.Add(cl.TotalStudent.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
