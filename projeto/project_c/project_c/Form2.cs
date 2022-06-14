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

namespace project_c
{
    public partial class LoginForm : Form
    {
        SqlConnection cnn;
        string email = "";
        string password = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.email = email_input.Text;
        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {
            this.password = password_input.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            cmd = new SqlCommand("login_user", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", this.email);
            cmd.Parameters.Add("@password", this.password);

            reader = cmd.ExecuteReader();
            string res = "";
            while(reader.Read())
            {
                res += reader["ID_utilizador"];
            }

            if(res == "")
            {
                MessageBox.Show("[LOGIN]: ERROR");
            } else
            {
                Program.log_id = res;
                MessageBox.Show("[LOGIN]: Success");
                this.Hide();
                cnn.Close();
                MainForm form = new MainForm();
                form.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.cnn.Close();
            RegisterForm form = new RegisterForm();
            form.Show();
        }
    }
}
