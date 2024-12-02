namespace WinFormsApp1
{
    partial class NumberGame
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
            UserGuess = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 15);
            label1.TabIndex = 0;
            label1.Text = "RULES: A random number 1-100 will be selected, you will have 10 chances to gues that number!";
            // 
            // UserGuess
            // 
            UserGuess.Location = new Point(12, 107);
            UserGuess.Name = "UserGuess";
            UserGuess.PlaceholderText = "Guess Goes Here!";
            UserGuess.Size = new Size(100, 23);
            UserGuess.TabIndex = 1;
            UserGuess.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(96, 13);
            label3.TabIndex = 3;
            label3.Text = "Your number";
            // 
            // NumberGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserGuess);
            Controls.Add(label1);
            Name = "NumberGame";
            Text = "NumberGame";
            Load += NumberGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserGuess;
        private Label label2;
        private Label label3;
    }
}