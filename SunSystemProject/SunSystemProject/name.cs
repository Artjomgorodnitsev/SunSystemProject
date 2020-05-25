using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSystemProject
{
    public partial class name : Form
    {
        SqlConnection sqlConnection;
        
        public name()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void name_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aleks\source\repos\SunSystemProject\SunSystemProject\SunSystemProject\Database\DatabaseSunSystem.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(label2.Text!=null)
            {
                label2.Text = "";
            }
            if(!string.IsNullOrEmpty(textBox1.Text)&& !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO[Records](Name)VALUES(@Name)", sqlConnection);
                command.Parameters.AddWithValue("Name", textBox1.Text);

                await command.ExecuteNonQueryAsync();
                this.Close();
            }
            else
            {
                label2.Text = "Введите своё имя!";
            }

            
        }

        private void name_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
