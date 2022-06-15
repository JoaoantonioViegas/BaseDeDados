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
            // SqlCommand cmd = new SqlCommand("create_user", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // SqlDataReader reader = cmd.ExecuteReader();
            using (var command = new SqlCommand("create_user", cnn)
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
                while (reader.Read())
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

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
