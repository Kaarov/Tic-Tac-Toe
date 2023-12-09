namespace TicTacToe
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            A3 = new Button();
            A2 = new Button();
            A1 = new Button();
            o_win_count = new Label();
            draw_count = new Label();
            x_win_count = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CPUTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(306, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, resetToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(162, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(162, 22);
            resetToolStripMenuItem.Text = "Reset Win Count";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(162, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // C1
            // 
            C1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(10, 227);
            C1.Name = "C1";
            C1.Size = new Size(90, 90);
            C1.TabIndex = 18;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // C2
            // 
            C2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(106, 227);
            C2.Name = "C2";
            C2.Size = new Size(90, 90);
            C2.TabIndex = 17;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C3
            // 
            C3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(202, 227);
            C3.Name = "C3";
            C3.Size = new Size(90, 90);
            C3.TabIndex = 16;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // B1
            // 
            B1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(10, 131);
            B1.Name = "B1";
            B1.Size = new Size(90, 90);
            B1.TabIndex = 15;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // B2
            // 
            B2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(106, 131);
            B2.Name = "B2";
            B2.Size = new Size(90, 90);
            B2.TabIndex = 14;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B3
            // 
            B3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(202, 131);
            B3.Name = "B3";
            B3.Size = new Size(90, 90);
            B3.TabIndex = 13;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // A3
            // 
            A3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(202, 35);
            A3.Name = "A3";
            A3.Size = new Size(90, 90);
            A3.TabIndex = 12;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // A2
            // 
            A2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(106, 35);
            A2.Name = "A2";
            A2.Size = new Size(90, 90);
            A2.TabIndex = 11;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A1
            // 
            A1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(10, 35);
            A1.Name = "A1";
            A1.Size = new Size(90, 90);
            A1.TabIndex = 10;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // o_win_count
            // 
            o_win_count.AutoSize = true;
            o_win_count.Location = new Point(241, 348);
            o_win_count.Name = "o_win_count";
            o_win_count.Size = new Size(13, 15);
            o_win_count.TabIndex = 24;
            o_win_count.Text = "0";
            // 
            // draw_count
            // 
            draw_count.AutoSize = true;
            draw_count.Location = new Point(143, 348);
            draw_count.Name = "draw_count";
            draw_count.Size = new Size(13, 15);
            draw_count.TabIndex = 23;
            draw_count.Text = "0";
            // 
            // x_win_count
            // 
            x_win_count.AutoSize = true;
            x_win_count.Location = new Point(52, 348);
            x_win_count.Name = "x_win_count";
            x_win_count.Size = new Size(13, 15);
            x_win_count.TabIndex = 22;
            x_win_count.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(202, 320);
            label3.MaximumSize = new Size(86, 15);
            label3.MinimumSize = new Size(86, 15);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 21;
            label3.Text = "CPU Win";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(111, 320);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 20;
            label2.Text = "Draw Count";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(16, 320);
            label1.MaximumSize = new Size(85, 15);
            label1.MinimumSize = new Size(85, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 19;
            label1.Text = "You Win";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 375);
            Controls.Add(o_win_count);
            Controls.Add(draw_count);
            Controls.Add(x_win_count);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C1);
            Controls.Add(C2);
            Controls.Add(C3);
            Controls.Add(B1);
            Controls.Add(B2);
            Controls.Add(B3);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe CPU";
            Load += Form4_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button A3;
        private Button A2;
        private Button A1;
        private Label o_win_count;
        private Label draw_count;
        private Label x_win_count;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer CPUTimer;
    }
}