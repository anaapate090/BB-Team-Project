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
    public partial class HighScoreScreen : UserControl
    {

        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Goes to the menu screen
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }

        private void HighScoreScreen_Load(object sender, EventArgs e)
        {
            //needs XML reader code still
            nameOutput.ResetText();
            scoreOutput.ResetText();

            List<Scores> sortedList = Scores.scores.OrderBy(s => s.score).ToList();
            for (int i = 0; i < 10; i++)
            {
                if (sortedList[i] != null)
                {
                    nameOutput.Text += sortedList[i].name + "\n";

                    scoreOutput.Text += sortedList[i].score;
                }
            }
        }
    }
}
