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
            
Тут задаются картинки из ресурсов, что бы проект можно было открывать на разных компьютерах не меняя постоянно путь до картинок

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
 
 
Функция на кнопку для выхода из игры "Расставить планеты на скорость"
 
        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
Функция для кнопки начатия игры. При нажатии на кнопку, в этой функции включается таймер и планеты появляются в случайном месте в picturebox.        
        
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

Таймер для игры

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _gameDurationSec += 1;

            var t = TimeSpan.FromSeconds(_gameDurationSec);
            var answer = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";

            labelTime.Text = answer;
        }


Теперь переходим к форме для введения имени пользователя

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
        
        
 В форме пользователя прописана функция для кнопки подтверждения имени. Когда кнопка нажата, то имя сохраняется в БД
 
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
