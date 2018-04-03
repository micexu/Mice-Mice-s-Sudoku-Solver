using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuCracker
{
    public partial class WelcomeForm : Form
	{
        private int tickcount = 0;
        private int tutorialclickcount = 0;
        Panel[,] TutorialGridBackgroundPanel = new Panel[9, 9];
        Label[,] TutorialGridLabel = new Label[9, 9];
        public WelcomeForm()
		{
            InitializeComponent();
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    TutorialGridBackgroundPanel[row, column] = new Panel();
                    TutorialGridBackgroundPanel[row, column].BackColor = SystemColors.ControlLight;
                    TutorialGridBackgroundPanel[row, column].Location = new Point(0, 0);
                    TutorialGridBackgroundPanel[row, column].Margin = new Padding(1);
                    TutorialGridBackgroundPanel[row, column].Name = "TutorialGridBackgroundPanel(" + row + "," + column + ")";
                    TutorialGridBackgroundPanel[row, column].Size = new Size(30, 30);
                    TutorialGrid.Controls.Add(TutorialGridBackgroundPanel[row, column], column, row);
                    TutorialGridBackgroundPanel[row, column].Click += new EventHandler(TutorialPanel_Click);

                    TutorialGridLabel[row, column] = new Label();
                    TutorialGridLabel[row, column].AutoSize = true;
                    TutorialGridLabel[row, column].Location = new Point(3, 1);
                    TutorialGridLabel[row, column].Font = new Font("微软雅黑", 15.00F, FontStyle.Regular, GraphicsUnit.Point, 134);
                    TutorialGridLabel[row, column].ForeColor = SystemColors.ControlText;
                    TutorialGridLabel[row, column].Name = "TutorialGridLabel(" + row + "," + column + ")";
                    TutorialGridLabel[row, column].Size = new Size(30, 30);
                    TutorialGridLabel[row, column].TabIndex = row * 9 + column + 1;
                    TutorialGridLabel[row, column].TextAlign = ContentAlignment.MiddleCenter;
                    TutorialGridBackgroundPanel[row, column].Controls.Add(TutorialGridLabel[row, column]);
                    TutorialGridLabel[row, column].Click += new EventHandler(TutorialPanel_Click);
                }
            }
        }

        //用Tickhandler触发次数实现周期性淡显变色
        private int TickToFadingAlpha(int count)
        {
            //定义周期，计算相位
            int phase = count % 512;

            //周期前半部分实现淡入效果
            if(phase < 256)
            {
                return phase;
            }

            //周期后半部分实现淡出效果
            else
            {
                return 511 - phase;
            }
        }

        //用Tickhandler触发次数实现周期性闪烁
        private bool TickToBlinkVisible(int count)
        {
            //定义周期，计算相位
            int phase = count % 100;

            //周期前半部分目标出现
            if(phase < 50)
            {
                return true;
            }

            //周期后半部分目标消失
            else
            {
                return false;
            }
        }

        //传入起始色、目标色和alpha值，计算并返回中间alpha位置的颜色
        static Color MiddleColor(Color background, Color target, int alpha)
        {
            //获取背景色RGB值（从ARGB换算）
            int backR = (int)background.A * (int)background.R / 255;
            int backG = (int)background.A * (int)background.G / 255;
            int backB = (int)background.A * (int)background.B / 255;
            
            //获取前景色RGB指（从ARGB换算）
            int frontR = (int)target.A * (int)target.R / 255;
            int frontG = (int)target.A * (int)target.G / 255;
            int frontB = (int)target.A * (int)target.B / 255;

            //利用alpha和255的比指计算前景色和背景色的RGB比重
            int currentR = (alpha * frontR / 255) + ((255 - alpha) * backR / 255);
            int currentG = (alpha * frontG / 255) + ((255 - alpha) * backG / 255);
            int currentB = (alpha * frontB / 255) + ((255 - alpha) * backB / 255);

            //RGB值换算颜色后返回
            return Color.FromArgb(currentR, currentG, currentB);
        }

        //使用计时器的Tickhandler实现变色和闪烁
        private void MasterTimer_Tick(object sender, EventArgs e)
        {
            //tick触发的计数器自加
            tickcount++;

            //计数器换算成各效果所需值
            int alpha = TickToFadingAlpha(tickcount);
            bool visible = TickToBlinkVisible(tickcount);

            //用所需值实现各效果
            MainTitleEN.ForeColor = MainTitleCN.ForeColor = MiddleColor(this.BackColor, Color.Black, alpha);
            ExitTutorialLabel.Visible = visible;

            //在标题达到完全不透明时显示按钮
            if (tickcount == 256)
            {
                StartButton.Visible = true;
                AboutButton.Visible = true;
                ExitButton.Visible = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainTitle_MouseEnter(object sender, EventArgs e)
        {
            MainStatusLabel.Text = "本求解器使用递归算法。/ Core algorithm of this program is recursion.";
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            MainStatusLabel.Text = "鼠标所指内容将在此显示说明。/ Instructions will be displayed here.";
        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            MainStatusLabel.Text = "进入数独求解器。/ Click to start the program from creating plzzles.";
        }

        private void AboutButton_MouseEnter(object sender, EventArgs e)
        {
            MainStatusLabel.Text = "关于本程序的信息。/ Informations about this program.";
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            MainStatusLabel.Text = "退出本程序。/ Exit and see you next time.";
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("数独求解器 / Sudoku solver\n" +
                "版本 / Version: 0.01a\n" +
                "作者 / Maker: 徐健行 / Mice Xu\n" +
                "备注: 本程序是作者自学C#和Windows Form后制作的首个程序。作为自我提升的证明和申请、应聘.NET实习生职位，本代码欢迎他人使用、分享。\n" +
                "Notice: This is my first program after I study C# and Windows Form by my own. As a material for aprooving my own skills and applying for junior .NET developing position, codes in this program are allowed to be used by those in need and welcome to share around.");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TutorialPanel.Visible = true;
        }

        private void TutorialPanel_Click(object sender, EventArgs e)
        {
            tutorialclickcount++;
            switch (tutorialclickcount)
            {
                case 1:
                    TutorialTipLabel.Text = "玩家须将数字1-9填入各方格中， 使得每一行、每一列包含1-9所有数字。\n" +
                        "Players need to fill the digits with numbers from 1 to 9, so that each row, each column contains all of the digits from 1 to 9.";
                    int[,] examplesudokuanswer = new int[9, 9]
                    { { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, { 6, 7, 2, 1, 9, 5, 3, 4, 8 }, { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                    { 8, 5, 9, 7, 6, 1, 4, 2, 3 }, { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                    { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, { 2, 8, 7, 4, 1, 9, 6, 3, 5 }, { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            TutorialGridLabel[row, column].Text = examplesudokuanswer[row, column].ToString();
                        }
                    }
                    break;
                case 2:
                    TutorialTipLabel.Text = "此外，数独还含有9个3行×3列的小方格阵。（在上图中用不同颜色标记）\n" +
                        "In addition, Sudoku also contains 9 small girds with 3 rows × 3 columns.(Label in the form above with different colors)";
                    int boxindex, boxgridindex;
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            Sudoku.GridToBox(row, column, out boxindex, out boxgridindex);
                            if (boxindex % 2 == 0)
                            {
                                TutorialGridBackgroundPanel[row, column].BackColor = SystemColors.ControlDark;
                            }
                        }
                    }
                    break;
                case 3:
                    TutorialTipLabel.Text = "这些小方格阵称为“宫”。同样地，玩家也须确保每一个宫包含1-9所有数字。\n" +
                        "These small grids is called \"box\". Similarly, players need to ensure each box contains all of the digits from 1 to 9.";
                    break;
                case 4:
                    TutorialTipLabel.Text = "通常，玩家并不是从头开始填一份空白的数独，出题者会提供一部分数字提示，使之成为一道谜题。\n" +
                        "Usually, players don't fill an emplty Sudoku from the beginning. Makers would offer some digits as hints, which make Sudoku become a puzzle.";
                    string[,] examplesudokupuzzle = new string[9, 9]
                    { { "5", "3", "", "", "7", "", "", "", "" }, { "6", "", "", "1", "9", "5", "", "", "" }, { "", "9", "8", "", "", "", "", "6", ""},
                    { "8", "", "", "", "6", "", "", "", "3" }, { "4", "", "", "8", "", "3", "", "", "1" }, { "7", "", "", "", "2", "", "", "", "6" },
                    { "", "6", "", "", "", "", "2", "8", "" }, { "", "", "", "4", "1", "9", "", "", "5" }, { "", "", "", "", "8", "", "", "7", "9" } };
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            TutorialGridLabel[row, column].Text = examplesudokupuzzle[row, column];
                            if (TutorialGridLabel[row, column].Text != "")
                            {
                                TutorialGridLabel[row, column].ForeColor = Color.Blue;
                            }
                        }
                    }
                    break;
                case 5:
                    TutorialTipLabel.Text = "按照以上的规则，玩家在完成数独谜题后，会得出该谜题的答案。\n" +
                        "Following the rule above, after finish the Sudoku puzzle, players would get the answer.";
                    int[,] examplesudokupuzzleanswer = new int[9, 9]
                    { { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, { 6, 7, 2, 1, 9, 5, 3, 4, 8 }, { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                    { 8, 5, 9, 7, 6, 1, 4, 2, 3 }, { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                    { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, { 2, 8, 7, 4, 1, 9, 6, 3, 5 }, { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            TutorialGridLabel[row, column].Text = examplesudokupuzzleanswer[row, column].ToString();
                        }
                    }
                    break;
                case 6:
                    TutorialTipLabel.Text = "因此，该程序正是为了计算给定谜题的答案而设计的。\n" +
                        "So this is the very program which is designed for calculating the answer of given puzzles.";
                    break;
                case 7:
                    TutorialTipLabel.Text = "另外，谜题的答案并不总是唯一的；相反地，谜题的答案也并不总是存在的。\n" +
                        "Besides, the answer of a puzzle is not always unique. Contrarily, the answer is not always existent either.";
                    string[,] examplesudokucrappuzzle = new string[9, 9]
                    { { "1", "2", "3", "?", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "" }, { "", "", "", "7", "8", "9", "", "", ""},
                    { "", "", "", "4", "", "", "", "", "" }, { "", "", "", "5", "", "", "", "", "" }, { "", "", "", "6", "", "", "", "", "" },
                    { "", "", "", "", "", "", "?", "?", "?" }, { "", "", "", "", "", "", "?", "?", "?" }, { "", "", "", "", "", "", "?", "?", "?" } };
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            TutorialGridLabel[row, column].ForeColor = SystemColors.ControlText;
                            TutorialGridLabel[row, column].Text = examplesudokucrappuzzle[row, column];
                            if (TutorialGridLabel[row, column].Text != "")
                            {
                                TutorialGridLabel[row, column].ForeColor = Color.Blue;
                                if (TutorialGridLabel[row, column].Text == "?")
                                {
                                    TutorialGridLabel[row, column].ForeColor = Color.Purple;
                                }
                            }
                        }
                    }
                    break;
                case 8:
                    TutorialTipLabel.Text = "对于那些多个答案或者没有答案的谜题，玩家的体验会大幅下降。\n" +
                        "For those puzzles whose answers, either non-unique or non-existent ones would make players' experiences drop a lot.";
                    break;
                case 9:
                    TutorialTipLabel.Text = "所以，有且仅有一个答案的谜题才能称为“好”的谜题。\n" +
                        "So the puzzles with an existent and unique answer is able to be called \"good\" ones.";
                    string[,] examplesudokugoodpuzzle = new string[9, 9]
                    { { "5", "3", "", "", "7", "", "", "", "" }, { "6", "", "", "1", "9", "5", "", "", "" }, { "", "9", "8", "", "", "", "", "6", ""},
                    { "8", "", "", "", "6", "", "", "", "3" }, { "4", "", "", "8", "", "3", "", "", "1" }, { "7", "", "", "", "2", "", "", "", "6" },
                    { "", "6", "", "", "", "", "2", "8", "" }, { "", "", "", "4", "1", "9", "", "", "5" }, { "", "", "", "", "8", "", "", "7", "9" } };
                    for (int row = 0; row < 9; row++)
                    {
                        for (int column = 0; column < 9; column++)
                        {
                            TutorialGridLabel[row, column].ForeColor = SystemColors.ControlText;
                            TutorialGridLabel[row, column].Text = examplesudokugoodpuzzle[row, column];
                            if (TutorialGridLabel[row, column].Text != "")
                            {
                                TutorialGridLabel[row, column].ForeColor = Color.Blue;
                            }
                        }
                    }
                    break;
                case 10:
                    TutorialTipLabel.Text = "进一步来说，计算谜题答案的个数，甚至生成一道“好”的谜题，也设计在此程序里。\n" +
                        "Furthermore, calculating the amount of answers, even generating a \"good\" puzzle, these functions are designed in this program as well.";
                    break;
                case 11:
                    TutorialTipLabel.Text = "那么接下来，希望您使用愉快。\n" +
                        "Coming up, hope you enjoy this program.\n" +
                        "（教程结束，单击鼠标或者按Esc继续）\n" +
                        "(Tutorial done, press 'Esc' button or click to continue)";
                    break;
                default:
                    object sd = new object();
                    char kc = (char)27;
                    KeyPressEventArgs ee = new KeyPressEventArgs(kc);
                    WelcomeForm_KeyPress(sd, ee);
                    break;
            }
        }

        private void WelcomeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27 && TutorialPanel.Visible)
            {
                tutorialclickcount = 0;
                TutorialPanel.Visible = false;
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        TutorialGridLabel[row, column].Text = "";
                    }
                }
                TutorialTipLabel.Text = "数独由9行×9列的方格阵组成。\nSudoku is a gird formed with 9 rows × 9 columns." +
                    "\n（单击鼠标继续，下同）\n(Click to continue, same below)";
                FunctionForm function = new FunctionForm();
                function.ShowDialog();
            }
        }

        private void WelcomeForm_Activated(object sender, EventArgs e)
        {
            MasterTimer.Start();
        }

        private void WelcomeForm_Deactivate(object sender, EventArgs e)
        {
            MasterTimer.Stop();
        }
    }
}
