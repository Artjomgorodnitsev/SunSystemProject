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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefendGame));
            this.label1 = new System.Windows.Forms.Label();
            this.databaseSunSystemDataSet1 = new SunSystemProject.DatabaseSunSystemDataSet();
            this.databaseSunSystemDataSet2 = new SunSystemProject.DatabaseSunSystemDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Очки:";
            // 
            // databaseSunSystemDataSet1
            // 
            this.databaseSunSystemDataSet1.DataSetName = "DatabaseSunSystemDataSet";
            this.databaseSunSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseSunSystemDataSet2
            // 
            this.databaseSunSystemDataSet2.DataSetName = "DatabaseSunSystemDataSet";
            this.databaseSunSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(821, 53);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // FormDefendGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 640);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "FormDefendGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Защита планеты";
            this.Load += new System.EventHandler(this.FormDefendGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDefendGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDefendGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSunSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;

        #endregion

        private DatabaseSunSystemDataSet databaseSunSystemDataSet1;
        private DatabaseSunSystemDataSet databaseSunSystemDataSet2;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}