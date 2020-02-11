using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FormativeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            startButton.Text = "Play Game";

            startButton.BackColor = Color.Black;
            startButton.ForeColor = Color.White;

            label1.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);

            label1.Visible = true;
            startButton.Visible = false;

            label1.Text = "Game will start in : 3";
            alertPlayer.Play();
            Refresh();
            Thread.Sleep(2000);

            label1.Text = "Game will start in : 2";
            Refresh();
            Thread.Sleep(2000);

            label1.Text = "Game will start in : 1";
            Refresh();
            Thread.Sleep(2000);

            this.BackColor = Color.Green;
            label1.Text = "GO!!!";
            alertPlayer.Play();
            Refresh();
            Thread.Sleep(2000);
        }
    }
}
