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
            this.GenerateGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerateAutoButton = new System.Windows.Forms.Button();
            this.GenerateSemiAutoButton = new System.Windows.Forms.Button();
            this.GenerateManualButton = new System.Windows.Forms.Button();
            this.SolveGroupBox = new System.Windows.Forms.GroupBox();
            this.SolveAutoButton = new System.Windows.Forms.Button();
            this.SolveManualButton = new System.Windows.Forms.Button();
            this.FunctionTimer = new System.Windows.Forms.Timer(this.components);
            this.FunctionStatusStrip.SuspendLayout();
            this.SudokuGroupBox.SuspendLayout();
            this.GenerateGroupBox.SuspendLayout();
            this.SolveGroupBox.SuspendLayout();
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
            this.SudokuDialogGroupBox.Location = new System.Drawing.Point(15, 298);
            this.SudokuDialogGroupBox.Name = "SudokuDialogGroupBox";
            this.SudokuDialogGroupBox.Size = new System.Drawing.Size(330, 65);
            this.SudokuDialogGroupBox.TabIndex = 1;
            this.SudokuDialogGroupBox.TabStop = false;
            this.SudokuDialogGroupBox.Text = "对话框 / Dialog box";
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
            this.GenerateAutoButton.MouseEnter += new System.EventHandler(this.GenerateAutoButton_MouseEnter);
            this.GenerateAutoButton.MouseLeave += new System.EventHandler(this.FunctionForm_MouseLeave);
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
            this.GenerateSemiAutoButton.MouseEnter += new System.EventHandler(this.GenerateSemiAutoButton_MouseEnter);
            this.GenerateSemiAutoButton.MouseLeave += new System.EventHandler(this.FunctionForm_MouseLeave);
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
            this.GenerateManualButton.MouseEnter += new System.EventHandler(this.GenerateManualButton_MouseEnter);
            this.GenerateManualButton.MouseLeave += new System.EventHandler(this.FunctionForm_MouseLeave);
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
            this.SolveAutoButton.Click += new System.EventHandler(this.SolveAutoButton_Click);
            this.SolveAutoButton.MouseEnter += new System.EventHandler(this.SolveAutoButton_MouseEnter);
            this.SolveAutoButton.MouseLeave += new System.EventHandler(this.FunctionForm_MouseLeave);
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
            this.SolveManualButton.MouseEnter += new System.EventHandler(this.SolveManualButton_MouseEnter);
            this.SolveManualButton.MouseLeave += new System.EventHandler(this.FunctionForm_MouseLeave);
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
            this.GenerateGroupBox.ResumeLayout(false);
            this.SolveGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Timer FunctionTimer;
    }
}