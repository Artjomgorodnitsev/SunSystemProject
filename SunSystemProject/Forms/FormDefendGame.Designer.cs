namespace SunSystemProject.Forms
{
    partial class FormDefendGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefendGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.buttonExitForm1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(23, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Очки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(85, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "...";
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGameStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonGameStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGameStart.Location = new System.Drawing.Point(738, 558);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(130, 34);
            this.buttonGameStart.TabIndex = 3;
            this.buttonGameStart.Text = "Начать игру";
            this.buttonGameStart.UseVisualStyleBackColor = false;
            // 
            // buttonExitForm1
            // 
            this.buttonExitForm1.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExitForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitForm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitForm1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonExitForm1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExitForm1.Location = new System.Drawing.Point(902, 558);
            this.buttonExitForm1.Name = "buttonExitForm1";
            this.buttonExitForm1.Size = new System.Drawing.Size(76, 34);
            this.buttonExitForm1.TabIndex = 4;
            this.buttonExitForm1.Text = "Выйти";
            this.buttonExitForm1.UseVisualStyleBackColor = false;
            this.buttonExitForm1.Click += new System.EventHandler(this.buttonExitForm1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SunSystemProject.Properties.Resources.kosmos;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SunSystemProject.Properties.Resources.kosmos;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDefendGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(996, 599);
            this.Controls.Add(this.buttonExitForm1);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FormDefendGame";
            this.Text = "Защита планеты";
            this.Load += new System.EventHandler(this.FormDefendGame_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonExitForm1;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}