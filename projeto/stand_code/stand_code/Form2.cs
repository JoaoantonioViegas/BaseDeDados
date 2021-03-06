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

namespace stand_code
{
    public partial class LoginForm : Form
    {
        SqlConnection cnn;
        string email;
        string password;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsBuilder = new SqlConnectionStringBuilder();
            scsBuilder.UserID = Program.UserID;
            scsBuilder.Password = Program.Password;
            scsBuilder.DataSource = Program.DataSource;
            scsBuilder.InitialCatalog = Program.InitialCatalog;
            scsBuilder.IntegratedSecurity = false;
            cnn = new SqlConnection(scsBuilder.ConnectionString);
            cnn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void email_input_TextChanged(object sender, EventArgs e)
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
            string response = "";
            cmd = new SqlCommand("login_user", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 40).Value = this.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = this.password;
            cmd.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd.Parameters["@response"].Direction = ParameterDirection.Output;



            reader = cmd.ExecuteReader();
            string res = "";
            while (reader.Read())
            {
                res += reader["ID_utilizador"];
            }
            reader.Close();

            if (res == "")
            {
                MessageBox.Show("[LOGIN]: ERROR");
            }
            else
            {
                Program.log_id = res;
                MessageBox.Show("[LOGIN]: Success");
                this.Hide();
                cnn.Close();
                MainForm form = new MainForm();
                form.Show();
            }
        }

    }
}
