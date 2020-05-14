namespace SunSystemProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGames = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonSpeed = new System.Windows.Forms.Button();
            this.buttonDef = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonResult);
            this.groupBox2.Controls.Add(this.buttonTest);
            this.groupBox2.Controls.Add(this.labelTest);
            this.groupBox2.Controls.Add(this.buttonSpeed);
            this.groupBox2.Controls.Add(this.buttonDef);
            this.groupBox2.Controls.Add(this.labelGames);
            this.groupBox2.Location = new System.Drawing.Point(703, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 605);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelGames
            // 
            this.labelGames.AutoSize = true;
            this.labelGames.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGames.ForeColor = System.Drawing.Color.Black;
            this.labelGames.Location = new System.Drawing.Point(145, 16);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(100, 39);
            this.labelGames.TabIndex = 0;
            this.labelGames.Text = "Игры";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest.Location = new System.Drawing.Point(155, 243);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(81, 33);
            this.labelTest.TabIndex = 3;
            this.labelTest.Text = "Тест";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Peru;
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(18, 555);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(132, 36);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "Рекорды";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Защита планеты";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(217, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расставить планеты на скорость";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начать";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(303, 555);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 36);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::SunSystemProject.Properties.Resources.sunSystemForm1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 605);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTest
            // 
            this.buttonTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTest.Image = global::SunSystemProject.Properties.Resources.testIamge;
            this.buttonTest.Location = new System.Drawing.Point(112, 291);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(171, 124);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonSpeed
            // 
            this.buttonSpeed.BackColor = System.Drawing.Color.Tomato;
            this.buttonSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpeed.ForeColor = System.Drawing.Color.Red;
            this.buttonSpeed.Image = global::SunSystemProject.Properties.Resources.sunMain;
            this.buttonSpeed.Location = new System.Drawing.Point(197, 69);
            this.buttonSpeed.Name = "buttonSpeed";
            this.buttonSpeed.Size = new System.Drawing.Size(171, 124);
            this.buttonSpeed.TabIndex = 2;
            this.buttonSpeed.UseVisualStyleBackColor = false;
            this.buttonSpeed.Click += new System.EventHandler(this.buttonSpeed_Click);
            // 
            // buttonDef
            // 
            this.buttonDef.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDef.ForeColor = System.Drawing.Color.Red;
            this.buttonDef.Image = global::SunSystemProject.Properties.Resources.planetDefend;
            this.buttonDef.Location = new System.Drawing.Point(18, 69);
            this.buttonDef.Name = "buttonDef";
            this.buttonDef.Size = new System.Drawing.Size(171, 124);
            this.buttonDef.TabIndex = 1;
            this.buttonDef.UseVisualStyleBackColor = false;
            this.buttonDef.Click += new System.EventHandler(this.buttonDef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Солнечная Система";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonSpeed;
        private System.Windows.Forms.Button buttonDef;
        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

