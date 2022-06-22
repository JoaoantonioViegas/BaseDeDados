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
    public partial class Form6 : Form
    {
        SqlConnection cnn;
        string seller_id = "";
        string titulo_value = "";
        string preco_value = "";
        string matricula_value = "";
        string modelo_value = "";
        string ano_value = "";
        string condition_value = "";
        string combustivel_value = "";
        string marca_value = "";
        string submodelo_value = "";
        string segmento_value = "";
        string kms_value = "";
        string tipoveiculo_value = "";
        public Form6()
        {
            InitializeComponent();
            SqlConnectionStringBuilder scsBuilder = new SqlConnectionStringBuilder();
            scsBuilder.UserID = Program.UserID;
            scsBuilder.Password = Program.Password;
            scsBuilder.DataSource = Program.DataSource;
            scsBuilder.InitialCatalog = Program.InitialCatalog;
            scsBuilder.IntegratedSecurity = false;
            cnn = new SqlConnection(scsBuilder.ConnectionString);
            cnn.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           

        }

        private void title_input_TextChanged(object sender, EventArgs e)
        {
            this.titulo_value = title_input.Text;
        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {
            this.preco_value = price_input.Text;
        }

        private void create_ad_button_Click(object sender, EventArgs e)
        {
            int nr_rows;
            SqlCommand cmd;
            string response = "";
            cmd = new SqlCommand("create_anuncio_terrestre", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@seller_id", Program.log_id));
            cmd.Parameters.Add("@seller_id", SqlDbType.Int).Value = Program.log_id;
            //cmd.Parameters.Add(new SqlParameter("@titulo", titulo_value));
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar,100).Value = titulo_value;
            //cmd.Parameters.Add(new SqlParameter("@preco", Int32.Parse(preco_value)));
            cmd.Parameters.Add("@preco", SqlDbType.Real).Value = Int32.Parse(preco_value);
            //cmd.Parameters.Add(new SqlParameter("@matricula", matricula_value));
            cmd.Parameters.Add("@matricula", SqlDbType.VarChar, 9).Value = matricula_value;
            //cmd.Parameters.Add(new SqlParameter("@modelo", modelo_value));
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar,40).Value = modelo_value;
            //cmd.Parameters.Add(new SqlParameter("@ano", Int32.Parse(ano_value)));
            cmd.Parameters.Add("@ano", SqlDbType.Int).Value = Int32.Parse(ano_value);
            //cmd.Parameters.Add(new SqlParameter("@combustivel", combustivel_value));
            cmd.Parameters.Add("@combustivel", SqlDbType.VarChar, 20).Value = combustivel_value;
            //cmd.Parameters.Add(new SqlParameter("@marca", marca_value));
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 30).Value = marca_value;
            //cmd.Parameters.Add(new SqlParameter("@sub_modelo", submodelo_value));
            cmd.Parameters.Add("@sub_modelo", SqlDbType.VarChar, 30).Value = submodelo_value;
            //cmd.Parameters.Add(new SqlParameter("@segmento", segmento_value));
            cmd.Parameters.Add("@segmento", SqlDbType.VarChar,20).Value = segmento_value;
            //cmd.Parameters.Add(new SqlParameter("@kms", Int32.Parse(kms_value)));
            cmd.Parameters.Add("@kms", SqlDbType.Int).Value = Int32.Parse(kms_value);
            //cmd.Parameters.Add(new SqlParameter("@tipo_veiculo", tipoveiculo_value));
            cmd.Parameters.Add("@tipo_veiculo", SqlDbType.VarChar, 40).Value = tipoveiculo_value;
            cmd.Parameters.Add(new SqlParameter("@imagem", convertImageToBytes(pictureBox1.Image)));
            //cmd.Parameters.Add(new SqlParameter("@response", response));
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

        private void add_image_button_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*jpeg;*.png)|*.jpg|*.jpeg|*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        byte[] convertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.matricula_value = plate_input.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.modelo_value = model_input.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.ano_value = year_input.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.combustivel_value = fuel_input.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.marca_value = brand_input.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.submodelo_value = submodel_input.Text;
        }

        private void piece_name_input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }

        private void fuel_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.combustivel_value = fuel_input.Text;
        }

        private void tipo_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoveiculo_value = tipo_input.Text;
        }

        private void km_input_TextChanged(object sender, EventArgs e)
        {
            this.kms_value = km_input.Text;
        }

        private void segmento_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.segmento_value = segmento_input.SelectedItem.ToString();
        }

    }
    }

