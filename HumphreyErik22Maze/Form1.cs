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
            MessageBox.Show("Your objective is to navigate your cursor the start line (green) to the finish line (yellow) without touching any walls (blue).\r\n\r\nAs soon as you hit OK, your cursor will be placed on the start line.\r\nTry to get the fastest time!", "Maze Game");
            newGame();

        }

        void newGame()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(60, 80);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
            gameStarted = true;
        }

        // There is a button that the player can click to toggle the walls blocking their path. Clicking the button removes walls of the letter on the button

        private void btnWallToggler_Click(object sender, EventArgs e)
        {
            if (btnWallToggler.Text == "A")
            {
                btnWallToggler.Text = "B";
                lblWallA1.Visible = lblWallA2.Visible = false;
                lblWallB1.Visible = true;
            }
            // `else if` statement instead of just `else` is used in case I want to add more mechanics in the future 
            else if (btnWallToggler.Text == "B")
            {
                btnWallToggler.Text = "A";
                lblWallA1.Visible = lblWallA2.Visible = true;
                lblWallB1.Visible = false;
            }
        }

        private void tmrElapsedTime_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void wallEnter(object sender, EventArgs e)
        {
            if (gameStarted == true)
            {
                tmrElapsedTime.Stop();
                gameStarted = false;
                MessageBox.Show("Wall touched", "You ran into a wall and lost after " + timeElapsed + " seconds.\r\n\r\nClick OK to have another go.");
                timeElapsed = 0;
                lblTime.Text = "Time: " + timeElapsed.ToString();
            }
        }

    }
}
