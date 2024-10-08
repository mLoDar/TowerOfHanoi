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
            ButtonReset = new Button();
            ButtonStartStop = new Button();
            TrackBarSpeed = new TrackBar();
            ProgressBarMoveProgess = new ProgressBar();
            NumericUpDownAmountOfDisks = new NumericUpDown();
            LabelSpeed = new Label();
            LabelMoveProgess = new Label();
            LabelAmountOfDisks = new Label();
            LabelMoveProgressMinimum = new Label();
            LabelMoveProgressMaximum = new Label();
            TimerHanoiMove = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)TrackBarSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmountOfDisks).BeginInit();
            SuspendLayout();
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(330, 20);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(150, 50);
            ButtonReset.TabIndex = 1;
            ButtonReset.Text = "Reset";
            ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonStartStop
            // 
            ButtonStartStop.Location = new Point(160, 20);
            ButtonStartStop.Name = "ButtonStartStop";
            ButtonStartStop.Size = new Size(150, 50);
            ButtonStartStop.TabIndex = 0;
            ButtonStartStop.Text = "Start";
            ButtonStartStop.UseVisualStyleBackColor = true;
            // 
            // TrackBarSpeed
            // 
            TrackBarSpeed.Location = new Point(690, 20);
            TrackBarSpeed.Maximum = 1000;
            TrackBarSpeed.Minimum = 100;
            TrackBarSpeed.Name = "TrackBarSpeed";
            TrackBarSpeed.Size = new Size(150, 56);
            TrackBarSpeed.TabIndex = 7;
            TrackBarSpeed.Value = 500;
            TrackBarSpeed.ValueChanged += TrackBarSpeed_ValueChanged;
            // 
            // ProgressBarMoveProgess
            // 
            ProgressBarMoveProgess.Location = new Point(160, 150);
            ProgressBarMoveProgess.Maximum = 500;
            ProgressBarMoveProgess.Name = "ProgressBarMoveProgess";
            ProgressBarMoveProgess.Size = new Size(680, 20);
            ProgressBarMoveProgess.TabIndex = 4;
            // 
            // NumericUpDownAmountOfDisks
            // 
            NumericUpDownAmountOfDisks.Location = new Point(520, 43);
            NumericUpDownAmountOfDisks.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDownAmountOfDisks.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NumericUpDownAmountOfDisks.Name = "NumericUpDownAmountOfDisks";
            NumericUpDownAmountOfDisks.Size = new Size(150, 27);
            NumericUpDownAmountOfDisks.TabIndex = 3;
            NumericUpDownAmountOfDisks.TextAlign = HorizontalAlignment.Center;
            NumericUpDownAmountOfDisks.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // LabelSpeed
            // 
            LabelSpeed.AutoSize = true;
            LabelSpeed.Location = new Point(705, 56);
            LabelSpeed.Name = "LabelSpeed";
            LabelSpeed.Size = new Size(121, 20);
            LabelSpeed.TabIndex = 8;
            LabelSpeed.Text = "Speed: 500 millis";
            // 
            // LabelMoveProgess
            // 
            LabelMoveProgess.AutoSize = true;
            LabelMoveProgess.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelMoveProgess.Location = new Point(465, 120);
            LabelMoveProgess.Name = "LabelMoveProgess";
            LabelMoveProgess.Size = new Size(85, 25);
            LabelMoveProgess.TabIndex = 9;
            LabelMoveProgess.Text = "Progress";
            // 
            // LabelAmountOfDisks
            // 
            LabelAmountOfDisks.AutoSize = true;
            LabelAmountOfDisks.Location = new Point(535, 20);
            LabelAmountOfDisks.Name = "LabelAmountOfDisks";
            LabelAmountOfDisks.Size = new Size(119, 20);
            LabelAmountOfDisks.TabIndex = 2;
            LabelAmountOfDisks.Text = "Amount of disks:";
            // 
            // LabelMoveProgressMinimum
            // 
            LabelMoveProgressMinimum.AutoSize = true;
            LabelMoveProgressMinimum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMoveProgressMinimum.Location = new Point(132, 145);
            LabelMoveProgressMinimum.Name = "LabelMoveProgressMinimum";
            LabelMoveProgressMinimum.Size = new Size(22, 25);
            LabelMoveProgressMinimum.TabIndex = 5;
            LabelMoveProgressMinimum.Text = "0";
            // 
            // LabelMoveProgressMaximum
            // 
            LabelMoveProgressMaximum.AutoSize = true;
            LabelMoveProgressMaximum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMoveProgressMaximum.Location = new Point(846, 145);
            LabelMoveProgressMaximum.Name = "LabelMoveProgressMaximum";
            LabelMoveProgressMaximum.Size = new Size(22, 25);
            LabelMoveProgressMaximum.TabIndex = 6;
            LabelMoveProgressMaximum.Text = "0";
            // 
            // TimerHanoiMove
            // 
            TimerHanoiMove.Interval = 500;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(LabelMoveProgess);
            Controls.Add(LabelSpeed);
            Controls.Add(TrackBarSpeed);
            Controls.Add(LabelMoveProgressMaximum);
            Controls.Add(LabelMoveProgressMinimum);
            Controls.Add(ProgressBarMoveProgess);
            Controls.Add(NumericUpDownAmountOfDisks);
            Controls.Add(LabelAmountOfDisks);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonStartStop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tower of Hanoi visualization";
            ((System.ComponentModel.ISupportInitialize)TrackBarSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmountOfDisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonReset;
        private Button ButtonStartStop;
        private TrackBar TrackBarSpeed;
        private ProgressBar ProgressBarMoveProgess;
        private NumericUpDown NumericUpDownAmountOfDisks;
        private Label LabelSpeed;
        private Label LabelMoveProgess;
        private Label LabelAmountOfDisks;
        private Label LabelMoveProgressMinimum;
        private Label LabelMoveProgressMaximum;
        private System.Windows.Forms.Timer TimerHanoiMove;
    }
}
