using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessEngineGUI
{
    public partial class Form1 : Form
    {
        public string chessEnginePath;
        public Boolean againstEngine;
        public int movetime = 5;
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
            againstEngine = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void begin_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(chessEnginePath, againstEngine, movetime);
            f2.Show();
        }

        private void selectEngine_Click(object sender, EventArgs e)
        {
            if (againstEngine)
            {
                DifficultyForm f3 = new DifficultyForm(this);
                f3.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must change the gamemode to Player vs. AI and select an engine first!");
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            GameModeForm f4 = new GameModeForm(this);
            f4.Show();
        }
    }
}
