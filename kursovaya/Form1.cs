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
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void visiblepassword_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            visiblepassword.Visible = false;
            button2.Visible = true;


        }

        private void log_in_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox2.Text;
            var passUser = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table  = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand comand = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = comand;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            visiblepassword.Visible = true;
            button2.Visible =false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
