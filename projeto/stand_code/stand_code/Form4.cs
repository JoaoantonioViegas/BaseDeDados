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
    public partial class RegisterForm : Form
    {
        SqlConnection cnn;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("create_user", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@fname", firstname_input.Text));
            cmd.Parameters.Add(new SqlParameter("@lname", lastname_input.Text));
            cmd.Parameters.Add(new SqlParameter("@tel", tel_input.Text));
            cmd.Parameters.Add(new SqlParameter("@email", email_input.Text));
            cmd.Parameters.Add(new SqlParameter("@pw", pw_input.Text));
            cmd.Parameters.Add(new SqlParameter("@NIF", Nif_input.Text));
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            string res = "";
            while(reader.Read())
            {
                res += reader.GetValue(0);
            }
            MessageBox.Show(res);

            this.Hide();
            cnn.Close();
            MainForm log_form = new MainForm();
            log_form.Show();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void firstname_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
