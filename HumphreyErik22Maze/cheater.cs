using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik22Maze;

namespace HumphreyErik22Maze
{
    public partial class frmCheater : Form
    {
        public frmCheater()
        {
            InitializeComponent();
        }

        private void userClicksWhateverButtonWhoCares(object sender, EventArgs e)
        {
            frmMazeGame mazeGame = new frmMazeGame();
            mazeGame.Show();
            this.Hide();
        }

        private void frmCheater_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
