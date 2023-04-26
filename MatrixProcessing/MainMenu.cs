namespace MatrixProcessing
{
    public partial class MainMenu : Form
    {
        private Author? _author;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _author = new Author();
            _author.Show();
        }

        private void MinUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinUpDown.Value > MaxUpDown.Value) { MaxUpDown.Value++; }

        }

        private void MaxUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaxUpDown.Value < MinUpDown.Value) { MinUpDown.Value--; }

        }
    }
}