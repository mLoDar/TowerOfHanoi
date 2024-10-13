namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        private static int _AmountOfDisks;
        private static int _AmountOfNeededMoves;





        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshSpeedRelatedVariables();
            RefreshDiskRelatedVariables();

            PrgMoveProgess.Value = 0;
        }





        private void TrbSpeed_ValueChanged(object sender, EventArgs e)
        {
            RefreshSpeedRelatedVariables();
        }

        private void NudAmountOfDisks_ValueChanged(object sender, EventArgs e)
        {
            RefreshDiskRelatedVariables();
        }





        private void RefreshSpeedRelatedVariables()
        {
            TmrHanoiMove.Interval = TrbSpeed.Value * 100;

            if (TrbSpeed.Value == 10)
            {
                LblSpeed.Text = $"Speed:    1 second";
                return;
            }

            LblSpeed.Text = $"Speed: 0.{TrbSpeed.Value} seconds";
        }

        private void RefreshDiskRelatedVariables()
        {
            _AmountOfDisks = (int)Math.Round(NudAmountOfDisks.Value);
            _AmountOfNeededMoves = (int)Math.Pow(2, _AmountOfDisks) - 1;

            LblMoveProgressMaximum.Text = Convert.ToString(_AmountOfNeededMoves);
        }
    }
}