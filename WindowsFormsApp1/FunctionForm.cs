using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SudokuCracker
{
    public partial class FunctionForm : Form
    {
        public FunctionForm()
        {
            InitializeComponent();
            GenerateSudoku();
            GenerateManual();
            GenerateSemiAuto();
            GenerateSolve();
            GenerateAnswer();
            GenerateSave();
        }

        //生成数独面板
        public Panel[,] SudokuGridBackgroundPanel = new Panel[9, 9];
        public Label[,] SudokuGridLabel = new Label[9, 9];
        public Label SudokuDialogLabel = new Label();
        private void GenerateSudoku()
        {
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
                    SudokuGridBackgroundPanel[row, column].MouseEnter += new EventHandler(SudokuGrid_MouseEnter);
                    SudokuGridBackgroundPanel[row, column].MouseLeave += new EventHandler(FunctionForm_MouseLeave);

                    SudokuGridLabel[row, column] = new Label();
                    SudokuGridLabel[row, column].AutoSize = true;
                    SudokuGridLabel[row, column].Location = new Point(3, 1);
                    SudokuGridLabel[row, column].Font = new Font("微软雅黑", 15.00F, FontStyle.Regular, GraphicsUnit.Point, 134);
                    SudokuGridLabel[row, column].Name = "SudokuGridLabel(" + row + "," + column + ")";
                    SudokuGridLabel[row, column].Size = new Size(30, 30);
                    SudokuGridLabel[row, column].TextAlign = ContentAlignment.MiddleCenter;
                    SudokuGridBackgroundPanel[row, column].Controls.Add(SudokuGridLabel[row, column]);
                    SudokuGridLabel[row, column].Click += new EventHandler(SudokuGrid_Click);
                    SudokuGridLabel[row, column].TextChanged += new EventHandler(SudokuGridLabel_TextChanged);
                    SudokuGridLabel[row, column].MouseEnter += new EventHandler(SudokuGrid_MouseEnter);
                    SudokuGridLabel[row, column].MouseLeave += new EventHandler(FunctionForm_MouseLeave);

                    SudokuDialogLabel.AutoSize = true;
                    SudokuDialogLabel.Location = new Point(6, 19);
                    SudokuDialogLabel.Name = "SudokuDialogLabel";
                    SudokuDialogLabel.Size = new Size(0, 17);
                    SudokuDialogGroupBox.Controls.Add(SudokuDialogLabel);
                }
            }
        }

        //生成手动填写面板
        public Panel ManualPanel = new Panel();
        public GroupBox ManualGroupBox = new GroupBox();
        public Label ManualRowLabel = new Label();
        public NumericUpDown ManualRowUpDown = new NumericUpDown();
        public TrackBar ManualRowTrackBar = new TrackBar();
        public RadioButton ManualRCModeRadioButton = new RadioButton();
        public Label ManualColumnLabel = new Label();
        public NumericUpDown ManualColumnUpDown = new NumericUpDown();
        public TrackBar ManualColumnTrackBar = new TrackBar();
        public RadioButton ManualBGModeRadioButton = new RadioButton();
        public Label ManualBoxGridLabel = new Label();
        public NumericUpDown ManualBoxGridUpDown = new NumericUpDown();
        public Label ManualBoxLabel = new Label();
        public NumericUpDown ManualBoxUpDown = new NumericUpDown();
        public TrackBar ManualBoxTrackBar = new TrackBar();
        public Button ManualClearButton = new Button();
        public Button ManualRedoButton = new Button();
        public Button ManualUndoButton = new Button();
        public Button ManualDoneButton = new Button();
        public Button ManualNextButton = new Button();
        public Label ManualValueLabel = new Label();
        public NumericUpDown ManualValueUpDown = new NumericUpDown();
        public TrackBar ManualValueTrackBar = new TrackBar();
        public TrackBar ManualBoxGridTrackBar = new TrackBar();
        private void GenerateManual()
        {
            ManualPanel.SuspendLayout();
            ManualGroupBox.SuspendLayout();
            ((ISupportInitialize)(ManualValueUpDown)).BeginInit();
            ((ISupportInitialize)(ManualBoxGridUpDown)).BeginInit();
            ((ISupportInitialize)(ManualColumnUpDown)).BeginInit();
            ((ISupportInitialize)(ManualValueTrackBar)).BeginInit();
            ((ISupportInitialize)(ManualBoxUpDown)).BeginInit();
            ((ISupportInitialize)(ManualColumnTrackBar)).BeginInit();
            ((ISupportInitialize)(ManualBoxGridTrackBar)).BeginInit();
            ((ISupportInitialize)(ManualBoxTrackBar)).BeginInit();
            ((ISupportInitialize)(ManualRowUpDown)).BeginInit();
            ((ISupportInitialize)(ManualRowTrackBar)).BeginInit();

            ManualPanel.Controls.Add(ManualGroupBox);
            ManualPanel.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ManualPanel.Location = new Point(0, 0);
            ManualPanel.Name = "ManualPanel";
            ManualPanel.Size = new Size(235, 390);
            ManualPanel.Visible = false;

            ManualGroupBox.Controls.Add(ManualClearButton);
            ManualGroupBox.Controls.Add(ManualRedoButton);
            ManualGroupBox.Controls.Add(ManualUndoButton);
            ManualGroupBox.Controls.Add(ManualDoneButton);
            ManualGroupBox.Controls.Add(ManualNextButton);
            ManualGroupBox.Controls.Add(ManualBGModeRadioButton);
            ManualGroupBox.Controls.Add(ManualValueLabel);
            ManualGroupBox.Controls.Add(ManualBoxGridLabel);
            ManualGroupBox.Controls.Add(ManualRCModeRadioButton);
            ManualGroupBox.Controls.Add(ManualValueUpDown);
            ManualGroupBox.Controls.Add(ManualBoxGridUpDown);
            ManualGroupBox.Controls.Add(ManualColumnLabel);
            ManualGroupBox.Controls.Add(ManualBoxLabel);
            ManualGroupBox.Controls.Add(ManualColumnUpDown);
            ManualGroupBox.Controls.Add(ManualValueTrackBar);
            ManualGroupBox.Controls.Add(ManualRowLabel);
            ManualGroupBox.Controls.Add(ManualBoxUpDown);
            ManualGroupBox.Controls.Add(ManualColumnTrackBar);
            ManualGroupBox.Controls.Add(ManualBoxGridTrackBar);
            ManualGroupBox.Controls.Add(ManualBoxTrackBar);
            ManualGroupBox.Controls.Add(ManualRowUpDown);
            ManualGroupBox.Controls.Add(ManualRowTrackBar);
            ManualGroupBox.Location = new Point(20, 10);
            ManualGroupBox.Name = "ManualGroupBox";
            ManualGroupBox.Size = new Size(215, 380);
            ManualGroupBox.TabStop = false;
            ManualGroupBox.Text = "手动输入 / Manually input";

            ManualClearButton.Enabled = false;
            ManualClearButton.Location = new Point(143, 345);
            ManualClearButton.Name = "ManualClearButton";
            ManualClearButton.Size = new Size(60, 23);
            ManualClearButton.Text = "×";
            ManualClearButton.UseVisualStyleBackColor = true;
            ManualClearButton.Click += new EventHandler(ManualClearButton_Click);
            ManualClearButton.MouseEnter += new EventHandler(ManualClearButton_MouseEnter);
            ManualClearButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualRedoButton.Enabled = false;
            ManualRedoButton.Location = new Point(76, 345);
            ManualRedoButton.Name = "ManualRedoButton";
            ManualRedoButton.Size = new Size(60, 23);
            ManualRedoButton.Text = "→";
            ManualRedoButton.UseVisualStyleBackColor = true;
            ManualRedoButton.Click += new EventHandler(ManualRedoButton_Click);
            ManualRedoButton.MouseEnter += new EventHandler(ManualRedoButton_MouseEnter);
            ManualRedoButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualUndoButton.Enabled = false;
            ManualUndoButton.Location = new Point(9, 345);
            ManualUndoButton.Name = "ManualUndoButton";
            ManualUndoButton.Size = new Size(60, 23);
            ManualUndoButton.Text = "←";
            ManualUndoButton.UseVisualStyleBackColor = true;
            ManualUndoButton.Click += new EventHandler(ManualUndoButton_Click);
            ManualUndoButton.MouseEnter += new EventHandler(ManualUndoButton_MouseEnter);
            ManualUndoButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualDoneButton.Location = new Point(111, 315);
            ManualDoneButton.Name = "ManualDoneButton";
            ManualDoneButton.Size = new Size(92, 23);
            ManualDoneButton.Text = "完成 / Done";
            ManualDoneButton.UseVisualStyleBackColor = true;
            ManualDoneButton.Click += new EventHandler(ManualDoneButton_Click);
            ManualDoneButton.MouseEnter += new EventHandler(ManualDoneButton_MouseEnter);
            ManualDoneButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualNextButton.Location = new Point(9, 315);
            ManualNextButton.Name = "ManualNextButton";
            ManualNextButton.Size = new Size(92, 23);
            ManualNextButton.Text = "下一个 / Next";
            ManualNextButton.UseVisualStyleBackColor = true;
            ManualNextButton.Click += new EventHandler(ManualNextButton_Click);
            ManualNextButton.MouseEnter += new EventHandler(ManualNextButton_MouseEnter);
            ManualNextButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualBGModeRadioButton.AutoSize = true;
            ManualBGModeRadioButton.Location = new Point(6, 138);
            ManualBGModeRadioButton.Name = "ManualBGModeRadioButton";
            ManualBGModeRadioButton.Size = new Size(147, 21);
            ManualBGModeRadioButton.Text = "宫格模式 / Box mode";
            ManualBGModeRadioButton.UseVisualStyleBackColor = true;
            ManualBGModeRadioButton.MouseEnter += new EventHandler(ManualBGModeRadioButton_MouseEnter);
            ManualBGModeRadioButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualValueLabel.AutoSize = true;
            ManualValueLabel.Location = new Point(5, 258);
            ManualValueLabel.Name = "ManualValueLabel";
            ManualValueLabel.Size = new Size(65, 17);
            ManualValueLabel.Text = "值 / Value";

            ManualBoxGridLabel.AutoSize = true;
            ManualBoxGridLabel.Enabled = false;
            ManualBoxGridLabel.Location = new Point(4, 210);
            ManualBoxGridLabel.Name = "ManualBoxGridLabel";
            ManualBoxGridLabel.Size = new Size(95, 17);
            ManualBoxGridLabel.Text = "宫格 / Box grid";

            ManualRCModeRadioButton.AutoSize = true;
            ManualRCModeRadioButton.Checked = true;
            ManualRCModeRadioButton.Location = new Point(6, 22);
            ManualRCModeRadioButton.Name = "ManualRCModeRadioButton";
            ManualRCModeRadioButton.Size = new Size(197, 21);
            ManualRCModeRadioButton.TabStop = true;
            ManualRCModeRadioButton.Text = "行列模式 / Row-column mode";
            ManualRCModeRadioButton.UseVisualStyleBackColor = true;
            ManualRCModeRadioButton.CheckedChanged += new EventHandler(ManualRadioButton_CheckedChanged);
            ManualRCModeRadioButton.MouseEnter += new EventHandler(ManualRCModeRadioButton_MouseEnter);
            ManualRCModeRadioButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualValueUpDown.BorderStyle = BorderStyle.FixedSingle;
            ManualValueUpDown.Location = new Point(172, 278);
            ManualValueUpDown.Maximum = 9;
            ManualValueUpDown.Name = "ManualValueUpDown";
            ManualValueUpDown.Size = new Size(30, 23);
            ManualValueUpDown.ValueChanged += new EventHandler(ManualValueUpDown_ValueChanged);
            ManualValueUpDown.MouseEnter += new EventHandler(ManualValue_MouseEnter);
            ManualValueUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualBoxGridUpDown.BorderStyle = BorderStyle.FixedSingle;
            ManualBoxGridUpDown.Enabled = false;
            ManualBoxGridUpDown.Location = new Point(171, 230);
            ManualBoxGridUpDown.Maximum = 9;
            ManualBoxGridUpDown.Minimum = 1;
            ManualBoxGridUpDown.Name = "ManualBoxGridUpDown";
            ManualBoxGridUpDown.Size = new Size(30, 23);
            ManualBoxGridUpDown.Value = 1;
            ManualBoxGridUpDown.ValueChanged += new EventHandler(ManualBoxGridUpDown_ValueVChanged);
            ManualBoxGridUpDown.MouseEnter += new EventHandler(ManualBoxGrid_MouseEnter);
            ManualBoxGridUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualColumnLabel.AutoSize = true;
            ManualColumnLabel.Location = new Point(4, 93);
            ManualColumnLabel.Name = "ManualColumnLabel";
            ManualColumnLabel.Size = new Size(77, 17);
            ManualColumnLabel.Text = "列 / Column";

            ManualBoxLabel.AutoSize = true;
            ManualBoxLabel.Enabled = false;
            ManualBoxLabel.Location = new Point(3, 162);
            ManualBoxLabel.Name = "ManualBoxLabel";
            ManualBoxLabel.Size = new Size(55, 17);
            ManualBoxLabel.Text = "宫 / Box";

            ManualColumnUpDown.BorderStyle = BorderStyle.FixedSingle;
            ManualColumnUpDown.Location = new Point(171, 113);
            ManualColumnUpDown.Maximum = 9;
            ManualColumnUpDown.Minimum = 1;
            ManualColumnUpDown.Name = "ManualColumnUpDown";
            ManualColumnUpDown.Size = new Size(30, 23);
            ManualColumnUpDown.Value = 1;
            ManualColumnUpDown.ValueChanged += new EventHandler(ManualColumnUpDown_ValueChanged);
            ManualColumnUpDown.MouseEnter += new EventHandler(ManualColumn_MouseEnter);
            ManualColumnUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualValueTrackBar.LargeChange = 1;
            ManualValueTrackBar.Location = new Point(9, 278);
            ManualValueTrackBar.Maximum = 9;
            ManualValueTrackBar.Name = "ManualValueTrackBar";
            ManualValueTrackBar.Size = new Size(157, 45);
            ManualValueTrackBar.Tag = "";
            ManualValueTrackBar.ValueChanged += new EventHandler(ManualValueTrackBar_ValueChanged);
            ManualValueTrackBar.MouseEnter += new EventHandler(ManualValue_MouseEnter);
            ManualValueTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualRowLabel.AutoSize = true;
            ManualRowLabel.Location = new Point(3, 46);
            ManualRowLabel.Name = "ManualRowLabel";
            ManualRowLabel.Size = new Size(58, 17);
            ManualRowLabel.Text = "行 / Row";

            ManualBoxUpDown.BorderStyle = BorderStyle.FixedSingle;
            ManualBoxUpDown.Enabled = false;
            ManualBoxUpDown.Location = new Point(170, 182);
            ManualBoxUpDown.Maximum = 9;
            ManualBoxUpDown.Minimum = 1;
            ManualBoxUpDown.Name = "ManualBoxUpDown";
            ManualBoxUpDown.Size = new Size(30, 23);
            ManualBoxUpDown.Value = 1;
            ManualBoxUpDown.ValueChanged += new EventHandler(ManualBoxUpDown_ValueChanged);
            ManualBoxUpDown.MouseEnter += new EventHandler(ManualBox_MouseEnter);
            ManualBoxUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualColumnTrackBar.LargeChange = 1;
            ManualColumnTrackBar.Location = new Point(8, 113);
            ManualColumnTrackBar.Maximum = 9;
            ManualColumnTrackBar.Minimum = 1;
            ManualColumnTrackBar.Name = "ManualColumnTrackBar";
            ManualColumnTrackBar.Size = new Size(157, 45);
            ManualColumnTrackBar.Tag = "";
            ManualColumnTrackBar.Value = 1;
            ManualColumnTrackBar.ValueChanged += new EventHandler(ManualColumnTrackBar_ValueChanged);
            ManualColumnTrackBar.MouseEnter += new EventHandler(ManualColumn_MouseEnter);
            ManualColumnTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualBoxGridTrackBar.Enabled = false;
            ManualBoxGridTrackBar.LargeChange = 1;
            ManualBoxGridTrackBar.Location = new Point(8, 230);
            ManualBoxGridTrackBar.Maximum = 9;
            ManualBoxGridTrackBar.Minimum = 1;
            ManualBoxGridTrackBar.Name = "ManualBoxGridTrackBar";
            ManualBoxGridTrackBar.Size = new Size(157, 45);
            ManualBoxGridTrackBar.Tag = "";
            ManualBoxGridTrackBar.Value = 1;
            ManualBoxGridTrackBar.ValueChanged += new EventHandler(ManualBoxGridTrackBar_ValueChanged);
            ManualBoxGridTrackBar.MouseEnter += new EventHandler(ManualBoxGrid_MouseEnter);
            ManualBoxGridTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualBoxTrackBar.Enabled = false;
            ManualBoxTrackBar.LargeChange = 1;
            ManualBoxTrackBar.Location = new Point(7, 182);
            ManualBoxTrackBar.Maximum = 9;
            ManualBoxTrackBar.Minimum = 1;
            ManualBoxTrackBar.Name = "ManualBoxTrackBar";
            ManualBoxTrackBar.Size = new Size(157, 45);
            ManualBoxTrackBar.Tag = "";
            ManualBoxTrackBar.Value = 1;
            ManualBoxTrackBar.ValueChanged += new EventHandler(ManualBoxTrackBar_ValueChanged);
            ManualBoxTrackBar.MouseEnter += new EventHandler(ManualBox_MouseEnter);
            ManualBoxTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualRowUpDown.BorderStyle = BorderStyle.FixedSingle;
            ManualRowUpDown.Location = new Point(170, 66);
            ManualRowUpDown.Maximum = 9;
            ManualRowUpDown.Minimum = 1;
            ManualRowUpDown.Name = "ManualRowUpDown";
            ManualRowUpDown.Size = new Size(30, 23);
            ManualRowUpDown.Value = 1;
            ManualRowUpDown.ValueChanged += new EventHandler(ManualRowUpDown_ValueChanged);
            ManualRowUpDown.MouseEnter += new EventHandler(ManualRow_MouseEnter);
            ManualRowUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            ManualRowTrackBar.LargeChange = 1;
            ManualRowTrackBar.Location = new Point(7, 66);
            ManualRowTrackBar.Maximum = 9;
            ManualRowTrackBar.Minimum = 1;
            ManualRowTrackBar.Name = "ManualRowTrackBar";
            ManualRowTrackBar.Size = new Size(157, 45);
            ManualRowTrackBar.Tag = "";
            ManualRowTrackBar.Value = 1;
            ManualRowTrackBar.ValueChanged += new EventHandler(ManualRowTrackBar_ValueChanged);
            ManualRowTrackBar.MouseEnter += new EventHandler(ManualRow_MouseEnter);
            ManualRowTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            Controls.Add(ManualPanel);
            ManualPanel.ResumeLayout(false);
            ManualGroupBox.ResumeLayout(false);
            ManualGroupBox.PerformLayout();
            ((ISupportInitialize)(ManualValueUpDown)).EndInit();
            ((ISupportInitialize)(ManualBoxGridUpDown)).EndInit();
            ((ISupportInitialize)(ManualColumnUpDown)).EndInit();
            ((ISupportInitialize)(ManualValueTrackBar)).EndInit();
            ((ISupportInitialize)(ManualBoxUpDown)).EndInit();
            ((ISupportInitialize)(ManualColumnTrackBar)).EndInit();
            ((ISupportInitialize)(ManualBoxGridTrackBar)).EndInit();
            ((ISupportInitialize)(ManualBoxTrackBar)).EndInit();
            ((ISupportInitialize)(ManualRowUpDown)).EndInit();
            ((ISupportInitialize)(ManualRowTrackBar)).EndInit();
            ManualPanel.BringToFront();
        }

        //生成指定提示数控件
        public Button GenerateButton = new Button();
        public NumericUpDown HintsUpDown = new NumericUpDown();
        public TrackBar HintsTrackBar = new TrackBar();
        private void GenerateSemiAuto()
        {
            GenerateButton.Location = new Point(217, 22);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(107, 23);
            GenerateButton.Text = "生成 / Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Visible = false;
            GenerateButton.Click += new EventHandler(GenerateButton_Click);
            GenerateButton.MouseEnter += new EventHandler(GenerateButton_MouseEnter);
            GenerateButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            HintsUpDown.BorderStyle = BorderStyle.FixedSingle;
            HintsUpDown.Location = new Point(172, 22);
            HintsUpDown.Maximum = 80;
            HintsUpDown.Minimum = 1;
            HintsUpDown.Name = "HintsUpDown";
            HintsUpDown.Size = new Size(39, 23);
            HintsUpDown.Value = 1;
            HintsUpDown.Visible = false;
            HintsUpDown.ValueChanged += new EventHandler(HintsUpDown_ValueChanged);
            HintsUpDown.MouseEnter += new EventHandler(SemiAutoHints_MouseEnter);
            HintsUpDown.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            HintsTrackBar.LargeChange = 1;
            HintsTrackBar.Location = new Point(55, 17);
            HintsTrackBar.Maximum = 80;
            HintsTrackBar.Minimum = 1;
            HintsTrackBar.Name = "HintsTrackBar";
            HintsTrackBar.Size = new Size(120, 45);
            HintsTrackBar.Tag = "";
            HintsTrackBar.Value = 1;
            HintsTrackBar.Visible = false;
            HintsTrackBar.ValueChanged += new EventHandler(HintsTrackBar_ValueChanged);
            HintsTrackBar.MouseEnter += new EventHandler(SemiAutoHints_MouseEnter);
            HintsTrackBar.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            SudokuDialogGroupBox.Controls.Add(GenerateButton);
            SudokuDialogGroupBox.Controls.Add(HintsUpDown);
            SudokuDialogGroupBox.Controls.Add(HintsTrackBar);
        }

        //生成自动计算答案控件
        private Button SolveButton = new Button();
        private void GenerateSolve()
        {
            SolveButton.Location = new Point(217, 22);
            SolveButton.Name = "SolveButton";
            SolveButton.Size = new Size(107, 23);
            SolveButton.Text = "计算 / Calculate";
            SolveButton.UseVisualStyleBackColor = true;
            SolveButton.Visible = false;
            SolveButton.Click += new EventHandler(SolveButton_Click);
            SolveButton.MouseEnter += new EventHandler(SolveButton_MouseEnter);
            SolveButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);
            SudokuDialogGroupBox.Controls.Add(SolveButton);
        }

        //生成发现新答案控件
        public Button AnswerYesButton = new Button();
        public Button AnswerNoButton = new Button();
        public Button AnswerEndlessButton = new Button();
        private Point DialogMiddle = new Point(250, 22);
        private Point DialogRight = new Point(280, 22);
        private void GenerateAnswer()
        {
            AnswerYesButton.Location = new Point(220, 22);
            AnswerYesButton.Name = "AnswerYesButton";
            AnswerYesButton.Size = new Size(23, 23);
            AnswerYesButton.Text = "√";
            AnswerYesButton.UseVisualStyleBackColor = true;
            AnswerYesButton.Visible = false;
            AnswerYesButton.Click += new EventHandler(AnswerButton_Click);
            AnswerYesButton.MouseEnter += new EventHandler(AnswerYesButton_MouseEnter);
            AnswerYesButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            AnswerNoButton.Location = DialogMiddle;
            AnswerNoButton.Name = "AnswerNoButton";
            AnswerNoButton.Size = new Size(23, 23);
            AnswerNoButton.Text = "×";
            AnswerNoButton.UseVisualStyleBackColor = true;
            AnswerNoButton.Visible = false;
            AnswerNoButton.Click += new EventHandler(AnswerButton_Click);
            AnswerNoButton.MouseEnter += new EventHandler(AnswerNoButton_MouseEnter);
            AnswerNoButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            AnswerEndlessButton.Location = DialogRight;
            AnswerEndlessButton.Name = "AnswerEndlessButton";
            AnswerEndlessButton.Size = new Size(40, 23);
            AnswerEndlessButton.Text = "√√";
            AnswerEndlessButton.UseVisualStyleBackColor = true;
            AnswerEndlessButton.Visible = false;
            AnswerEndlessButton.Click += new EventHandler(AnswerButton_Click);
            AnswerEndlessButton.MouseEnter += new EventHandler(AnswerEndlessButton_MouseEnter);
            AnswerEndlessButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            SudokuDialogGroupBox.Controls.Add(AnswerYesButton);
            SudokuDialogGroupBox.Controls.Add(AnswerNoButton);
            SudokuDialogGroupBox.Controls.Add(AnswerEndlessButton);
        }

        //生成答案保存按钮
        private Button SaveYesButton = new Button();
        private Button SaveNoButton = new Button();
        private void GenerateSave()
        {
            SaveYesButton.Location = new Point(267, 22);
            SaveYesButton.Name = "SaveYesButton";
            SaveYesButton.Size = new Size(23, 23);
            SaveYesButton.Text = "√";
            SaveYesButton.UseVisualStyleBackColor = true;
            SaveYesButton.Visible = false;
            SaveYesButton.Click += new EventHandler(SaveButton_Click);
            SaveYesButton.MouseEnter += new EventHandler(SaveYesButton_MouseEnter);
            SaveYesButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            SaveNoButton.Location = new Point(297, 22);
            SaveNoButton.Name = "SaveNoButton";
            SaveNoButton.Size = new Size(23, 23);
            SaveNoButton.Text = "×";
            SaveNoButton.UseVisualStyleBackColor = true;
            SaveNoButton.Visible = false;
            SaveNoButton.Click += new EventHandler(SaveButton_Click);
            SaveNoButton.MouseEnter += new EventHandler(SaveNoButton_MouseEnter);
            SaveNoButton.MouseLeave += new EventHandler(FunctionForm_MouseLeave);

            SudokuDialogGroupBox.Controls.Add(SaveYesButton);
            SudokuDialogGroupBox.Controls.Add(SaveNoButton);
        }

        //点击手动输入和手动作答按钮
        public ManualMode CurrentManual;
        public AutoMode CurrentAuto;
        private int blinkingrow = 0;
        private int blinkingcolumn = 0;
        public int[,] puzzlearray = new int[9, 9];
        public int[,] solvingarray = new int[9, 9];
        public List<short[,]> puzzlerecord = new List<short[,]>();
        public List<short[,]> solvingrecord = new List<short[,]>();
        public int puzzlestepindex = 0;
        public int solvingstepindex = 0;
        private void Manual_Click(object sender, EventArgs e)
        {
            //清除自动生成和计算控件
            HintsTrackBar.Visible = HintsUpDown.Visible
                = GenerateButton.Visible = SolveButton.Visible = false;

            //点击手动输入时模式标记为“Generate”，手动作答是模式标记为“Solve”
            if (sender == GenerateManualButton)
            {
                CurrentManual = ManualMode.Generate;
            }
            else
            {
                CurrentManual = ManualMode.Solve;
            }

            //记录空白谜题为首个谜题还原点
            if (puzzlestepindex == 0)
            {
                puzzlerecord.Add(new short[9, 9]);
                puzzlestepindex++;
                ToSolve = new Sudoku();
            }

            //solve模式下记录目前谜题为首个答案还原点
            if (CurrentManual == ManualMode.Solve && solvingstepindex == 0)
            {
                solvingrecord.Add(new short[9, 9]);
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        solvingarray[row, column] = puzzlearray[row, column];
                        solvingrecord[0][row, column] = (short)solvingarray[row, column];
                    }
                }
                solvingstepindex++;
            }

            //刷新UI（对话框、底色、文字、文字颜色复位）
            RefreshSudokuUI(sender);

            //显示输入面板
            ManualPanel.Visible = true;

            //开始计时
            FunctionTimer.Start();

            //当前方格背景色变白
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;

            //如果目前标记为“solve”且方格已经存在数值，则将此方格的Value相关控件设为不可用
            if (CurrentManual == ManualMode.Solve)
            {
                ManualValueTrackBar.Enabled = ManualValueUpDown.Enabled = puzzlearray[blinkingrow, blinkingcolumn] == 0;
            }

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
            //刷新UI
            RefreshSudokuUI(sender);

            //改变位置
            blinkingrow = ManualRowTrackBar.Value - 1;
            blinkingcolumn = ManualColumnTrackBar.Value - 1;

            //当前位置底色高亮，ManualValueTrackBar控件复位
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
            ManualValueTrackBar.Value = 0;

            //关联UpDown控件
            ManualRowUpDown.Value = ManualRowTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out int boxindex, out int boxgridindex);
            ManualBoxTrackBar.Value = ++boxindex;
            ManualBoxGridTrackBar.Value = ++boxgridindex;

            //如果目前标记为“solve”且方格已经存在数值，则将此方格的Value相关控件设为不可用
            if (CurrentManual == ManualMode.Solve)
            {
                ManualValueTrackBar.Enabled = ManualValueUpDown.Enabled = puzzlearray[blinkingrow, blinkingcolumn] == 0;
            }
        }

        //改变行UpDown值属性
        private void ManualRowUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualRowTrackBar.Value = (int)ManualRowUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out int boxindex, out int boxgridindex);
            ManualBoxTrackBar.Value = ++boxindex;
            ManualBoxGridTrackBar.Value = ++boxgridindex;
        }

        //改变列TrackBar值属性
        private void ManualColumnTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //刷新UI
            RefreshSudokuUI(sender);

            //改变位置
            blinkingrow = ManualRowTrackBar.Value - 1;
            blinkingcolumn = ManualColumnTrackBar.Value - 1;

            //当前位置底色高亮，ManualValueTrackBar控件复位
            SudokuGridBackgroundPanel[blinkingrow, blinkingcolumn].BackColor = SystemColors.ControlLightLight;
            ManualValueTrackBar.Value = 0;

            //关联UpDown控件
            ManualColumnUpDown.Value = ManualColumnTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.GridToBox(ManualRowTrackBar.Value - 1, ManualColumnTrackBar.Value - 1, out int boxindex, out int boxgridindex);
            ManualBoxTrackBar.Value = ++boxindex;
            ManualBoxGridTrackBar.Value = ++boxgridindex;

            //如果目前标记为“solve”且方格已经存在数值，则将此方格的Value相关控件设为不可用
            if (CurrentManual == ManualMode.Solve)
            {
                ManualValueTrackBar.Enabled = ManualValueUpDown.Enabled = puzzlearray[blinkingrow, blinkingcolumn] == 0;
            }

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
            ManualRowTrackBar.Value = ++rowindex;
            ManualColumnTrackBar.Value = ++columnindex;
        }

        //改变宮UpDown值属性
        private void ManualBoxUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualBoxTrackBar.Value = (int)ManualBoxUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = ++rowindex;
            ManualColumnTrackBar.Value = ++columnindex;
        }

        //改变宮格TrackBar值属性
        private void ManualBoxGridTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联Updown控件
            ManualBoxGridUpDown.Value = ManualBoxGridTrackBar.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = ++rowindex;
            ManualColumnTrackBar.Value = ++columnindex;
        }

        //改变宫格UpDown值属性
        private void ManualBoxGridUpDown_ValueVChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            ManualBoxGridTrackBar.Value = (int)ManualBoxGridUpDown.Value;

            //换算另一坐标值，并在控件中显示
            Sudoku.BoxToGrid(ManualBoxTrackBar.Value - 1, ManualBoxGridTrackBar.Value - 1, out int rowindex, out int columnindex);
            ManualRowTrackBar.Value = ++rowindex;
            ManualColumnTrackBar.Value = ++columnindex;
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
                        if (sender == SudokuGridBackgroundPanel[row, column])
                        {
                            ManualRowTrackBar.Value = row + 1;
                            ManualColumnTrackBar.Value = column + 1;
                            ActiveControl = (Panel)sender;
                        }
                        else if (sender == SudokuGridLabel[row, column])
                        {
                            ManualRowTrackBar.Value = row + 1;
                            ManualColumnTrackBar.Value = column + 1;
                            ActiveControl = (Label)sender;
                        }
                    }
                }
            }
        }

        //计时器Tickhandler实现闪烁
        bool tickedon = true;
        private void FunctionTimer_Tick(object sender, EventArgs e)
        {
            //tickedon切换状态
            tickedon = !tickedon;

            //根据计数器的奇偶性实现当前方格闪烁
            if (ManualPanel.Visible)
            {
                if (tickedon)
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
            //刷新UI
            RefreshSudokuUI(sender);

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

            //将“0”值更换成“”值，更换成黑色
            if (label.Text == "0")
            {
                label.Text = "";
                label.ForeColor = SystemColors.ControlText;
            }

            //其余值则更换成深灰色
            else
            {
                label.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        //检测键盘按键
        private void FunctionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按键转化成相应TrackBar值属性并且执行单击下一步按钮
            if (ManualPanel.Visible && ManualValueTrackBar.Enabled
                && ActiveControl != ManualRowUpDown && ActiveControl != ManualColumnUpDown
                && ActiveControl != ManualBoxUpDown && ActiveControl != ManualBoxGridUpDown
                && ActiveControl != ManualValueUpDown)
            {
                switch (e.KeyChar)
                {
                    case (char)49:
                        ManualValueTrackBar.Value = 1;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)50:
                        ManualValueTrackBar.Value = 2;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)51:
                        ManualValueTrackBar.Value = 3;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)52:
                        ManualValueTrackBar.Value = 4;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)53:
                        ManualValueTrackBar.Value = 5;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)54:
                        ManualValueTrackBar.Value = 6;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)55:
                        ManualValueTrackBar.Value = 7;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)56:
                        ManualValueTrackBar.Value = 8;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)57:
                        ManualValueTrackBar.Value = 9;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    case (char)8:
                    case (char)48:
                    case (char)127:
                        ManualValueTrackBar.Value = 0;
                        ManualNextButton_Click(ManualNextButton, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }

        //单击下一步按钮
        private Sudoku ToCheck;
        public void ManualNextButton_Click(object sender, EventArgs e)
        {
            //目前生成数独实例用于验证合法赋值
            if (CurrentManual == ManualMode.Generate)
            {
                ToCheck = new Sudoku(puzzlearray);
            }
            else
            {
                ToCheck = new Sudoku(solvingarray);
            }

            //value在UI相应方格上反馈
            if (CurrentManual == ManualMode.Generate)
            {

                //value值为0但数组为0时清除方格
                if (ManualValueTrackBar.Value == 0 && puzzlearray[blinkingrow, blinkingcolumn] != 0)
                {
                    SudokuGridLabel[blinkingrow, blinkingcolumn].Text = "0";
                    puzzlearray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                    SetDialogText("方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")清除数值成功。\n" +
                        "Erase value in(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") successful.");
                }
                //value值不为0时检查是否合法赋值
                else if (ToCheck.CheckRule(blinkingrow, blinkingcolumn, ManualValueTrackBar.Value, this))
                {
                    puzzlearray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                    SudokuGridLabel[blinkingrow, blinkingcolumn].Text = ManualValueTrackBar.Value.ToString();
                    SudokuGridLabel[blinkingrow, blinkingcolumn].ForeColor = Color.DarkBlue;
                    SetDialogText("方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")填入数值" + ManualValueTrackBar.Value + "成功。\n" +
                        "Fill(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") with value " + ManualValueTrackBar.Value + " successful.");
                }
                //不合法赋值或重复清除方格则操作无效
                else
                {
                    return;
                }
            }
            else
            {
                //value值为0时
                if (ManualValueTrackBar.Value == 0)
                {
                    //数组不为0时或重复清除方格时不予操作
                    if (puzzlearray[blinkingrow, blinkingcolumn] != 0 || solvingarray[blinkingrow, blinkingcolumn] == 0)
                    {
                        return;
                    }

                    //数组为0时清除方格
                    else
                    {
                        SudokuGridLabel[blinkingrow, blinkingcolumn].Text = "0";
                        solvingarray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                        SetDialogText("方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")清除数值成功。\n" +
                            "Erase value in(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") successful.");
                    }
                }
                //value值不为0时检查是否合法赋值
                else if (ToCheck.CheckRule(blinkingrow, blinkingcolumn, ManualValueTrackBar.Value, this))
                {
                    solvingarray[blinkingrow, blinkingcolumn] = ManualValueTrackBar.Value;
                    SudokuGridLabel[blinkingrow, blinkingcolumn].Text = ManualValueTrackBar.Value.ToString();
                    SudokuGridLabel[blinkingrow, blinkingcolumn].ForeColor = SystemColors.ControlText;
                    SetDialogText("方格(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ")填入数值" + ManualValueTrackBar.Value + "成功。\n" +
                        "Fill(" + (blinkingrow + 1) + "," + (blinkingcolumn + 1) + ") with value " + ManualValueTrackBar.Value + " successful.");
                }
                //不合法赋值则操作无效
                else
                {
                    return;
                }
            }

            //检测是否重复赋值或者是否已经完成解答
            bool issimular = true, isfull = true;
            if (CurrentManual == ManualMode.Generate)
            {
                for (int row = 0; row < 9; row++)
                {
                    if (!issimular)
                    {
                        break;
                    }
                    for (int column = 0; column < 9; column++)
                    {
                        if (puzzlerecord[puzzlestepindex - 1][row, column] != puzzlearray[row, column])
                        {
                            issimular = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int row = 0; row < 9; row++)
                {
                    if (!issimular && !isfull)
                    {
                        break;
                    }
                    for (int column = 0; column < 9; column++)
                    {
                        if (!issimular && !isfull)
                        {
                            break;
                        }
                        if (solvingrecord[solvingstepindex - 1][row, column] != solvingarray[row, column])
                        {
                            issimular = false;
                        }
                        if (solvingarray[row, column] == 0)
                        {
                            isfull = false;
                        }
                    }
                }
            }

            //重复赋值终止记录
            if (((CurrentManual == ManualMode.Generate && puzzlerecord.Count > 0)
                || (CurrentManual == ManualMode.Solve && solvingrecord.Count > 0)) && issimular)
            {
                return;
            }

            //在Generate模式下成功赋值并记录，则清除solving记录
            if (CurrentManual == ManualMode.Generate)
            {
                solvingrecord.Clear();
                solvingrecord.TrimExcess();
                solvingstepindex = 0;
            }

            //若曾经撤销过重新赋值则作为最新记录
            if (CurrentManual == ManualMode.Generate)
            {
                if (puzzlerecord.Count > puzzlestepindex + 1)
                {
                    puzzlerecord.RemoveRange(puzzlestepindex + 1, puzzlerecord.Count - puzzlestepindex - 1);
                    puzzlerecord.TrimExcess();
                }
            }
            else
            {
                if (solvingrecord.Count > solvingstepindex + 1)
                {
                    solvingrecord.RemoveRange(solvingstepindex + 1, solvingrecord.Count - solvingstepindex - 1);
                    solvingrecord.TrimExcess();
                }
            }

            //数组赋值到记录
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlerecord.Add(new short[9, 9]);
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        puzzlerecord[puzzlestepindex][row, column] = (short)puzzlearray[row, column];
                    }
                }
            }
            else
            {
                solvingrecord.Add(new short[9, 9]);
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        solvingrecord[solvingstepindex][row, column] = (short)solvingarray[row, column];
                    }
                }
            }

            //步骤计数器自加
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlestepindex++;
            }
            else
            {
                solvingstepindex++;
            }

            if (CurrentManual == ManualMode.Solve && isfull)
            {
                //填满则全部方格显示为绿色
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkGreen;
                    }
                }

                //对话框提示已经填满
                SetDialogText("恭喜，您做到了。您仍可继续试新的答案或者谜题。 /" +
                    "\nYou did it！You can still try more answers or puzzles.");
            }
            else
            {
                //数独仍未填满则刷新UI
                RefreshSudokuUI(sender);
            }
        }

        //单击完成按钮
        private Sudoku ToSolve;
        public void ManualDoneButton_Click(object sender, EventArgs e)
        {
            //目前数组生成数独实例
            ToSolve = new Sudoku(puzzlearray);

            //停止计时
            FunctionTimer.Stop();

            //TrackBar和UpDown控件复位
            ManualRowTrackBar.Value = 1;
            ManualColumnTrackBar.Value = 1;
            ManualValueTrackBar.Value = 0;

            //还原Value相关控件
            ManualValueTrackBar.Enabled = ManualValueUpDown.Enabled = true;

            //隐藏输入面板
            if (ManualPanel.Visible)
            {
                ManualPanel.Visible = false;
            }

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
                    if (puzzlerecord[puzzlestepindex - 1][row, column] != 0)
                    {
                        isblank = false;
                        break;
                    }
                }
            }
            GenerateSemiAutoButton.Enabled = GenerateAutoButton.Enabled = isblank;

            //刷新UI
            RefreshSudokuUI(sender);
        }

        //单击撤销按钮
        private void ManualUndoButton_Click(object sender, EventArgs e)
        {
            //步骤计数器自减
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlestepindex -= 2;
            }
            else
            {
                solvingstepindex -= 2;
            }

            //显示上一还原点的内容
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (CurrentManual == ManualMode.Solve)
                    {
                        solvingarray[row, column] = solvingrecord[solvingstepindex][row, column];
                        SudokuGridLabel[row, column].Text = solvingarray[row, column].ToString();
                        SudokuGridLabel[row, column].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        puzzlearray[row, column] = puzzlerecord[puzzlestepindex][row, column];
                        SudokuGridLabel[row, column].Text = puzzlearray[row, column].ToString();
                    }
                    if (puzzlearray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //步骤计数器自加
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlestepindex++;
            }
            else
            {
                solvingstepindex++;
            }

            //刷新UI
            RefreshSudokuUI(sender);

            //对话框显示撤销完成
            SetDialogText("数独撤销完成。 /\nSudoku undone.");
        }

        //单击重做按钮
        private void ManualRedoButton_Click(object sender, EventArgs e)
        {
            //显示下一还原点的内容
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (CurrentManual == ManualMode.Solve)
                    {
                        solvingarray[row, column] = solvingrecord[solvingstepindex][row, column];
                        SudokuGridLabel[row, column].Text = solvingarray[row, column].ToString();
                        SudokuGridLabel[row, column].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        puzzlearray[row, column] = puzzlerecord[puzzlestepindex][row, column];
                        SudokuGridLabel[row, column].Text = puzzlearray[row, column].ToString();
                    }
                    if (puzzlearray[row, column] != 0)
                    {
                        SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                    }
                }
            }

            //步骤计数器自加
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlestepindex++;
            }
            else
            {
                solvingstepindex++;
            }

            //刷新UI
            RefreshSudokuUI(sender);

            //对话框显示重做完成
            SetDialogText("数独重做完成。 /\nSudoku redone.");
        }

        //单击清空按钮
        private void ManualClearButton_Click(object sender, EventArgs e)
        {
            //所有方格清空并将数组赋值到记录中
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlerecord.Add(new short[9, 9]);
            }
            else
            {
                solvingrecord.Add(new short[9, 9]);
            }
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (CurrentManual == ManualMode.Generate)
                    {
                        puzzlearray[row, column] = 0;
                        puzzlerecord[puzzlestepindex][row, column] = (short)puzzlearray[row, column];
                        SudokuGridLabel[row, column].Text = puzzlearray[row, column].ToString();
                    }
                    else
                    {
                        solvingarray[row, column] = puzzlerecord[puzzlestepindex - 1][row, column];
                        solvingrecord[solvingstepindex][row, column] = (short)solvingarray[row, column];
                        SudokuGridLabel[row, column].Text = solvingarray[row, column].ToString();
                    }
                }
            }

            //若曾经撤销过重新赋值则作为最新记录
            if (CurrentManual == ManualMode.Generate)
            {
                if (puzzlerecord.Count > puzzlestepindex + 1)
                {
                    puzzlerecord.RemoveRange(puzzlestepindex + 1, puzzlerecord.Count - puzzlestepindex - 1);
                    puzzlerecord.TrimExcess();
                }
            }
            else
            {
                if (solvingrecord.Count > solvingstepindex + 1)
                {
                    solvingrecord.RemoveRange(solvingstepindex + 1, solvingrecord.Count - solvingstepindex - 1);
                    solvingrecord.TrimExcess();
                }
            }

            //步骤计数器自加
            if (CurrentManual == ManualMode.Generate)
            {
                puzzlestepindex++;
            }
            else
            {
                solvingstepindex++;
            }

            //刷新UI
            RefreshSudokuUI(sender);

            //对话框显示清空完成
            SetDialogText("数独清空完成。 /\nSudoku cleared.");
        }

        //单击按提示生成按钮
        private void GenerateSemiAutoButton_Click(object sender, EventArgs e)
        {
            //标记目前模式为半自动生成
            CurrentAuto = AutoMode.SemiAuto;
            CurrentManual = ManualMode.Generate;

            //显示半自动生成所需控件
            HintsTrackBar.Visible = HintsUpDown.Visible = GenerateButton.Visible = true;

            //隐藏开始自动计算按钮
            SolveButton.Visible = false;

            //对话框显示提示数说明
            SetDialogText("提示数 /\nHints");
        }

        //单击唯一答案谜题生成按钮
        private void GenerateAutoButton_Click(object sender, EventArgs e)
        {
            //标记目前模式为自动生成
            CurrentAuto = AutoMode.Auto;
            CurrentManual = ManualMode.Generate;

            //隐藏半自动生成控件和开始计算按钮
            HintsTrackBar.Visible = HintsUpDown.Visible
                = SolveButton.Visible = false;

            //显示生成按钮
            GenerateButton.Visible = true;

            //对话框显示点击确认生成
            SetDialogText("点击以确认生成。 /\nClick to confirm generation.");
        }

        //单击对话框内生成按钮
        public int targethints;
        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            //对话框提示正在生成
            SetDialogText("数独谜题生成中... /\nSudoku puzzle generating...");

            //隐藏HintsTrackBar、HintsUpDown和GenerateButton控件
            HintsTrackBar.Visible = HintsUpDown.Visible = GenerateButton.Visible = false;
            targethints = HintsTrackBar.Value;

            //记录空白数独为首个还原点
            puzzlerecord.Add(new short[9, 9]);
            puzzlestepindex++;

            //禁用所有按钮
            GenerateManualButton.Enabled = GenerateSemiAutoButton.Enabled = GenerateAutoButton.Enabled =
                SolveManualButton.Enabled = SolveAutoButton.Enabled = false;

            //生成谜题
            await Task.Run(() =>
            {
                Sudoku.GeneratePuzzle(this);
            }
            );

            //清除solving记录
            solvingrecord.Clear();
            solvingrecord.TrimExcess();
            solvingstepindex = 0;

            //启用自动生成以外的按钮
            GenerateManualButton.Enabled = SolveManualButton.Enabled = SolveAutoButton.Enabled = true;

            //对话框显示生成完成
            SetDialogText("数独谜题生成完成。 /\nSudoku puzzle generating done.");
        }

        //改变提示数TrackBar属性
        private void HintsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //关联Updown控件
            HintsUpDown.Value = HintsTrackBar.Value;
        }

        //改变提示数UpDown属性
        private void HintsUpDown_ValueChanged(object sender, EventArgs e)
        {
            //关联TrackBar控件
            HintsTrackBar.Value = (int)HintsUpDown.Value;
        }

        //数独UI刷新
        private delegate void DelegatedRefresh(object sender);
        private void RefreshSudokuUI(object sender)
        {
            if (InvokeRequired)
            {
                DelegatedRefresh refresh = new DelegatedRefresh(RefreshSudokuUI);
                Invoke(refresh, sender);
            }
            else
            {
                if (sender != ManualNextButton)
                {
                    //清除对话框信息
                    SudokuDialogLabel.Visible = false;
                }

                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        //底色复位
                        Sudoku.GridToBox(row, column, out int boxindex, out int boxgridindex);
                        if (boxindex % 2 == 0)
                        {
                            SudokuGridBackgroundPanel[row, column].BackColor = SystemColors.ControlDark;
                        }
                        else
                        {
                            SudokuGridBackgroundPanel[row, column].BackColor = SystemColors.ControlLight;
                        }

                        //文字和文字颜色复位
                        if (CurrentManual == ManualMode.Solve)
                        {
                            SudokuGridLabel[row, column].Text = solvingarray[row, column].ToString();
                            SudokuGridLabel[row, column].ForeColor = SystemColors.ControlText;
                        }
                        else
                        {
                            SudokuGridLabel[row, column].Text = puzzlearray[row, column].ToString();
                        }
                        if (puzzlearray[row, column] != 0)
                        {
                            SudokuGridLabel[row, column].ForeColor = Color.DarkBlue;
                        }
                    }
                }

                //所有方格空白时清空按钮不可用
                bool isblank = true;
                for (int row = 0; row < 9; row++)
                {
                    if (!isblank)
                    {
                        break;
                    }
                    for (int column = 0; column < 9; column++)
                    {
                        if ((CurrentManual == ManualMode.Generate && puzzlerecord[puzzlestepindex - 1][row, column] != 0)
                            || (CurrentManual == ManualMode.Solve && solvingrecord[solvingstepindex - 1][row, column] != puzzlerecord[puzzlestepindex - 1][row, column]))
                        {
                            isblank = false;
                            break;
                        }
                    }
                }
                ManualClearButton.Enabled = !isblank;

                //撤销到尽头时撤销按钮设为不可用
                bool canundo = !((CurrentManual == ManualMode.Generate && puzzlestepindex - 1 == 0)
                    || (CurrentManual == ManualMode.Solve && solvingstepindex - 1 == 0));
                ManualUndoButton.Enabled = canundo;

                //重做到尽头时重做按钮设为不可用
                bool canredo = !((CurrentManual == ManualMode.Generate && puzzlestepindex - 1 == puzzlerecord.Count - 1)
                    || (CurrentManual == ManualMode.Solve && solvingstepindex - 1 == solvingrecord.Count - 1));
                ManualRedoButton.Enabled = canredo;
            }
        }

        //单击自动计算答案按钮
        private void SolveAutoButton_Click(object sender, EventArgs e)
        {
            //目前模式标记为Solve
            CurrentManual = ManualMode.Solve;

            //记录空白谜题为首个谜题还原点
            if (puzzlestepindex == 0)
            {
                puzzlerecord.Add(new short[9, 9]);
                puzzlestepindex++;
                ToSolve = new Sudoku();
            }

            //显示开始自动计算按钮
            SolveButton.Visible = true;

            //隐藏开始生成谜题按钮
            GenerateButton.Visible = false;

            //对话框显示点击确认计算答案
            SetDialogText("点击以确认计算答案。 /\nClick to confirm answer calculation.");
        }

        //单击对话框内计算答案按钮
        private int indexstarttosave;
        private int answercount = 0;
        private async void SolveButton_Click(object sender, EventArgs e)
        {
            //对话框提示正在生成
            SetDialogText("计算谜题答案中... /\nAnswers generating...");

            //隐藏SolveButton控件
            SolveButton.Visible = false;

            //清空目前非谜题方格
            ManualClearButton_Click(sender, new EventArgs());

            //记录下目前答案
            indexstarttosave = solvingstepindex;

            //禁用所有按钮
            GenerateManualButton.Enabled = GenerateSemiAutoButton.Enabled = GenerateAutoButton.Enabled =
                SolveManualButton.Enabled = SolveAutoButton.Enabled = false;

            //生成谜题
            await Task.Run(() =>
            {
                answercount = ToSolve.GetAnswer(this);
            }
            );

            //启用自动生成以外的按钮
            GenerateManualButton.Enabled = SolveManualButton.Enabled = SolveAutoButton.Enabled = true;

            //对话框显示生成完成
            SetDialogText("计算完成，已算出" + answercount + "个答案，是否导出？/" +
                "\nDone. " + answercount + "answer(s) found, Export?");

            //对话框显示保存按钮
            SaveYesButton.Visible = SaveNoButton.Visible = true;
        }


        //按下对话框内新答案按钮
        private string answerbuttonpressed = "";
        private void AnswerButton_Click(object sender, EventArgs e)
        {

            //使用字符串AnswerButtonPressed记录哪个按钮按下
            if (sender.Equals(AnswerYesButton))
            {
                answerbuttonpressed = "Yes";
            }
            else if (sender.Equals(AnswerNoButton))
            {
                answerbuttonpressed = "No";
            }
            else
            {
                answerbuttonpressed = "Endless";
            }

            //重新隐藏按钮
            SetAnswerButtonVisibility("Invisible");
        }

        //循环等待用户按下按钮
        public string WaitAnswerButtonPressed()
        {
            //当字符串AnswerButtonPressed为空值时循环等待
            while (answerbuttonpressed == "")
            {

            }

            //非空值则返回字符串的值
            return answerbuttonpressed;
        }

        //设定新答案相关按钮的可见性
        private delegate void delegatenewanswer(string visiblemode);
        public void SetAnswerButtonVisibility(string visiblemode)
        {
            if (InvokeRequired)
            {
                delegatenewanswer newanswer = new delegatenewanswer(SetAnswerButtonVisibility);
                Invoke(newanswer, visiblemode);
            }
            else
            {
                //不可见时隐藏所有按钮和对话框
                if (visiblemode == "Invisible")
                {
                    answerbuttonpressed = "";
                    AnswerYesButton.Visible = AnswerNoButton.Visible
                        = AnswerEndlessButton.Visible = SudokuDialogLabel.Visible = false;
                }
                else
                {
                    //带有YesButton可见时显示所有按钮，不带有YesButton可见时仅显示NoButton和EndlessButton
                    AnswerNoButton.Visible = AnswerEndlessButton.Visible = true;
                    if (visiblemode == "WithYes")
                    {
                        AnswerNoButton.Location = DialogMiddle;
                        AnswerEndlessButton.Location = DialogRight;
                        AnswerYesButton.Visible = true;
                    }
                    else
                    {
                        AnswerNoButton.Location = new Point(297, 22);
                        AnswerEndlessButton.Location = DialogMiddle;
                    }
                }
            }
        }

        //设置对话框提示内容
        private delegate void delegatesetdialog(string text);
        public void SetDialogText(string text)
        {
            if (InvokeRequired)
            {
                delegatesetdialog setdialog = new delegatesetdialog(SetDialogText);
                Invoke(setdialog, text);
            }
            else
            {
                //按实参显示对话框提示内容
                SudokuDialogLabel.Visible = true;
                SudokuDialogLabel.Text = text;
            }
        }

        //显示新答案
        private delegate void delegatedisplaynewanswer(Sudoku answer);
        public void DisplayAnswer(Sudoku answer)
        {
            if (InvokeRequired)
            {
                delegatedisplaynewanswer display = new delegatedisplaynewanswer(DisplayAnswer);
                Invoke(display, answer);
            }
            else
            {
                //UI上显示为深绿色
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        SudokuGridLabel[row, column].Text = answer.GridNumber[row, column].ToString();
                        SudokuGridLabel[row, column].ForeColor = Color.DarkGreen;
                    }
                }
            }
        }

        //点击保存按钮
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //执行保存
            if (sender == SaveYesButton)
            {
                //声明字符串接受保存路径
                string path;
                do
                {
                    //初始化保存窗口
                    SaveFileDialog savedialog = new SaveFileDialog();
                    savedialog.Title = "";
                    savedialog.InitialDirectory = @"C:\";
                    savedialog.Filter = "文本文件| *.txt";
                    savedialog.ShowDialog();
                    path = savedialog.FileName;
                } while (path == "");

                //声明字符串以接受写入文件的内容

                //当路径不存在同名文件时则新建文件流并写入文件
                if (!File.Exists(path))
                {
                    FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write); 
                    StreamWriter newwriter = new StreamWriter(stream);
                    WriteInFile(newwriter);
                    stream.Close();  
                }    
                
                //路肩存在同名文件时则直接写入目前文件覆盖
                else
                {
                    StreamWriter existwriter = new StreamWriter(path, false, Encoding.Default);
                    WriteInFile(existwriter);
                }
            }

            //隐藏保存按钮
            SaveYesButton.Visible = SaveNoButton.Visible = false;

            //清空答案数
            answercount = 0;

            //刷新UI
            RefreshSudokuUI(sender);

            //对话框提示保存完成
            if (sender == SaveYesButton)
            {
                SetDialogText("导出完成。\nExporting done.");
            }
        }

        //将谜题和已发现的答案写入文件
        private void WriteInFile(StreamWriter writer)
        {
            //写入总标题
            string currenttitle = "本文件由Mice的数独计算器生成。" +
                "\r\nGenerated by Mice's Sudoku Solver." +
                "\r\n" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "\r\n";
            writer.Write(currenttitle);

            //写入谜题
            currenttitle = "\r\n当前谜题：/Current puzzle:\r\n";
            string currentwriting = currenttitle + Sudoku.ArrayToString(puzzlerecord[puzzlestepindex - 1]);
            writer.Write(currentwriting);

            //写入答案
            currenttitle = "\r\n通过计算，目前已经发现" + answercount + "个答案。" +
                "\r\n" + answercount + " answer(s) found after calculation.\r\n";
            writer.Write(currenttitle);
            for (int answerindex = indexstarttosave; answerindex < solvingrecord.Count; answerindex++)
            {
                currenttitle = "\r\n答案" + (answerindex - indexstarttosave + 1) + "：/" +
                    "Answer " + (answerindex - indexstarttosave + 1) + ":\r\n";
                currentwriting = currenttitle + Sudoku.ArrayToString(solvingrecord[answerindex]);
                writer.Write(currentwriting);
            }

            //写入结尾
            currenttitle = "\r\n导出结束，以上为谜题内容以及目前发现的答案。\r\nExporting done. Sudoku puzzle its answer(s) that found so far are displayed above.";
            writer.Write(currenttitle);
            
            //写入结束
            writer.Close();
        }

        //鼠标移入移开的事件处理，在状态栏显示相应说明
        private void GenerateManualButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "使用手动的方式输入谜题。/ Input Sudoku puzzle by manual.";
        }

        private void GenerateSemiAutoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "随机生成指定提示数的谜题（有答案的）。/ Generate puzzle by amount of hints, with answer(s) one.";
        }

        private void GenerateAutoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "随机生成只有唯一答案的谜题。/ Generate puzzle that has the only answer.";
        }

        private void SolveManualButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "手动解答当前的谜题。/ Manually solve the current puzzle.";
        }

        private void SolveAutoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "自动计算当前谜题的所有答案。/ Automatically calculate all the answers for this puzzle.";
        }

        private void SudokuGrid_MouseEnter(object sender, EventArgs e)
        {
            if (ManualPanel.Visible)
            {
                FunctionStatusLabel.Text = "可使用点击方格输入数字的方式输入内容。/ It's able to click this grid and type number to input.";
            }
        }

        private void ManualClearButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "清空当前已填的方格。/ Clear all the filled grids.";
        }

        private void ManualRedoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "重做一步已撤销的操作。/ Redo for a step.";
        }

        private void ManualUndoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "撤销一步已执行的操作。/ Undo for a step.";
        }

        private void ManualDoneButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "手动输入完成，关闭目前面板。/ Manually input done and close this panel.";
        }

        private void ManualNextButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "确认该次输入，继续输入下一方格。/ Confirm this input operation and continue next input.";
        }

        private void ManualBGModeRadioButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "使用宫格模式定位方格。/ Use Box-grid mode to position the gird.";
        }

        private void ManualRCModeRadioButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "使用行列模式定位方格。/ Use Row-column mode to position the gird.";
        }

        private void ManualValue_MouseEnter(object sender, EventArgs e)
        {
            Control component = (Control)sender;
            if (component.Enabled)
            {
                FunctionStatusLabel.Text = "更改方格内数值的大小，0为清除该方格。/ Change value of current grid. 0 means clean this grid";
            }
        }

        private void ManualBoxGrid_MouseEnter(object sender, EventArgs e)
        {
            Control component = (Control)sender;
            if (component.Enabled)
            {
                FunctionStatusLabel.Text = "更改目前方格的宫格坐标值。/ Change current position by boxgrid.";
            }
        }

        private void ManualBox_MouseEnter(object sender, EventArgs e)
        {
            Control component = (Control)sender;
            if (component.Enabled)
            {
                FunctionStatusLabel.Text = "更改目前方格的宫坐标值。/ Change current position by box.";
            }
        }

        private void ManualColumn_MouseEnter(object sender, EventArgs e)
        {
            Control component = (Control)sender;
            if (component.Enabled)
            {
                FunctionStatusLabel.Text = "更改目前方格的列坐标值。/ Change current position by column.";
            }
        }

        private void ManualRow_MouseEnter(object sender, EventArgs e)
        {
            Control component = (Control)sender;
            if (component.Enabled)
            {
                FunctionStatusLabel.Text = "更改目前方格的行坐标值。/ Change current position by row.";
            }
        }

        private void GenerateButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "点击以确认生成。/ Click to confirm generation.";
        }

        private void SemiAutoHints_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "更改目标谜题的提示数。/ Change hints amount of target puzzle.";
        }

        private void SolveButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "点击以确认计算答案。 / Click to confirm answer calculation.";
        }

        private void AnswerYesButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "点击以继续计算下一答案。 / Click to continue calculating next answer.";
        }

        private void AnswerNoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "点击以中止计算。 / Click to stop calculating.";
        }

        private void AnswerEndlessButton_MouseEnter(object sender, EventArgs e)
        {
            if (ToSolve.AnswerCount != 100000)
            {
                FunctionStatusLabel.Text = "点击以继续计算下一答案，并不再提示。 / Click to continue calculating and never ask again.";
            }
            else
            {
                FunctionStatusLabel.Text = "将消耗大量时间和资源，这次不会再有提示了。 / Would spend A LOT and never ask again FOR REAL.";
            }
        }

        private void SaveYesButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "完成本次计算并导出计算结果。 / Finish calculating with export the result.";
        }

        private void SaveNoButton_MouseEnter(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "完成本次计算并但不导出结果。 / Finish calculating without export the result.";
        }

        private void FunctionForm_MouseLeave(object sender, EventArgs e)
        {
            FunctionStatusLabel.Text = "鼠标所指内容将在此显示说明。/ Instructions will be displayed here.";
        }
    }
}
