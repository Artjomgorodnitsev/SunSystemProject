# SunSystemProject


В начале нас встречает главная форма, где мы присваиваем label, то что он родитель picturebox, что бы в будующем сделать их прозрачными на picturebox.


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


Тут мы прописываем функции для label. Что бы при двойном нажатии на планету label c информацией исчезал.

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
        

Функция для исчезновения информации о планете

        private void Label4_DoubleClick(object sender, EventArgs e)
        {
            label16.Visible = false;
        }
        
        
Тут мы проптсали функции для кнопок, что бы они открывали новые окна с 2 играми, тестом, рекордами игроков и смена имени.    

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
        
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new NameFrm(this);
            form.Show();
        }
        
        
Так же тут прописана функция для полного выхода из приложения.

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        


Дальше мы поподаем форму Расставить планеты на скорость.
Форма состоит из нескольких кнопко и picturebox- где и происходит сама игра.

В самом начале мы создаем множество переменных.

Данные переменные созданы для того, что бы их использовать в функциях для перетаскивания планет. (Что бы планету можно было взять при нажатии на мышку и поставить в другую точку отпустив левую кнопку мыши):
        
        bool EarthClicked,
            MercuryClicked,
            VeneraClicked,
            MarsClicked,
            JupiterClicked,
            SaturnClicked,
            UrankClicked,
            NeptunClicked,
            PlutonClicked;

Данные переменные созданы для планеты, которая была поставлена на правильно место была зафиксирована на этом месте и не могла бы быть задействована дальше.

        bool StatusDone,
            StatusDone2,
            StatusDone3,
            StatusDone4,
            StatusDone5,
            StatusDone6,
            StatusDone7,
            StatusDone8,
            StatusDone9;

Данные переменные созданы для получения координат планет.

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

Данные переменные это фигуры, которым мы присваиваем картинку плнеты, её изначальное расположение и размеры.

        Rectangle earth = new Rectangle(-200, -200, 91, 92);
        Rectangle mercury = new Rectangle(-200, -200, 42, 40);
        Rectangle venera = new Rectangle(-200, -200, 84, 83);
        Rectangle mars = new Rectangle(-200, -200, 79, 78);
        Rectangle jupiter = new Rectangle(-200, -200, 166, 164);
        Rectangle saturn = new Rectangle(-200, -200, 156, 204);
        Rectangle uran = new Rectangle(-200, -200, 102, 101);
        Rectangle neptun = new Rectangle(-200, -200, 87, 88);
        Rectangle pluton = new Rectangle(-200, -200, 38, 38);
 
 
Тут прописаны 3 функции для кнопок. Функции- при нажатии на кнопку, при движение курсора и при отпускании кнопки.

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
            label2.Parent = pictureBox1;
            
Тут задаются картинки из ресурсов, что бы проект можно было открывать на разных компьютерах не меняя постоянно путь до картинок.

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
        
Данная функция для считывания координаты планеты, когда кнопка мыши нажимается.

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
         }
         
Функция для движения планеты. Если StatusDone=false, то планета может быть перемещена, в противном случае она будет статичная и невозможна для перемещения.

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
        }
        
        pictureBox1.Invalidate();
 
Данная функция для считывания координаты планеты и куда была перемещена планета когда кнопка отпускается. 
 
    private async void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (((labelEarth.Location.X < earth.X + earth.Width) && (labelEarth.Location.X > earth.X))
                && ((labelEarth.Location.Y < earth.Y + earth.Height) && (labelEarth.Location.Y > earth.Y)))
            {
                StatusDone = true;
                earth.X = 394;
                earth.Y = 231;
            }
        }
 
 Когда все статусы выполнены, то игра заканчивается и сохроняется в БД.
 
        if (StatusDone && StatusDone2 && StatusDone3 && StatusDone4 &&
                StatusDone5 && StatusDone6 && StatusDone7 && StatusDone8 &&
                StatusDone9)
            {
                await SaveGame();
            }
 
 Проверка для повторного перемещения планеты, если она ещё не статичная.
 
        if (EarthClicked)
            {
                LastClicked = 1;
                X = earth.X;
                Y = earth.Y;
            }
        EarthClicked = false;
 
 
