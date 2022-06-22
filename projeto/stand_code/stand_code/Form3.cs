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
using System.IO;

namespace stand_code
{
    public partial class ProfileForm : Form
    {
        SqlConnection cnn;
        string email = "";
        string fname = "";
        string lname = "";
        string tel = "";
        string nif = "";
        string selected_ad = "";
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
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
                this.tel = reader["Telefone"].ToString();
                this.nif = reader["NIF"].ToString();
            }
            this.email_label.Text = this.email;
            this.fname_label.Text = this.fname;
            this.lname_label.Text = this.lname;
            this.tel_label.Text = this.tel;
            this.NIF_label.Text = this.nif;
            reader.Close();

            edit_button.Enabled = false;

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

        private void change_credentials_button_Click(object sender, EventArgs e)
        {
            ChangeCredentialsForm form = new ChangeCredentialsForm();
            this.Hide();
            cnn.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection("data source = LENOVO-PC; integrated security=true; initial catalog = stand");
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("update_anuncio", cnn1);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.selected_ad)));
            if(new_title_input.Text == "")
            {
                cmd.Parameters.Add(new SqlParameter("@new_title", DBNull.Value));
            } else
            {
                cmd.Parameters.Add(new SqlParameter("@new_title", new_title_input.Text));
            }

            if(new_price_input.Text == "")
            {
                cmd.Parameters.Add(new SqlParameter("@new_price", DBNull.Value));
            } else
            {
                cmd.Parameters.Add(new SqlParameter("@new_price", int.Parse(new_price_input.Text)));
            }

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

        private void table_anuncios_utilizador_carros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_anuncios_utilizador_carros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                table_anuncios_utilizador_carros.CurrentRow.Selected = true;
                this.selected_ad = table_anuncios_utilizador_carros.Rows[e.RowIndex].Cells["ID_Anuncio"].FormattedValue.ToString();
                edit_button.Enabled = true;

                DataTable dt = table_anuncios_utilizador_carros.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    if(row["imagem"].ToString() != "")
                    {
                        pictureBox1.Image = convertByteArraytoImage((byte[])row["imagem"]);
                    }
                }

            }
            else
            {
                table_anuncios_utilizador_carros.CurrentRow.Selected = false;
            }
        }

        public Image convertByteArraytoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void table_anuncios_utilizador_pecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_anuncios_utilizador_pecas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                table_anuncios_utilizador_pecas.CurrentRow.Selected = true;
                this.selected_ad = table_anuncios_utilizador_pecas.Rows[e.RowIndex].Cells["ID_Anuncio"].FormattedValue.ToString();
                edit_button.Enabled = true;
                DataTable dt = table_anuncios_utilizador_pecas.DataSource as DataTable;
                if(dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    if(row["imagem"].ToString() != "")
                    {
                        pictureBox1.Image = convertByteArraytoImage((byte[])row["imagem"]);
                    }
                }
            }
            else
            {
                table_anuncios_utilizador_pecas.CurrentRow.Selected = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void delete_ad_button_Click(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection("data source = LENOVO-PC; integrated security=true; initial catalog = stand");
            cnn1.Open();
            if (this.selected_ad != "")
            {
                SqlCommand cmd = new SqlCommand("delete_anuncio", cnn1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_user", int.Parse(Program.log_id)));
                cmd.Parameters.Add(new SqlParameter("id_anuncio", int.Parse(this.selected_ad)));
                cmd.Parameters.Add("@response", SqlDbType.VarChar, 40);
                cmd.Parameters["@response"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string msg = cmd.Parameters["@response"].Value.ToString();
                MessageBox.Show(msg);

                this.Hide();
                cnn1.Close();
                ProfileForm form = new ProfileForm();
                form.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void table_anuncios_utilizador_carros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
