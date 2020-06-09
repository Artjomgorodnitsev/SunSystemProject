using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunSystemProject.Forms
{
    public partial class NameFrm : Form
    {
        private readonly MainFrm _mainForm;

        public NameFrm()
        {
            InitializeComponent();
        }

        public NameFrm(Form mainForm)
        {
            _mainForm = mainForm as MainFrm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void name_Load(object sender, EventArgs e)
        {
            // var connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString01"];
            // MainFrm.sqlConnection = new SqlConnection(connectionString.ToString());
            // await MainFrm.sqlConnection.OpenAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text != null)
            {
                label2.Text = @"";
            }

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var command = new SqlCommand("INSERT INTO [Records] (Name) VALUES (@Name)",
                    await MainFrm.GetSqlConnection());
                command.Parameters.AddWithValue("Name", textBox1.Text);

                await command.ExecuteNonQueryAsync();
                MainFrm.UserId = textBox1.Text;
                await _mainForm.LoadName();
                Close();
            }
            else
            {
                label2.Text = @"Введите своё имя!";
            }
        }
    }
}