Функция на кнопку для выхода из игры "Расставить планеты на скорость".
 
        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
Функция для кнопки "Начать игру". При нажатии на кнопку, в этой функции включается таймер и планеты появляются в случайном месте в picturebox.        
        
        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.planetSpeedSunSystemCutRus;
            timer1.Enabled = true;
            buttonGameStart.Visible = false;

            Random rand = new Random();
            X = rand.Next(pictureBox1.Width - 100);
            Y = rand.Next(pictureBox1.Height - 400);
            earth.Location = new Point(X, Y);
            earth.Size = new Size(91, 92);
            StatusDone = false;
          } 

Таймер для игры.

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _gameDurationSec += 1;

            var t = TimeSpan.FromSeconds(_gameDurationSec);
            var answer = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";

            labelTime.Text = answer;
        }


Теперь переходим к форме для введения имени пользователя.

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
        
        
 В форме пользователя прописана функция для кнопки подтверждения имени. Когда кнопка нажата, то имя сохраняется в БД.
 
        private async void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text != null)
            {
                label2.Text = @"";
            }

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var command = new SqlCommand("INSERT INTO [Records] (Name) VALUES (@Name)",
                    await MainFrm.GetSqlConnection());
                command.Parameters.AddWithValue("Name", textBox1.Text);

                await command.ExecuteNonQueryAsync();
                MainFrm.UserId = textBox1.Text;
                await _mainForm.LoadName();
                Close();
            }
            else
            {
                label2.Text = @"Введите своё имя!";
            }
        }
        
        
Далее переходим к форме с рекордами пользователей.

        public FormResult()
        {
            InitializeComponent();
        }

Сразу как мы загружаем эту форму, нам открывается большая таблица с именами пользователей и их рекордами из БД.

        private async void FormResult_Load(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString01"];

            _sqlConnection = new SqlConnection(connectionString.ToString());

            await _sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            var command = new SqlCommand("SELECT * FROM[Records]", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseSunSystemDataSet1.Records".
            // При необходимости она может быть перемещена или удалена.
            //this.recordsTableAdapter.Fill(this.databaseSunSystemDataSet1.Records);
        }
        
        
 При закрытии формы рекордов, с формой закрывается и подключение к БД
 
    private void FormResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sqlConnection != null && _sqlConnection.State != ConnectionState.Closed)
                _sqlConnection.Close();
        }



Функция для сортировки в листбоксах рекордов.

        private async void label6_Click(object sender, EventArgs e)
        {
            clear();
            SqlDataReader sqlReader = null;
            SqlCommand command =
                new SqlCommand("SELECT * FROM[Records] ORDER BY[IncorrectAnswer] DESC", _sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Level"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Points"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["CorrectAnswer"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["IncorrectAnswer"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
        }






Функции дляя переключений между листбоксами, для отображения разных рекордов из разных игр.


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = false;
            listBox7.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = true;
            listBox7.Visible = true;
        }
        
        
Функция для очистки листбоксов после переключения между ними 
 
        private void clear()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }




Форма защиты планеты.
В начале создаем переменные для дальнейшего использования в коде.

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
        private static int score = 0;
 
        Random GetRandom = new Random();
        
        
Функция, которая рисует все объекты в форме.


        private void FormDefendGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("kosmos2.jpg"), backgroundHorizontal, 0, 1200, 800);

            e.Graphics.DrawImage(new Bitmap(earth), earthHorizontal, earthVertical, 100, 100);

            e.Graphics.DrawImage(new Bitmap(moonImage), moonHorizontal, moonVertical, 30, 30);

            asteroidImage = "asteroid3.png";
            for (int i = 0; i <= 4; i++)
            {
                e.Graphics.DrawImage(new Bitmap(asteroidImage), asteroidsHorizontal[i], asteroidsVertical[i], asteroidsHeightWidth[i],                  asteroidsHeightWidth[i]);
            }
        }
        
        
 
