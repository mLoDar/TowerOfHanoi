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
            BtnReset.Location = new Point(289, 15);
            BtnReset.Margin = new Padding(3, 2, 3, 2);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(131, 38);
            BtnReset.TabIndex = 1;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnStartStop
            // 
            BtnStartStop.Location = new Point(140, 15);
            BtnStartStop.Margin = new Padding(3, 2, 3, 2);
            BtnStartStop.Name = "BtnStartStop";
            BtnStartStop.Size = new Size(131, 38);
            BtnStartStop.TabIndex = 0;
            BtnStartStop.Text = "Start";
            BtnStartStop.UseVisualStyleBackColor = true;
            // 
            // TrbSpeed
            // 
            TrbSpeed.Location = new Point(604, 15);
            TrbSpeed.Margin = new Padding(3, 2, 3, 2);
            TrbSpeed.Minimum = 1;
            TrbSpeed.Name = "TrbSpeed";
            TrbSpeed.Size = new Size(131, 45);
            TrbSpeed.TabIndex = 7;
            TrbSpeed.Value = 5;
            TrbSpeed.ValueChanged += TrbSpeed_ValueChanged;
            // 
            // PrgMoveProgess
            // 
            PrgMoveProgess.Location = new Point(140, 112);
            PrgMoveProgess.Margin = new Padding(3, 2, 3, 2);
            PrgMoveProgess.Maximum = 500;
            PrgMoveProgess.Name = "PrgMoveProgess";
            PrgMoveProgess.Size = new Size(595, 15);
            PrgMoveProgess.TabIndex = 4;
            // 
            // NudAmountOfDisks
            // 
            NudAmountOfDisks.Location = new Point(455, 32);
            NudAmountOfDisks.Margin = new Padding(3, 2, 3, 2);
            NudAmountOfDisks.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudAmountOfDisks.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NudAmountOfDisks.Name = "NudAmountOfDisks";
            NudAmountOfDisks.Size = new Size(131, 23);
            NudAmountOfDisks.TabIndex = 3;
            NudAmountOfDisks.TextAlign = HorizontalAlignment.Center;
            NudAmountOfDisks.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NudAmountOfDisks.ValueChanged += NudAmountOfDisks_ValueChanged;
            // 
            // LblSpeed
            // 
            LblSpeed.AutoSize = true;
            LblSpeed.Location = new Point(617, 42);
            LblSpeed.Name = "LblSpeed";
            LblSpeed.Size = new Size(106, 15);
            LblSpeed.TabIndex = 8;
            LblSpeed.Text = "Speed: 0.5 seconds";
            // 
            // LblMoveProgess
            // 
            LblMoveProgess.AutoSize = true;
            LblMoveProgess.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMoveProgess.Location = new Point(407, 90);
            LblMoveProgess.Name = "LblMoveProgess";
            LblMoveProgess.Size = new Size(70, 20);
            LblMoveProgess.TabIndex = 9;
            LblMoveProgess.Text = "Progress";
            // 
            // LblAmountOfDisks
            // 
            LblAmountOfDisks.AutoSize = true;
            LblAmountOfDisks.Location = new Point(468, 15);
            LblAmountOfDisks.Name = "LblAmountOfDisks";
            LblAmountOfDisks.Size = new Size(97, 15);
            LblAmountOfDisks.TabIndex = 2;
            LblAmountOfDisks.Text = "Amount of disks:";
            // 
            // LblMoveProgressMinimum
            // 
            LblMoveProgressMinimum.AutoSize = true;
            LblMoveProgressMinimum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMoveProgressMinimum.Location = new Point(116, 109);
            LblMoveProgressMinimum.Name = "LblMoveProgressMinimum";
            LblMoveProgressMinimum.Size = new Size(17, 20);
            LblMoveProgressMinimum.TabIndex = 5;
            LblMoveProgressMinimum.Text = "0";
            // 
            // LblMoveProgressMaximum
            // 
            LblMoveProgressMaximum.AutoSize = true;
            LblMoveProgressMaximum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMoveProgressMaximum.Location = new Point(740, 109);
            LblMoveProgressMaximum.Name = "LblMoveProgressMaximum";
            LblMoveProgressMaximum.Size = new Size(17, 20);
            LblMoveProgressMaximum.TabIndex = 6;
            LblMoveProgressMaximum.Text = "0";
            // 
            // TmrHanoiMove
            // 
            TmrHanoiMove.Interval = 500;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
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
            Margin = new Padding(3, 2, 3, 2);
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
