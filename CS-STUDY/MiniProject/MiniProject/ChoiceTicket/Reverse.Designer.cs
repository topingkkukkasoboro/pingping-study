﻿namespace MiniProject.ChoiceTicket
{
    partial class Reverse
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어OTF ExtraBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 230);
            label1.Name = "label1";
            label1.Size = new Size(222, 41);
            label1.TabIndex = 0;
            label1.Text = "예매번호조회";
            // 
            // button1
            // 
            button1.Location = new Point(170, 369);
            button1.Name = "button1";
            button1.Size = new Size(175, 51);
            button1.TabIndex = 1;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 588);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "홈";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 2;
            // 
            // Reverse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(524, 701);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Reverse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reverse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}