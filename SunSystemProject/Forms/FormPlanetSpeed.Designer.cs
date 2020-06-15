namespace SunSystemProject.Forms
{
    partial class FormPlanetSpeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanetSpeed));
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.buttonExitForm1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEarth = new System.Windows.Forms.Label();
            this.labelVenera = new System.Windows.Forms.Label();
            this.labelMercury = new System.Windows.Forms.Label();
            this.labelMars = new System.Windows.Forms.Label();
            this.labelJupiter = new System.Windows.Forms.Label();
            this.labelSaturn = new System.Windows.Forms.Label();
            this.labelUran = new System.Windows.Forms.Label();
            this.labelNeptun = new System.Windows.Forms.Label();
            this.labelPluton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGameStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGameStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGameStart.Location = new System.Drawing.Point(971, 580);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(194, 34);
            this.buttonGameStart.TabIndex = 4;
            this.buttonGameStart.Text = "Начать игру";
            this.buttonGameStart.UseVisualStyleBackColor = false;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // buttonExitForm1
            // 
            this.buttonExitForm1.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExitForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitForm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitForm1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitForm1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExitForm1.Location = new System.Drawing.Point(1213, 580);
            this.buttonExitForm1.Name = "buttonExitForm1";
            this.buttonExitForm1.Size = new System.Drawing.Size(76, 34);
            this.buttonExitForm1.TabIndex = 5;
            this.buttonExitForm1.Text = "Выйти";
            this.buttonExitForm1.UseVisualStyleBackColor = false;
            this.buttonExitForm1.Click += new System.EventHandler(this.buttonExitForm1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таймер:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(118, 583);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 19);
            this.labelTime.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SunSystemProject.Properties.Resources.planetSpeedMain2rus;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1276, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelEarth
            // 
            this.labelEarth.BackColor = System.Drawing.Color.Transparent;
            this.labelEarth.Location = new System.Drawing.Point(416, 262);
            this.labelEarth.Name = "labelEarth";
            this.labelEarth.Size = new System.Drawing.Size(57, 25);
            this.labelEarth.TabIndex = 9;
            // 
            // labelVenera
            // 
            this.labelVenera.BackColor = System.Drawing.Color.Transparent;
            this.labelVenera.Location = new System.Drawing.Point(321, 287);
            this.labelVenera.Name = "labelVenera";
            this.labelVenera.Size = new System.Drawing.Size(57, 13);
            this.labelVenera.TabIndex = 10;
            // 
            // labelMercury
            // 
            this.labelMercury.Location = new System.Drawing.Point(256, 287);
            this.labelMercury.Name = "labelMercury";
            this.labelMercury.Size = new System.Drawing.Size(32, 13);
            this.labelMercury.TabIndex = 11;
            // 
            // labelMars
            // 
            this.labelMars.BackColor = System.Drawing.Color.Transparent;
            this.labelMars.Location = new System.Drawing.Point(540, 274);
            this.labelMars.Name = "labelMars";
            this.labelMars.Size = new System.Drawing.Size(35, 13);
            this.labelMars.TabIndex = 12;
            // 
            // labelJupiter
            // 
            this.labelJupiter.BackColor = System.Drawing.Color.Transparent;
            this.labelJupiter.Location = new System.Drawing.Point(673, 287);
            this.labelJupiter.Name = "labelJupiter";
            this.labelJupiter.Size = new System.Drawing.Size(35, 13);
            this.labelJupiter.TabIndex = 13;
            // 
            // labelSaturn
            // 
            this.labelSaturn.BackColor = System.Drawing.Color.Transparent;
            this.labelSaturn.Location = new System.Drawing.Point(860, 287);
            this.labelSaturn.Name = "labelSaturn";
            this.labelSaturn.Size = new System.Drawing.Size(35, 13);
            this.labelSaturn.TabIndex = 14;
            // 
            // labelUran
            // 
            this.labelUran.BackColor = System.Drawing.Color.Transparent;
            this.labelUran.Location = new System.Drawing.Point(1015, 287);
            this.labelUran.Name = "labelUran";
            this.labelUran.Size = new System.Drawing.Size(35, 13);
            this.labelUran.TabIndex = 15;
            // 
            // labelNeptun
            // 
            this.labelNeptun.BackColor = System.Drawing.Color.Transparent;
            this.labelNeptun.Location = new System.Drawing.Point(1130, 287);
            this.labelNeptun.Name = "labelNeptun";
            this.labelNeptun.Size = new System.Drawing.Size(35, 13);
            this.labelNeptun.TabIndex = 16;
            // 
            // labelPluton
            // 
            this.labelPluton.BackColor = System.Drawing.Color.Transparent;
            this.labelPluton.Location = new System.Drawing.Point(1221, 287);
            this.labelPluton.Name = "labelPluton";
            this.labelPluton.Size = new System.Drawing.Size(35, 13);
            this.labelPluton.TabIndex = 17;
            // 
            // FormPlanetSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 621);
            this.Controls.Add(this.labelPluton);
            this.Controls.Add(this.labelNeptun);
            this.Controls.Add(this.labelUran);
            this.Controls.Add(this.labelSaturn);
            this.Controls.Add(this.labelJupiter);
            this.Controls.Add(this.labelMars);
            this.Controls.Add(this.labelMercury);
            this.Controls.Add(this.labelVenera);
            this.Controls.Add(this.labelEarth);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitForm1);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlanetSpeed";
            this.Text = "Расставление планет на скорость";
            this.Load += new System.EventHandler(this.FormPlanetSpeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonExitForm1;
        private System.Windows.Forms.Button buttonGameStart;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEarth;
        private System.Windows.Forms.Label labelJupiter;
        private System.Windows.Forms.Label labelMars;
        private System.Windows.Forms.Label labelMercury;
        private System.Windows.Forms.Label labelNeptun;
        private System.Windows.Forms.Label labelPluton;
        private System.Windows.Forms.Label labelSaturn;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelUran;
        private System.Windows.Forms.Label labelVenera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}