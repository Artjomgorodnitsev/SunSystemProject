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
    public partial class FormResult : Form
    {
        SqlConnection sqlConnection;
        public FormResult()
        {
            InitializeComponent();
        }

        private async void FormResult_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aleks\source\repos\SunSystemProject-master\SunSystemProject\SunSystemProject\Database\DatabaseSunSystem.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM[Records]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add( Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseSunSystemDataSet1.Records". При необходимости она может быть перемещена или удалена.
            //this.recordsTableAdapter.Fill(this.databaseSunSystemDataSet1.Records);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
