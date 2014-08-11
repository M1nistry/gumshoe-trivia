using System.Collections.Generic;
using System.Windows.Forms;

namespace POETrivia
{
    public partial class AddUpdateQuestions : Form
    {
        private bool _update;
        private int _id;
        private SQLite _sqLite;

        public AddUpdateQuestions()
        {
            InitializeComponent();
            _sqLite = new SQLite();
        }

        public void Populate(string question, List<string> answers, int id)
        {
            _update = true;
            questionTextBox.Text = question;
            answerListBox.DataSource = answers;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (_update)
            {
                //_sqLite.Update()
            }
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }
    }
}
