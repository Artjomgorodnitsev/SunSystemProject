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
    public partial class FormTest : Form
    {
        private int m, s, ms;
        public FormTest()
        {
            InitializeComponent();
        }

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 60)
            {
                ms = 0;
                s += 1;
            }
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            times.Text = m.ToString() + " : " + s.ToString() + " : " + ms.ToString();
        }
    }
}
