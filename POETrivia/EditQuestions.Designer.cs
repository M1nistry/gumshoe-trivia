namespace POETrivia
{
    partial class EditQuestions
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.resetLink = new System.Windows.Forms.LinkLabel();
            this.questionsDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.answerListBox = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnswerTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).BeginInit();
            this.answersContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 9);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(204, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(413, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(463, 9);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(158, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // resetLink
            // 
            this.resetLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetLink.AutoSize = true;
            this.resetLink.Location = new System.Drawing.Point(627, 12);
            this.resetLink.Name = "resetLink";
            this.resetLink.Size = new System.Drawing.Size(35, 13);
            this.resetLink.TabIndex = 4;
            this.resetLink.TabStop = true;
            this.resetLink.Text = "Reset";
            // 
            // questionsDGV
            // 
            this.questionsDGV.AllowUserToOrderColumns = true;
            this.questionsDGV.AllowUserToResizeRows = false;
            this.questionsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.questionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Question,
            this.Difficulty});
            this.questionsDGV.Location = new System.Drawing.Point(12, 33);
            this.questionsDGV.MultiSelect = false;
            this.questionsDGV.Name = "questionsDGV";
            this.questionsDGV.ReadOnly = true;
            this.questionsDGV.RowHeadersVisible = false;
            this.questionsDGV.RowHeadersWidth = 24;
            this.questionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionsDGV.Size = new System.Drawing.Size(495, 145);
            this.questionsDGV.TabIndex = 5;
            this.questionsDGV.SelectionChanged += new System.EventHandler(this.questionsDGV_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(590, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(509, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // answerListBox
            // 
            this.answerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.answerListBox.BackColor = System.Drawing.SystemColors.Window;
            this.answerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerListBox.ContextMenuStrip = this.answersContextMenu;
            this.answerListBox.FormattingEnabled = true;
            this.answerListBox.Location = new System.Drawing.Point(509, 33);
            this.answerListBox.Name = "answerListBox";
            this.answerListBox.Size = new System.Drawing.Size(156, 145);
            this.answerListBox.TabIndex = 8;
            this.answerListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.answerListBox_MouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "question_id";
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 50;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.DataPropertyName = "question_question";
            this.Question.HeaderText = "Question";
            this.Question.MaxInputLength = 150;
            this.Question.Name = "Question";
            // 
            // Difficulty
            // 
            this.Difficulty.DataPropertyName = "question_difficulty";
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.MaxInputLength = 50;
            this.Difficulty.Name = "Difficulty";
            // 
            // answersContextMenu
            // 
            this.answersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.answersContextMenu.Name = "answersContextMenu";
            this.answersContextMenu.ShowImageMargin = false;
            this.answersContextMenu.Size = new System.Drawing.Size(83, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnswerTextBox,
            this.applyToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addAnswerTextBox
            // 
            this.addAnswerTextBox.Name = "addAnswerTextBox";
            this.addAnswerTextBox.Size = new System.Drawing.Size(120, 23);
            this.addAnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addAnswerTextBox_KeyPress);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // EditQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 217);
            this.Controls.Add(this.answerListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionsDGV);
            this.Controls.Add(this.resetLink);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Name = "EditQuestions";
            this.Text = "Edit Questions";
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).EndInit();
            this.answersContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.LinkLabel resetLink;
        private System.Windows.Forms.DataGridView questionsDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox answerListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.ContextMenuStrip answersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox addAnswerTextBox;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}