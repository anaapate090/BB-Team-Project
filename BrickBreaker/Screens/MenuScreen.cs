﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        private void playButton_Enter(object sender, EventArgs e)
        {

            exitButton.BackColor = Color.LightGray;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightGray;

        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            highScoreButton.BackColor = Color.Silver;
            playButton.BackColor = Color.Silver;
            exitButton.BackColor = Color.LightSalmon;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightGray;
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            // Goes to the high scores screen
            HighScoreScreen hs = new HighScoreScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(hs);

            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            InstructionsScreen ins = new InstructionsScreen();

            f.Controls.Remove(this);
            f.Controls.Add(ins);

            ins.Focus();
        }

        private void instructionsButton_Enter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightGray;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightSalmon;
        private void highScoreButton_Enter(object sender, EventArgs e)
        {
            highScoreButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
            playButton.BackColor = Color.Silver;

        }
    }
}