Функции для генерации летающих тарелок, которые будут атаковать землю. 
 
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
        
        
        
        
 
 
 В начале игры появляется лейбл для очков.
 
        private void FormDefendGame_Load(object sender, EventArgs e)
        {
            
            label1.Text = "Очки: " + score.ToString();
            
        }
        
        
 
 Функция для земли. Что бы земля не могла уходить за определенные границы.
 
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
        
        
Функция для передвижения объектов в форме.        
        
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
        
        
        
        
        
  Функция для выхода из игры.             
        
        private void Exit()
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
        
        
        
        
 Функция при проигрыше. Которая спрашивает игрока, хочет ли он продолжить игру.
 
        private void Defeat()
        {
            for (int i = 0; i <= 4; i++)
            {
                if (((earthHorizontal > asteroidsHorizontal[i] - 60)) && ((earthVertical > asteroidsVertical[i] - 60) && (earthVertical         < asteroidsVertical[i] + asteroidsHeightWidth[i])))
                {
                    if ((earthHorizontal < asteroidsHorizontal[i] + asteroidsHeightWidth[i]))
                    {

                        earth = "objectOff.png";
                        timer1.Enabled = false;
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Хочешь попробовать сыграть ещё?", "Твои очки: " + score, MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            earthHorizontal = 30; earthVertical = 280;
                            AsteroidsGenerate(i);
                            earth = "Earth.png";
                            score = 0;
                            label1.Text = "Очки: " + score.ToString();
                            for (i = 0; i <= 4; i++)
                            {
                                asteroidAlive[i] = false;
                            }
                            timer1.Enabled = true;
                        }

                        if (dialog == DialogResult.No)
                        {
                            Close();
                        }
                    }
                }
            }
        }
        
        
        
        
        
        
       
