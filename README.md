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
        
        
Данная функция для считывания координаты планеты и куда была перемещена планета когда кнопка отпускается.

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
            
 
Функция на кнопку для выхода из игры "Расставить планеты на скорость"
 
        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


