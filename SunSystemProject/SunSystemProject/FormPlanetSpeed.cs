using System;
using System.Windows.Forms;

namespace SunSystemProject
{
    public partial class FormPlanetSpeed : Form
    {
        public FormPlanetSpeed()
        {
            InitializeComponent();
        }

        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.planetSpeedSunSystemCutRus;
        }
    }
}
