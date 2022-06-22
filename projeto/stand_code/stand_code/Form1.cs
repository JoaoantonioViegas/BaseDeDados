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
    public partial class MainForm : Form
    {
        SqlConnection cnn;
        string fuel_value = "";
        string km_value = "";
        string search_value = "";
        string condition_value = "";
        string selected_ad = "";

        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            //connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            SqlConnectionStringBuilder scsBuilder = new SqlConnectionStringBuilder();
            scsBuilder.UserID = Program.UserID;
            scsBuilder.Password = Program.Password;
            scsBuilder.DataSource = Program.DataSource;
            scsBuilder.InitialCatalog = Program.InitialCatalog;
            scsBuilder.IntegratedSecurity = false;
            cnn = new SqlConnection(scsBuilder.ConnectionString);
            cnn.Open();

            if(Program.log_id != "")
            {
                profile_button.Enabled = true;
                add_anuncio_button.Enabled = true;
                add_car.Enabled = true;
                add_favourites_button.Enabled = true;
                buy_button.Enabled = true;
            } else
            {
                profile_button.Enabled = false;
                add_anuncio_button.Enabled = false;
                add_car.Enabled = false;
                add_favourites_button.Enabled = false;
                buy_button.Enabled = false;
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

        private void add_favourites_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("add_to_favourties", cnn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@id_anuncio", int.Parse(this.selected_ad));
            cmd1.Parameters.Add("@id_client", Program.log_id);
               
            cmd1.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd1.Parameters["@response"].Direction = ParameterDirection.Output;

            cmd1.ExecuteNonQuery();
            string msg = cmd1.Parameters["@response"].Value.ToString();
            MessageBox.Show(msg);

            this.Hide();
            cnn.Close();
            MainForm form = new MainForm();
            form.Show();
        }

        private void search_result_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (search_result_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    search_result_table.CurrentRow.Selected = true;
                    this.selected_ad = search_result_table.Rows[e.RowIndex].Cells["ID_Anuncio"].FormattedValue.ToString();

                    DataTable dt = search_result_table.DataSource as DataTable;
                    if (dt != null)
                    {
                        DataRow row = dt.Rows[e.RowIndex];
                        if (row["imagem"].ToString() != "")
                        {
                            pictureBox1.Image = convertByteArraytoImage((byte[])row["imagem"]);
                        }
                    }

                }
                else
                {
                    search_result_table.CurrentRow.Selected = false;
                }
            }
            
        }

        public Image convertByteArraytoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void table_pecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (table_pecas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    table_pecas.CurrentRow.Selected = true;
                    this.selected_ad = table_pecas.Rows[e.RowIndex].Cells["ID_Anuncio"].FormattedValue.ToString();

                    DataTable dt = table_pecas.DataSource as DataTable;
                    if (dt != null)
                    {
                        DataRow row = dt.Rows[e.RowIndex];
                        if (row["imagem"].ToString() != "")
                        {
                            pictureBox2.Image = convertByteArraytoImage((byte[])row["imagem"]);
                        }
                    }

                }
                else
                {
                    table_pecas.CurrentRow.Selected = false;
                }
            }
            
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            if (this.selected_ad != "")
            {
                SqlCommand cmd = new SqlCommand("accept_advertise", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_client", int.Parse(Program.log_id)));
                cmd.Parameters.Add(new SqlParameter("id_anuncio", int.Parse(this.selected_ad)));
                cmd.Parameters.Add("@response", SqlDbType.VarChar, 40);
                cmd.Parameters["@response"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string msg = cmd.Parameters["@response"].Value.ToString();
                MessageBox.Show(msg);

                this.Hide();
                cnn.Close();
                MainForm form = new MainForm();
                form.Show();
            }
        }
    }
}
