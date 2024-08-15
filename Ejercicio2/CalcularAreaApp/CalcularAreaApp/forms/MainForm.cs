namespace CalcularAreaApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void elipseButton_Click(object sender, EventArgs e)
        {
            forms.ElipseCalculator elipseCalculator = new forms.ElipseCalculator();
            elipseCalculator.ShowDialog();
        }

        private void paralelogramoButton_Click(object sender, EventArgs e)
        {
            ParalelogramoCalculator paralelogramoCalculator = new ParalelogramoCalculator();
            paralelogramoCalculator.ShowDialog();
        }
    }
}
