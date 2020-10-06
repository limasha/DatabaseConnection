using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace exampledb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;user id=root;database=exdb";
            String query = "INSERT INTO user (Username,Password) VALUES ('"+textBox1.Text+ "','" + textBox2.Text + "')";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);

            int a=cmd.ExecuteNonQuery();
            if(a==1)
            {
                MessageBox.Show("Record Inserted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            connection.Close();

        }

    }
}
