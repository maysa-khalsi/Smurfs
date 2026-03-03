using System;
using System.Drawing;
using System.Windows.Forms;
using MarioControlLibrary;  // Reference to your user control library

namespace TesterUserControl
{
    public partial class Form1 : Form
    {
        private bool left, right, up, down;
        private System.Windows.Forms.Timer moveTimer;

        public Form1()
        {
            InitializeComponent();

            // Enable key preview on the form to capture arrow keys
            this.KeyPreview = true;

            // Setup keyboard events
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Setup movement timer for smooth animation (~60 FPS)
            moveTimer = new System.Windows.Forms.Timer { Interval = 16 };
            moveTimer.Tick += MoveTimer_Tick;
            moveTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.Up) up = true;
            if (e.KeyCode == Keys.Down) down = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Up) up = false;
            if (e.KeyCode == Keys.Down) down = false;
        }

        private void MoveTimer_Tick(object? sender, EventArgs e)
        {
            // Check if mario would go out of bounds before moving
            var p = marioUc1.Location;
            int speed = 4;

            if (left && p.X - speed >= 0) marioUc1.DeplacerGauche();
            else if (right && p.X + speed + marioUc1.Width <= this.ClientSize.Width) marioUc1.DeplacerDroite();
            else if (up && p.Y - speed >= 0) marioUc1.DeplacerHaut();
            else if (down && p.Y + speed + marioUc1.Height <= this.ClientSize.Height) marioUc1.DeplacerBas();
        }
    }
}