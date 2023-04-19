namespace ChessEngineGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            scoreText = new TextBox();
            resetButton = new Button();
            undoButton = new Button();
            boardPicture = new PictureBox();
            changeSidesButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boardPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 44);
            panel1.TabIndex = 0;
            panel1.MouseDown += mouse_down;
            panel1.MouseMove += mouse_move;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 64, 64);
            button5.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(238, 235, 193);
            button5.Location = new Point(648, 7);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(49, 37);
            button5.TabIndex = 9;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 64, 64);
            button6.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(238, 235, 193);
            button6.Location = new Point(603, 3);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(49, 37);
            button6.TabIndex = 10;
            button6.Text = "_";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 235, 193);
            panel2.Location = new Point(0, 801);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 16);
            panel2.TabIndex = 7;
            // 
            // scoreText
            // 
            scoreText.BackColor = Color.FromArgb(158, 63, 80);
            scoreText.BorderStyle = BorderStyle.None;
            scoreText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            scoreText.ForeColor = SystemColors.Info;
            scoreText.Location = new Point(284, 68);
            scoreText.Margin = new Padding(4, 3, 4, 3);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(148, 24);
            scoreText.TabIndex = 9;
            scoreText.Text = "Score: 0000";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(238, 235, 193);
            resetButton.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.FromArgb(158, 63, 80);
            resetButton.Location = new Point(274, 718);
            resetButton.Margin = new Padding(4, 3, 4, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(148, 46);
            resetButton.TabIndex = 11;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // undoButton
            // 
            undoButton.BackColor = Color.FromArgb(238, 235, 193);
            undoButton.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            undoButton.FlatStyle = FlatStyle.Flat;
            undoButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            undoButton.ForeColor = Color.FromArgb(158, 63, 80);
            undoButton.Location = new Point(108, 718);
            undoButton.Margin = new Padding(4, 3, 4, 3);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(148, 46);
            undoButton.TabIndex = 10;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = false;
            undoButton.Click += undoButton_Click;
            // 
            // boardPicture
            // 
            boardPicture.Image = (Image)resources.GetObject("boardPicture.Image");
            boardPicture.Location = new Point(108, 164);
            boardPicture.Name = "boardPicture";
            boardPicture.Size = new Size(480, 480);
            boardPicture.TabIndex = 12;
            boardPicture.TabStop = false;
            // 
            // changeSidesButton
            // 
            changeSidesButton.BackColor = Color.FromArgb(238, 235, 193);
            changeSidesButton.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            changeSidesButton.FlatStyle = FlatStyle.Flat;
            changeSidesButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeSidesButton.ForeColor = Color.FromArgb(158, 63, 80);
            changeSidesButton.Location = new Point(440, 718);
            changeSidesButton.Margin = new Padding(4, 3, 4, 3);
            changeSidesButton.Name = "changeSidesButton";
            changeSidesButton.Size = new Size(148, 46);
            changeSidesButton.TabIndex = 13;
            changeSidesButton.Text = "Swap Sides";
            changeSidesButton.UseVisualStyleBackColor = false;
            changeSidesButton.Click += changeSidesButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 63, 80);
            ClientSize = new Size(695, 808);
            Controls.Add(changeSidesButton);
            Controls.Add(boardPicture);
            Controls.Add(resetButton);
            Controls.Add(undoButton);
            Controls.Add(scoreText);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)boardPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox scoreText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button undoButton;
        private PictureBox boardPicture;
        private Button changeSidesButton;
    }
}