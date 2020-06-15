using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunSystemProject.Properties;

namespace SunSystemProject.Forms
{
    public partial class FormPlanetSpeed : Form
    {
        string time = null;
        bool EarthClicked,
            MercuryClicked,
            VeneraClicked,
            MarsClicked,
            JupiterClicked,
            SaturnClicked,
            UrankClicked,
            NeptunClicked,
            PlutonClicked;

        bool StatusDone,
            StatusDone2,
            StatusDone3,
            StatusDone4,
            StatusDone5,
            StatusDone6,
            StatusDone7,
            StatusDone8,
            StatusDone9;

        int EarthX,
            EarthY,
            MercuryX,
            MercuryY,
            VeneraX,
            VeneraY,
            MarsX,
            MarsY,
            JupiterX,
            JupiterY,
            SaturnX,
            SaturnY,
            UranX,
            UranY,
            NeptunX,
            NeptunY,
            PlutonX,
            PlutonY;


        int X, Y, X2, Y2, X3, Y3, X4, Y4, X5, Y5, X6, Y6, X7, Y7, X8, Y8, X9, Y9;
        int LastClicked;
        Image img1, img2, img3, img4, img5, img6, img7, img8, img9;


        Rectangle earth = new Rectangle(-200, -200, 91, 92);
        Rectangle mercury = new Rectangle(-200, -200, 42, 40);
        Rectangle venera = new Rectangle(-200, -200, 84, 83);
        Rectangle mars = new Rectangle(-200, -200, 79, 78);
        Rectangle jupiter = new Rectangle(-200, -200, 166, 164);
        Rectangle saturn = new Rectangle(-200, -200, 156, 204);
        Rectangle uran = new Rectangle(-200, -200, 102, 101);
        Rectangle neptun = new Rectangle(-200, -200, 87, 88);
        Rectangle pluton = new Rectangle(-200, -200, 38, 38);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img1, earth);
            e.Graphics.DrawImage(img2, mercury);
            e.Graphics.DrawImage(img3, venera);
            e.Graphics.DrawImage(img4, mars);
            e.Graphics.DrawImage(img5, jupiter);
            e.Graphics.DrawImage(img6, saturn);
            e.Graphics.DrawImage(img7, uran);
            e.Graphics.DrawImage(img8, neptun);
            e.Graphics.DrawImage(img9, pluton);
        }

        public FormPlanetSpeed()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.MouseMove += PictureBox1_MouseMove;

            labelEarth.Parent = pictureBox1;
            labelMercury.Parent = pictureBox1;
            labelVenera.Parent = pictureBox1;
            labelMars.Parent = pictureBox1;
            labelJupiter.Parent = pictureBox1;
            labelSaturn.Parent = pictureBox1;
            labelUran.Parent = pictureBox1;
            labelNeptun.Parent = pictureBox1;
            labelPluton.Parent = pictureBox1;
            //label2.Parent = pictureBox1;

            img1 = Resources.earthSpeed;
            img2 = Resources.merkurySpeed;
            img3 = Resources.veneraSpeed;
            img4 = Resources.marsSpeed;
            img5 = Resources.upiterSpeed;
            img6 = Resources.saturnSpeed;
            img7 = Resources.uranSpeed;
            img8 = Resources.neptunSpeed;
            img9 = Resources.plutonSpeed;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (StatusDone == false)
            {
                if (EarthClicked)
                {
                    earth.X = e.X - EarthX;
                    earth.Y = e.Y - EarthY;
                }
            }

            if (StatusDone2 == false)
            {
                if (MercuryClicked)
                {
                    mercury.X = e.X - MercuryX;
                    mercury.Y = e.Y - MercuryY;
                }
            }

            if (StatusDone3 == false)
            {
                if (VeneraClicked)
                {
                    venera.X = e.X - VeneraX;
                    venera.Y = e.Y - VeneraY;
                }
            }

            if (StatusDone4 == false)
            {
                if (MarsClicked)
                {
                    mars.X = e.X - MarsX;
                    mars.Y = e.Y - MarsY;
                }
            }

            if (StatusDone5 == false)
            {
                if (JupiterClicked)
                {
                    jupiter.X = e.X - JupiterX;
                    jupiter.Y = e.Y - JupiterY;
                }
            }

            if (StatusDone6 == false)
            {
                if (SaturnClicked)
                {
                    saturn.X = e.X - SaturnX;
                    saturn.Y = e.Y - SaturnY;
                }
            }

            if (StatusDone7 == false)
            {
                if (UrankClicked)
                {
                    uran.X = e.X - UranX;
                    uran.Y = e.Y - UranY;
                }
            }

            if (StatusDone8 == false)
            {
                if (NeptunClicked)
                {
                    neptun.X = e.X - NeptunX;
                    neptun.Y = e.Y - NeptunY;
                }
            }

            if (StatusDone9 == false)
            {
                if (PlutonClicked)
                {
                    pluton.X = e.X - PlutonX;
                    pluton.Y = e.Y - PlutonY;
                }
            }

            pictureBox1.Invalidate();
        }

        private async void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (((labelEarth.Location.X < earth.X + earth.Width) && (labelEarth.Location.X > earth.X))
                && ((labelEarth.Location.Y < earth.Y + earth.Height) && (labelEarth.Location.Y > earth.Y)))
            {
                StatusDone = true;
                earth.X = 394;
                earth.Y = 231;
            }

            if (((labelMercury.Location.X < mercury.X + mercury.Width) && (labelMercury.Location.X > mercury.X))
                && ((labelMercury.Location.Y < mercury.Y + mercury.Height) && (labelMercury.Location.Y > mercury.Y)))
            {
                StatusDone2 = true;
                mercury.X = 239;
                mercury.Y = 257;
            }

            if (((labelVenera.Location.X < venera.X + venera.Width) && (labelVenera.Location.X > venera.X))
                && ((labelVenera.Location.Y < venera.Y + venera.Height) && (labelVenera.Location.Y > venera.Y)))
            {
                StatusDone3 = true;
                venera.X = 295;
                venera.Y = 235;
            }

            if (((labelMars.Location.X < mars.X + mars.Width) && (labelMars.Location.X > mars.X))
                && ((labelMars.Location.Y < mars.Y + mars.Height) && (labelMars.Location.Y > mars.Y)))
            {
                StatusDone4 = true;
                mars.X = 502;
                mars.Y = 238;
            }

            if (((labelJupiter.Location.X < jupiter.X + jupiter.Width) && (labelJupiter.Location.X > jupiter.X))
                && ((labelJupiter.Location.Y < jupiter.Y + jupiter.Height) && (labelJupiter.Location.Y > jupiter.Y)))
            {
                StatusDone5 = true;
                jupiter.X = 599;
                jupiter.Y = 195;
            }

            if (((labelSaturn.Location.X < saturn.X + saturn.Width) && (labelSaturn.Location.X > saturn.X))
                && ((labelSaturn.Location.Y < saturn.Y + saturn.Height) && (labelSaturn.Location.Y > saturn.Y)))
            {
                StatusDone6 = true;
                saturn.X = 786;
                saturn.Y = 175;
            }

            if (((labelUran.Location.X < uran.X + uran.Width) && (labelUran.Location.X > uran.X))
                && ((labelUran.Location.Y < uran.Y + uran.Height) && (labelUran.Location.Y > uran.Y)))
            {
                StatusDone7 = true;
                uran.X = 965;
                uran.Y = 226;
            }

            if (((labelNeptun.Location.X < neptun.X + neptun.Width) && (labelNeptun.Location.X > neptun.X))
                && ((labelNeptun.Location.Y < neptun.Y + neptun.Height) && (labelNeptun.Location.Y > neptun.Y)))
            {
                StatusDone8 = true;
                neptun.X = 1090;
                neptun.Y = 233;
            }

            if (((labelPluton.Location.X < pluton.X + pluton.Width) && (labelPluton.Location.X > pluton.X))
                && ((labelPluton.Location.Y < pluton.Y + pluton.Height) && (labelPluton.Location.Y > pluton.Y)))
            {
                StatusDone9 = true;
                pluton.X = 1205;
                pluton.Y = 256;
            }

            if (StatusDone && StatusDone2 && StatusDone3 && StatusDone4 &&
                StatusDone5 && StatusDone6 && StatusDone7 && StatusDone8 &&
                StatusDone9)
            {
                timer1.Enabled = false;
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Хочешь попробовать сыграть ещё?", "Твоё время: " + time, MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    buttonGameStart.Visible = true;

                }

                if (dialog == DialogResult.No)
                {
                    Close();
                }
                await SaveGame();
            }


            if (EarthClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (MercuryClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (VeneraClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (MarsClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (JupiterClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (SaturnClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (UrankClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (NeptunClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            if (PlutonClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }

            EarthClicked = false;
            MercuryClicked = false;
            VeneraClicked = false;
            MarsClicked = false;
            JupiterClicked = false;
            SaturnClicked = false;
            UrankClicked = false;
            NeptunClicked = false;
            PlutonClicked = false;
        }
        private DateTime date;
        protected virtual async Task SaveGame()
        {
            date = DateTime.Now;
            timer1.Enabled = false;
            //label2.Text = @"Все планеты расставлены верно";
            //label2.Visible = false;

            var command = new SqlCommand("UPDATE [Records] set Time = @Time  where Name = @Name",
                await MainFrm.GetSqlConnection());
            var command1 = new SqlCommand("UPDATE [Records] set Date = @Date  where Name = @Name",
                await MainFrm.GetSqlConnection());
            TimeSpan t = TimeSpan.FromSeconds(_gameDurationSec);
            command.Parameters.AddWithValue("Time", t);
            command1.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Name", MainFrm.UserId);
            command1.Parameters.AddWithValue("Name", MainFrm.UserId);

            await command.ExecuteNonQueryAsync();
            await command1.ExecuteNonQueryAsync();
            //Close();
            //Может что-то важное закоментил!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < earth.X + earth.Width) && (e.X > earth.X))
            {
                if ((e.Y < earth.Y + earth.Height) && (e.Y > earth.Y))
                {
                    EarthClicked = true;

                    EarthX = e.X - earth.X;
                    EarthY = e.Y - earth.Y;
                }
            }

            if ((e.X < mercury.X + mercury.Width) && (e.X > mercury.X))
            {
                if ((e.Y < mercury.Y + mercury.Height) && (e.Y > mercury.Y))
                {
                    MercuryClicked = true;

                    MercuryX = e.X - mercury.X;
                    MercuryY = e.Y - mercury.Y;
                }
            }

            if ((e.X < venera.X + venera.Width) && (e.X > venera.X))
            {
                if ((e.Y < venera.Y + venera.Height) && (e.Y > venera.Y))
                {
                    VeneraClicked = true;

                    VeneraX = e.X - venera.X;
                    VeneraY = e.Y - venera.Y;
                }
            }

            if ((e.X < mars.X + mars.Width) && (e.X > mars.X))
            {
                if ((e.Y < mars.Y + mars.Height) && (e.Y > mars.Y))
                {
                    MarsClicked = true;

                    MarsX = e.X - mars.X;
                    MarsY = e.Y - mars.Y;
                }
            }

            if ((e.X < jupiter.X + jupiter.Width) && (e.X > jupiter.X))
            {
                if ((e.Y < jupiter.Y + jupiter.Height) && (e.Y > jupiter.Y))
                {
                    JupiterClicked = true;

                    JupiterX = e.X - jupiter.X;
                    JupiterY = e.Y - jupiter.Y;
                }
            }

            if ((e.X < saturn.X + saturn.Width) && (e.X > saturn.X))
            {
                if ((e.Y < saturn.Y + saturn.Height) && (e.Y > saturn.Y))
                {
                    SaturnClicked = true;

                    SaturnX = e.X - saturn.X;
                    SaturnY = e.Y - saturn.Y;
                }
            }

            if ((e.X < uran.X + uran.Width) && (e.X > uran.X))
            {
                if ((e.Y < uran.Y + uran.Height) && (e.Y > uran.Y))
                {
                    UrankClicked = true;

                    UranX = e.X - uran.X;
                    UranY = e.Y - uran.Y;
                }
            }

            if ((e.X < neptun.X + neptun.Width) && (e.X > neptun.X))
            {
                if ((e.Y < neptun.Y + neptun.Height) && (e.Y > neptun.Y))
                {
                    NeptunClicked = true;

                    NeptunX = e.X - neptun.X;
                    NeptunY = e.Y - neptun.Y;
                }
            }

            if ((e.X < pluton.X + pluton.Width) && (e.X > pluton.X))
            {
                if ((e.Y < pluton.Y + pluton.Height) && (e.Y > pluton.Y))
                {
                    PlutonClicked = true;

                    PlutonX = e.X - pluton.X;
                    PlutonY = e.Y - pluton.Y;
                }
            }
        }


        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPlanetSpeed_Load(object sender, EventArgs e)
        {
        }

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            _gameDurationSec = 0;
            pictureBox1.Image = Resources.planetSpeedSunSystemCutRus;
            timer1.Enabled = true;
            buttonGameStart.Visible = false;

            Random rand = new Random();
            X = rand.Next(pictureBox1.Width - 100);
            Y = rand.Next(pictureBox1.Height - 400);
            earth.Location = new Point(X, Y);
            earth.Size = new Size(91, 92);
            StatusDone = false;
            X2 = rand.Next(pictureBox1.Width - 100);
            Y2 = rand.Next(pictureBox1.Height - 400);
            mercury.Location = new Point(X2, Y2);
            mercury.Size = new Size(42, 40);
            StatusDone2 = false;
            X3 = rand.Next(pictureBox1.Width - 100);
            Y3 = rand.Next(pictureBox1.Height - 400);
            venera.Location = new Point(X3, Y3);
            venera.Size = new Size(84, 83);
            StatusDone3 = false;
            X4 = rand.Next(pictureBox1.Width - 100);
            Y4 = rand.Next(pictureBox1.Height - 400);
            mars.Location = new Point(X4, Y4);
            mars.Size = new Size(79, 78);
            StatusDone4 = false;
            X5 = rand.Next(pictureBox1.Width - 100);
            Y5 = rand.Next(pictureBox1.Height - 400);
            jupiter.Location = new Point(X5, Y5);
            jupiter.Size = new Size(166, 164);
            StatusDone5 = false;
            X6 = rand.Next(pictureBox1.Width - 100);
            Y6 = rand.Next(pictureBox1.Height - 400);
            saturn.Location = new Point(X6, Y6);
            saturn.Size = new Size(156, 204);
            StatusDone6 = false;
            X7 = rand.Next(pictureBox1.Width - 100);
            Y7 = rand.Next(pictureBox1.Height - 400);
            uran.Location = new Point(X7, Y7);
            uran.Size = new Size(102, 101);
            StatusDone7 = false;
            X8 = rand.Next(pictureBox1.Width - 100);
            Y8 = rand.Next(pictureBox1.Height - 400);
            neptun.Location = new Point(X8, Y8);
            neptun.Size = new Size(87, 88);
            StatusDone8 = false;
            X9 = rand.Next(pictureBox1.Width - 100);
            Y9 = rand.Next(pictureBox1.Height - 400);
            pluton.Location = new Point(X9, Y9);
            pluton.Size = new Size(38, 38);
            StatusDone9 = false;
        }

        private int _gameDurationSec;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _gameDurationSec += 1;

            var t = TimeSpan.FromSeconds(_gameDurationSec);
            var answer = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";
            time = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";

            labelTime.Text = answer;
        }
    }
}