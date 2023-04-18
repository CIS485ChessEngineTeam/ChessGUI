namespace ChessEngineGUI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.begin = new System.Windows.Forms.Button();
            this.selectEngine = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 32);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.button6.Location = new System.Drawing.Point(253, -3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "_";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.button5.Location = new System.Drawing.Point(290, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 14);
            this.panel2.TabIndex = 6;
            // 
            // begin
            // 
            this.begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.begin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.begin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.begin.Location = new System.Drawing.Point(102, 86);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(127, 40);
            this.begin.TabIndex = 10;
            this.begin.Text = "Begin ";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // selectEngine
            // 
            this.selectEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.selectEngine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.selectEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectEngine.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEngine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.selectEngine.Location = new System.Drawing.Point(102, 250);
            this.selectEngine.Name = "selectEngine";
            this.selectEngine.Size = new System.Drawing.Size(127, 40);
            this.selectEngine.TabIndex = 9;
            this.selectEngine.Text = "Difficulty";
            this.selectEngine.UseVisualStyleBackColor = false;
            this.selectEngine.Click += new System.EventHandler(this.selectEngine_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(193)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.settings.Location = new System.Drawing.Point(102, 167);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(127, 40);
            this.settings.TabIndex = 8;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(332, 350);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.selectEngine);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button selectEngine;
        private System.Windows.Forms.Button settings;
    }
}

