using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSystemProject.Forms
{
    public partial class MainFrm : Form
    {
        public static string UserId;

        public static async Task<SqlConnection> GetSqlConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString01"];
            var sqlConnection = new SqlConnection(connectionString.ToString());
            await sqlConnection.OpenAsync();
            return sqlConnection;
        }

        public MainFrm()
        {
            InitializeComponent();
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;
            label11.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label13.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            label15.Parent = pictureBox1;
            label16.Parent = pictureBox1;
            label17.Parent = pictureBox1;
            label18.Parent = pictureBox1;
            label19.Parent = pictureBox1;
            label20.Parent = pictureBox1;
            label21.Parent = pictureBox1;
            label22.Parent = pictureBox1;
            label23.Parent = pictureBox1;
            label24.Parent = pictureBox1;
            label25.Parent = pictureBox1;
            label26.Parent = pictureBox1;
            label27.Parent = pictureBox1;

            label4.DoubleClick += Label4_DoubleClick;
            label5.DoubleClick += Label5_DoubleClick;
            label6.DoubleClick += Label6_DoubleClick;
            label7.DoubleClick += Label7_DoubleClick;
            label8.DoubleClick += Label8_DoubleClick;
            label9.DoubleClick += Label9_DoubleClick;
            label10.DoubleClick += Label10_DoubleClick;
            label11.DoubleClick += Label11_DoubleClick;
            label12.DoubleClick += Label12_DoubleClick;
            label13.DoubleClick += Label13_DoubleClick;
            label14.DoubleClick += Label14_DoubleClick;
            label15.DoubleClick += Label15_DoubleClick;
        }


        private void Label15_DoubleClick(object sender, EventArgs e)
        {
            label27.Visible = false;
        }

        private void Label14_DoubleClick(object sender, EventArgs e)
        {
            label26.Visible = false;
        }

        private void Label13_DoubleClick(object sender, EventArgs e)
        {
            label25.Visible = false;
        }

        private void Label12_DoubleClick(object sender, EventArgs e)
        {
            label24.Visible = false;
        }

        private void Label11_DoubleClick(object sender, EventArgs e)
        {
            label23.Visible = false;
        }

        private void Label10_DoubleClick(object sender, EventArgs e)
        {
            label22.Visible = false;
        }

        private void Label9_DoubleClick(object sender, EventArgs e)
        {
            label21.Visible = false;
        }

        private void Label8_DoubleClick(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void Label7_DoubleClick(object sender, EventArgs e)
        {
            label19.Visible = false;
        }

        private void Label6_DoubleClick(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void Label5_DoubleClick(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void Label4_DoubleClick(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void buttonDef_Click(object sender, EventArgs e)
        {
            var form = new FormDefendGame();
            form.Show();
        }

        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            var form = new FormPlanetSpeed();
            form.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            var form = new FormTest();
            form.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var form = new FormResult();
            form.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadName();
        }

        public async Task LoadName()
        {
            UserId = await GetName(null);
            label29.Text = UserId;
        }

        public async Task<string> GetName(string name)
        {
            string result = null;
            try
            {
                using var sqlConnection = await GetSqlConnection();
                var sql = "SELECT TOP 1 * FROM [Records] {0} order by id desc";
                string where = null;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    where = "where Name=@Name";
                }

                sql = string.Format(sql, where);
                var command = new SqlCommand(sql, sqlConnection);

                if (!string.IsNullOrWhiteSpace(name))
                {
                    command.Parameters.AddWithValue("Name", name);
                }

                using var sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    result = Convert.ToString(sqlReader["Name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return result;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            label16.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label18.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label22.Visible = true;
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label23.Visible = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label24.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label25.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label26.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label27.Visible = true;
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new NameFrm(this);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_CursorChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }
    }
}