namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        private static int _amountOfDisks;
        private static int _amountOfNeededMoves;

        private List<Tuple<int, int, int>> _moves = [];





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
            _amountOfDisks = (int)Math.Round(NudAmountOfDisks.Value);
            _amountOfNeededMoves = (int)Math.Pow(2, _amountOfDisks) - 1;

            LblMoveProgressMaximum.Text = Convert.ToString(_amountOfNeededMoves);
        }

        private void SolverTowerOfHanoi(int diskCount, int rodSender, int rodReceiver, int rodCache)
        {
            if (diskCount == 1)
            {
                _moves.Add(new Tuple<int, int, int>(diskCount, rodSender, rodReceiver));
                return;
            }

            SolverTowerOfHanoi(diskCount - 1, rodSender, rodCache, rodReceiver);

            _moves.Add(new Tuple<int, int, int>(diskCount, rodSender, rodReceiver));

            SolverTowerOfHanoi(diskCount - 1, rodCache, rodReceiver, rodSender);
        }
    }
}