namespace SudokuCracker
{
    partial class WelcomeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTitleCN = new System.Windows.Forms.Label();
            this.MasterTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.MainTitleEN = new System.Windows.Forms.Label();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TutorialPanel = new System.Windows.Forms.Panel();
            this.TutorialTipLabel = new System.Windows.Forms.Label();
            this.TutorialGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ExitTutorialLabel = new System.Windows.Forms.Label();
            this.MainStatusStrip.SuspendLayout();
            this.TutorialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitleCN
            // 
            this.MainTitleCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTitleCN.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainTitleCN.ForeColor = System.Drawing.SystemColors.Control;
            this.MainTitleCN.Location = new System.Drawing.Point(51, 18);
            this.MainTitleCN.Name = "MainTitleCN";
            this.MainTitleCN.Size = new System.Drawing.Size(331, 83);
            this.MainTitleCN.TabIndex = 0;
            this.MainTitleCN.Text = "数独求解器";
            this.MainTitleCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTitleCN.DragLeave += new System.EventHandler(this.Main_MouseLeave);
            this.MainTitleCN.MouseEnter += new System.EventHandler(this.MainTitle_MouseEnter);
            this.MainTitleCN.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            // 
            // MasterTimer
            // 
            this.MasterTimer.Interval = 10;
            this.MasterTimer.Tick += new System.EventHandler(this.MasterTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartButton.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Location = new System.Drawing.Point(125, 150);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(190, 37);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "开始 / Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.StartButton.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(125, 300);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 37);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "退出 / Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AboutButton.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutButton.Location = new System.Drawing.Point(125, 225);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(190, 37);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "关于 / About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Visible = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.AboutButton.MouseEnter += new System.EventHandler(this.AboutButton_MouseEnter);
            this.AboutButton.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            // 
            // MainTitleEN
            // 
            this.MainTitleEN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainTitleEN.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainTitleEN.ForeColor = System.Drawing.SystemColors.Control;
            this.MainTitleEN.Location = new System.Drawing.Point(37, 87);
            this.MainTitleEN.Name = "MainTitleEN";
            this.MainTitleEN.Size = new System.Drawing.Size(360, 42);
            this.MainTitleEN.TabIndex = 4;
            this.MainTitleEN.Text = "Sudoku Solver";
            this.MainTitleEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTitleEN.MouseEnter += new System.EventHandler(this.MainTitle_MouseEnter);
            this.MainTitleEN.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 389);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(434, 22);
            this.MainStatusStrip.TabIndex = 5;
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(386, 17);
            this.MainStatusLabel.Text = "鼠标所指内容将在此显示说明。/ Instructions will be displayed here.";
            // 
            // TutorialPanel
            // 
            this.TutorialPanel.Controls.Add(this.TutorialTipLabel);
            this.TutorialPanel.Controls.Add(this.TutorialGrid);
            this.TutorialPanel.Controls.Add(this.ExitTutorialLabel);
            this.TutorialPanel.Location = new System.Drawing.Point(0, 0);
            this.TutorialPanel.Name = "TutorialPanel";
            this.TutorialPanel.Size = new System.Drawing.Size(434, 411);
            this.TutorialPanel.TabIndex = 6;
            this.TutorialPanel.Visible = false;
            this.TutorialPanel.Click += new System.EventHandler(this.TutorialPanel_Click);
            // 
            // TutorialTipLabel
            // 
            this.TutorialTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TutorialTipLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TutorialTipLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TutorialTipLabel.Location = new System.Drawing.Point(77, 303);
            this.TutorialTipLabel.Name = "TutorialTipLabel";
            this.TutorialTipLabel.Size = new System.Drawing.Size(272, 107);
            this.TutorialTipLabel.TabIndex = 3;
            this.TutorialTipLabel.Text = "数独由9行×9列的方格阵组成。\nSudoku is a gird formed with 9 rows × 9 columns.\n（单击鼠标继续，下同）\n(Cli" +
    "ck to continue, same below)";
            this.TutorialTipLabel.Click += new System.EventHandler(this.TutorialPanel_Click);
            // 
            // TutorialGrid
            // 
            this.TutorialGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TutorialGrid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TutorialGrid.ColumnCount = 9;
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TutorialGrid.Location = new System.Drawing.Point(80, 30);
            this.TutorialGrid.Margin = new System.Windows.Forms.Padding(0);
            this.TutorialGrid.Name = "TutorialGrid";
            this.TutorialGrid.RowCount = 9;
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TutorialGrid.Size = new System.Drawing.Size(270, 270);
            this.TutorialGrid.TabIndex = 0;
            this.TutorialGrid.Click += new System.EventHandler(this.TutorialPanel_Click);
            // 
            // ExitTutorialLabel
            // 
            this.ExitTutorialLabel.AutoSize = true;
            this.ExitTutorialLabel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitTutorialLabel.Location = new System.Drawing.Point(12, 9);
            this.ExitTutorialLabel.Name = "ExitTutorialLabel";
            this.ExitTutorialLabel.Size = new System.Drawing.Size(337, 19);
            this.ExitTutorialLabel.TabIndex = 0;
            this.ExitTutorialLabel.Text = "● 按Esc跳过教程。 / Press \'Esc\' button to skip tutorial.";
            this.ExitTutorialLabel.Click += new System.EventHandler(this.TutorialPanel_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.TutorialPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainTitleEN);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MainTitleCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "数独求解器 / Sudoku Solver";
            this.Activated += new System.EventHandler(this.WelcomeForm_Activated);
            this.Deactivate += new System.EventHandler(this.WelcomeForm_Deactivate);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WelcomeForm_KeyPress);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.TutorialPanel.ResumeLayout(false);
            this.TutorialPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleCN;
        private System.Windows.Forms.Timer MasterTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label MainTitleEN;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.Panel TutorialPanel;
        private System.Windows.Forms.Label ExitTutorialLabel;
        private System.Windows.Forms.Label TutorialTipLabel;
        private System.Windows.Forms.TableLayoutPanel TutorialGrid;
    }
}

