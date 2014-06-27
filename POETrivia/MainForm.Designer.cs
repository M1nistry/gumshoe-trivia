namespace POETrivia
{
    partial class MainForm
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
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statisticPage = new System.Windows.Forms.TabPage();
            this.resetLabel = new System.Windows.Forms.LinkLabel();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.togglePlayersButton = new System.Windows.Forms.Button();
            this.playerStatisticsListView = new System.Windows.Forms.ListView();
            this.playersLabel = new System.Windows.Forms.Label();
            this.toggleQuestionsButton = new System.Windows.Forms.Button();
            this.questionsLabel = new System.Windows.Forms.Label();
            this.statisticsListView = new System.Windows.Forms.ListView();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cooldownNumeric = new System.Windows.Forms.NumericUpDown();
            this.cooldownLabel = new System.Windows.Forms.Label();
            this.blacklistNameAddTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.blacklistListBox = new System.Windows.Forms.ListBox();
            this.blacklistLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.questionDurationNumeric = new System.Windows.Forms.NumericUpDown();
            this.questionTimeLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chatBGW = new System.ComponentModel.BackgroundWorker();
            this.readTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.statisticPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDurationNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(6, 6);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(60, 13);
            this.categoriesLabel.TabIndex = 0;
            this.categoriesLabel.Text = "Categories:";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(103, 6);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.categoriesListBox.Size = new System.Drawing.Size(180, 69);
            this.categoriesListBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.statisticPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(304, 487);
            this.tabControl.TabIndex = 1;
            // 
            // statisticPage
            // 
            this.statisticPage.Controls.Add(this.resetLabel);
            this.statisticPage.Controls.Add(this.filterTextBox);
            this.statisticPage.Controls.Add(this.filterLabel);
            this.statisticPage.Controls.Add(this.togglePlayersButton);
            this.statisticPage.Controls.Add(this.playerStatisticsListView);
            this.statisticPage.Controls.Add(this.playersLabel);
            this.statisticPage.Controls.Add(this.toggleQuestionsButton);
            this.statisticPage.Controls.Add(this.questionsLabel);
            this.statisticPage.Controls.Add(this.statisticsListView);
            this.statisticPage.Location = new System.Drawing.Point(4, 22);
            this.statisticPage.Name = "statisticPage";
            this.statisticPage.Padding = new System.Windows.Forms.Padding(3);
            this.statisticPage.Size = new System.Drawing.Size(296, 461);
            this.statisticPage.TabIndex = 0;
            this.statisticPage.Text = "Statistics";
            this.statisticPage.UseVisualStyleBackColor = true;
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Location = new System.Drawing.Point(253, 354);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(35, 13);
            this.resetLabel.TabIndex = 8;
            this.resetLabel.TabStop = true;
            this.resetLabel.Text = "Reset";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(44, 351);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(203, 20);
            this.filterTextBox.TabIndex = 7;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(6, 354);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(32, 13);
            this.filterLabel.TabIndex = 6;
            this.filterLabel.Text = "Filter:";
            // 
            // togglePlayersButton
            // 
            this.togglePlayersButton.Location = new System.Drawing.Point(266, 189);
            this.togglePlayersButton.Name = "togglePlayersButton";
            this.togglePlayersButton.Size = new System.Drawing.Size(22, 20);
            this.togglePlayersButton.TabIndex = 5;
            this.togglePlayersButton.Text = "↑";
            this.togglePlayersButton.UseVisualStyleBackColor = true;
            // 
            // playerStatisticsListView
            // 
            this.playerStatisticsListView.Location = new System.Drawing.Point(6, 214);
            this.playerStatisticsListView.Name = "playerStatisticsListView";
            this.playerStatisticsListView.Size = new System.Drawing.Size(282, 131);
            this.playerStatisticsListView.TabIndex = 4;
            this.playerStatisticsListView.UseCompatibleStateImageBehavior = false;
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Location = new System.Drawing.Point(6, 193);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(44, 13);
            this.playersLabel.TabIndex = 3;
            this.playersLabel.Text = "Players:";
            // 
            // toggleQuestionsButton
            // 
            this.toggleQuestionsButton.Location = new System.Drawing.Point(266, 6);
            this.toggleQuestionsButton.Name = "toggleQuestionsButton";
            this.toggleQuestionsButton.Size = new System.Drawing.Size(22, 20);
            this.toggleQuestionsButton.TabIndex = 2;
            this.toggleQuestionsButton.Text = "↑";
            this.toggleQuestionsButton.UseVisualStyleBackColor = true;
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Location = new System.Drawing.Point(6, 10);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(57, 13);
            this.questionsLabel.TabIndex = 1;
            this.questionsLabel.Text = "Questions:";
            // 
            // statisticsListView
            // 
            this.statisticsListView.Location = new System.Drawing.Point(6, 32);
            this.statisticsListView.Name = "statisticsListView";
            this.statisticsListView.Size = new System.Drawing.Size(282, 153);
            this.statisticsListView.TabIndex = 0;
            this.statisticsListView.UseCompatibleStateImageBehavior = false;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.label1);
            this.settingsTabPage.Controls.Add(this.cooldownNumeric);
            this.settingsTabPage.Controls.Add(this.cooldownLabel);
            this.settingsTabPage.Controls.Add(this.blacklistNameAddTextBox);
            this.settingsTabPage.Controls.Add(this.button1);
            this.settingsTabPage.Controls.Add(this.blacklistListBox);
            this.settingsTabPage.Controls.Add(this.blacklistLabel);
            this.settingsTabPage.Controls.Add(this.secondsLabel);
            this.settingsTabPage.Controls.Add(this.questionDurationNumeric);
            this.settingsTabPage.Controls.Add(this.questionTimeLabel);
            this.settingsTabPage.Controls.Add(this.categoriesListBox);
            this.settingsTabPage.Controls.Add(this.categoriesLabel);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(296, 461);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "seconds";
            // 
            // cooldownNumeric
            // 
            this.cooldownNumeric.Location = new System.Drawing.Point(103, 118);
            this.cooldownNumeric.Name = "cooldownNumeric";
            this.cooldownNumeric.Size = new System.Drawing.Size(52, 20);
            this.cooldownNumeric.TabIndex = 11;
            this.toolTip.SetToolTip(this.cooldownNumeric, "Time between a question finishing/being answer before asking a new question");
            // 
            // cooldownLabel
            // 
            this.cooldownLabel.AutoSize = true;
            this.cooldownLabel.Location = new System.Drawing.Point(6, 120);
            this.cooldownLabel.Name = "cooldownLabel";
            this.cooldownLabel.Size = new System.Drawing.Size(57, 13);
            this.cooldownLabel.TabIndex = 10;
            this.cooldownLabel.Text = "Cooldown:";
            // 
            // blacklistNameAddTextBox
            // 
            this.blacklistNameAddTextBox.Location = new System.Drawing.Point(102, 433);
            this.blacklistNameAddTextBox.Multiline = true;
            this.blacklistNameAddTextBox.Name = "blacklistNameAddTextBox";
            this.blacklistNameAddTextBox.Size = new System.Drawing.Size(123, 21);
            this.blacklistNameAddTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // blacklistListBox
            // 
            this.blacklistListBox.FormattingEnabled = true;
            this.blacklistListBox.Location = new System.Drawing.Point(103, 345);
            this.blacklistListBox.Name = "blacklistListBox";
            this.blacklistListBox.Size = new System.Drawing.Size(180, 82);
            this.blacklistListBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.blacklistListBox, "List of character names blacklisted from answering");
            // 
            // blacklistLabel
            // 
            this.blacklistLabel.AutoSize = true;
            this.blacklistLabel.Location = new System.Drawing.Point(17, 345);
            this.blacklistLabel.Name = "blacklistLabel";
            this.blacklistLabel.Size = new System.Drawing.Size(49, 13);
            this.blacklistLabel.TabIndex = 5;
            this.blacklistLabel.Text = "Blacklist:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(161, 94);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(47, 13);
            this.secondsLabel.TabIndex = 4;
            this.secondsLabel.Text = "seconds";
            // 
            // questionDurationNumeric
            // 
            this.questionDurationNumeric.Location = new System.Drawing.Point(103, 92);
            this.questionDurationNumeric.Name = "questionDurationNumeric";
            this.questionDurationNumeric.Size = new System.Drawing.Size(52, 20);
            this.questionDurationNumeric.TabIndex = 3;
            this.questionDurationNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // questionTimeLabel
            // 
            this.questionTimeLabel.AutoSize = true;
            this.questionTimeLabel.Location = new System.Drawing.Point(6, 94);
            this.questionTimeLabel.Name = "questionTimeLabel";
            this.questionTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.questionTimeLabel.TabIndex = 2;
            this.questionTimeLabel.Text = "Question Time:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusValueLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // statusValueLabel
            // 
            this.statusValueLabel.Name = "statusValueLabel";
            this.statusValueLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // chatBGW
            // 
            this.chatBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.chatBGW_DoWork);
            // 
            // readTimer
            // 
            this.readTimer.Tick += new System.EventHandler(this.readTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 524);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Gumshoe Trivia";
            this.tabControl.ResumeLayout(false);
            this.statisticPage.ResumeLayout(false);
            this.statisticPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDurationNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage statisticPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TextBox blacklistNameAddTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox blacklistListBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label blacklistLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.NumericUpDown questionDurationNumeric;
        private System.Windows.Forms.Label questionTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cooldownNumeric;
        private System.Windows.Forms.Label cooldownLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusValueLabel;
        private System.Windows.Forms.LinkLabel resetLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button togglePlayersButton;
        private System.Windows.Forms.ListView playerStatisticsListView;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Button toggleQuestionsButton;
        private System.Windows.Forms.Label questionsLabel;
        private System.Windows.Forms.ListView statisticsListView;
        private System.ComponentModel.BackgroundWorker chatBGW;
        private System.Windows.Forms.Timer readTimer;
    }
}

