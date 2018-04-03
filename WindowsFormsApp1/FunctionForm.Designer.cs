namespace SudokuCracker
{
    partial class FunctionForm
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
            this.FunctionStatusStrip = new System.Windows.Forms.StatusStrip();
            this.FunctionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SudokuGroupBox = new System.Windows.Forms.GroupBox();
            this.SudokuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SudokuDialogGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.HintsUpDown = new System.Windows.Forms.NumericUpDown();
            this.HintsTrackBar = new System.Windows.Forms.TrackBar();
            this.SudokuDialogLabel = new System.Windows.Forms.Label();
            this.GenerateGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerateAutoButton = new System.Windows.Forms.Button();
            this.GenerateSemiAutoButton = new System.Windows.Forms.Button();
            this.GenerateManualButton = new System.Windows.Forms.Button();
            this.SolveGroupBox = new System.Windows.Forms.GroupBox();
            this.SolveAutoButton = new System.Windows.Forms.Button();
            this.SolveManualButton = new System.Windows.Forms.Button();
            this.ManualPanel = new System.Windows.Forms.Panel();
            this.ManualGroupBox = new System.Windows.Forms.GroupBox();
            this.ManualClearButton = new System.Windows.Forms.Button();
            this.ManualRedoButton = new System.Windows.Forms.Button();
            this.ManualUndoButton = new System.Windows.Forms.Button();
            this.ManualDoneButton = new System.Windows.Forms.Button();
            this.ManualNextButton = new System.Windows.Forms.Button();
            this.ManualBGModeRadioButton = new System.Windows.Forms.RadioButton();
            this.ManualValueLabel = new System.Windows.Forms.Label();
            this.ManualBoxGridLabel = new System.Windows.Forms.Label();
            this.ManualRCModeRadioButton = new System.Windows.Forms.RadioButton();
            this.ManualValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManualBoxGridUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManualColumnLabel = new System.Windows.Forms.Label();
            this.ManualBoxLabel = new System.Windows.Forms.Label();
            this.ManualColumnUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManualValueTrackBar = new System.Windows.Forms.TrackBar();
            this.ManualRowLabel = new System.Windows.Forms.Label();
            this.ManualBoxUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManualColumnTrackBar = new System.Windows.Forms.TrackBar();
            this.ManualBoxGridTrackBar = new System.Windows.Forms.TrackBar();
            this.ManualBoxTrackBar = new System.Windows.Forms.TrackBar();
            this.ManualRowUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManualRowTrackBar = new System.Windows.Forms.TrackBar();
            this.FunctionTimer = new System.Windows.Forms.Timer(this.components);
            this.FunctionStatusStrip.SuspendLayout();
            this.SudokuGroupBox.SuspendLayout();
            this.SudokuDialogGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HintsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintsTrackBar)).BeginInit();
            this.GenerateGroupBox.SuspendLayout();
            this.SolveGroupBox.SuspendLayout();
            this.ManualPanel.SuspendLayout();
            this.ManualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualValueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxGridUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualColumnUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualColumnTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxGridTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualRowUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualRowTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionStatusStrip
            // 
            this.FunctionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FunctionStatusLabel});
            this.FunctionStatusStrip.Location = new System.Drawing.Point(0, 409);
            this.FunctionStatusStrip.Name = "FunctionStatusStrip";
            this.FunctionStatusStrip.Size = new System.Drawing.Size(634, 22);
            this.FunctionStatusStrip.TabIndex = 0;
            this.FunctionStatusStrip.Text = "statusStrip1";
            // 
            // FunctionStatusLabel
            // 
            this.FunctionStatusLabel.Name = "FunctionStatusLabel";
            this.FunctionStatusLabel.Size = new System.Drawing.Size(386, 17);
            this.FunctionStatusLabel.Text = "鼠标所指内容将在此显示说明。/ Instructions will be displayed here.";
            // 
            // SudokuGroupBox
            // 
            this.SudokuGroupBox.Controls.Add(this.SudokuTablePanel);
            this.SudokuGroupBox.Controls.Add(this.SudokuDialogGroupBox);
            this.SudokuGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SudokuGroupBox.Location = new System.Drawing.Point(255, 10);
            this.SudokuGroupBox.Name = "SudokuGroupBox";
            this.SudokuGroupBox.Size = new System.Drawing.Size(360, 380);
            this.SudokuGroupBox.TabIndex = 0;
            this.SudokuGroupBox.TabStop = false;
            this.SudokuGroupBox.Text = "当前数独 / Current Sudoku";
            // 
            // SudokuTablePanel
            // 
            this.SudokuTablePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SudokuTablePanel.ColumnCount = 9;
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.Location = new System.Drawing.Point(46, 22);
            this.SudokuTablePanel.Name = "SudokuTablePanel";
            this.SudokuTablePanel.RowCount = 9;
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SudokuTablePanel.Size = new System.Drawing.Size(270, 270);
            this.SudokuTablePanel.TabIndex = 2;
            // 
            // SudokuDialogGroupBox
            // 
            this.SudokuDialogGroupBox.Controls.Add(this.GenerateButton);
            this.SudokuDialogGroupBox.Controls.Add(this.HintsUpDown);
            this.SudokuDialogGroupBox.Controls.Add(this.HintsTrackBar);
            this.SudokuDialogGroupBox.Controls.Add(this.SudokuDialogLabel);
            this.SudokuDialogGroupBox.Location = new System.Drawing.Point(15, 298);
            this.SudokuDialogGroupBox.Name = "SudokuDialogGroupBox";
            this.SudokuDialogGroupBox.Size = new System.Drawing.Size(330, 65);
            this.SudokuDialogGroupBox.TabIndex = 1;
            this.SudokuDialogGroupBox.TabStop = false;
            this.SudokuDialogGroupBox.Text = "对话框 / Dialog box";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(217, 22);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(107, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "生成 / Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Visible = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // HintsUpDown
            // 
            this.HintsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HintsUpDown.Location = new System.Drawing.Point(172, 22);
            this.HintsUpDown.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.HintsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HintsUpDown.Name = "HintsUpDown";
            this.HintsUpDown.Size = new System.Drawing.Size(39, 23);
            this.HintsUpDown.TabIndex = 4;
            this.HintsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HintsUpDown.Visible = false;
            this.HintsUpDown.ValueChanged += new System.EventHandler(this.HintsUpDown_ValueChanged);
            // 
            // HintsTrackBar
            // 
            this.HintsTrackBar.LargeChange = 1;
            this.HintsTrackBar.Location = new System.Drawing.Point(55, 17);
            this.HintsTrackBar.Maximum = 80;
            this.HintsTrackBar.Minimum = 1;
            this.HintsTrackBar.Name = "HintsTrackBar";
            this.HintsTrackBar.Size = new System.Drawing.Size(120, 45);
            this.HintsTrackBar.TabIndex = 3;
            this.HintsTrackBar.Tag = "";
            this.HintsTrackBar.Value = 1;
            this.HintsTrackBar.Visible = false;
            this.HintsTrackBar.ValueChanged += new System.EventHandler(this.HintsTrackBar_ValueChanged);
            // 
            // SudokuDialogLabel
            // 
            this.SudokuDialogLabel.AutoSize = true;
            this.SudokuDialogLabel.Location = new System.Drawing.Point(6, 19);
            this.SudokuDialogLabel.Name = "SudokuDialogLabel";
            this.SudokuDialogLabel.Size = new System.Drawing.Size(0, 17);
            this.SudokuDialogLabel.TabIndex = 0;
            // 
            // GenerateGroupBox
            // 
            this.GenerateGroupBox.Controls.Add(this.GenerateAutoButton);
            this.GenerateGroupBox.Controls.Add(this.GenerateSemiAutoButton);
            this.GenerateGroupBox.Controls.Add(this.GenerateManualButton);
            this.GenerateGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateGroupBox.Location = new System.Drawing.Point(20, 10);
            this.GenerateGroupBox.Name = "GenerateGroupBox";
            this.GenerateGroupBox.Size = new System.Drawing.Size(215, 230);
            this.GenerateGroupBox.TabIndex = 1;
            this.GenerateGroupBox.TabStop = false;
            this.GenerateGroupBox.Text = "生成谜题 / Puzzle generation";
            // 
            // GenerateAutoButton
            // 
            this.GenerateAutoButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateAutoButton.Location = new System.Drawing.Point(10, 153);
            this.GenerateAutoButton.Name = "GenerateAutoButton";
            this.GenerateAutoButton.Size = new System.Drawing.Size(193, 65);
            this.GenerateAutoButton.TabIndex = 5;
            this.GenerateAutoButton.Text = "自动生成（唯一答案）/\n Auto generate( until unique answer)";
            this.GenerateAutoButton.UseVisualStyleBackColor = true;
            this.GenerateAutoButton.Click += new System.EventHandler(this.GenerateAutoButton_Click);
            // 
            // GenerateSemiAutoButton
            // 
            this.GenerateSemiAutoButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateSemiAutoButton.Location = new System.Drawing.Point(10, 75);
            this.GenerateSemiAutoButton.Name = "GenerateSemiAutoButton";
            this.GenerateSemiAutoButton.Size = new System.Drawing.Size(193, 65);
            this.GenerateSemiAutoButton.TabIndex = 4;
            this.GenerateSemiAutoButton.Text = "自动生成（按提示数）/\nAuto generate( by amount  of hints)";
            this.GenerateSemiAutoButton.UseVisualStyleBackColor = true;
            this.GenerateSemiAutoButton.Click += new System.EventHandler(this.GenerateSemiAutoButton_Click);
            // 
            // GenerateManualButton
            // 
            this.GenerateManualButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateManualButton.Location = new System.Drawing.Point(10, 25);
            this.GenerateManualButton.Name = "GenerateManualButton";
            this.GenerateManualButton.Size = new System.Drawing.Size(193, 40);
            this.GenerateManualButton.TabIndex = 3;
            this.GenerateManualButton.Text = "手动输入 / Manually input";
            this.GenerateManualButton.UseVisualStyleBackColor = true;
            this.GenerateManualButton.Click += new System.EventHandler(this.Manual_Click);
            // 
            // SolveGroupBox
            // 
            this.SolveGroupBox.Controls.Add(this.SolveAutoButton);
            this.SolveGroupBox.Controls.Add(this.SolveManualButton);
            this.SolveGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SolveGroupBox.Location = new System.Drawing.Point(20, 250);
            this.SolveGroupBox.Name = "SolveGroupBox";
            this.SolveGroupBox.Size = new System.Drawing.Size(215, 140);
            this.SolveGroupBox.TabIndex = 2;
            this.SolveGroupBox.TabStop = false;
            this.SolveGroupBox.Text = "解答谜题 / Puzzle solving";
            // 
            // SolveAutoButton
            // 
            this.SolveAutoButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SolveAutoButton.Location = new System.Drawing.Point(10, 80);
            this.SolveAutoButton.Name = "SolveAutoButton";
            this.SolveAutoButton.Size = new System.Drawing.Size(193, 40);
            this.SolveAutoButton.TabIndex = 5;
            this.SolveAutoButton.Text = "自动计算 / Auto Calculate";
            this.SolveAutoButton.UseVisualStyleBackColor = true;
            // 
            // SolveManualButton
            // 
            this.SolveManualButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SolveManualButton.Location = new System.Drawing.Point(10, 25);
            this.SolveManualButton.Name = "SolveManualButton";
            this.SolveManualButton.Size = new System.Drawing.Size(193, 40);
            this.SolveManualButton.TabIndex = 4;
            this.SolveManualButton.Text = "手动作答 / Manually solve";
            this.SolveManualButton.UseVisualStyleBackColor = true;
            this.SolveManualButton.Click += new System.EventHandler(this.Manual_Click);
            // 
            // ManualPanel
            // 
            this.ManualPanel.Controls.Add(this.ManualGroupBox);
            this.ManualPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManualPanel.Location = new System.Drawing.Point(500, 0);
            this.ManualPanel.Name = "ManualPanel";
            this.ManualPanel.Size = new System.Drawing.Size(235, 390);
            this.ManualPanel.TabIndex = 3;
            this.ManualPanel.Visible = false;
            // 
            // ManualGroupBox
            // 
            this.ManualGroupBox.Controls.Add(this.ManualClearButton);
            this.ManualGroupBox.Controls.Add(this.ManualRedoButton);
            this.ManualGroupBox.Controls.Add(this.ManualUndoButton);
            this.ManualGroupBox.Controls.Add(this.ManualDoneButton);
            this.ManualGroupBox.Controls.Add(this.ManualNextButton);
            this.ManualGroupBox.Controls.Add(this.ManualBGModeRadioButton);
            this.ManualGroupBox.Controls.Add(this.ManualValueLabel);
            this.ManualGroupBox.Controls.Add(this.ManualBoxGridLabel);
            this.ManualGroupBox.Controls.Add(this.ManualRCModeRadioButton);
            this.ManualGroupBox.Controls.Add(this.ManualValueUpDown);
            this.ManualGroupBox.Controls.Add(this.ManualBoxGridUpDown);
            this.ManualGroupBox.Controls.Add(this.ManualColumnLabel);
            this.ManualGroupBox.Controls.Add(this.ManualBoxLabel);
            this.ManualGroupBox.Controls.Add(this.ManualColumnUpDown);
            this.ManualGroupBox.Controls.Add(this.ManualValueTrackBar);
            this.ManualGroupBox.Controls.Add(this.ManualRowLabel);
            this.ManualGroupBox.Controls.Add(this.ManualBoxUpDown);
            this.ManualGroupBox.Controls.Add(this.ManualColumnTrackBar);
            this.ManualGroupBox.Controls.Add(this.ManualBoxGridTrackBar);
            this.ManualGroupBox.Controls.Add(this.ManualBoxTrackBar);
            this.ManualGroupBox.Controls.Add(this.ManualRowUpDown);
            this.ManualGroupBox.Controls.Add(this.ManualRowTrackBar);
            this.ManualGroupBox.Location = new System.Drawing.Point(20, 10);
            this.ManualGroupBox.Name = "ManualGroupBox";
            this.ManualGroupBox.Size = new System.Drawing.Size(215, 380);
            this.ManualGroupBox.TabIndex = 0;
            this.ManualGroupBox.TabStop = false;
            this.ManualGroupBox.Text = "手动输入 / Manually input";
            // 
            // ManualClearButton
            // 
            this.ManualClearButton.Enabled = false;
            this.ManualClearButton.Location = new System.Drawing.Point(143, 345);
            this.ManualClearButton.Name = "ManualClearButton";
            this.ManualClearButton.Size = new System.Drawing.Size(60, 23);
            this.ManualClearButton.TabIndex = 4;
            this.ManualClearButton.Text = "×";
            this.ManualClearButton.UseVisualStyleBackColor = true;
            this.ManualClearButton.Click += new System.EventHandler(this.ManualClearButton_Click);
            // 
            // ManualRedoButton
            // 
            this.ManualRedoButton.Enabled = false;
            this.ManualRedoButton.Location = new System.Drawing.Point(76, 345);
            this.ManualRedoButton.Name = "ManualRedoButton";
            this.ManualRedoButton.Size = new System.Drawing.Size(60, 23);
            this.ManualRedoButton.TabIndex = 4;
            this.ManualRedoButton.Text = "→";
            this.ManualRedoButton.UseVisualStyleBackColor = true;
            this.ManualRedoButton.Click += new System.EventHandler(this.ManualRedoButton_Click);
            // 
            // ManualUndoButton
            // 
            this.ManualUndoButton.Enabled = false;
            this.ManualUndoButton.Location = new System.Drawing.Point(9, 345);
            this.ManualUndoButton.Name = "ManualUndoButton";
            this.ManualUndoButton.Size = new System.Drawing.Size(60, 23);
            this.ManualUndoButton.TabIndex = 4;
            this.ManualUndoButton.Text = "←";
            this.ManualUndoButton.UseVisualStyleBackColor = true;
            this.ManualUndoButton.Click += new System.EventHandler(this.ManualUndoButton_Click);
            // 
            // ManualDoneButton
            // 
            this.ManualDoneButton.Location = new System.Drawing.Point(111, 315);
            this.ManualDoneButton.Name = "ManualDoneButton";
            this.ManualDoneButton.Size = new System.Drawing.Size(92, 23);
            this.ManualDoneButton.TabIndex = 4;
            this.ManualDoneButton.Text = "完成 / Done";
            this.ManualDoneButton.UseVisualStyleBackColor = true;
            this.ManualDoneButton.Click += new System.EventHandler(this.ManualDoneButton_Click);
            // 
            // ManualNextButton
            // 
            this.ManualNextButton.Location = new System.Drawing.Point(9, 315);
            this.ManualNextButton.Name = "ManualNextButton";
            this.ManualNextButton.Size = new System.Drawing.Size(92, 23);
            this.ManualNextButton.TabIndex = 4;
            this.ManualNextButton.Text = "下一个 / Next";
            this.ManualNextButton.UseVisualStyleBackColor = true;
            this.ManualNextButton.Click += new System.EventHandler(this.ManualNextButton_Click);
            // 
            // ManualBGModeRadioButton
            // 
            this.ManualBGModeRadioButton.AutoSize = true;
            this.ManualBGModeRadioButton.Location = new System.Drawing.Point(6, 138);
            this.ManualBGModeRadioButton.Name = "ManualBGModeRadioButton";
            this.ManualBGModeRadioButton.Size = new System.Drawing.Size(147, 21);
            this.ManualBGModeRadioButton.TabIndex = 3;
            this.ManualBGModeRadioButton.Text = "宫格模式 / Box mode";
            this.ManualBGModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ManualValueLabel
            // 
            this.ManualValueLabel.AutoSize = true;
            this.ManualValueLabel.Location = new System.Drawing.Point(5, 258);
            this.ManualValueLabel.Name = "ManualValueLabel";
            this.ManualValueLabel.Size = new System.Drawing.Size(65, 17);
            this.ManualValueLabel.TabIndex = 2;
            this.ManualValueLabel.Text = "值 / Value";
            // 
            // ManualBoxGridLabel
            // 
            this.ManualBoxGridLabel.AutoSize = true;
            this.ManualBoxGridLabel.Enabled = false;
            this.ManualBoxGridLabel.Location = new System.Drawing.Point(4, 210);
            this.ManualBoxGridLabel.Name = "ManualBoxGridLabel";
            this.ManualBoxGridLabel.Size = new System.Drawing.Size(95, 17);
            this.ManualBoxGridLabel.TabIndex = 2;
            this.ManualBoxGridLabel.Text = "宫格 / Box grid";
            // 
            // ManualRCModeRadioButton
            // 
            this.ManualRCModeRadioButton.AutoSize = true;
            this.ManualRCModeRadioButton.Checked = true;
            this.ManualRCModeRadioButton.Location = new System.Drawing.Point(6, 22);
            this.ManualRCModeRadioButton.Name = "ManualRCModeRadioButton";
            this.ManualRCModeRadioButton.Size = new System.Drawing.Size(197, 21);
            this.ManualRCModeRadioButton.TabIndex = 3;
            this.ManualRCModeRadioButton.TabStop = true;
            this.ManualRCModeRadioButton.Text = "行列模式 / Row-column mode";
            this.ManualRCModeRadioButton.UseVisualStyleBackColor = true;
            this.ManualRCModeRadioButton.CheckedChanged += new System.EventHandler(this.ManualRadioButton_CheckedChanged);
            // 
            // ManualValueUpDown
            // 
            this.ManualValueUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualValueUpDown.Location = new System.Drawing.Point(172, 278);
            this.ManualValueUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ManualValueUpDown.Name = "ManualValueUpDown";
            this.ManualValueUpDown.Size = new System.Drawing.Size(30, 23);
            this.ManualValueUpDown.TabIndex = 1;
            this.ManualValueUpDown.ValueChanged += new System.EventHandler(this.ManualValueUpDown_ValueChanged);
            // 
            // ManualBoxGridUpDown
            // 
            this.ManualBoxGridUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualBoxGridUpDown.Enabled = false;
            this.ManualBoxGridUpDown.Location = new System.Drawing.Point(171, 230);
            this.ManualBoxGridUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ManualBoxGridUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualBoxGridUpDown.Name = "ManualBoxGridUpDown";
            this.ManualBoxGridUpDown.Size = new System.Drawing.Size(30, 23);
            this.ManualBoxGridUpDown.TabIndex = 1;
            this.ManualBoxGridUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualBoxGridUpDown.ValueChanged += new System.EventHandler(this.ManualBoxGridUpDown_ValueVChanged);
            // 
            // ManualColumnLabel
            // 
            this.ManualColumnLabel.AutoSize = true;
            this.ManualColumnLabel.Location = new System.Drawing.Point(4, 93);
            this.ManualColumnLabel.Name = "ManualColumnLabel";
            this.ManualColumnLabel.Size = new System.Drawing.Size(77, 17);
            this.ManualColumnLabel.TabIndex = 2;
            this.ManualColumnLabel.Text = "列 / Column";
            // 
            // ManualBoxLabel
            // 
            this.ManualBoxLabel.AutoSize = true;
            this.ManualBoxLabel.Enabled = false;
            this.ManualBoxLabel.Location = new System.Drawing.Point(3, 162);
            this.ManualBoxLabel.Name = "ManualBoxLabel";
            this.ManualBoxLabel.Size = new System.Drawing.Size(55, 17);
            this.ManualBoxLabel.TabIndex = 2;
            this.ManualBoxLabel.Text = "宫 / Box";
            // 
            // ManualColumnUpDown
            // 
            this.ManualColumnUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualColumnUpDown.Location = new System.Drawing.Point(171, 113);
            this.ManualColumnUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ManualColumnUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualColumnUpDown.Name = "ManualColumnUpDown";
            this.ManualColumnUpDown.Size = new System.Drawing.Size(30, 23);
            this.ManualColumnUpDown.TabIndex = 1;
            this.ManualColumnUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualColumnUpDown.ValueChanged += new System.EventHandler(this.ManualColumnUpDown_ValueChanged);
            // 
            // ManualValueTrackBar
            // 
            this.ManualValueTrackBar.LargeChange = 1;
            this.ManualValueTrackBar.Location = new System.Drawing.Point(9, 278);
            this.ManualValueTrackBar.Maximum = 9;
            this.ManualValueTrackBar.Name = "ManualValueTrackBar";
            this.ManualValueTrackBar.Size = new System.Drawing.Size(157, 45);
            this.ManualValueTrackBar.TabIndex = 0;
            this.ManualValueTrackBar.Tag = "";
            this.ManualValueTrackBar.ValueChanged += new System.EventHandler(this.ManualValueTrackBar_ValueChanged);
            // 
            // ManualRowLabel
            // 
            this.ManualRowLabel.AutoSize = true;
            this.ManualRowLabel.Location = new System.Drawing.Point(3, 46);
            this.ManualRowLabel.Name = "ManualRowLabel";
            this.ManualRowLabel.Size = new System.Drawing.Size(58, 17);
            this.ManualRowLabel.TabIndex = 2;
            this.ManualRowLabel.Text = "行 / Row";
            // 
            // ManualBoxUpDown
            // 
            this.ManualBoxUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualBoxUpDown.Enabled = false;
            this.ManualBoxUpDown.Location = new System.Drawing.Point(170, 182);
            this.ManualBoxUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ManualBoxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualBoxUpDown.Name = "ManualBoxUpDown";
            this.ManualBoxUpDown.Size = new System.Drawing.Size(30, 23);
            this.ManualBoxUpDown.TabIndex = 1;
            this.ManualBoxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualBoxUpDown.ValueChanged += new System.EventHandler(this.ManualBoxUpDown_ValueChanged);
            // 
            // ManualColumnTrackBar
            // 
            this.ManualColumnTrackBar.LargeChange = 1;
            this.ManualColumnTrackBar.Location = new System.Drawing.Point(8, 113);
            this.ManualColumnTrackBar.Maximum = 9;
            this.ManualColumnTrackBar.Minimum = 1;
            this.ManualColumnTrackBar.Name = "ManualColumnTrackBar";
            this.ManualColumnTrackBar.Size = new System.Drawing.Size(157, 45);
            this.ManualColumnTrackBar.TabIndex = 0;
            this.ManualColumnTrackBar.Tag = "";
            this.ManualColumnTrackBar.Value = 1;
            this.ManualColumnTrackBar.ValueChanged += new System.EventHandler(this.ManualColumnTrackBar_ValueChanged);
            // 
            // ManualBoxGridTrackBar
            // 
            this.ManualBoxGridTrackBar.Enabled = false;
            this.ManualBoxGridTrackBar.LargeChange = 1;
            this.ManualBoxGridTrackBar.Location = new System.Drawing.Point(8, 230);
            this.ManualBoxGridTrackBar.Maximum = 9;
            this.ManualBoxGridTrackBar.Minimum = 1;
            this.ManualBoxGridTrackBar.Name = "ManualBoxGridTrackBar";
            this.ManualBoxGridTrackBar.Size = new System.Drawing.Size(157, 45);
            this.ManualBoxGridTrackBar.TabIndex = 0;
            this.ManualBoxGridTrackBar.Tag = "";
            this.ManualBoxGridTrackBar.Value = 1;
            this.ManualBoxGridTrackBar.ValueChanged += new System.EventHandler(this.ManualBoxGridTrackBar_ValueChanged);
            // 
            // ManualBoxTrackBar
            // 
            this.ManualBoxTrackBar.Enabled = false;
            this.ManualBoxTrackBar.LargeChange = 1;
            this.ManualBoxTrackBar.Location = new System.Drawing.Point(7, 182);
            this.ManualBoxTrackBar.Maximum = 9;
            this.ManualBoxTrackBar.Minimum = 1;
            this.ManualBoxTrackBar.Name = "ManualBoxTrackBar";
            this.ManualBoxTrackBar.Size = new System.Drawing.Size(157, 45);
            this.ManualBoxTrackBar.TabIndex = 0;
            this.ManualBoxTrackBar.Tag = "";
            this.ManualBoxTrackBar.Value = 1;
            this.ManualBoxTrackBar.ValueChanged += new System.EventHandler(this.ManualBoxTrackBar_ValueChanged);
            // 
            // ManualRowUpDown
            // 
            this.ManualRowUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualRowUpDown.Location = new System.Drawing.Point(170, 66);
            this.ManualRowUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ManualRowUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualRowUpDown.Name = "ManualRowUpDown";
            this.ManualRowUpDown.Size = new System.Drawing.Size(30, 23);
            this.ManualRowUpDown.TabIndex = 1;
            this.ManualRowUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ManualRowUpDown.ValueChanged += new System.EventHandler(this.ManualRowUpDown_ValueChanged);
            // 
            // ManualRowTrackBar
            // 
            this.ManualRowTrackBar.LargeChange = 1;
            this.ManualRowTrackBar.Location = new System.Drawing.Point(7, 66);
            this.ManualRowTrackBar.Maximum = 9;
            this.ManualRowTrackBar.Minimum = 1;
            this.ManualRowTrackBar.Name = "ManualRowTrackBar";
            this.ManualRowTrackBar.Size = new System.Drawing.Size(157, 45);
            this.ManualRowTrackBar.TabIndex = 0;
            this.ManualRowTrackBar.Tag = "";
            this.ManualRowTrackBar.Value = 1;
            this.ManualRowTrackBar.ValueChanged += new System.EventHandler(this.ManualRowTrackBar_ValueChanged);
            // 
            // FunctionTimer
            // 
            this.FunctionTimer.Interval = 500;
            this.FunctionTimer.Tick += new System.EventHandler(this.FunctionTimer_Tick);
            // 
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 431);
            this.Controls.Add(this.ManualPanel);
            this.Controls.Add(this.SolveGroupBox);
            this.Controls.Add(this.GenerateGroupBox);
            this.Controls.Add(this.SudokuGroupBox);
            this.Controls.Add(this.FunctionStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FunctionForm";
            this.Text = "数独求解器 / Sudoku Solver";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FunctionForm_KeyPress);
            this.FunctionStatusStrip.ResumeLayout(false);
            this.FunctionStatusStrip.PerformLayout();
            this.SudokuGroupBox.ResumeLayout(false);
            this.SudokuDialogGroupBox.ResumeLayout(false);
            this.SudokuDialogGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HintsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintsTrackBar)).EndInit();
            this.GenerateGroupBox.ResumeLayout(false);
            this.SolveGroupBox.ResumeLayout(false);
            this.ManualPanel.ResumeLayout(false);
            this.ManualGroupBox.ResumeLayout(false);
            this.ManualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualValueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxGridUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualColumnUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualColumnTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxGridTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualBoxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualRowUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualRowTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip FunctionStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel FunctionStatusLabel;
        private System.Windows.Forms.GroupBox SudokuGroupBox;
        private System.Windows.Forms.GroupBox GenerateGroupBox;
        private System.Windows.Forms.Button GenerateManualButton;
        private System.Windows.Forms.GroupBox SolveGroupBox;
        private System.Windows.Forms.Button GenerateSemiAutoButton;
        private System.Windows.Forms.Button GenerateAutoButton;
        private System.Windows.Forms.GroupBox SudokuDialogGroupBox;
        private System.Windows.Forms.Button SolveAutoButton;
        private System.Windows.Forms.Button SolveManualButton;
        private System.Windows.Forms.TableLayoutPanel SudokuTablePanel;
        private System.Windows.Forms.Panel ManualPanel;
        private System.Windows.Forms.GroupBox ManualGroupBox;
        private System.Windows.Forms.Label ManualRowLabel;
        private System.Windows.Forms.NumericUpDown ManualRowUpDown;
        private System.Windows.Forms.TrackBar ManualRowTrackBar;
        private System.Windows.Forms.RadioButton ManualRCModeRadioButton;
        private System.Windows.Forms.Label ManualColumnLabel;
        private System.Windows.Forms.NumericUpDown ManualColumnUpDown;
        private System.Windows.Forms.TrackBar ManualColumnTrackBar;
        private System.Windows.Forms.RadioButton ManualBGModeRadioButton;
        private System.Windows.Forms.Label ManualBoxGridLabel;
        private System.Windows.Forms.NumericUpDown ManualBoxGridUpDown;
        private System.Windows.Forms.Label ManualBoxLabel;
        private System.Windows.Forms.NumericUpDown ManualBoxUpDown;
        private System.Windows.Forms.TrackBar ManualBoxTrackBar;
        private System.Windows.Forms.Button ManualClearButton;
        private System.Windows.Forms.Button ManualRedoButton;
        private System.Windows.Forms.Button ManualUndoButton;
        private System.Windows.Forms.Button ManualDoneButton;
        private System.Windows.Forms.Button ManualNextButton;
        private System.Windows.Forms.Label ManualValueLabel;
        private System.Windows.Forms.NumericUpDown ManualValueUpDown;
        private System.Windows.Forms.TrackBar ManualValueTrackBar;
        private System.Windows.Forms.TrackBar ManualBoxGridTrackBar;
        private System.Windows.Forms.Timer FunctionTimer;
        private System.Windows.Forms.Label SudokuDialogLabel;
        private System.Windows.Forms.NumericUpDown HintsUpDown;
        private System.Windows.Forms.TrackBar HintsTrackBar;
        private System.Windows.Forms.Button GenerateButton;
    }
}