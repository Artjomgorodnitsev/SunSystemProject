namespace SunSystemProject
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.databaseSunSystemDataSet1 = new SunSystemProject.DatabaseSunSystemDataSet();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.buttonExitForm1 = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(31, 165);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ответ1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(31, 203);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ответ2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(31, 239);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ответ3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton4.Location = new System.Drawing.Point(31, 275);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ответ4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 132);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вопрос";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 358);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(136, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "0 / 8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SunSystemProject.Properties.Resources.Earth;
            this.pictureBox1.Location = new System.Drawing.Point(441, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // databaseSunSystemDataSet1
            // 
            this.databaseSunSystemDataSet1.DataSetName = "DatabaseSunSystemDataSet";
            this.databaseSunSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGameStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGameStart.ForeColor = System.Drawing.Color.White;
            this.buttonGameStart.Location = new System.Drawing.Point(797, 336);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(125, 34);
            this.buttonGameStart.TabIndex = 8;
            this.buttonGameStart.Text = "Начать тест";
            this.buttonGameStart.UseVisualStyleBackColor = false;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // buttonExitForm1
            // 
            this.buttonExitForm1.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExitForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitForm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitForm1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitForm1.ForeColor = System.Drawing.Color.White;
            this.buttonExitForm1.Location = new System.Drawing.Point(935, 336);
            this.buttonExitForm1.Name = "buttonExitForm1";
            this.buttonExitForm1.Size = new System.Drawing.Size(76, 34);
            this.buttonExitForm1.TabIndex = 7;
            this.buttonExitForm1.Text = "Выйти";
            this.buttonExitForm1.UseVisualStyleBackColor = false;
            this.buttonExitForm1.Click += new System.EventHandler(this.buttonExitForm1_Click);
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(792, 117);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(229, 32);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Время:";
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.BackColor = System.Drawing.Color.Transparent;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.times.ForeColor = System.Drawing.Color.White;
            this.times.Location = new System.Drawing.Point(885, 120);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(0, 29);
            this.times.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(792, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 67);
            this.label2.TabIndex = 7;
            this.label2.Text = "Правильных ответов:";
            this.label2.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunSystemProject.Properties.Resources.sunSystemForm1Main;
            this.ClientSize = new System.Drawing.Size(1023, 382);
            this.Controls.Add(this.times);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonExitForm1);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTest";
            this.Text = "Тест";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DatabaseSunSystemDataSet databaseSunSystemDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Button buttonExitForm1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label times;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}