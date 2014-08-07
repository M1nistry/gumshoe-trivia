using System.Collections;
using System.Windows.Forms;

namespace POETrivia
{
    public partial class EditQuestions : Form
    {
        private readonly MainForm _main;
        private int _questionId;
        public EditQuestions()
        {
            InitializeComponent();
            _main = MainForm.GetSingleton();
            categoryComboBox.DataSource = _main.categoriesListBox.DataSource;
        }

        private void PopulateQuestions()
        {
            var categoryId = _main._categories[categoryComboBox.Text];
            questionsDGV.DataSource = _main._sqLite.QueryQuestions(categoryId);
        }

        private void PopulateAnswers()
        {
            if (questionsDGV.CurrentRow == null) return;
            _questionId = int.Parse(questionsDGV.Rows[questionsDGV.CurrentRow.Index].Cells["ID"].Value.ToString());
            answerListBox.DataSource = _main._sqLite.QueryAnswers(_questionId);
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            PopulateQuestions();
        }

        private void questionsDGV_SelectionChanged(object sender, System.EventArgs e)
        {
            PopulateAnswers();
        }

        #region Answer Box

        private void applyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UpdateAnswer();
        }

        private void addAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateAnswer();
        }

        private void UpdateAnswer()
        {
            answerListBox.Items.Clear();
            PopulateAnswers();
        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        private void answerListBox_MouseDown(object sender, MouseEventArgs e)
        {
            answerListBox.SelectedIndex = answerListBox.IndexFromPoint(e.X, e.Y);
        }
    }
}