Управление землей.        
        
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
        
        
     public FormDefendGame()
        {
            InitializeComponent();
            AsteroidAlive();
        }
        
        
        
        
        
        
        
  Форма с Теста.
  
  В начале создаются переменные для дальнейшего использования.
  
        public List<string> voprosi;
        int num;
        string vopros;
        string potvet;
        public int correct = 0;
        public int incorrect = 0;
        int randomm = 9;
        public Random random = new Random();
        int kolotvetov = 0;
        
        
  
  При загрузке формы, загружается лист с вопросами.
  
        public FormTest()
        {
            InitializeComponent();

            voprosi = new List<string>() { "Какая по счету от Солнца планета Земля?", "Эта планета могла стать звездой, но не набрала           достаточно массы:", "Сколько спутников у Марса?",
             "Солнце – типичный представитель этого класса звезд:","Ближайшая к Солнцу планета:","Сколько всего планет в Солнечной              системе?","Первооткрывателем законов движения планет Солнечной системы был:","Самая большая планета Солнечной системы?","Самый          большой спутник в Солнечной системе:"};
        }
        
        
        
 Функция для кнопки "Начать игру".
 
        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            buttonGameStart.Visible = false;//кнопка начать игру пропадает
            timer1.Enabled = true;//таймер начинаеться
            num = random.Next(0, randomm);//береться рандомный индекс
            vopros = voprosi[num];
            label1.Text = voprosi[num];
            voprosi.RemoveAt(num);//удаляеться вопрос
            randomm -= 1;
            num = 0;

            switch (vopros)
            {
                case "Какая по счету от Солнца планета Земля?":
                    radioButton1.Text = "первая";
                    radioButton2.Text = "вторая";
                    radioButton3.Text = "третья+";
                    radioButton4.Text = "четвертая";
                    potvet = "radioButton3";
                    break;
                case "Эта планета могла стать звездой, но не набрала достаточно массы:":
                    radioButton1.Text = "Юпитер+";
                    radioButton2.Text = "Меркурий";
                    radioButton3.Text = "Нептун";
                    radioButton4.Text = "Сатурн";
                    potvet = "radioButton1";
                    break;
                case "Сколько спутников у Марса?":
                    radioButton1.Text = "у Марса нет спутников";
                    radioButton2.Text = "один спутник";
                    radioButton3.Text = "два спутника+";
                    radioButton4.Text = "пять спутников";
                    potvet = "radioButton3";
                    break;
                case "Солнце – типичный представитель этого класса звезд:":
                    radioButton1.Text = "желтый карлик+";
                    radioButton2.Text = "белый карлик";
                    radioButton3.Text = "красный гигант";
                    radioButton4.Text = "пульсар";
                    potvet = "radioButton1";
                    break;
                case "Ближайшая к Солнцу планета:":
                    radioButton1.Text = "Земля";
                    radioButton2.Text = "Юпитер";
                    radioButton3.Text = "Марс";
                    radioButton4.Text = "Меркурий+";
                    potvet = "radioButton4";
                    break;
                case "Сколько всего планет в Солнечной системе?":
                    radioButton1.Text = "шесть";
                    radioButton2.Text = "семь";
                    radioButton3.Text = "восемь+";
                    radioButton4.Text = "девять";
                    potvet = "radioButton3";
                    break;
                case "Первооткрывателем законов движения планет Солнечной системы был:":
                    radioButton1.Text = "Николай Коперник";
                    radioButton2.Text = "Иоганн Кеплер+";
                    radioButton3.Text = "Джордано Бруно";
                    radioButton4.Text = "Жак Кассини";
                    potvet = "radioButton2";
                    break;
                case "Самая большая планета Солнечной системы?":
                    radioButton1.Text = "Уран";
                    radioButton2.Text = "Церера";
                    radioButton3.Text = "Сатурн";
                    radioButton4.Text = "Юпитер+";
                    potvet = "radioButton4";
                    break;
                case "Самый большой спутник в Солнечной системе:":
                    radioButton1.Text = "Ио";
                    radioButton2.Text = "Ганимед+";
                    radioButton3.Text = "Европа";
                    radioButton4.Text = "Фобос";
                    potvet = "radioButton2";
                    break;
            }
        }
        
        
        
        
 Функция для кнопки "Ответить".
  
        private void button1_Click_2(object sender, EventArgs e)
        {
           
            if (kolotvetov < 8)
            {


                kolotvetov++;
                label5.Text = kolotvetov.ToString() + " / 8";
                num = 0;
                randomm -= 1;
                num = random.Next(0, randomm);
                if (radioButton1.Name == potvet && radioButton1.Checked)
                {

                   
                    correct++;
                    label2.Text = "Правильных ответов: " + correct.ToString();
                    ffgf();

                }
                else if (radioButton2.Name == potvet && radioButton2.Checked)
                {

                    
                    correct++;
                    label2.Text = "Правильных ответов: " + correct.ToString();
                    ffgf();
                }
                else if (radioButton3.Name == potvet && radioButton3.Checked)
                {

                    
                    correct++;
                    label2.Text = "Правильных ответов: " + correct.ToString();
                    ffgf();

                }
                else if (radioButton4.Name == potvet && radioButton4.Checked)
                {

                    
                    correct++;
                    label2.Text = "Правильных ответов: " + correct.ToString();
                    ffgf();

                }
                else
                {
                    incorrect++;
                    ffgf();
                }
            }
            else
            {
                
                label1.Text = "konec";
                timer1.Enabled = false;
                SaveGame();
            }

        }
        
        
        
