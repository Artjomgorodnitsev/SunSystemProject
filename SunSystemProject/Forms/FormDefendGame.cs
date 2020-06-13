using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSystemProject.Forms
{
    public partial class FormDefendGame : Form
    {
        private string asteroidImage;
        private int[] asteroidsHorizontal = new int[5];
        private int[] asteroidsVertical = new int[5];
        private int[] asteroidsHeightWidth = new int[5];
        private bool[] asteroidAlive = new bool[5];
        private int[] asteroidSpeed = new int[5];


        private string laserImage = "objectOff.png", ship = "ship.png";
        private static int laserHorizontal = shipHorizontal + 60, laserVertical = shipVertical + 15;
        private bool laserAchievesGoal = false;


        private static int shipHorizontal = 30, shipVertical = 280, backgroundHorizontal = 0, backgroundHorizontal2 = 1580;
        private static int score = 0;
 
        Random GetRandom = new Random();


        private void FormDefendGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("background.jpg"), backgroundHorizontal, 0, 1680, 640);
            e.Graphics.DrawImage(new Bitmap("background2.jpg"), backgroundHorizontal2, 0, 1680, 640);

            e.Graphics.DrawImage(new Bitmap(ship), shipHorizontal, shipVertical, 60, 60);

            e.Graphics.DrawImage(new Bitmap(laserImage), laserHorizontal, laserVertical, 30, 30);

            asteroidImage = "asteroid1.png";
            for (int i = 0; i <= 4; i++)
            {
                e.Graphics.DrawImage(new Bitmap(asteroidImage), asteroidsHorizontal[i], asteroidsVertical[i], asteroidsHeightWidth[i], asteroidsHeightWidth[i]);
            }
        }
        private void BackgroundMoving()
        {
            if (backgroundHorizontal < -1580)
            {
                backgroundHorizontal = 1580;
            }
            if (backgroundHorizontal2 < -1580)
            {
                backgroundHorizontal2 = 1580;
            }

            backgroundHorizontal -= 3;
            backgroundHorizontal2 -= 3;
        }
        private void AsteroidAlive()
        {
            for (int i = 0; i <= 4; i++)
            {
                asteroidAlive[i] = false;
            }
        }
        private void AsteroidsGenerate(int i)
        {
            asteroidsHeightWidth[i] = GetRandom.Next(30, 130);
            asteroidsHorizontal[i] = GetRandom.Next(1024, 1300);
            asteroidsVertical[i] = GetRandom.Next(15, 548);
            asteroidSpeed[i] = GetRandom.Next(4, 8);
            asteroidAlive[i] = true;
            int image = GetRandom.Next(1, 3);
            asteroidImage = ("asteroid" + image + ".png").ToString();

            asteroidsHorizontal[i] -= asteroidSpeed[i];
        }


        private void FormDefendGame_Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score.ToString();
        }
        private void SetSceneBorders()
        {
            if (shipHorizontal <= 10)
            {
                shipHorizontal = 11;
            }
            else if (shipHorizontal >= 940)
            {
                shipHorizontal = 938;
            }
            else if (shipVertical <= 10)
            {
                shipVertical = 15;
            }
            else if (shipVertical >= 550)
            {
                shipVertical = 548;
            }
        }
        private void ShipExplosionSound()
        {
            SoundPlayer shipExplosion = new SoundPlayer(@"shipExplosion.wav");
            shipExplosion.Play();
        }

        private void LaserSound()
        {
            SoundPlayer laserSound = new SoundPlayer(@"laser.wav");
            laserSound.Play();
        }

        private void AsteroidExplosionSound()
        {
            SoundPlayer explosionSound = new SoundPlayer(@"asteroidExplosion.wav");
            explosionSound.Play();
        }

        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            Defeat();
            for (int i = 0; i <= 4; i++)
            {
                if (asteroidAlive[i] == false)
                {
                    AsteroidsGenerate(i);

                }
                else
                {
                    asteroidsHorizontal[i] -= asteroidSpeed[i];
                }
            }

            for (int i = 0; i <= 4; i++)
            {
                if (asteroidsHorizontal[i] < 0 - asteroidsHeightWidth[i])
                {
                    AsteroidsGenerate(i);
                }
                else if ((laserImage == "laserOn.png") && (laserHorizontal >= asteroidsHorizontal[i] - 30))
                {
                    if ((laserVertical >= asteroidsVertical[i] - 30) && (laserVertical <= asteroidsVertical[i] + asteroidsHeightWidth[i]))
                    {
                        laserAchievesGoal = true;
                        asteroidAlive[i] = false;
                        asteroidImage = "objectOff.png";
                        AsteroidExplosionSound();
                        AsteroidsGenerate(i);
                        score += 1;
                        label1.Text = "Score: " + score.ToString();
                    }
                }
            }




            if ((laserHorizontal > 1024) || (laserAchievesGoal == true))
            {
                laserImage = "objectOff.png";
                laserAchievesGoal = false;
            }
            else
            {
                laserHorizontal += 150;
            }
            BackgroundMoving();
            Invalidate();
        }

        private void Exit()
        {
            DialogResult dialog = new DialogResult();
            timer1.Enabled = false;
            dialog = MessageBox.Show("Are you sure?", "Close The Game", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {
                timer1.Enabled = true;
            }
        }



        private void Defeat()
        {
            for (int i = 0; i <= 4; i++)
            {
                if (((shipHorizontal > asteroidsHorizontal[i] - 60)) && ((shipVertical > asteroidsVertical[i] - 60) && (shipVertical < asteroidsVertical[i] + asteroidsHeightWidth[i])))
                {
                    if ((shipHorizontal < asteroidsHorizontal[i] + asteroidsHeightWidth[i]))
                    {


                        ShipExplosionSound();
                        ship = "objectOff.png";
                        timer1.Enabled = false;
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Do you want to try again?", "Your score is: " + score, MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            shipHorizontal = 30; shipVertical = 280;
                            AsteroidsGenerate(i);
                            ship = "ship.png";
                            score = 0;
                            label1.Text = "Score: " + score.ToString();
                            for (i = 0; i <= 4; i++)
                            {
                                asteroidAlive[i] = false;
                            }
                            timer1.Enabled = true;
                        }

                        if (dialog == DialogResult.No)
                        {
                            Environment.Exit(1);
                        }
                    }
                }
            }
        }
        private void FormDefendGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    shipHorizontal -= 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Right:
                    shipHorizontal += 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Up:
                    shipVertical -= 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Down:
                    shipVertical += 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Escape:
                    Exit();
                    break;
                case Keys.Space:
                    if (laserHorizontal < 1024)
                    {

                    }
                    else
                    {
                        LaserSound();
                        laserHorizontal = shipHorizontal + 60;
                        laserVertical = shipVertical + 15;
                        laserImage = "laserOn.png";
                    }
                    break;
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }
        public FormDefendGame()
        {
            InitializeComponent();
            AsteroidAlive();
        }
    }
}