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
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aleks\source\repos\SunSystemProject\SunSystemProject\SunSystemProject\Database\DatabaseSunSystem.mdf;Integrated Security=True";

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

        private async void label3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Level] DESC", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private async void label4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Points] DESC", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private async void label5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[IncorrectAnswer] ASC", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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

        }

        private async void label6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[IncorrectAnswer] DESC", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private async void label7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Date] DESC", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private async void label8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Time]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Name]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
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
        }

        private void label9_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox1.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] WHERE[Name]=@Name", sqlConnection);
            command.Parameters.AddWithValue("Name", textBox1.Text);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Level"]) + "                " + Convert.ToString(sqlReader["Points"]) + "                 " + Convert.ToString(sqlReader["CorrectAnswer"]) + "                 " + Convert.ToString(sqlReader["IncorrectAnswer"]) + "             " + Convert.ToString(sqlReader["Date"]) + "            " + Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button1.Visible = false;
                textBox1.Visible = false;
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }
    }
}
