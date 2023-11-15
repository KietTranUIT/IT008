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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string id = idTbox.Text;
            if(id == "")
            {
                MessageBox.Show("MSSV khong ton tai!");
                return;
            }
            string removeCommand = $"DELETE FROM SINHVIEN WHERE id='{id}'";

            try
            {
                MySqlCommand command = new MySqlCommand(removeCommand, Database.conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Xoa sinh vien thanh cong!");
                this.Close();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
        }
    }
}
