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
            SqlConnectionStringBuilder scsBuilder = new SqlConnectionStringBuilder();
            scsBuilder.UserID = Program.UserID;
            scsBuilder.Password = Program.Password;
            scsBuilder.DataSource = Program.DataSource;
            scsBuilder.InitialCatalog = Program.InitialCatalog;
            scsBuilder.IntegratedSecurity = false;
            cnn = new SqlConnection(scsBuilder.ConnectionString);
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
            string response = "";
            SqlCommand cmd = new SqlCommand("create_anuncio_peca", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@seller_id", SqlDbType.Int).Value = Program.log_id;
            cmd.Parameters.Add("@title", SqlDbType.VarChar,100).Value = this.title;
            cmd.Parameters.Add("@price", SqlDbType.Real).Value = this.price;
            cmd.Parameters.Add("@piece_name", SqlDbType.VarChar,30).Value = this.piece_name;
            cmd.Parameters.Add("@piece_condition", SqlDbType.VarChar,10).Value = this.piece_condition;
            cmd.Parameters.Add("@categoria", SqlDbType.VarChar, 50).Value = this.comboBox1.SelectedItem.ToString();
            cmd.Parameters.Add(new SqlParameter("@image", convertImageToBytes(pictureBox1.Image)));
            cmd.Parameters.Add("@response", SqlDbType.VarChar, 50);
            cmd.Parameters["@response"].Direction = ParameterDirection.Output;


            nr_rows = cmd.ExecuteNonQuery();
            string msg = cmd.Parameters["@response"].Value.ToString();
            MessageBox.Show(msg);
            if (nr_rows > 0)
            {
                //MessageBox.Show("Advertised successfully created!");
                MainForm form = new MainForm();
                this.Hide();
                form.Show();
            }
            else
            {
                //MessageBox.Show("Error while creating the advertisement!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_image_button_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*jpeg;*.png)|*.jpg|*.jpeg|*.png", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        byte[] convertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            cnn.Close();
            this.Hide();
            form.Show();
        }
    }
}
