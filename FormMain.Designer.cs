namespace TowerOfHanoi
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BtnReset = new Button();
            BtnStartStop = new Button();
            TrbSpeed = new TrackBar();
            PrgMoveProgess = new ProgressBar();
            NudAmountOfDisks = new NumericUpDown();
            LblSpeed = new Label();
            LblMoveProgess = new Label();
            LblAmountOfDisks = new Label();
            LblMoveProgressMinimum = new Label();
            LblMoveProgressMaximum = new Label();
            TmrHanoiMove = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)TrbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudAmountOfDisks).BeginInit();
            SuspendLayout();
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(330, 20);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(150, 51);
            BtnReset.TabIndex = 1;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnStartStop
            // 
            BtnStartStop.Location = new Point(160, 20);
            BtnStartStop.Name = "BtnStartStop";
            BtnStartStop.Size = new Size(150, 51);
            BtnStartStop.TabIndex = 0;
            BtnStartStop.Text = "Start";
            BtnStartStop.UseVisualStyleBackColor = true;
            BtnStartStop.Click += BtnStartStop_Click;
            // 
            // TrbSpeed
            // 
            TrbSpeed.Location = new Point(690, 20);
            TrbSpeed.Minimum = 1;
            TrbSpeed.Name = "TrbSpeed";
            TrbSpeed.Size = new Size(150, 56);
            TrbSpeed.TabIndex = 7;
            TrbSpeed.Value = 5;
            TrbSpeed.ValueChanged += TrbSpeed_ValueChanged;
            // 
            // PrgMoveProgess
            // 
            PrgMoveProgess.Location = new Point(160, 149);
            PrgMoveProgess.Maximum = 500;
            PrgMoveProgess.Name = "PrgMoveProgess";
            PrgMoveProgess.Size = new Size(680, 20);
            PrgMoveProgess.TabIndex = 4;
            // 
            // NudAmountOfDisks
            // 
            NudAmountOfDisks.Location = new Point(520, 43);
            NudAmountOfDisks.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudAmountOfDisks.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NudAmountOfDisks.Name = "NudAmountOfDisks";
            NudAmountOfDisks.Size = new Size(150, 27);
            NudAmountOfDisks.TabIndex = 3;
            NudAmountOfDisks.TextAlign = HorizontalAlignment.Center;
            NudAmountOfDisks.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NudAmountOfDisks.ValueChanged += NudAmountOfDisks_ValueChanged;
            // 
            // LblSpeed
            // 
            LblSpeed.AutoSize = true;
            LblSpeed.Location = new Point(705, 56);
            LblSpeed.Name = "LblSpeed";
            LblSpeed.Size = new Size(134, 20);
            LblSpeed.TabIndex = 8;
            LblSpeed.Text = "Speed: 0.5 seconds";
            // 
            // LblMoveProgess
            // 
            LblMoveProgess.AutoSize = true;
            LblMoveProgess.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMoveProgess.Location = new Point(435, 120);
            LblMoveProgess.Name = "LblMoveProgess";
            LblMoveProgess.Size = new Size(146, 25);
            LblMoveProgess.TabIndex = 9;
            LblMoveProgess.Text = "Moves progress";
            // 
            // LblAmountOfDisks
            // 
            LblAmountOfDisks.AutoSize = true;
            LblAmountOfDisks.Location = new Point(535, 20);
            LblAmountOfDisks.Name = "LblAmountOfDisks";
            LblAmountOfDisks.Size = new Size(119, 20);
            LblAmountOfDisks.TabIndex = 2;
            LblAmountOfDisks.Text = "Amount of disks:";
            // 
            // LblMoveProgressMinimum
            // 
            LblMoveProgressMinimum.AutoSize = true;
            LblMoveProgressMinimum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMoveProgressMinimum.Location = new Point(133, 145);
            LblMoveProgressMinimum.Name = "LblMoveProgressMinimum";
            LblMoveProgressMinimum.Size = new Size(22, 25);
            LblMoveProgressMinimum.TabIndex = 5;
            LblMoveProgressMinimum.Text = "0";
            // 
            // LblMoveProgressMaximum
            // 
            LblMoveProgressMaximum.AutoSize = true;
            LblMoveProgressMaximum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMoveProgressMaximum.Location = new Point(846, 145);
            LblMoveProgressMaximum.Name = "LblMoveProgressMaximum";
            LblMoveProgressMaximum.Size = new Size(22, 25);
            LblMoveProgressMaximum.TabIndex = 6;
            LblMoveProgressMaximum.Text = "0";
            // 
            // TmrHanoiMove
            // 
            TmrHanoiMove.Interval = 500;
            TmrHanoiMove.Tick += TmrHanoiMove_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(LblMoveProgess);
            Controls.Add(LblSpeed);
            Controls.Add(TrbSpeed);
            Controls.Add(LblMoveProgressMaximum);
            Controls.Add(LblMoveProgressMinimum);
            Controls.Add(PrgMoveProgess);
            Controls.Add(NudAmountOfDisks);
            Controls.Add(LblAmountOfDisks);
            Controls.Add(BtnReset);
            Controls.Add(BtnStartStop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tower of Hanoi visualization";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)TrbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudAmountOfDisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnReset;
        private Button BtnStartStop;
        private TrackBar TrbSpeed;
        private ProgressBar PrgMoveProgess;
        private NumericUpDown NudAmountOfDisks;
        private Label LblSpeed;
        private Label LblMoveProgess;
        private Label LblAmountOfDisks;
        private Label LblMoveProgressMinimum;
        private Label LblMoveProgressMaximum;
        private System.Windows.Forms.Timer TmrHanoiMove;
    }
}
