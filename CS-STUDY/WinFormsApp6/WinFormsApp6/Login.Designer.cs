namespace WinFormsApp6
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(143, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 26);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            textBox2.Location = new Point(143, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 26);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            label1.Location = new Point(73, 50);
            label1.Name = "label1";
            label1.Size = new Size(24, 18);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // button1
            // 
            button1.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            button1.Location = new Point(282, 46);
            button1.Name = "button1";
            button1.Size = new Size(81, 65);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 233);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}