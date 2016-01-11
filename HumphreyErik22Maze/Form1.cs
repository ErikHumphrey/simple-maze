/*  ___  ___                  
    |  \/  |                  
    | .  . |  __ _  ____  ___ 
    | |\/| | / _` ||_  / / _ \
    | |  | || (_| | / / |  __/
    \_|  |_/ \__,_|/___| \___|  */
                          
/* Author: Erik Humphrey
 * Project title: Project 22 - Maze
 * Date started: December 13th 2015
 * Executable name: HumphreyErik22Maze.exe
 * Description: Maze game; user must move cursor from start to finish without touching any walls
 */

// Note: It doesn't matter how thick the walls are, I tested that even the thickest of the walls can be bypassed at high mouse speeds. So that's not a bug.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik22Maze
{
    public partial class frmMazeGame : Form
    {
        // Global declarations
        int timeElapsed;
        bool gameStarted = false;

        public frmMazeGame()
        {
            InitializeComponent();
        }

        private void frmMazeGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your objective is to navigate your cursor the start line (green) to the finish line (yellow) without touching any walls (blue/red).\r\n\r\nAs soon as you hit OK, your cursor will be placed on the start line.\r\nTry to get the fastest time!",
                "Maze Game",
                MessageBoxButtons.OK);
            newGame();

        }

        public void newGame()
        {

            tmrElapsedTime.Start();
            timeElapsed = 0; // Reset elapsed time
            lblTime.Text = "Time: " + timeElapsed.ToString();
            // Reset button puzzle
            lblCheatDetector.Text = "A";
            lblWallA1.Visible = lblWallA2.Visible = true;
            lblWallB1.Visible = false;
            // Move the mouse cursor to the starting point
            Cursor.Position = new Point(652, 309);
            // Cursor.Position = new Point(815, 395);            Setting for 1920x1080 resolution (what I use at home)
            gameStarted = true;
        }

        // There is a button that the player can click to toggle the walls blocking their path. Clicking the button removes walls of the letter on the button

        private void btnWallToggler_Click(object sender, EventArgs e)
        {
            if (lblCheatDetector.Text == "A")
            {
                lblCheatDetector.Text = "B";
                lblWallA1.Visible = lblWallA2.Visible = false;
                lblWallB1.Visible = true;
            }
            // `else if` statement instead of just `else` is used in case I want to add more mechanics in the future 
            else if (lblCheatDetector.Text == "B")
            {
                lblCheatDetector.Text = "A";
                lblWallA1.Visible = lblWallA2.Visible = true;
                lblWallB1.Visible = false;
            }
        }

        private void tmrElapsedTime_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            lblTime.Text = "Time: " + timeElapsed.ToString(); // Update the label with the current time
        }



        private void wallEnter(object sender, EventArgs e)
        {
            // Make sure the game is in progress when the user runs in to a wall.
            if (gameStarted == true)
            {
                tmrElapsedTime.Stop();
                gameStarted = false;
                // Start a new game if the user wants to try again. Otherwise, close the program.
                DialogResult haveAnotherGo = MessageBox.Show("You ran into a wall and lost after " + timeElapsed + " seconds. Take it slow!\r\n\r\nClick OK to have another go, or hit Alt+F4 twice to close the program.",
                    "Wall touched",
                    MessageBoxButtons.OK);
                if (haveAnotherGo == DialogResult.OK)
                    newGame();
                else
                    this.Close();
            }
        }

        private void lblFinishLine_MouseEnter(object sender, EventArgs e)
        {
            // Make sure the game is in progress when the user runs in to a wall.
            if (gameStarted == true)
            {
                tmrElapsedTime.Stop();
                gameStarted = false;
                // Start a new game if the user wants to try again. Otherwise, close the program.
                DialogResult tryForABetterTime = MessageBox.Show("You reached the finish line in " + timeElapsed + " seconds.\r\n\r\nTry for a better time?",
                    "You win",
                    MessageBoxButtons.YesNo);
                if (tryForABetterTime == DialogResult.Yes)
                    newGame();
                else
                    this.Close();
            }
        }

        private void frmMazeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the program entirely
        }

        /* Scrapped idea of extra dialog 
         
         frmCheater cheatDialog = new frmCheater();
         cheatDialog.Show();
         this.Hide();
         */
    }
}
