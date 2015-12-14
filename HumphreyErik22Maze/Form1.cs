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
        bool gameStarted;

        public frmMazeGame()
        {
            InitializeComponent();
        }

        private void frmMazeGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your objective is to navigate your cursor the start line (green) to the finish line (red) without touching any walls (blue).\r\n\r\nAs soon as you hit OK, your cursor will be placed on the start line.\r\nTry to get the fastest time!", "Maze Game");
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
        }

    }
}
