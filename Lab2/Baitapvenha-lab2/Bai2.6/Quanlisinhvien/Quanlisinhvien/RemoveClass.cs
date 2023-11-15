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
    public partial class RemoveClass : Form
    {
        public RemoveClass()
        {
            InitializeComponent();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string idClass = idTbox.Text;

            string insertClassCommand = $"DELETE FROM LOPHOC WHERE id='{idClass}'";

            try
            {
                MySqlCommand command = new MySqlCommand(insertClassCommand, Database.conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Xoa lop hoc thanh cong!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            this.Close();
        }
    }
}
