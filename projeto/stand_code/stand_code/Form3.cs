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

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = VIEGAS\\SQLEXPRESS; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_user_info", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(Program.log_id)));
            cmd.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd.Parameters["@response"].Direction = ParameterDirection.Output;
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

            SqlCommand cmd3 = new SqlCommand("get_favourites", cnn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add(new SqlParameter("@id_client", int.Parse(Program.log_id)));
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            favourites_table.DataSource = table3;

            cnn.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }

        private void table_anuncios_utilizador_pecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void change_credentials_button_Click(object sender, EventArgs e)
        {
            ChangeCredentialsForm form = new ChangeCredentialsForm();
            this.Hide();
            cnn.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection("data source = VIEGAS\\SQLEXPRESS; integrated security=true; initial catalog = stand");
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("update_anuncio", cnn1);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id_anuncio_input.Text)));
            cmd.Parameters.Add(new SqlParameter("@new_title", new_title_input.Text));
            cmd.Parameters.Add(new SqlParameter("@new_price", int.Parse(new_price_input.Text)));
            cmd.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd.Parameters["@response"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            string msg = cmd.Parameters["@response"].Value.ToString();
            MessageBox.Show(msg);


            ProfileForm form = new ProfileForm();
            this.Hide();
            cnn1.Close();
            cnn.Close();
            form.Show();
        }
    }
}
