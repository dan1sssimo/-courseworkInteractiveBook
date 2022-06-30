namespace CourseBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMusic = new System.Windows.Forms.PictureBox();
            this.heroView = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonStart = new System.Windows.Forms.PictureBox();
            this.buttonContinue = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.PictureBox();
            this.startGame = new System.Windows.Forms.Label();
            this.continueGame = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.hp1 = new System.Windows.Forms.PictureBox();
            this.hp2 = new System.Windows.Forms.PictureBox();
            this.hp3 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.backToMenu = new System.Windows.Forms.Label();
            this.buttonNextStory = new System.Windows.Forms.PictureBox();
            this.helpInfoNext = new System.Windows.Forms.Label();
            this.infoLabelStory2 = new System.Windows.Forms.Label();
            this.infoLabelStory = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextStory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.Color.Transparent;
            this.buttonMusic.Image = global::CourseBook.Properties.Resources.misu;
            this.buttonMusic.InitialImage = global::CourseBook.Properties.Resources.soundOn;
            this.buttonMusic.Location = new System.Drawing.Point(1159, 792);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(50, 50);
            this.buttonMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMusic.TabIndex = 3;
            this.buttonMusic.TabStop = false;
            this.buttonMusic.Visible = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // heroView
            // 
            this.heroView.BackColor = System.Drawing.Color.Transparent;
            this.heroView.Image = global::CourseBook.Properties.Resources.heroViw;
            this.heroView.Location = new System.Drawing.Point(13, 498);
            this.heroView.Name = "heroView";
            this.heroView.Size = new System.Drawing.Size(250, 350);
            this.heroView.TabIndex = 5;
            this.heroView.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.buttonStart.Location = new System.Drawing.Point(127, 330);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(500, 125);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.TabStop = false;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.buttonContinue.Location = new System.Drawing.Point(127, 461);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(500, 125);
            this.buttonContinue.TabIndex = 8;
            this.buttonContinue.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.buttonExit.Location = new System.Drawing.Point(127, 723);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(500, 125);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.buttonHelp.Location = new System.Drawing.Point(127, 592);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(500, 125);
            this.buttonHelp.TabIndex = 10;
            this.buttonHelp.TabStop = false;
            // 
            // startGame
            // 
            this.startGame.AutoSize = true;
            this.startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.startGame.Font = new System.Drawing.Font("Segoe Script", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.startGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGame.Location = new System.Drawing.Point(266, 353);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(233, 71);
            this.startGame.TabIndex = 11;
            this.startGame.Text = "Нова гра";
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // continueGame
            // 
            this.continueGame.AutoSize = true;
            this.continueGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.continueGame.Font = new System.Drawing.Font("Segoe Script", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.continueGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continueGame.Location = new System.Drawing.Point(185, 495);
            this.continueGame.Name = "continueGame";
            this.continueGame.Size = new System.Drawing.Size(382, 63);
            this.continueGame.TabIndex = 12;
            this.continueGame.Text = "Продовжити гру";
            this.continueGame.Click += new System.EventHandler(this.continueGame_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.exit.Font = new System.Drawing.Font("Segoe Script", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(215, 617);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(337, 71);
            this.exit.TabIndex = 13;
            this.exit.Text = "Вийти з гри";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.help.Font = new System.Drawing.Font("Segoe Script", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.help.Location = new System.Drawing.Point(228, 754);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(303, 71);
            this.help.TabIndex = 14;
            this.help.Text = "Інструкція";
            this.help.Click += new System.EventHandler(this.label4_Click);
            // 
            // hp1
            // 
            this.hp1.BackColor = System.Drawing.Color.Transparent;
            this.hp1.Image = global::CourseBook.Properties.Resources.gifSerze;
            this.hp1.Location = new System.Drawing.Point(13, 442);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(56, 50);
            this.hp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hp1.TabIndex = 15;
            this.hp1.TabStop = false;
            // 
            // hp2
            // 
            this.hp2.BackColor = System.Drawing.Color.Transparent;
            this.hp2.Image = global::CourseBook.Properties.Resources.gifSerze;
            this.hp2.Location = new System.Drawing.Point(107, 442);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(56, 50);
            this.hp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hp2.TabIndex = 16;
            this.hp2.TabStop = false;
            // 
            // hp3
            // 
            this.hp3.BackColor = System.Drawing.Color.Transparent;
            this.hp3.Image = global::CourseBook.Properties.Resources.gifSerze;
            this.hp3.Location = new System.Drawing.Point(207, 442);
            this.hp3.Name = "hp3";
            this.hp3.Size = new System.Drawing.Size(56, 50);
            this.hp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hp3.TabIndex = 17;
            this.hp3.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(208, 44);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ви загинули";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(286, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 287);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть дію : ";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton4.Location = new System.Drawing.Point(6, 231);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(207, 44);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(6, 162);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(207, 44);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(6, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(207, 44);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // backToMenu
            // 
            this.backToMenu.AutoSize = true;
            this.backToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.backToMenu.Font = new System.Drawing.Font("Segoe Script", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.backToMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backToMenu.Location = new System.Drawing.Point(228, 256);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(800, 71);
            this.backToMenu.TabIndex = 28;
            this.backToMenu.Text = "Повернутися до головного меню";
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // buttonNextStory
            // 
            this.buttonNextStory.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextStory.Image = global::CourseBook.Properties.Resources.YOPR;
            this.buttonNextStory.Location = new System.Drawing.Point(1024, 650);
            this.buttonNextStory.Name = "buttonNextStory";
            this.buttonNextStory.Size = new System.Drawing.Size(166, 101);
            this.buttonNextStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonNextStory.TabIndex = 20;
            this.buttonNextStory.TabStop = false;
            this.buttonNextStory.Click += new System.EventHandler(this.buttonNextStory_Click);
            // 
            // helpInfoNext
            // 
            this.helpInfoNext.AutoSize = true;
            this.helpInfoNext.BackColor = System.Drawing.Color.Black;
            this.helpInfoNext.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpInfoNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpInfoNext.Location = new System.Drawing.Point(1024, 569);
            this.helpInfoNext.Name = "helpInfoNext";
            this.helpInfoNext.Size = new System.Drawing.Size(166, 78);
            this.helpInfoNext.TabIndex = 21;
            this.helpInfoNext.Text = "Зробити вибір\r\n       та \r\nперейти далі:";
            // 
            // infoLabelStory2
            // 
            this.infoLabelStory2.AutoSize = true;
            this.infoLabelStory2.BackColor = System.Drawing.Color.Black;
            this.infoLabelStory2.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.infoLabelStory2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLabelStory2.Location = new System.Drawing.Point(107, 186);
            this.infoLabelStory2.Name = "infoLabelStory2";
            this.infoLabelStory2.Size = new System.Drawing.Size(77, 31);
            this.infoLabelStory2.TabIndex = 24;
            this.infoLabelStory2.Text = "label2";
            // 
            // infoLabelStory
            // 
            this.infoLabelStory.AutoSize = true;
            this.infoLabelStory.BackColor = System.Drawing.Color.Black;
            this.infoLabelStory.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.infoLabelStory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLabelStory.Location = new System.Drawing.Point(25, 74);
            this.infoLabelStory.Name = "infoLabelStory";
            this.infoLabelStory.Size = new System.Drawing.Size(77, 31);
            this.infoLabelStory.TabIndex = 25;
            this.infoLabelStory.Text = "label2";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            this.menu.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Location = new System.Drawing.Point(1039, 811);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(90, 31);
            this.menu.TabIndex = 29;
            this.menu.Text = "У меню";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseBook.Properties.Resources.storyFirst;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.infoLabelStory);
            this.Controls.Add(this.infoLabelStory2);
            this.Controls.Add(this.helpInfoNext);
            this.Controls.Add(this.buttonNextStory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hp3);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.continueGame);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.heroView);
            this.Controls.Add(this.buttonMusic);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1250, 900);
            this.MinimumSize = new System.Drawing.Size(1250, 900);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пригоди Божевільного Макса";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox buttonMusic;
        private PictureBox heroView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox buttonStart;
        private PictureBox buttonContinue;
        private PictureBox buttonExit;
        private PictureBox buttonHelp;
        private Label startGame;
        private Label continueGame;
        private Label exit;
        private Label help;
        private PictureBox hp1;
        private PictureBox hp2;
        private PictureBox hp3;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private PictureBox buttonNextStory;
        private Label helpInfoNext;
        private Label infoLabelStory2;
        private Label infoLabelStory;
        private Label backToMenu;
        private Label menu;
    }
}