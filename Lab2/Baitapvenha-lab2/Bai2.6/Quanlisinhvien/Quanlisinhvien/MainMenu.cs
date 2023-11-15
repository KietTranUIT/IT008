using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlisinhvien
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            string myConnectionString = "SERVER=127.0.0.1;UID=root;" + "PASSWORD=root;DATABASE=QuanLiSinhVien";
            try
            {
                Database.conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                //conn.ConnectionString = myConnectionString;
                Database.conn.Open();
                MessageBox.Show("Ket noi den co so du lieu thanh cong thanh cong!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Ket noi den co so du lieu that bai! Loi: " + ex.Message);
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Database.conn.Close();
                MessageBox.Show("Dong ket noi co so du lieu thanh cong!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            ClassManagement cl = new ClassManagement();
            this.Hide();
            cl.Show();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentManagement st = new StudentManagement();
            this.Hide();
            st.Show();
        }
    }
}
