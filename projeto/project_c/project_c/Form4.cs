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
    public partial class ProfileForm : Form
    {
        SqlConnection cnn;
        string email = "";
        string fname = "";
        string lname = "";
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_user_info", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(Program.log_id)));
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.email = reader["email"].ToString();
                this.fname = reader["Fname"].ToString();
                this.lname = reader["Lname"].ToString();
            }
            this.email_label.Text = this.email;
            this.fname_label.Text = this.fname;
            this.lname_label.Text = this.lname;
            reader.Close();

            // anuncios do user
            SqlCommand cmd1 = new SqlCommand("get_anuncios_utilizador_veiculos_terrestres", cnn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("@id", int.Parse(Program.log_id)));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table_anuncios_utilizador_carros.DataSource = table;

            SqlCommand cmd2 = new SqlCommand("get_anuncios_utilizador_pecas", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add(new SqlParameter("@id", int.Parse(Program.log_id)));
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            table_anuncios_utilizador_pecas.DataSource = table2;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }
    }
}
