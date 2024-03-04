namespace RandomGame
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
            textBox1 = new TextBox();
            Plus = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Print = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 0;
            // 
            // Plus
            // 
            Plus.Location = new Point(240, 27);
            Plus.Name = "Plus";
            Plus.Size = new Size(108, 36);
            Plus.TabIndex = 1;
            Plus.Text = "사용자 추가";
            Plus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어OTF ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(199, 53);
            label1.TabIndex = 2;
            label1.Text = "제비뽑기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔스퀘어OTF Bold", 27.75F, FontStyle.Bold);
            label2.Location = new Point(46, 388);
            label2.Name = "label2";
            label2.Size = new Size(176, 41);
            label2.TabIndex = 3;
            label2.Text = "당첨자는 :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔스퀘어OTF Bold", 27.75F, FontStyle.Bold);
            label3.Location = new Point(228, 388);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 4;
            label3.Text = "???";
            label3.Click += this.label3_Click;
            // 
            // Print
            // 
            Print.Location = new Point(46, 340);
            Print.Name = "Print";
            Print.Size = new Size(130, 45);
            Print.TabIndex = 5;
            Print.Text = "뽑기";
            Print.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(Print);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Plus);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Plus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Print;
    }
}
