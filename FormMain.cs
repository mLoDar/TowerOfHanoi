namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void TrackBarSpeed_Scroll(object sender, EventArgs e)
        {
            LabelSpeed.Text = $"Speed: {TrackBarSpeed.Value} millis";
        }
    }
}