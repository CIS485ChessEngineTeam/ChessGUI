using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessEngineGUI
{
    public partial class GameModeForm : Form
    {
        private Form1 form1;
        public Point mouseLocation;
        public GameModeForm(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
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

        private void GameModeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                form1.chessEnginePath = file.FileName;
                form1.againstEngine = true;
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.againstEngine = false;
            Form6 f6 = new Form6();
            f6.Show();

        }
    }
}
