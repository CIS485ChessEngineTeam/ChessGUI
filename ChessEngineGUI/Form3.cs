using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessEngineGUI
{
    public partial class DifficultyForm : Form
    {
        public Point mouseLocation;
        private Form1 form1;
        public DifficultyForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // easy
            form1.movetime = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // med
            form1.movetime = 5;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hard
            form1.movetime = 10;
            this.Close();
        }
    }
}
