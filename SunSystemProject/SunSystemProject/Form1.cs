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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonDef_Click(object sender, EventArgs e)
        {
            FormDefendGame formdefendgame = new FormDefendGame();
            formdefendgame.Show();
        }

        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            FormPlanetSpeed formplanetspeed = new FormPlanetSpeed();
            formplanetspeed.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FormTest formtest = new FormTest();
            formtest.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FormResult formresult = new FormResult();
            formresult.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
