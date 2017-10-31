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

namespace Teacher_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;" +
                "pwd=;database=teacher app;");
        MySqlDataAdapter adapter;

        DataTable table = new DataTable();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `professor` WHERE `username` = '" + Username.Text + "' AND `password` = '" + Password.Text + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                LoginCheck.ForeColor = Color.Red;
                LoginCheck.Text = "Username Or Password Are Invalid";
            }
            else
            {
                LoginCheck.ForeColor = Color.Green;
                LoginCheck.Text = "Login Successfully";
                this.Hide();
                Form1 F2 = new Form1();
                F2.ShowDialog();
                this.Close();

            }

            table.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
