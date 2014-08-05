using System.Windows.Forms;

namespace POETrivia
{
    public partial class EditQuestions : Form
    {
        private MainForm _main;
        public EditQuestions()
        {
            InitializeComponent();
            _main = MainForm.GetSingleton();
            categoryComboBox.DataSource = _main.categoriesListBox.DataSource;
        }
    }
}
