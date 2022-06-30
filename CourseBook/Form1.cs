using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using LibOfClasses1;

namespace CourseBook
{
    public partial class Form1 : Form
    {
        public Graphics g;
        private Random r = new Random();
        public int storyOfGame = 0;
        public int hpHero=3;
        public string sceneGame = "";
        public int endSceneGame = 0;
        private void EnemyBloodCreate()
        {
            g = heroView.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[2000];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(3))
                {
                    case 1:
                        arr[0] = new LibOfClasses1.Blood();
                        arr[0].Draw(g);
                        break;
                }
            }
        }
        private void EnemyBloodCreate2()
        {
            g = heroView.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[2000];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(4))
                {
                    case 1:
                        arr[0] = new LibOfClasses1.BuildBlood();
                        arr[0].Draw(g);
                        break;
                    case 2:
                        arr[0] = new LibOfClasses1.Blood();
                        arr[0].Draw(g);
                        break;
                    case 3:
                        arr[0] = new LibOfClasses1.KnifeDamage();
                        arr[0].Draw(g);
                        break;
                }
            }
        }
        private void EnemyBloodCreate3()
        {
            g = heroView.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[500];
            for (int i = 0; i < arr.Length; i++)
            {
                        arr[0] = new LibOfClasses1.KnifeDamage();
                        arr[0].Draw(g);
            }
        }
        public void Story1()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.storyFirst;
            infoLabelStory.Text = "��� �� �������� � ������ 2195 ����," +
                " ���� ���������� ���� ��������� ������������ ���������...";
            infoLabelStory2.Text = "³� ������ ��..." +
                "������...";
            heroView.Visible = true;    
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            buttonContinue.Visible = false;
            buttonHelp.Visible = false;
            buttonExit.Visible = false;
            buttonStart.Visible = false;
            startGame.Visible = false;
            continueGame.Visible = false;
            help.Visible = false;
            exit.Visible = false;
            storyOfGame=1;
        }
        public void Story2()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story1;
            infoLabelStory.Text = "�� �������� �������� ������� ����� � ��������...";
            infoLabelStory2.Text = "����� ������ ������ ������ ����...";
            radioButton1.Text = "�������� � ������� ��.";
            radioButton2.Text = "������������ �� �����.";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = true;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            if (radioButton1.Checked == true)
            {
                hpHero--;
                storyOfGame = 2;
                MessageBox.Show("�� �������� ���������", "������������!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnemyBloodCreate();
            }      
            else
             if (radioButton2.Checked == true)
            {
                endSceneGame++;
                storyOfGame = 3;
            }
        }
        public void Story2_1()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story2_1_1;
            infoLabelStory.Text = "���������� �������....�� � �� ����!!!";
            infoLabelStory2.Text = "������... ʲ�����!!! �����...";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            storyOfGame = 10;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            backToMenu.Visible = false;
            hpHero--;
            MessageBox.Show("�� �������� ���������", "������������!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            EnemyBloodCreate2();
        }
        public void Story2_1_1()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story2_11;
            infoLabelStory.Text = "���� ������� � ������� ��...��������.." +
                "Ѳ�����...";
            infoLabelStory2.Text = "����: '�������� ����������'. ";
            radioButton1.Text = "������������ ��.";
            radioButton2.Text = "���������� �������� ��, �������� ���������.";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = true;
            backToMenu.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            if (radioButton1.Checked == true)
            {
                storyOfGame = 11;
                endSceneGame++;
            }
            else
           if (radioButton2.Checked == true)
            {
                storyOfGame = 12;
                hpHero--;
                MessageBox.Show("�� �������� ���������", "������������!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnemyBloodCreate3();
            }

        }
        public void badEnd()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story_badEnd;
            infoLabelStory.Text = "������, ���� �������...";
            infoLabelStory2.Text = "���� �� ��������� ������, ���� ������ ���� ������� ��������(((";
            heroView.Visible = true;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            menu.Visible = false;
            backToMenu.Visible = true;
            storyOfGame = 12;
        }
        public void happyEnd()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story_happyEnd;
            infoLabelStory.Text = "����� ������� �� ������ �����!!!";
            infoLabelStory2.Text = "³� ������ ��� ������ �� �������� ������ ������..";
            heroView.Visible = true;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            menu.Visible = false;
            backToMenu.Visible = true;
            storyOfGame = 11;
        }
        public void Story2_2()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story2_2;
            infoLabelStory.Text = "�� �������� ������� �������� ������������";
            infoLabelStory2.Text = "�������... ��������.....";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            storyOfGame = 4;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        public void Story2_2_2()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story2_2_2;
            infoLabelStory.Text = "���������� �����...����� ������� ����...";
            infoLabelStory2.Text = "ϳ��� ����� �����, �� ������ ����� �������...";
            radioButton1.Text = "���������� � ��������.";
            radioButton2.Text = "������ �� ���� �������.";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = true;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            if (radioButton1.Checked == true)
            {
                storyOfGame = 6;
                hpHero--;
                MessageBox.Show("�� �������� ���������", "������������!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnemyBloodCreate2();
            }
            else
           if (radioButton2.Checked == true)
            {
                storyOfGame = 7;
                endSceneGame++;
            }
        }
        public void Story7()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.goodfinal1;
            infoLabelStory.Text = "�����!!! �������, ����� ������� ������..";
            infoLabelStory2.Text = "��������.... �������������...!!!!!";
            heroView.Visible = true;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            menu.Visible = false;
            backToMenu.Visible = true;
            storyOfGame = 7;
        }
        public void Story5()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.story5;
            infoLabelStory.Text = "����� �`������� ������.";
            infoLabelStory2.Text = "�������� ������� ����.... ��� ���, �� ������ ����...";
            heroView.Visible = true;
            helpInfoNext.Visible = true;
            buttonNextStory.Visible = true;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            storyOfGame = 8;
            EnemyBloodCreate3();
        }
        public void Story8()
        {
            menu.Visible = true;
            this.BackgroundImage = Properties.Resources.deadMax1;
            infoLabelStory.Text = "���������...���� �������� � �����.";
            infoLabelStory2.Text = "������, ���� ����� �� ������ ������.";
            heroView.Visible = true;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = true;
            infoLabelStory2.Visible = true;
            groupBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            hpHero = 0;
            storyOfGame = 8;
            EnemyBloodCreate3();
        }
        public void functionHpHero(int hpHero)
        {
            if (hpHero == 1)
            {
                hp1.Visible = true;
                hp2.Visible = false;
                hp3.Visible = false;
            }
            else
                if (hpHero == 2)
            {
                hp1.Visible = true;
                hp2.Visible = true;
                hp3.Visible = false;
            }
            else
                if (hpHero == 3)
            {
                hp1.Visible = true;
                hp2.Visible = true;
                hp3.Visible = true;
            }   
            else 
                if(hpHero == 0)
            {
                hp1.Visible = false;
                hp2.Visible = false;
                hp3.Visible = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
         
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.menuBack1;
            heroView.Visible = false;
            hp1.Visible = false;
            hp2.Visible = false;
            hp3.Visible = false;
            groupBox1.Visible = false;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = false;
            infoLabelStory2.Visible = false;
            backToMenu.Visible = false;
            menu.Visible = false;
            IntPtr startgame = CreateEllipticRgn(0, 0, buttonStart.Width-5, buttonStart.Height-5 );
            SetWindowRgn(buttonStart.Handle, startgame, true);
            IntPtr continuegame = CreateEllipticRgn(0, 0, buttonContinue.Width - 5, buttonContinue.Height - 5);
            SetWindowRgn(buttonContinue.Handle, continuegame, true);
            IntPtr endgame = CreateEllipticRgn(0, 0, buttonExit.Width - 5, buttonExit.Height - 5);
            SetWindowRgn(buttonExit.Handle, endgame, true);
            IntPtr helpmenu = CreateEllipticRgn(0, 0, buttonHelp.Width - 5, buttonHelp.Height - 5);
            SetWindowRgn(buttonHelp.Handle, helpmenu, true);
           
        }
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateEllipticRgn(int Left, int Top, int Right, int Bot);
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr Vusota, IntPtr VusKr, bool bRed);

        private void label4_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("���� ��� ������ � ����, �� �� ������ ������ ����� �� ������� ����� � ��������� �� ������ ������� �� ��. �� ����� ���������� ���� ��� �� �� ������ �������� ������� ������'� ( �� ������ 3 ) �� �������� ��� �� ������. �� ����� ��������� �� �� �� ������ �������� ������'�, � ������ �������� �� ������. �� ���������� ��� ���� �������� ��������� ��� ��������� ������� �����. ���� ������'� ���� ���������� 0 - ��� ����������� � ������� ���� ������ ��� ��������.                                                                                                                                  ����� ���!!!", "���������.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            storyOfGame = 0;
            hpHero = 3;
            functionHpHero(hpHero);
            Story1();
            menu.Visible = true;
        }

        private void continueGame_Click(object sender, EventArgs e)
        {  if (storyOfGame > 0)
            {
                buttonContinue.Visible = false;
                buttonHelp.Visible = false;
                buttonExit.Visible = false;
                buttonStart.Visible = false;
                startGame.Visible = false;
                continueGame.Visible = false;
                exit.Visible = false;
                help.Visible = false;
                if (storyOfGame == 8)
                {
                    backToMenu.Visible = true;
                    menu.Visible = false;
                }
                else
                if (storyOfGame == 7)
                {
                    backToMenu.Visible = true;
                    menu.Visible = false;
                }
                else
                if (storyOfGame == 11)
                {
                    backToMenu.Visible = true;
                    menu.Visible = false;
                }
                else
                if (storyOfGame == 12)
                {
                    backToMenu.Visible = true;
                    menu.Visible = false;
                }
                switch (storyOfGame)
                {
                    case 1:
                        {
                            if (storyOfGame == 1)
                                Story2();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 2:
                        {
                            if (storyOfGame == 2)
                                Story2_1();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 3:
                        {
                            if (storyOfGame == 3)
                                Story2_2();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 4:
                        {
                            if (storyOfGame == 4)
                                Story2_2_2();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 6:
                        {
                            if (storyOfGame == 6)
                                Story5();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 7:
                        {
                            if (storyOfGame == 7)
                                Story7();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 8:
                        {
                            if (storyOfGame == 8)
                                Story8();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 10:
                        {
                            if (storyOfGame == 10)
                                Story2_1_1();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 11:
                        {
                            if (storyOfGame == 11)
                                happyEnd();
                            functionHpHero(hpHero);
                            break;
                        }
                    case 12:
                        {
                            if (storyOfGame == 12)
                                badEnd();
                            functionHpHero(hpHero);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("�� �� �� �������� ���", "��������!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNextStory_Click(object sender, EventArgs e)
        {
            if (storyOfGame == 8)
            {
                backToMenu.Visible = true;
                menu.Visible = false;
            }
            else
                if (storyOfGame == 7)
            {
                backToMenu.Visible = true;
                menu.Visible = false;
            }
            else
                if (storyOfGame == 11)
            {
                backToMenu.Visible = true;
                menu.Visible = false;
            }
            else
                if (storyOfGame == 12)
            {
                backToMenu.Visible = true;
                menu.Visible = false;
            }
            switch (storyOfGame)
            {
                case 1:
                    {
                        if(storyOfGame == 1) 
                          Story2();
                        functionHpHero(hpHero);
                        break;
                    }
                case 2:
                    {
                        if (storyOfGame == 2)
                            Story2_1();
                        functionHpHero(hpHero);
                        break;
                    }
                case 3:
                    {
                        if(storyOfGame ==3)
                          Story2_2();
                        functionHpHero(hpHero);
                        break;
                    }
                case 4:
                    {
                        if (storyOfGame == 4)
                            Story2_2_2();
                        functionHpHero(hpHero);
                        break;
                    }
                case 6:
                    {
                        if (storyOfGame == 6)
                            Story5();
                        functionHpHero(hpHero);
                        break;
                    }
                case 7:
                    {
                        if (storyOfGame == 7)
                            Story7();
                        functionHpHero(hpHero);
                        break;
                    }
                case 8:
                    {
                        if (storyOfGame == 8)
                            Story8();
                        functionHpHero(hpHero);
                        break;
                    }
                case 10:
                     {
                        if (storyOfGame == 10)
                            Story2_1_1();
                        functionHpHero(hpHero);
                        break;
                    }
                case 11:
                    { 
                        if (storyOfGame == 11)
                            happyEnd();
                        functionHpHero(hpHero);
                        break;
                    }
                case 12:
                    {            
                        if (storyOfGame == 12)
                            badEnd();
                        functionHpHero(hpHero);
                        break;
                    }
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            this.BackgroundImage = Properties.Resources.menuBack1;
            heroView.Visible = false;
            hp1.Visible = false;
            hp2.Visible = false;
            hp3.Visible = false;
            groupBox1.Visible = false;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = false;
            infoLabelStory2.Visible = false;
            backToMenu.Visible = false;
            buttonContinue.Visible = true;
            buttonHelp.Visible = true;
            buttonExit.Visible = true;
            buttonStart.Visible = true;
            startGame.Visible = true;
            continueGame.Visible = true;
            help.Visible = true;
            exit.Visible = true;
            storyOfGame = 0;
            hpHero = 3;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.menuBack1;
            heroView.Visible = false;
            hp1.Visible = false;
            hp2.Visible = false;
            hp3.Visible = false;
            groupBox1.Visible = false;
            helpInfoNext.Visible = false;
            buttonNextStory.Visible = false;
            infoLabelStory.Visible = false;
            infoLabelStory2.Visible = false;
            backToMenu.Visible = false;
            buttonContinue.Visible = true;
            buttonHelp.Visible = true;
            buttonExit.Visible = true;
            buttonStart.Visible = true;
            startGame.Visible = true;
            continueGame.Visible = true;
            help.Visible = true;
            exit.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            menu.Visible = false;
        }
    }
}