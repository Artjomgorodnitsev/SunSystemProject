using System;
using System.Windows.Forms;

namespace SunSystemProject.Forms
{
    public partial class FormDefendGame : Form
    {
        public FormDefendGame()
        {
            InitializeComponent();
        }

        private void FormDefendGame_Load(object sender, EventArgs e)
        {
        }

        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}