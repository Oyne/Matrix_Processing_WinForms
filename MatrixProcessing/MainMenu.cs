using System.Text.Json;

namespace MatrixProcessing
{
    public partial class MainMenu : Form
    {
        private Author? _author;
        private MatrixProccesing? _proccesing;
        private string _file_name;
        private MatrixOperations _matrix = new MatrixOperations();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            _author = new Author();
            _author.ShowDialog();
        }

        private void MinUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinUpDown.Value > MaxUpDown.Value) { MaxUpDown.Value++; }

        }

        private void MaxUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaxUpDown.Value < MinUpDown.Value) { MinUpDown.Value--; }

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportFileDialog = new OpenFileDialog();
            ImportFileDialog.InitialDirectory = "Desktop";
            ImportFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

            ImportFileDialog.FilterIndex = 1;
            ImportFileDialog.Title = "Import file";

            if (ImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                _file_name = ImportFileDialog.FileName;
                string json = File.ReadAllText(_file_name);
                //_matrix.Value = JsonSerializer.Deserialize<int[][]>(json);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _matrix.GenerateMatrix(Convert.ToInt32(SizeUpDown.Value), Convert.ToInt32(MinUpDown.Value), Convert.ToInt32(MaxUpDown.Value));
            _proccesing = new MatrixProccesing(_file_name, _matrix);

            _proccesing.ShowDialog();
        }
    }
}