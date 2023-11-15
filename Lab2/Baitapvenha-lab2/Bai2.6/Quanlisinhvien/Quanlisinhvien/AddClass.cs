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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string idClass = idTbox.Text;

            string insertClassCommand = $"INSERT INTO LOPHOC VALUES ('{idClass}', '0')";

            try
            {
                MySqlCommand command = new MySqlCommand(insertClassCommand, Database.conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Them lop hoc thanh cong!");
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                idTbox.Text = "";
                if(ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Them lop that bai! Ma lop da ton tai!");
                    return;
                }
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
