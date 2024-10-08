namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void TrackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            TimerHanoiMove.Interval = TrackBarSpeed.Value;

            LabelSpeed.Text = $"Speed: {TrackBarSpeed.Value} millis";
        }
    }
}