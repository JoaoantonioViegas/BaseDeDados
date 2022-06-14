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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            // SqlCommand cmd = new SqlCommand("create_user", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // SqlDataReader reader = cmd.ExecuteReader();
            using(var command = new SqlCommand("create_user", cnn)
            {
                CommandType = CommandType.StoredProcedure,
                //Parameters = new SqlParameter("@fname", firstname_input),
                //Parameters = new SqlParameter("@lname", lastname_input),
                //Parameters = new SqlParameter("@tel", tel_input),
                //Parameters = new SqlParameter("@email", email_input),
                //Parameters = new SqlParameter("@pw", pw_input)
            })
            {
                command.Parameters.Add(new SqlParameter("@fname", firstname_input.Text));
                command.Parameters.Add(new SqlParameter("@lname", lastname_input.Text));
                command.Parameters.Add(new SqlParameter("@tel", tel_input.Text));
                command.Parameters.Add(new SqlParameter("@email", email_input.Text));
                command.Parameters.Add(new SqlParameter("@pw", pw_input.Text));
                command.ExecuteNonQuery();

                SqlDataReader reader;
                reader = command.ExecuteReader();
                string res = "";
                while(reader.Read())
                {
                    res = res + reader.GetValue(0);
                }
                reader.Close();
                MessageBox.Show(res);


            }

            this.Hide();
            cnn.Close();
            MainForm log_form = new MainForm();
            log_form.Show();
        }

    }
}
