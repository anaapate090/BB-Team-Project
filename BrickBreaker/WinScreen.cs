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
    public partial class playAgainButton : UserControl
    {
        public playAgainButton()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();

            f.Controls.Remove(this);
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            ms.Focus();
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.LightSalmon;
            menuButton.BackColor = Color.LightGray;
        }

        private void menuButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.LightGray;
            menuButton.BackColor = Color.LightSalmon;
        }
    }
}
