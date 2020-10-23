namespace BrickBreaker
{
    partial class HighScoreScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.highScoreHeader = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.scoreHeader = new System.Windows.Forms.Label();
            this.nameHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 43);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // highScoreHeader
            // 
            this.highScoreHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.highScoreHeader.Location = new System.Drawing.Point(369, 36);
            this.highScoreHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreHeader.Name = "highScoreHeader";
            this.highScoreHeader.Size = new System.Drawing.Size(400, 49);
            this.highScoreHeader.TabIndex = 1;
            this.highScoreHeader.Text = "HIGH SCORES";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.outputLabel.Location = new System.Drawing.Point(267, 100);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(596, 540);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.White;
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameOutput.Location = new System.Drawing.Point(267, 137);
            this.nameOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(289, 503);
            this.nameOutput.TabIndex = 3;
            this.nameOutput.Text = "iu";
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.White;
            this.scoreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreOutput.Location = new System.Drawing.Point(551, 137);
            this.scoreOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(312, 503);
            this.scoreOutput.TabIndex = 4;
            this.scoreOutput.Text = "ui";
            this.scoreOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreHeader
            // 
            this.scoreHeader.BackColor = System.Drawing.Color.White;
            this.scoreHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.scoreHeader.Location = new System.Drawing.Point(559, 100);
            this.scoreHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreHeader.Name = "scoreHeader";
            this.scoreHeader.Size = new System.Drawing.Size(304, 37);
            this.scoreHeader.TabIndex = 5;
            this.scoreHeader.Text = "Score";
            this.scoreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameHeader
            // 
            this.nameHeader.BackColor = System.Drawing.Color.White;
            this.nameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nameHeader.Location = new System.Drawing.Point(269, 100);
            this.nameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(304, 37);
            this.nameHeader.TabIndex = 6;
            this.nameHeader.Text = "Name";
            this.nameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.nameHeader);
            this.Controls.Add(this.scoreHeader);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.highScoreHeader);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(1139, 667);
            this.Load += new System.EventHandler(this.HighScoreScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label highScoreHeader;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label scoreHeader;
        private System.Windows.Forms.Label nameHeader;
    }
}
