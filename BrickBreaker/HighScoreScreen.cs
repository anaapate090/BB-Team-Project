using System;
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
            for (int i = 0; i < GameScreen.scores.Count(); i++)
            {
                if (GameScreen.scores[GameScreen.scores.Count() - 1] >= GameScreen.scores[GameScreen.scores.Count()])
                {
                    outputLabel.Text += "\n" + i + ": " + GameScreen.scores[i];

                    nameOutput.Text += GameOverScreen.nameKeeper + "\n";
                    //WinScreen
                    nameOutput.Text += playAgainButton.nameKeeper1 + "\n";

                    scoreOutput.Text += GameScreen.score;
                }
            }
        }
    }
}
