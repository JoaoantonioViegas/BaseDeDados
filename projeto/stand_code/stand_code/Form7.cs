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
    public partial class ChangeCredentialsForm : Form
    {
        SqlConnection cnn;
        public ChangeCredentialsForm()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            SqlCommand aux = new SqlCommand("get_email_pw", cnn);
            aux.CommandType = CommandType.StoredProcedure;
            aux.Parameters.Add("@id", Program.log_id);
            aux.Parameters.Add("@response", SqlDbType.VarChar, 50);
            aux.Parameters["@response"].Direction = ParameterDirection.Output;
            SqlDataReader reader;
            reader = aux.ExecuteReader();
            string old_email = "";
            string old_pw = "";
            while(reader.Read())
            {
                old_email = reader["email"].ToString();
                old_pw = reader["pw"].ToString();
            }
            reader.Close();

            SqlCommand cmd = new SqlCommand("update_user_password", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@old_email", old_email);
            cmd.Parameters.Add("@old_password", old_pw);
            cmd.Parameters.Add("@new_email", new_email_input.Text);
            cmd.Parameters.Add("@new_password", new_password_input.Text);
            cmd.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd.Parameters["@response"].Direction = ParameterDirection.Output;


            cmd.ExecuteNonQuery();
            string msg = cmd.Parameters["@response"].Value.ToString();
            MessageBox.Show(msg);

            this.Hide();
            cnn.Close();
            MainForm log_form = new MainForm();
            log_form.Show();

        }

        private void ChangeCredentialsForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = VIEGAS\\SQLEXPRESS; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm();
            cnn.Close();
            this.Hide();
            form.Show();
        }
    }
}
