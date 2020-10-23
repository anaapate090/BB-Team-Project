namespace BrickBreaker
{
    partial class InstructionsScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.winInstructionLabel = new System.Windows.Forms.Label();
            this.moveInstructionLabel = new System.Windows.Forms.Label();
            this.hpInstructionLabel = new System.Windows.Forms.Label();
            this.loseInstructionLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Old English Text MT", 50F);
            this.titleLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.titleLabel.Location = new System.Drawing.Point(-3, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(854, 76);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Instructions";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winInstructionLabel
            // 
            this.winInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.winInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.winInstructionLabel.Location = new System.Drawing.Point(3, 94);
            this.winInstructionLabel.Name = "winInstructionLabel";
            this.winInstructionLabel.Size = new System.Drawing.Size(848, 71);
            this.winInstructionLabel.TabIndex = 5;
            this.winInstructionLabel.Text = "- To win, destroy all displayed bricks by bouncing the canon ball towards them us" +
    "ing the sword";
            this.winInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveInstructionLabel
            // 
            this.moveInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.moveInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.moveInstructionLabel.Location = new System.Drawing.Point(0, 182);
            this.moveInstructionLabel.Name = "moveInstructionLabel";
            this.moveInstructionLabel.Size = new System.Drawing.Size(854, 31);
            this.moveInstructionLabel.TabIndex = 6;
            this.moveInstructionLabel.Text = "- Use left and right arrows to move paddle";
            this.moveInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hpInstructionLabel
            // 
            this.hpInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.hpInstructionLabel.Location = new System.Drawing.Point(135, 241);
            this.hpInstructionLabel.Name = "hpInstructionLabel";
            this.hpInstructionLabel.Size = new System.Drawing.Size(593, 70);
            this.hpInstructionLabel.TabIndex = 7;
            this.hpInstructionLabel.Text = "- Cracked bricks have 1 HP, normal bricks have 2 HP, and golden bricks have 3 HP";
            this.hpInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loseInstructionLabel
            // 
            this.loseInstructionLabel.AutoSize = true;
            this.loseInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.loseInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.loseInstructionLabel.Location = new System.Drawing.Point(64, 338);
            this.loseInstructionLabel.Name = "loseInstructionLabel";
            this.loseInstructionLabel.Size = new System.Drawing.Size(743, 31);
            this.loseInstructionLabel.TabIndex = 8;
            this.loseInstructionLabel.Text = "- Don\'t let the canon ball hit the ground, or else you will lose a life\r\n";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.menuButton.Location = new System.Drawing.Point(338, 409);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(194, 77);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // InstructionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.game_screen_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.loseInstructionLabel);
            this.Controls.Add(this.hpInstructionLabel);
            this.Controls.Add(this.moveInstructionLabel);
            this.Controls.Add(this.winInstructionLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "InstructionsScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label winInstructionLabel;
        private System.Windows.Forms.Label moveInstructionLabel;
        private System.Windows.Forms.Label hpInstructionLabel;
        private System.Windows.Forms.Label loseInstructionLabel;
        private System.Windows.Forms.Button menuButton;
    }
}
