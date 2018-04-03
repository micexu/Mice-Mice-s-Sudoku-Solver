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
    public partial class FunctionForm : Form
    {
        Panel[,] SudokuGridBackgroundPanel = new Panel[9, 9];
        Label[,] SudokuGridLabel = new Label[9, 9];
        public string ManualMode;
        public string AutoMode;
        private int tickcount = 0;
        private int blinkingrow = 0;
        private int blinkingcolumn = 0;
        private int[,] numberarray = new int[9, 9];
        private List<int[,]> steprecord = new List<int[,]>();
        private int stepindex = 0;

        public FunctionForm()
        {
            InitializeComponent();
            ManualPanel.Location = new Point(0, 0);

            //显示数独的Panel和Label数组
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    SudokuGridBackgroundPanel[row, column] = new Panel();
                    Sudoku.GridToBox(row, column, out int boxindex, out int boxgridindex);
                    if (boxindex % 2 == 0)
                    {
                        SudokuGridBackgroundPanel[row, column].BackColor = SystemColors.ControlDark;
                    }
                    else
                    {
                        SudokuGridBackgroundPanel[row, column].BackColor = SystemColors.ControlLight;
                    }
                    SudokuGridBackgroundPanel[row, column].Location = new Point(0, 0);
                    SudokuGridBackgroundPanel[row, column].Margin = new Padding(1);
                    SudokuGridBackgroundPanel[row, column].Name = "SudokuGridBackgroundPanel(" + row + "," + column + ")";
                    SudokuGridBackgroundPanel[row, column].Size = new Size(30, 30);
                    SudokuTablePanel.Controls.Add(SudokuGridBackgroundPanel[row, column], column, row);
                    SudokuGridBackgroundPanel[row, column].Click += new EventHandler(SudokuGrid_Click);

                    SudokuGridLabel[row, column] = new Label();
                    SudokuGridLabel[row, column].AutoSize = true;
                    SudokuGridLabel[row, column].Location = new Point(3, 1);
                    SudokuGridLabel[row, column].Font = new Font("微软雅黑", 15.00F, FontStyle.Regular, GraphicsUnit.Point, 134);
                    SudokuGridLabel[row, column].Name = "SudokuGridLabel(" + row + "," + column + ")";
                    SudokuGridLabel[row, column].Size = new Size(30, 30);
                    SudokuGridLabel[row, column].TabIndex = row * 9 + column + 1;
                    SudokuGridLabel[row, column].TextAlign = ContentAlignment.MiddleCenter;
                    SudokuGridBackgroundPanel[row, column].Controls.Add(SudokuGridLabel[row, column]);
                    SudokuGridLabel[row, column].Click += new EventHandler(SudokuGrid_Click);
                    SudokuGridLabel[row, column].TextChanged += new EventHandler(SudokuGridLabel_TextChanged);
                }
            }
        }

        //点击手动输入和手动作答按钮
        private void Manual_Click(object sender, EventArgs e)
        {
            //清除对话框信息
            SudokuDialogLabel.Text = "";
            HintsTrackBar.Visible = HintsUpDown.Visible = GenerateButton.Visible = false;

            //点击手动输入时模式标记为“generate”，手动作答是模式标记为“solve”
            if (sender == GenerateManualButton)
            {
                ManualMode = "generate";
            }
            else
            {
                ManualMode = "solve";
            }

            //记录空白数独为首个还原点
            if (stepindex == 0)
            {
                steprecord.Add(new int[9, 9]);
                stepindex++;
            }

            //显示输入面板
            ManualPanel.Visible = true;

            //开始计时
            FunctionTimer.Start();

            //方格（0,0）背景色变白
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
        }

        //切换单选按钮
        private void ManualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //TrackBar和UpDown的Enable属性均和RadioButton的Checked属性一致
            ManualRowTrackBar.Enabled
                = ManualRowUpDown.Enabled
                = ManualRowLabel.Enabled
                = ManualColumnTrackBar.Enabled
                = ManualColumnUpDown.Enabled
                = ManualColumnLabel.Enabled
                = ManualRCModeRadioButton.Checked;

            ManualBoxTrackBar.Enabled
                = ManualBoxUpDown.Enabled
                = ManualBoxLabel.Enabled
                = ManualBoxGridTrackBar.Enabled
                = ManualBoxGridUpDown.Enabled
                = ManualBoxGridLabel.Enabled
                = ManualBGModeRadioButton.Checked;
        }

        //改变行TrackBar值属性
        private void ManualRowTrackBar_ValueChanged(object sender, EventArgs e)
        {

            //清除对话框信息
            SudokuDialogLabel.Text = "";

            //原位置底色复位
            Sudoku.GridToBox(blinkingrow, blinkingcolumn, out int boxindex, out int boxgridindex);
            if (boxindex % 2 == 0)
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlDark;
            }
            else
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLight;
            }

            //原位置文字复位
            SudokuGridLabel[blinkingrow, blinkingcolumn].Text = numberarray[blinkingrow, blinkingcolumn].ToString();

            //消除红色标记
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (numberarray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //改变位置
            blinkingrow = ManualRowTrackBar.Value - 1;
            blinkingcolumn = ManualColumnTrackBar.Value - 1;

            //当前位置底色高亮，ManualValueTrackBar控件复位
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
            ManualValueTrackBar.Value = 0;

            //关联UpDown控件
            ManualRowUpDown.Value = ManualRowTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out boxindex, out boxgridindex);
            ManualBoxTrackBar.Value = boxindex + 1;
            ManualBoxGridTrackBar.Value = boxgridindex + 1;
        }

        //改变行UpDown值属性
        private void ManualRowUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualRowTrackBar.Value = (int)ManualRowUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out int boxindex, out int boxgridindex);
            ManualBoxTrackBar.Value = boxindex + 1;
            ManualBoxGridTrackBar.Value = boxgridindex + 1;
        }

        //改变列TrackBar值属性
        private void ManualColumnTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //清除对话框信息
            SudokuDialogLabel.Text = "";

            //原位置底色复位
            Sudoku.GridToBox(blinkingrow, blinkingcolumn, out int boxindex, out int boxgridindex);
            if (boxindex % 2 == 0)
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlDark;
            }
            else
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLight;
            }

            //原位置文字复位
            SudokuGridLabel[blinkingrow, blinkingcolumn].Text = numberarray[blinkingrow, blinkingcolumn].ToString();

            //消除红色标记
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (numberarray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //改变位置
            blinkingrow = ManualRowTrackBar.Value - 1;
            blinkingcolumn = ManualColumnTrackBar.Value - 1;

            //当前位置底色高亮，ManualValueTrackBar控件复位
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
            ManualValueTrackBar.Value = 0;

            //关联UpDown控件
            ManualColumnUpDown.Value = ManualColumnTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out boxindex, out boxgridindex);
            ManualBoxTrackBar.Value = boxindex + 1;
            ManualBoxGridTrackBar.Value = boxgridindex + 1;
        }

        //改变列UpDown值属性
        private void ManualColumnUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualColumnTrackBar.Value = (int)ManualColumnUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out int boxindex, out int boxgridindex);
            ManualBoxTrackBar.Value = boxindex + 1;
            ManualBoxGridTrackBar.Value = boxgridindex + 1;
        }

        //改变宮TrackBar值属性
        private void ManualBoxTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联Updown控件
            ManualBoxUpDown.Value = ManualBoxTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = rowindex + 1;
            ManualColumnTrackBar.Value = columnindex + 1;
        }

        //改变宮UpDown值属性
        private void ManualBoxUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualBoxTrackBar.Value = (int)ManualBoxUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = rowindex + 1;
            ManualColumnTrackBar.Value = columnindex + 1;
        }

        //改变宮格TrackBar值属性
        private void ManualBoxGridTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联Updown控件
            ManualBoxGridUpDown.Value = ManualBoxGridTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = rowindex + 1;
            ManualColumnTrackBar.Value = columnindex + 1;
        }

        //改变宫格UpDown值属性
        private void ManualBoxGridUpDown_ValueVChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualBoxGridTrackBar.Value = (int)ManualBoxGridUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = rowindex + 1;
            ManualColumnTrackBar.Value = columnindex + 1;
        }

        //单击数独上各Panel和Label
        private void SudokuGrid_Click(object sender, EventArgs e)
        {
            //根据sender改变行列TrackBar值
            if (ManualPanel.Visible)
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        if (sender == SudokuGridBackgroundPanel[row, column] || sender == SudokuGridLabel[row, column])
                        {
                            ManualRowTrackBar.Value = row + 1;
                            ManualColumnTrackBar.Value = column + 1;
                        }
                    }
                }
            }
        }

        //计时器Tickhandler实现闪烁
        private void FunctionTimer_Tick(object sender, EventArgs e)
        {
            //tickcount计数器自加
            tickcount++;

            //根据计数器的奇偶性实现当前方格闪烁
            if (ManualPanel.Visible)
            {
                if (tickcount % 2 == 0)
                {
                    SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
                }
                else
                {
                    Sudoku.GridToBox(blinkingrow, blinkingcolumn, out int boxindex, out int boxgridindex);
                    if (boxindex % 2 == 0)
                    {
                        SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlDark;
                    }
                    else
                    {
                        SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLight;
                    }
                }
            }
        }

        //改变值TrackBar属性
        private void ManualValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联UpDown控件
            ManualValueUpDown.Value = ManualValueTrackBar.Value;

            //在Label显示Value值
            SudokuGridLabel[blinkingrow, blinkingcolumn].Text = ManualValueTrackBar.Value.ToString();

        }

        //改变值UpDown属性
        private void ManualValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar值
            ManualValueTrackBar.Value = (int)ManualValueUpDown.Value;
        }

        //改变Label的Text值
        private void SudokuGridLabel_TextChanged(object sender, EventArgs e)
        {
            //实例化一个Label接收sender
            Label label = sender as Label;

            //将“0”值更换成“”值，更换颜色
            if (label.Text == "0")
            {
                label.Text = "";
                label.ForeColor = SystemColors.ControlText;
            }

            //更换颜色
            else
            {
                label.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        //检测键盘按键
        private void FunctionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按键转化成相应TrackBar值属性并且执行单击下一步按钮
            if (ManualPanel.Visible && ManualValueTrackBar.Enabled)
            {
                switch (e.KeyChar)
                {
                    case (char)49:
                        ManualValueTrackBar.Value = 1;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)50:
                        ManualValueTrackBar.Value = 2;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)51:
                        ManualValueTrackBar.Value = 3;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)52:
                        ManualValueTrackBar.Value = 4;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)53:
                        ManualValueTrackBar.Value = 5;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)54:
                        ManualValueTrackBar.Value = 6;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)55:
                        ManualValueTrackBar.Value = 7;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)56:
                        ManualValueTrackBar.Value = 8;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)57:
                        ManualValueTrackBar.Value = 9;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    case (char)8:
                    case (char)48:
                    case (char)127:
                        ManualValueTrackBar.Value = 0;
                        ManualNextButton_Click(new object(), new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }

        //单击下一步按钮
        private void ManualNextButton_Click(object sender, EventArgs e)
        {
            //清除红色标记
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (numberarray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //清除对话框信息
            SudokuDialogLabel.Text = "";

            //value赋值到numberarray
            if (ManualValueTrackBar.Value == 0 && numberarray[blinkingrow, blinkingcolumn] != 0)
            {
                SudokuGridLabel[blinkingrow, blinkingcolumn].Text = "0";
                numberarray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                SudokuDialogLabel.Text = "方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")清除数值成功。\n" +
                    "Erase value in(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") successful.";
            }
            else if (Sudoku.CheckRule(numberarray, blinkingrow, blinkingcolumn, ManualValueTrackBar.Value, SudokuGridLabel, SudokuDialogLabel))
            {
                numberarray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                SudokuGridLabel[blinkingrow, blinkingcolumn].Text = ManualValueTrackBar.Value.ToString();
                SudokuGridLabel[blinkingrow, blinkingcolumn].ForeColor = Color.DarkBlue;
                SudokuDialogLabel.Text = "方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")填入数值" + ManualValueTrackBar.Value + "成功。\n" +
                    "Fill(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") with value " + ManualValueTrackBar.Value + " successful.";
            }
            else
            {
                return;
            }

            //检测是否重复赋值及是否所有方格空白
            bool issimular = true, isblank = true;
            for (int row = 0; row < 9; row++)
            {
                if (!isblank && !issimular)
                {
                    break;
                }
                for (int column = 0; column < 9; column++)
                {
                    if (!isblank && !issimular)
                    {
                        break;
                    }
                    if (numberarray[row, column] != 0)
                    {
                        isblank = false;
                    }
                    if (steprecord[stepindex - 1][row, column] != numberarray[row, column])
                    {
                        issimular = false;
                    }
                }
            }

            //重复赋值终止记录
            if (steprecord.Count > 0 && issimular)
            {
                return;
            }

            //numberarray赋值到steprecord
            steprecord.Add(new int[9, 9]);
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    steprecord[stepindex][row, column] = numberarray[row, column];
                }
            }

            //若曾经撤销过重新赋值则作为最新记录
            if (steprecord.Count > stepindex + 1)
            {
                steprecord.RemoveRange(stepindex + 1, steprecord.Count - stepindex - 1);
                steprecord.TrimExcess();
            }

            //步骤计数器自加
            stepindex++;

            //撤销按钮设为可用
            ManualUndoButton.Enabled = true;

            //存在非空白方格时清空按钮设为可用
            ManualClearButton.Enabled = !isblank;

            //重做按钮设为不可用
            ManualRedoButton.Enabled = false;
        }

        //单击完成按钮
        private void ManualDoneButton_Click(object sender, EventArgs e)
        {
            //声明Sudoku实例并赋值
            Sudoku Tosolve = new Sudoku(numberarray);

            //停止计时
            FunctionTimer.Stop();

            //TrackBar和UpDown控件复位
            ManualRowTrackBar.Value = 1;
            ManualColumnTrackBar.Value = 1;
            ManualValueTrackBar.Value = 0;


            //还原背景色
            Sudoku.GridToBox(blinkingrow, blinkingcolumn, out int boxindex, out int boxgridindex);
            if (boxindex % 2 == 0)
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlDark;
            }
            else
            {
                SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLight;
            }

            //隐藏输入面板
            ManualPanel.Visible = false;

            //存在非空白方格时自动生成按钮设为不可用
            bool isblank = true;
            for (int row = 0; row < 9; row++)
            {
                if (!isblank)
                {
                    break;
                }
                for (int column = 0; column < 9; column++)
                {
                    if (steprecord[stepindex - 1][row, column] != 0)
                    {
                        isblank = false;
                        break;
                    }
                }
            }
            GenerateSemiAutoButton.Enabled = GenerateAutoButton.Enabled = isblank;
        }

        //单击撤销按钮
        private void ManualUndoButton_Click(object sender, EventArgs e)
        {
            //清除对话框消息
            SudokuDialogLabel.Text = "";

            //stepindex自减
            stepindex -= 2;

            //撤销到尽头时撤销按钮设为不可用
            if (stepindex == 0)
            {
                ManualUndoButton.Enabled = false;
            }

            //检测是否所有方格空白
            bool isblank = true;
            for (int row = 0; row < 9; row++)
            {
                if (!isblank)
                {
                    break;
                }
                for (int column = 0; column < 9; column++)
                {
                    if (steprecord[stepindex][row, column] != 0)
                    {
                        isblank = false;
                        break;
                    }
                }
            }

            //所有方格空白时清空按钮设为不可用
            ManualClearButton.Enabled = !isblank;

            //重做按钮设为可用
            ManualRedoButton.Enabled = true;

            //显示上一还原点的内容
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    numberarray[row, column] = steprecord[stepindex][row, column];
                    SudokuGridLabel[row, column].Text = numberarray[row, column].ToString();
                    if (numberarray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //stepindex自加
            stepindex++;
        }

        private void ManualRedoButton_Click(object sender, EventArgs e)
        {
            //清除对话框信息
            SudokuDialogLabel.Text = "";

            //重做到尽头时重做按钮设为不可用
            if (stepindex == steprecord.Count - 1)
            {
                ManualRedoButton.Enabled = false;
            }

            //撤销按钮设为可用
            ManualUndoButton.Enabled = true;

            //检测是否所有方格空白
            bool isblank = true;
            for (int row = 0; row < 9; row++)
            {
                if (!isblank)
                {
                    break;
                }
                for (int column = 0; column < 9; column++)
                {
                    if (steprecord[stepindex][row, column] != 0)
                    {
                        isblank = false;
                        break;
                    }
                }
            }

            //所有方格空白时清空按钮设为不可用
            ManualClearButton.Enabled = !isblank;

            //显示下一还原点的内容
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    numberarray[row, column] = steprecord[stepindex][row, column];
                    SudokuGridLabel[row, column].Text = numberarray[row, column].ToString();
                    if (numberarray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //stepindex自加
            stepindex++;
        }

        private void ManualClearButton_Click(object sender, EventArgs e)
        {
            //清除对话框信息
            SudokuDialogLabel.Text = "";

            //所有方格清空并将numberarray赋值到steprecord
            steprecord.Add(new int[9, 9]);
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    steprecord[stepindex][row, column] = numberarray[row, column] = 0;
                    SudokuGridLabel[row, column].Text = numberarray[row, column].ToString();
                    SudokuGridLabel[row, column].ForeColor = SystemColors.ControlText;
                }
            }

            //若曾经撤销过重新赋值则作为最新记录
            if (steprecord.Count > stepindex + 1)
            {
                steprecord.RemoveRange(stepindex + 1, steprecord.Count - stepindex - 1);
                steprecord.TrimExcess();
            }

            //stepindex自加        
            stepindex++;

            //撤销按钮设为可用
            ManualUndoButton.Enabled = true;

            //清空按钮设为不可用
            ManualClearButton.Enabled = false;

            //重做按钮设为不可用
            ManualRedoButton.Enabled = false;
        }

        private void GenerateSemiAutoButton_Click(object sender, EventArgs e)
        {
            AutoMode = "SemiAuto";
            HintsTrackBar.Visible = HintsUpDown.Visible = GenerateButton.Visible = true;
            SudokuDialogLabel.Text = "提示数 /\nHints";
        }

        private void GenerateAutoButton_Click(object sender, EventArgs e)
        {
            AutoMode = "Auto";
            HintsTrackBar.Visible = HintsUpDown.Visible = false;
            GenerateButton.Visible = true;
            SudokuDialogLabel.Text = "点击以确认生成。 /\nClick to confirm generation.";
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //隐藏HintsTrackBar、HintsUpDown和GenerateButton控件
            HintsTrackBar.Visible = HintsUpDown.Visible = GenerateButton.Visible = false;

            //记录空白数独为首个还原点
            steprecord.Add(new int[9, 9]);
            stepindex++;

            //按提示数生成谜题
            if (AutoMode == "SemiAuto")
            {
                Sudoku SemiAuto = new Sudoku();
                for (int hintscount = 0; hintscount < HintsTrackBar.Value; hintscount++)
                {
                    SemiAuto.GenerateOneHint(out int rowindex, out int columnindex, out int value);
                    ManualRowTrackBar.Value = rowindex + 1;
                    ManualColumnTrackBar.Value = columnindex + 1;
                    ManualValueTrackBar.Value = value;
                    ManualNextButton_Click(new object(), new EventArgs());
                }
                ManualDoneButton_Click(new object(), new EventArgs());
            }
        }

        private void HintsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联Updown控件
            HintsUpDown.Value = HintsTrackBar.Value;
        }

        private void HintsUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            HintsTrackBar.Value = (int)HintsUpDown.Value;
        }
    }
}
