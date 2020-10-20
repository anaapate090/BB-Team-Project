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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightSalmon;
        }
    }
}
