using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_boln
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            //textBox_password.PasswordChar = '*';
            button_picture11.Visible = false;
            textBox_login2.MaxLength = 20;
            textBox_password2.MaxLength = 20;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (checkuser())

            {
                return;
            }
            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string querystring = $"insert into register(login_user, password_user, is_admin) values('{login}', '{password}', 0)";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успешно");
                Log_in frm_login = new Log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Аккаунт не создан", "Ошибка");
            }
            dataBase.closeConnection();

        }

        private Boolean checkuser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким именем уже существует", "Ошибка");
                return true;
            }
            else 
            {
                return false;
            }

        }

        private void button_picture11_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            button_picture22.Visible = true;
            button_picture11.Visible = false;

        }

        private void button_picture22_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            button_picture22.Visible = false;
            button_picture11.Visible = true;
        }

        private void button_Clear2_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in frm_sign = new Log_in();
            frm_sign.Show();
            this.Hide();
        }
    }
}
