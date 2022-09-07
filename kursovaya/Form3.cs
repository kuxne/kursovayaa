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

namespace kursovaya
{
    public partial class Form3 : Form
    {
        DataBase dataBase = new DataBase();
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.UseSystemPasswordChar = false;
            button2.Visible = false;
            visiblepassword.Visible = true;
        }

        private void visiblepassword_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            button2.Visible = true;
            visiblepassword.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var login = textBox2.Text;
            var password = textBox1.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand comand = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();

            if(comand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in log_In = new log_in();
                this.Hide();
                log_In.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnection();
        }


        private Boolean checkuser()
        {
            var loginUser = textBox2.Text;
            var passUser = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand comand = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = comand;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;

            }
            else
            {
               return false;
            }
        }
    }
}
 