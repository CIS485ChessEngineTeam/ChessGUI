namespace ChessEngineGUI
{
    partial class DifficultyForm
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
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 44);
            panel1.TabIndex = 1;
            panel1.MouseDown += mouse_down;
            panel1.MouseMove += mouse_move;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 64, 64);
            button6.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(238, 235, 193);
            button6.Location = new Point(365, 3);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(49, 37);
            button6.TabIndex = 10;
            button6.Text = "_";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 64, 64);
            button5.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(238, 235, 193);
            button5.Location = new Point(407, 7);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(49, 37);
            button5.TabIndex = 9;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(158, 63, 80);
            button3.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(238, 235, 193);
            button3.Location = new Point(154, 128);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(148, 46);
            button3.TabIndex = 4;
            button3.Text = "Easy";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(158, 63, 80);
            button1.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(238, 235, 193);
            button1.Location = new Point(154, 234);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(148, 46);
            button1.TabIndex = 5;
            button1.Text = "Hard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(158, 63, 80);
            button2.FlatAppearance.BorderColor = Color.FromArgb(238, 235, 193);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(238, 235, 193);
            button2.Location = new Point(154, 181);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(148, 46);
            button2.TabIndex = 6;
            button2.Text = "Medium";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(238, 235, 193);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(128, 64, 64);
            textBox1.Location = new Point(76, 77);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 28);
            textBox1.TabIndex = 8;
            textBox1.Text = "Choose Your Difficulty";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DifficultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 235, 193);
            ClientSize = new Size(455, 328);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DifficultyForm";
            Text = "Form3";
            Load += DifficultyForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}