using System;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;

            var newName = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                SaveName(newName);
            }
            else
            {
                label2.Text = @"Введите своё имя!";
            }
        }

        private async void SaveName(string newName)
        {
            var existingName = await _mainForm.GetName(newName);
            if (existingName == null)
            {
                using var sqlConnection = await MainFrm.GetSqlConnection();
                var command = new SqlCommand("INSERT INTO [Records] (Name) VALUES (@newName)",
                    sqlConnection);
                command.Parameters.AddWithValue("newName", newName);
                await command.ExecuteNonQueryAsync();

                await _mainForm.LoadName();

                Close();
            }
            else
            {
                label2.Text = @"Такое имя уже есть!";
            }
        }

        private void NameFrm_Load(object sender, EventArgs e)
        {

        }
    }
}