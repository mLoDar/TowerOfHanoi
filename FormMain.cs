namespace TowerOfHanoi
{
    public partial class FormMain : Form
    {
        private static int _amountOfDisks;
        private static int _amountOfNeededMoves;
        private static int _amountOfCurrentMoves;

        private static int _moveIndex = 0;

        private static List<Tuple<int, int, int>> _moves = [];
        private static Stack<Panel>[] _rods =
        [
            new Stack<Panel>(),
            new Stack<Panel>(),
            new Stack<Panel>()
        ];

        private static bool _processStarted = false;
        private static bool _processEnded = false;
        private static bool _stopOver = false;



        private static readonly int _uiScalingRodHeight = 250;
        private static readonly int _uiScalingRodWidth = 10;
        private static readonly int _uiScalingDisksHeight = 20;
        private static readonly int _uiScalingDisksMargin = 20;
        private static readonly int _uiScalingBiggestDiskWidth = 100;





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

        private void TmrHanoiMove_Tick(object sender, EventArgs e)
        {
            if (_moveIndex < _moves.Count)
            {
                var move = _moves[_moveIndex];

                int rodSender = move.Item2;
                int rodReceiver = move.Item3;

                if (_rods[rodSender].Count > 0)
                {
                    Panel disk = _rods[rodSender].Pop();
                    _rods[rodReceiver].Push(disk);

                    int rodCenterX = this.Width / 6;
                    int newRodX = (rodCenterX * (2 * rodReceiver + 1)) - (disk.Width / 2);

                    disk.Location = new Point(newRodX, this.Height - (_rods[rodReceiver].Count) * (_uiScalingDisksHeight + 2) - 100);

                    _amountOfCurrentMoves++;

                    PrgMoveProgess.Value = _amountOfCurrentMoves;
                }

                _moveIndex++;
            }
            else
            {
                TmrHanoiMove.Stop();

                _processStarted = true;
                _processEnded = true;

                BtnStartStop.Text = "Start";
                BtnStartStop.Enabled = false;
                PrgMoveProgess.Value = 0;

                BtnReset.Enabled = true;
                NudAmountOfDisks.Enabled = true;


                string msbCaption = "Success";
                string msbText = "All disks have been moved!";

                MessageBoxIcon msbIcons = MessageBoxIcon.Information;
                MessageBoxButtons msbButtons = MessageBoxButtons.OK;
                
                MessageBox.Show(msbText, msbCaption, msbButtons, msbIcons);
            }
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (_processEnded == true)
            {
                return;
            }

            if (_processStarted == false)
            {
                if (_stopOver == false)
                {
                    RefreshDiskRelatedVariables();



                    int rodCenterX = this.Width / 6;

                    for (int i = 0; i < 3; i++)
                    {
                        _rods[i] = new Stack<Panel>();
                    }

                    for (int i = 0; i < _rods.Length; i++)
                    {
                        Panel rod = new()
                        {
                            Width = _uiScalingRodWidth,
                            Height = _uiScalingRodHeight,
                            BackColor = Color.Black,

                            Location = new Point((rodCenterX * (2 * i + 1)) - (_uiScalingRodWidth / 2), this.Height - _uiScalingRodHeight - 100)
                        };
                        this.Controls.Add(rod);
                    }

                    for (int i = _amountOfDisks; i > 0; i--)
                    {
                        Panel disk = new()
                        {
                            Width = _uiScalingBiggestDiskWidth + (i - 1) * _uiScalingDisksMargin,
                            Height = _uiScalingDisksHeight,

                            BackColor = Color.DeepSkyBlue
                        };

                        int rodX = (rodCenterX * (2 * 0 + 1)) - (disk.Width / 2);
                        disk.Location = new Point(rodX, this.Height - (_amountOfDisks - i + 1) * (_uiScalingDisksHeight + 2) - 100);

                        _rods[0].Push(disk);
                        this.Controls.Add(disk);
                    }
                }



                BtnReset.Enabled = false;
                NudAmountOfDisks.Enabled = false;

                SolverTowerOfHanoi(_amountOfDisks, 0, 2, 1);

                BtnStartStop.Text = "Stop";
                TmrHanoiMove.Start();

                _processStarted = true;
            }
            else
            {
                BtnStartStop.Text = "Start";
                TmrHanoiMove.Stop();

                _processStarted = false;
                _stopOver = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            List<Control> panelsToRemove = [];

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    panelsToRemove.Add(control);
                }
            }

            foreach (Control panel in panelsToRemove)
            {
                this.Controls.Remove(panel);
            }



            _processStarted = false;
            _processEnded = false;
            _stopOver = false;

            _moveIndex = 0;
            _amountOfCurrentMoves = 0;

            _rods = new Stack<Panel>[3];
            _moves = [];

            PrgMoveProgess.Value = 0;

            BtnStartStop.Enabled = true;
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

            PrgMoveProgess.Maximum = _amountOfNeededMoves;

            LblMoveProgressMaximum.Text = Convert.ToString(_amountOfNeededMoves);
        }

        private static void SolverTowerOfHanoi(int diskCount, int rodSender, int rodReceiver, int rodCache)
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