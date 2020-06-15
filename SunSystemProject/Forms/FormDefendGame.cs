using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        private string moonImage = "objectOff.png", earth = "Earth.png";
        private static int moonHorizontal = earthHorizontal + 60, moonVertical = earthVertical + 15;
        private bool moonAchievesGoal = false;


        private static int earthHorizontal = 30, earthVertical = 280, backgroundHorizontal = 0;
        public static int score = 0;
 
        Random GetRandom = new Random();


        private void FormDefendGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("kosmos2.jpg"), backgroundHorizontal, 0, 1200, 800);

            e.Graphics.DrawImage(new Bitmap(earth), earthHorizontal, earthVertical, 100, 100);

            e.Graphics.DrawImage(new Bitmap(moonImage), moonHorizontal, moonVertical, 30, 30);

            asteroidImage = "asteroid3.png";
            for (int i = 0; i <= 4; i++)
            {
                e.Graphics.DrawImage(new Bitmap(asteroidImage), asteroidsHorizontal[i], asteroidsVertical[i], asteroidsHeightWidth[i], asteroidsHeightWidth[i]);
            }
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
            
            label1.Text = "Очки: " + score.ToString();
            
        }
        private void SetSceneBorders()
        {
            if (earthHorizontal <= 10)
            {
                earthHorizontal = 11;
            }
            else if (earthHorizontal >= 200)
            {
                earthHorizontal = 198;
            }
            else if (earthVertical <= 10)
            {
                earthVertical = 15;
            }
            else if (earthVertical >= 480)
            {
                earthVertical = 478;
            }
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
                else if ((moonImage == "moon.png") && (moonHorizontal >= asteroidsHorizontal[i] - 30))
                {
                    if ((moonVertical >= asteroidsVertical[i] - 30) && (moonVertical <= asteroidsVertical[i] + asteroidsHeightWidth[i]))
                    {
                        moonAchievesGoal = true;
                        asteroidAlive[i] = false;
                        asteroidImage = "objectOff.png";
                        AsteroidsGenerate(i);
                        score += 1;
                        label1.Text = "Очки: " + score.ToString();
                    }
                }
            }




            if ((moonHorizontal > 1024) || (moonAchievesGoal == true))
            {
                moonImage = "objectOff.png";
                moonAchievesGoal = false;
            }
            else
            {
                moonHorizontal += 150;
            }
            Invalidate();
        }

        private async void Exit()
        {
            DialogResult dialog = new DialogResult();
            timer1.Enabled = false;
            dialog = MessageBox.Show("Ты уверен?", "Закрыть игру", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                timer1.Enabled = true;
            }
        }



        private async void Defeat()
        {
            for (int i = 0; i <= 4; i++)
            {
                if (((earthHorizontal > asteroidsHorizontal[i] - 60)) && ((earthVertical > asteroidsVertical[i] - 60) && (earthVertical < asteroidsVertical[i] + asteroidsHeightWidth[i])))
                {
                    if ((earthHorizontal < asteroidsHorizontal[i] + asteroidsHeightWidth[i]))
                    {

                        earth = "objectOff.png";
                        timer1.Enabled = false;
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Хочешь попробовать сыграть ещё?", "Твои очки: " + score, MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            score = 0;
                            earthHorizontal = 30; earthVertical = 280;
                            AsteroidsGenerate(i);
                            earth = "Earth.png";
                            label1.Text = "Очки: " + score.ToString();
                            for (i = 0; i <= 4; i++)
                            {
                                asteroidAlive[i] = false;
                            }
                            timer1.Enabled = true;
                        }

                        if (dialog == DialogResult.No)
                        {
                            var command = new SqlCommand("UPDATE [Records] set Points = @Score  where Name = @Name",
                            await MainFrm.GetSqlConnection());
                            command.Parameters.AddWithValue("Score", score);
                            command.Parameters.AddWithValue("Name", MainFrm.UserId);
                            if (score >= 2)
                            {
                                var command1 = new SqlCommand("UPDATE [Records] set Level = @level  where Name = @Name",
                                await MainFrm.GetSqlConnection());
                                command1.Parameters.AddWithValue("level", 2);
                                command1.Parameters.AddWithValue("Name", MainFrm.UserId);
                            }
                            if(score > 0)
                            {
                                var command2 = new SqlCommand("UPDATE [Records] set Level= @level  where Name = @Name",
                                   await MainFrm.GetSqlConnection());
                                command2.Parameters.AddWithValue("level", 1);
                                command2.Parameters.AddWithValue("Name", MainFrm.UserId);
                                await command2.ExecuteNonQueryAsync();
                            }
                            if (score >= 5)
                            {
                                var command3 = new SqlCommand("UPDATE [Records] set Level = @level  where Name = @Name",
                                await MainFrm.GetSqlConnection());
                                command3.Parameters.AddWithValue("level", 3);
                                command3.Parameters.AddWithValue("Name", MainFrm.UserId);
                                await command3.ExecuteNonQueryAsync();
                            }
                            if (score == 0)
                            {
                                var command4 = new SqlCommand("UPDATE [Records] set Level = @level  where Name = @Name",
                                await MainFrm.GetSqlConnection());
                                command4.Parameters.AddWithValue("level", 0);
                                command4.Parameters.AddWithValue("Name", MainFrm.UserId);
                                await command4.ExecuteNonQueryAsync();
                            }
                            if (score >= 10)
                            {
                                var command3 = new SqlCommand("UPDATE [Records] set Level = @level  where Name = @Name",
                                await MainFrm.GetSqlConnection());
                                command3.Parameters.AddWithValue("level", 4);
                                command3.Parameters.AddWithValue("Name", MainFrm.UserId);
                                await command3.ExecuteNonQueryAsync();
                            }
                            await command.ExecuteNonQueryAsync();
                            Close();
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
                    earthHorizontal -= 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Right:
                    earthHorizontal += 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Up:
                    earthVertical -= 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Down:
                    earthVertical += 7;
                    Defeat();
                    SetSceneBorders();
                    break;
                case Keys.Escape:
                    Exit();
                    break;
                case Keys.Space:
                    if (moonHorizontal < 1024)
                    {

                    }
                    else
                    {
                        moonHorizontal = earthHorizontal + 60;
                        moonVertical = earthVertical + 15;
                        moonImage = "moon.png";
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