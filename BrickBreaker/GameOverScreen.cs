using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
namespace BrickBreaker
{
    public partial class GameOverScreen : UserControl
    {
        #region global values
        //Boolean UpArrowDown, DownArrowDown, RightArrowDown, LeftArrowDown;
        int index1, index2, index3 = 0;



        public static string nameKeeper;

        
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        #endregion

        public GameOverScreen()
        {
            InitializeComponent();
        }



        private void playAgainButton_Click(object sender, EventArgs e)
        {
            storeScore();

            #region change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            gs.Focus();
            #endregion
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            storeScore();
            #region change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            ms.Focus();
            #endregion
        }

        public void storeScore()
        {
            //Need to add existing scores to the list in scores to keep them from being deleted on write(complete this action on reading the xml)
            string playerName = letter1Output.Text + letter2Output.Text + letter3Output.Text;
            int score = GameScreen.score;

            Scores newScores = new Scores(playerName, score + "");

            Scores.scores.Add(newScores);

        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
        }

        private void letter1Output_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    // UpArrowDown = true;
                   
                        if (index1 < 25)
                        {
                            index1++;
                        }
                        else
                        {
                            index1 = 0;
                        }
                        letter1Output.Text = alphabet[index1];
                        Refresh();

                  

                    break;
                case Keys.Down:
                    //DownArrowDown = true;

                  
                        if (index1 > 0)
                        {
                            index1--;
                        }
                        else
                        {
                            index1 = 25;
                        }
                        letter1Output.Text = alphabet[index1];
                        Refresh();
               

                    break;
                case Keys.Right:
                    //RightArrowDown = true;
                    letter2Output.Enabled = true;
                    letter2Output.Focus();
                    letter1Output.Enabled = false;

                    letter1Output.ForeColor = Color.Black;
                    letter2Output.ForeColor = Color.Firebrick;
                    break;
                case Keys.Left:
                    //LeftArrowDown = true;
                    exitButton.Focus();

                    exitButton.Enabled = true;
                    exitButton.Focus();
                    letter1Output.Enabled = false;

                    letter1Output.ForeColor = Color.Black;

                    break;

                default:
                    break;
            }
        }

        private void letter2Output_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    // UpArrowDown = true;
                   
                        if (index2 < 25)
                        {
                            index2++;
                        }
                        else
                        {
                            index2 = 0;
                        }
                        letter2Output.Text = alphabet[index2];
                        Refresh();

                    break;
                case Keys.Down:
                    //DownArrowDown = true;

                   
                        if (index2 > 0)
                        {
                            index2--;
                        }
                        else
                        {
                            index2 = 25;
                        }
                        letter2Output.Text = alphabet[index2];
                        Refresh();
                    

                    break;
                case Keys.Right:
                    //RightArrowDown = true;

                    letter3Output.Enabled = true;
                    letter3Output.Focus();
                    letter2Output.Enabled = false;

                    letter2Output.ForeColor = Color.Black;
                    letter3Output.ForeColor = Color.Firebrick;
                    break;
                case Keys.Left:
                    //LeftArrowDown = true;
                   
                    letter1Output.Enabled = true;
                    letter1Output.Focus();
                    letter2Output.Enabled = false;

                    letter1Output.ForeColor = Color.Firebrick;
                    letter2Output.ForeColor = Color.Black;

                    break;

                default:
                    break;
            }
        }

        private void letter3Output_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    // UpArrowDown = true;
                
                        if (index3 < 25)
                        {
                            index3++;
                        }
                        else
                        {
                            index3 = 0;
                        }
                        letter3Output.Text = alphabet[index3];
                        Refresh();

               

                    break;
                case Keys.Down:
                    //DownArrowDown = true;

                 
                        if (index3 > 0)
                        {
                            index3--;
                        }
                        else
                        {
                            index3 = 25;
                        }
                        letter3Output.Text = alphabet[index3];
                        Refresh();
       

                    break;
                case Keys.Right:
                    //RightArrowDown = true;
                    
                    playAgainButton.Enabled = true;
                    playAgainButton.Focus();
                    letter3Output.Enabled = false;

                    letter3Output.ForeColor = Color.Black;
                   
                    break;
                case Keys.Left:
                    //LeftArrowDown = true;
                   
                    letter2Output.Enabled = true;
                    letter2Output.Focus();
                    letter3Output.Enabled = false;

                    letter2Output.ForeColor = Color.Firebrick;
                    letter3Output.ForeColor = Color.Black;

                    break;

                default:
                    break;
            }
        }

        private void exitButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    //RightArrowDown = true;

                    playAgainButton.Enabled = true;
                    playAgainButton.Focus();
                    exitButton.Enabled = false;

                    

                    break;
                case Keys.Left:
                    //LeftArrowDown = true;

                    letter1Output.Enabled = true;
                    letter1Output.Focus();
                    exitButton.Enabled = false;

                    letter1Output.ForeColor = Color.Firebrick;
                    exitButton.BackColor = Color.Silver;
                    break;

                default:
                    break;
            }
        }

        private void playAgainButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    //RightArrowDown = true;

                    letter3Output.Enabled = true;
                    letter3Output.Focus();
                    playAgainButton.Enabled = false;

                    letter3Output.ForeColor = Color.Firebrick;
                    break;
                case Keys.Left:
                    //LeftArrowDown = true;

                    exitButton.Enabled = true;
                    exitButton.Focus();
                    playAgainButton.Enabled = false;
                    playAgainButton.BackColor = Color.Silver;

                    break;

                default:
                    break;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();

            f.Controls.Remove(this);
            f.Controls.Add(ms);

            ms.Focus();
        }

        private void menuButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightGray;
           // menuButton.BackColor = Color.LightSalmon;
        }


        private void exitButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightSalmon;
           // menuButton.BackColor = Color.LightGray;
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            if(GameScreen.win == true)
            {
                gameOverLabel.Text = "You Win!";
                Refresh();
            }
            else
            {
                gameOverLabel.Text = "Game Over";
                Refresh();
            }

            letter1Output.Text = alphabet[0];
            letter2Output.Text = alphabet[0];
            letter3Output.Text = alphabet[0];

            letter1Output.Focus();
            letter1Output.ForeColor = Color.Firebrick;
        }
    }
}
