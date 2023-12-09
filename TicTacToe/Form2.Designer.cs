namespace TicTacToe
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
            label1 = new Label();
            label2 = new Label();
            p1 = new TextBox();
            p2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Player One Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Player Two Name:";
            // 
            // p1
            // 
            p1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p1.Location = new Point(202, 28);
            p1.Name = "p1";
            p1.Size = new Size(175, 26);
            p1.TabIndex = 2;
            // 
            // p2
            // 
            p2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p2.Location = new Point(202, 80);
            p2.Name = "p2";
            p2.Size = new Size(175, 26);
            p2.TabIndex = 3;
            p2.KeyPress += p2_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(295, 124);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 4;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 164);
            Controls.Add(button1);
            Controls.Add(p2);
            Controls.Add(p1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(426, 203);
            MinimizeBox = false;
            MinimumSize = new Size(426, 203);
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += p1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox p1;
        private TextBox p2;
        private Button button1;
    }
}