Функции для сохранения данных из игры в базу данных.        

        protected virtual async Task SaveGame()
        {
            var command = new SqlCommand("UPDATE [Records] set CorrectAnswer = @correct where Name = @Name",
                await MainFrm.GetSqlConnection());
            command.Parameters.AddWithValue("correct", correct);
            command.Parameters.AddWithValue("Name", MainFrm.UserId);
            var command1 = new SqlCommand("UPDATE [Records] set IncorrectAnswer = @incorrect  where Name = @Name",
                await MainFrm.GetSqlConnection());
            command1.Parameters.AddWithValue("incorrect", incorrect);
            command1.Parameters.AddWithValue("Name", MainFrm.UserId);

            await command.ExecuteNonQueryAsync();
            await command1.ExecuteNonQueryAsync();
            Close();
        }
        private int _gameDurationSec;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _gameDurationSec += 1;

            var t = TimeSpan.FromSeconds(_gameDurationSec);
            var answer = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";

            labelTime.Text =  "Время: " + answer;
        }
        
        
        
 Функция для перехода к следующему ответу и проверки ответов, были ли ответы правильные или нет.       
    
        public void ffgf()
        {


            vopros = voprosi[num];
            label1.Text = vopros;
            voprosi.RemoveAt(num);


            switch (vopros)
            {
                case "Какая по счету от Солнца планета Земля?":
                    radioButton1.Text = "первая";
                    radioButton2.Text = "вторая";
                    radioButton3.Text = "третья+";
                    radioButton4.Text = "четвертая";
                    potvet = "radioButton3";
                    break;
                case "Эта планета могла стать звездой, но не набрала достаточно массы:":
                    radioButton1.Text = "Юпитер+";
                    radioButton2.Text = "Меркурий";
                    radioButton3.Text = "Нептун";
                    radioButton4.Text = "Сатурн";
                    potvet = "radioButton1";
                    break;
                case "Сколько спутников у Марса?":
                    radioButton1.Text = "у Марса нет спутников";
                    radioButton2.Text = "один спутник";
                    radioButton3.Text = "два спутника+";
                    radioButton4.Text = "пять спутников";
                    potvet = "radioButton3";
                    break;
                case "Солнце – типичный представитель этого класса звезд:":
                    radioButton1.Text = "желтый карлик+";
                    radioButton2.Text = "белый карлик";
                    radioButton3.Text = "красный гигант";
                    radioButton4.Text = "пульсар";
                    potvet = "radioButton1";
                    break;
                case "Ближайшая к Солнцу планета:":
                    radioButton1.Text = "Земля";
                    radioButton2.Text = "Юпитер";
                    radioButton3.Text = "Марс";
                    radioButton4.Text = "Меркурий+";
                    potvet = "radioButton4";
                    break;
                case "Сколько всего планет в Солнечной системе?":
                    radioButton1.Text = "шесть";
                    radioButton2.Text = "семь";
                    radioButton3.Text = "восемь+";
                    radioButton4.Text = "девять";
                    potvet = "radioButton3";
                    break;
                case "Первооткрывателем законов движения планет Солнечной системы был:":
                    radioButton1.Text = "Николай Коперник";
                    radioButton2.Text = "Иоганн Кеплер+";
                    radioButton3.Text = "Джордано Бруно";
                    radioButton4.Text = "Жак Кассини";
                    potvet = "radioButton2";
                    break;
                case "Самая большая планета Солнечной системы?":
                    radioButton1.Text = "Уран";
                    radioButton2.Text = "Церера";
                    radioButton3.Text = "Сатурн";
                    radioButton4.Text = "Юпитер+";
                    potvet = "radioButton4";
                    break;
                case "Самый большой спутник в Солнечной системе:":
                    radioButton1.Text = "Ио";
                    radioButton2.Text = "Ганимед+";
                    radioButton3.Text = "Европа";
                    radioButton4.Text = "Фобос";
                    potvet = "radioButton2";
                    break;
            }
        }
