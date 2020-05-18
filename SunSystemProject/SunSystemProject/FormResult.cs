using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSystemProject
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseSunSystemDataSet1.Records". При необходимости она может быть перемещена или удалена.
            this.recordsTableAdapter.Fill(this.databaseSunSystemDataSet1.Records);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
