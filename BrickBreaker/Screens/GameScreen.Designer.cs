namespace BrickBreaker
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resumeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkGray;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resumeButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.resumeButton.ForeColor = System.Drawing.Color.Black;
            this.resumeButton.Location = new System.Drawing.Point(376, 298);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(101, 38);
            this.resumeButton.TabIndex = 5;
            this.resumeButton.Text = "resume game";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(376, 254);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(101, 38);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "return to menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Old English Text MT", 25F);
            this.pauseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.pauseLabel.Location = new System.Drawing.Point(323, 211);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(210, 40);
            this.pauseLabel.TabIndex = 3;
            this.pauseLabel.Text = "Game Paused";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label pauseLabel;
    }
}
