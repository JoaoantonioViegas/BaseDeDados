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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection cnn;
        String email;
        String pw;

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "data source = LENOVO-PC; integrated security=true; initial catalog = stand";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open! ");

            //SqlCommand command;
            //SqlDataReader dataReader;
            //String sql, output = "";
            //String username = user_input.Text;
            //sql = "select * from utilizador where Fname = '" + username + "'";

            //command = new SqlCommand(sql, cnn);

            //dataReader = command.ExecuteReader();

            //while(dataReader.Read())
            //{
            //    output = output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(output);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            MessageBox.Show(res);

            if(res == "")
            {
                MessageBox.Show("Login Error.");
            } else
            {
                MessageBox.Show("Login Successfull.");
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
    }
}
