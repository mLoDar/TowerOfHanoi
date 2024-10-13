namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void TrbSpeed_ValueChanged(object sender, EventArgs e)
        {
            TmrHanoiMove.Interval = TrbSpeed.Value;

            LblSpeed.Text = $"Speed: {TrbSpeed.Value} millis";
        }
    }
}