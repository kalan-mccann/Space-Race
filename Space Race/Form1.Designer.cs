namespace Space_Race
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player2ScoreOutput = new System.Windows.Forms.Label();
            this.Player1ScoreOutput = new System.Windows.Forms.Label();
            this.winOutput = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Player2ScoreOutput
            // 
            this.Player2ScoreOutput.BackColor = System.Drawing.Color.Transparent;
            this.Player2ScoreOutput.ForeColor = System.Drawing.Color.White;
            this.Player2ScoreOutput.Location = new System.Drawing.Point(25, 47);
            this.Player2ScoreOutput.Name = "Player2ScoreOutput";
            this.Player2ScoreOutput.Size = new System.Drawing.Size(100, 23);
            this.Player2ScoreOutput.TabIndex = 0;
            // 
            // Player1ScoreOutput
            // 
            this.Player1ScoreOutput.BackColor = System.Drawing.Color.Transparent;
            this.Player1ScoreOutput.ForeColor = System.Drawing.Color.White;
            this.Player1ScoreOutput.Location = new System.Drawing.Point(662, 47);
            this.Player1ScoreOutput.Name = "Player1ScoreOutput";
            this.Player1ScoreOutput.Size = new System.Drawing.Size(100, 23);
            this.Player1ScoreOutput.TabIndex = 1;
            this.Player1ScoreOutput.Click += new System.EventHandler(this.Player1ScoreOutput_Click);
            // 
            // winOutput
            // 
            this.winOutput.BackColor = System.Drawing.Color.Transparent;
            this.winOutput.ForeColor = System.Drawing.Color.White;
            this.winOutput.Location = new System.Drawing.Point(314, 196);
            this.winOutput.Name = "winOutput";
            this.winOutput.Size = new System.Drawing.Size(100, 23);
            this.winOutput.TabIndex = 2;
            this.winOutput.Text = "SpaceRace";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(314, 263);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Press space to start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.winOutput);
            this.Controls.Add(this.Player1ScoreOutput);
            this.Controls.Add(this.Player2ScoreOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Player2ScoreOutput;
        private System.Windows.Forms.Label Player1ScoreOutput;
        private System.Windows.Forms.Label winOutput;
        private System.Windows.Forms.Label Start;
    }
}

