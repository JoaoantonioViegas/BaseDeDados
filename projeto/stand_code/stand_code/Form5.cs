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
    public partial class AddAdvertisementForm : Form
    {
        SqlConnection cnn;
        string title;
        double price;
        string piece_name;
        string piece_condition;

        public AddAdvertisementForm()
        {
            InitializeComponent();
        }
        private void AddAdvertisementForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        private void title_input_TextChanged(object sender, EventArgs e)
        {
            this.title = title_input.Text;
        }

        private void price_label_TextChanged(object sender, EventArgs e)
        {
            this.price = Double.Parse(price_input.Text);
        }

        private void piece_name_input_TextChanged(object sender, EventArgs e)
        {
            this.piece_name = piece_name_input.Text;
        }

        private void piece_condition_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.piece_condition = piece_condition_input.Text;
        }

        private void create_ad_button_Click(object sender, EventArgs e)
        {
            int nr_rows;
            SqlCommand cmd = new SqlCommand("create_anuncio_peca", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@seller_id", Program.log_id));
            cmd.Parameters.Add(new SqlParameter("@title", this.title));
            cmd.Parameters.Add(new SqlParameter("@price", this.price));
            cmd.Parameters.Add(new SqlParameter("@piece_name", this.piece_name));
            cmd.Parameters.Add(new SqlParameter("@piece_condition", this.piece_condition));


            nr_rows = cmd.ExecuteNonQuery();

            if(nr_rows > 0)
            {
                MessageBox.Show("Advertised successfully created!");
            } else
            {
                MessageBox.Show("Error while creating the advertisement!");
            }
            cnn.Close();
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
