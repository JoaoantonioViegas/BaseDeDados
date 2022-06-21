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
        string condition_value = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = VIEGAS\\SQLEXPRESS; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            if(Program.log_id != "")
            {
                profile_button.Enabled = true;
                add_anuncio_button.Enabled = true;
                add_car.Enabled = true;
            } else
            {
                profile_button.Enabled = false;
                add_anuncio_button.Enabled = false;
                add_car.Enabled = false;
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
            cmd = new SqlCommand("search_km_fuel_price", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.Add(new SqlParameter("@title", search_value));
            cmd.Parameters.Add(new SqlParameter("@fuel", fuel_value));
            cmd.Parameters.Add(new SqlParameter("@kms", km_value));
            cmd.Parameters.Add(new SqlParameter("@price", preco_veiculo_input.Text));

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

        private void add_anuncio_button_Click(object sender, EventArgs e)
        {
            AddAdvertisementForm form = new AddAdvertisementForm();
            this.Hide();
            cnn.Close();
            form.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_peca_input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            cmd = new SqlCommand("search_piece_title_price_cond", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@title", search_peca_input.Text));
            cmd.Parameters.Add(new SqlParameter("@price", preco_input.Text));
            cmd.Parameters.Add(new SqlParameter("@condition", condition_input.Text));
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            table_pecas.DataSource = table;
        }

        private void preco_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void condition_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.condition_value = condition_input.SelectedItem.ToString();
        }

        private void add_car_Click_1(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            this.Hide();
            cnn.Close();
            form.Show();
        }

        private void search_result_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
