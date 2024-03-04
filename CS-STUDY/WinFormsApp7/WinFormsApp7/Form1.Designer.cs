namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            timer1_trick = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(19, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(37, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(19, 100);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(62, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 100);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(87, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(19, 100);
            panel4.TabIndex = 0;
            // 
            // timer1_trick
            // 
            timer1_trick.AutoSize = true;
            timer1_trick.Location = new Point(263, 127);
            timer1_trick.Name = "timer1_trick";
            timer1_trick.Size = new Size(39, 15);
            timer1_trick.TabIndex = 1;
            timer1_trick.Text = "label1";
            timer1_trick.Click += timer1_trick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timer1_trick);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_keydown;
            KeyUp += Form1_keyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label timer1_trick;
    }
}
