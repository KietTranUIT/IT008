using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Ban vua an mot phim tren ban phim!");

            DateTime current = DateTime.Now;

            string str = $"Form Keypress | Character is '{(char)e.KeyCode}' and Code is {(int)e.KeyCode}  pressed at '{current}'";
            MessageBox.Show(str);

            string filePath = @"C:\Users\FShop\Documents\Tailieumonhoc\Laptrinhtrucquan\thuchanh\Lab3\Lab3\keyboard";

            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(str);
                    writer.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Co loi xay ra! Loi: " + error.Message);
            }
        }
    }
}
