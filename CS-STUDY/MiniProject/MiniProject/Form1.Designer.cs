namespace MiniProject
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
            components = new System.ComponentModel.Container();
            Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Day = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.DimGray;
            Time.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Time.Location = new Point(193, 153);
            Time.Name = "Time";
            Time.Size = new Size(107, 45);
            Time.TabIndex = 1;
            Time.Text = "label3";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.BackColor = Color.DimGray;
            Day.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Day.Location = new Point(193, 108);
            Day.Name = "Day";
            Day.Size = new Size(107, 45);
            Day.TabIndex = 1;
            Day.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("나눔스퀘어OTF ExtraBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(500, 674);
            button1.TabIndex = 2;
            button1.Text = "화면을 터치하세요";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(524, 701);
            Controls.Add(Day);
            Controls.Add(Time);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Time;
        private System.Windows.Forms.Timer timer1;
        private Label Day;
        private Button button1;
    }
}
