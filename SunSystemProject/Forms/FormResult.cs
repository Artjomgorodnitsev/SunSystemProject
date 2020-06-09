using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunSystemProject.Forms
{
    public partial class FormResult : Form
    {
        private SqlConnection _sqlConnection;

        public FormResult()
        {
            InitializeComponent();
        }

        private async void FormResult_Load(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString01"];

            _sqlConnection = new SqlConnection(connectionString.ToString());

            await _sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            var command = new SqlCommand("SELECT * FROM[Records]", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseSunSystemDataSet1.Records".
            // При необходимости она может быть перемещена или удалена.
            //this.recordsTableAdapter.Fill(this.databaseSunSystemDataSet1.Records);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sqlConnection != null && _sqlConnection.State != ConnectionState.Closed)
                _sqlConnection.Close();
        }

        private async void label3_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Level] DESC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label4_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Points] DESC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label5_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[IncorrectAnswer] ASC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label6_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command =
                new SqlCommand("SELECT * FROM[Records] ORDER BY[IncorrectAnswer] DESC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label7_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Date] DESC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label8_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Time]", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] ORDER BY[Name]", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox1.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM[Records] WHERE[Name]=@Name", _sqlConnection);
            command.Parameters.AddWithValue("Name", textBox1.Text);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                button1.Visible = false;
                textBox1.Visible = false;
                sqlReader?.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }
        private void clear()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }
    }
}