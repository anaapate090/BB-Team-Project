namespace BrickBreaker
{
    partial class GameOverScreen
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();

            this.letter1Output = new System.Windows.Forms.Button();
            this.letter2Output = new System.Windows.Forms.Button();
            this.letter3Output = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.gameOverLabel.Location = new System.Drawing.Point(0, 82);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(1139, 129);
            this.gameOverLabel.TabIndex = 10;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Enabled = false;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);

            this.exitButton.Location = new System.Drawing.Point(228, 521);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);

            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(259, 95);
            this.exitButton.TabIndex = 250;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            this.exitButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.exitButton_PreviewKeyDown);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.White;
            this.playAgainButton.Enabled = false;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);

            this.playAgainButton.Location = new System.Drawing.Point(660, 521);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(4);

            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(259, 95);
            this.playAgainButton.TabIndex = 200;
            this.playAgainButton.TabStop = false;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.Enter += new System.EventHandler(this.playAgainButton_Enter);
            this.playAgainButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playAgainButton_PreviewKeyDown);
            // 
            // letter1Output
            // 
            this.letter1Output.BackColor = System.Drawing.Color.White;
            this.letter1Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter1Output.Location = new System.Drawing.Point(322, 260);
            this.letter1Output.Name = "letter1Output";
            this.letter1Output.Size = new System.Drawing.Size(160, 148);
            this.letter1Output.TabIndex = 20;
            this.letter1Output.TabStop = false;
            this.letter1Output.Text = "A";
            this.letter1Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter1Output.UseVisualStyleBackColor = false;
            this.letter1Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter1Output_PreviewKeyDown);

            // 
            // letter2Output
            // 
            this.letter2Output.BackColor = System.Drawing.Color.White;
            this.letter2Output.Enabled = false;
            this.letter2Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter2Output.Location = new System.Drawing.Point(490, 260);
            this.letter2Output.Name = "letter2Output";
            this.letter2Output.Size = new System.Drawing.Size(160, 148);
            this.letter2Output.TabIndex = 99;
            this.letter2Output.TabStop = false;
            this.letter2Output.Text = "A";
            this.letter2Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter2Output.UseVisualStyleBackColor = false;
            this.letter2Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter2Output_PreviewKeyDown);
            // 
            // letter3Output
            // 
            this.letter3Output.BackColor = System.Drawing.Color.White;
            this.letter3Output.Enabled = false;
            this.letter3Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter3Output.Location = new System.Drawing.Point(656, 260);
            this.letter3Output.Name = "letter3Output";
            this.letter3Output.Size = new System.Drawing.Size(160, 148);
            this.letter3Output.TabIndex = 150;
            this.letter3Output.TabStop = false;
            this.letter3Output.Text = "A";
            this.letter3Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter3Output.UseVisualStyleBackColor = false;
            this.letter3Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter3Output_PreviewKeyDown);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.menuButton.Location = new System.Drawing.Point(334, 423);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(194, 77);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Enter += new System.EventHandler(this.menuButton_Enter);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.letter3Output);
            this.Controls.Add(this.letter2Output);
            this.Controls.Add(this.letter1Output);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(1139, 667);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;

        private System.Windows.Forms.Button letter1Output;
        private System.Windows.Forms.Button letter2Output;
        private System.Windows.Forms.Button letter3Output;

    }
}
