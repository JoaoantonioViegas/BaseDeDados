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
    public partial class MainForm : Form
    {
        SqlConnection cnn;
        string fuel_value = "";
        string km_value = "";
        string search_value = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            if(Program.log_id != "")
            {
                profile_button.Enabled = true;
            } else
            {
                profile_button.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {
            this.search_value = search_input.Text;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            cmd = new SqlCommand("search_km_fuel", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@title", search_value));
            cmd.Parameters.Add(new SqlParameter("@fuel", fuel_value));
            cmd.Parameters.Add(new SqlParameter("@kms", km_value));
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            search_result_table.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void filter_fuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fuel_value = filter_fuel.SelectedItem.ToString();
        }

        private void km_input_TextChanged(object sender, EventArgs e)
        {
            this.km_value = km_input.Text;
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            this.cnn.Close();
            ProfileForm form = new ProfileForm();
            this.Hide();
            form.Show();
        }
    }
}
