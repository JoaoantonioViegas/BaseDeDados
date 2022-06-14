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
    public partial class LoginForm : Form
    {
        SqlConnection cnn;
        String email;
        String pw;
        String fuel_value = "";
        String km_value = "";

        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader reader;

            string cmd_string = "select email, pw from utilizador where email='" + email + "' and pw='" + pw +"'";
            cmd = new SqlCommand(cmd_string, cnn);
            reader = cmd.ExecuteReader();
            string res = "";
            while(reader.Read())
            {
                res = res + reader.GetValue(0);
            }
            reader.Close();
            MessageBox.Show(res);

            if(res == "")
            {
                MessageBox.Show("Login Error.");
            } else
            {
                MessageBox.Show("Login Successfull.");
                this.Hide();
                cnn.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pw = pw_input.Text;
        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {
            email = email_input.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string res = "";
            SqlCommand cmd;
            // search bar
            //if(fuel_value != "" && km_value != "")
            //{
                cmd = new SqlCommand("search_km_fuel", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@title", search_input.Text));
                cmd.Parameters.Add(new SqlParameter("@fuel", fuel_value));
                cmd.Parameters.Add(new SqlParameter("@kms", km_value));
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res += reader["Titulo"] + ", " + reader["preco"] + ", " + reader["Marca"] + ", " + reader["Modelo"] + ", " + reader["Ano"] + ", " + reader["Combustivel"] + ", " + reader["quilometros"] + ", " + reader["Matricula"] + "\n";
                }
                reader.Close();
            //} else
            //{
            //    cmd = new SqlCommand("search_anuncio", cnn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add(new SqlParameter("@title", search_input.Text));
            //    SqlDataReader reader;
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        res += reader["Titulo"] + ", " + reader["preco"] + "\n";
            //    }
            //    reader.Close();

            //}
            MessageBox.Show(res);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fuel_value = filter_fuel.SelectedItem.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void km_input_TextChanged(object sender, EventArgs e)
        {
            this.km_value = km_input.Text;
        }
    }
}
