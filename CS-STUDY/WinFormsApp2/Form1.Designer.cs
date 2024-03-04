namespace WinFormsApp2
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
            button1 = new Button();
            label1 = new Label();
            tb = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tb_num2 = new TextBox();
            tb_num1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(188, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 205);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tb
            // 
            tb.Location = new Point(73, 202);
            tb.Name = "tb";
            tb.Size = new Size(100, 23);
            tb.TabIndex = 2;
            tb.Tag = "";
            tb.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("휴먼둥근헤드라인", 11.25F);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(559, 103);
            button2.Name = "button2";
            button2.Size = new Size(96, 55);
            button2.TabIndex = 3;
            button2.Text = "더하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("휴먼둥근헤드라인", 11.25F);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(559, 164);
            button3.Name = "button3";
            button3.Size = new Size(96, 55);
            button3.TabIndex = 4;
            button3.Text = "빼기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("휴먼둥근헤드라인", 11.25F);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(559, 225);
            button4.Name = "button4";
            button4.Size = new Size(96, 55);
            button4.TabIndex = 5;
            button4.Text = "나누기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("휴먼둥근헤드라인", 11.25F);
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Location = new Point(559, 286);
            button5.Name = "button5";
            button5.Size = new Size(96, 55);
            button5.TabIndex = 6;
            button5.Text = "곱하기";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(374, 225);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(100, 23);
            tb_num2.TabIndex = 7;
            tb_num2.Tag = "";
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(374, 181);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(100, 23);
            tb_num1.TabIndex = 8;
            tb_num1.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("휴먼옛체", 11.25F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(277, 186);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 9;
            label2.Text = "첫번째 숫자";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("휴먼옛체", 11.25F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(277, 230);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 10;
            label3.Text = "두번째 숫자";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("휴먼옛체", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(305, 297);
            label5.Name = "label5";
            label5.Size = new Size(60, 26);
            label5.TabIndex = 12;
            label5.Text = "결과";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("휴먼옛체", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(374, 297);
            label6.Name = "label6";
            label6.Size = new Size(60, 26);
            label6.TabIndex = 13;
            label6.Text = "결과";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_num1);
            Controls.Add(tb_num2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tb);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tb;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox tb_num2;
        private TextBox tb_num1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
