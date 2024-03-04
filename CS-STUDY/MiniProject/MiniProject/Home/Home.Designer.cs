namespace MiniProject.Choice
{
    partial class Home
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
            Print = new Button();
            Ticket = new Button();
            Cancle = new Button();
            Time = new Label();
            Time2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Print
            // 
            Print.BackColor = Color.Gray;
            Print.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Print.Location = new Point(285, 243);
            Print.Name = "Print";
            Print.Size = new Size(185, 185);
            Print.TabIndex = 0;
            Print.Text = "예매 티켓 출력";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // Ticket
            // 
            Ticket.BackColor = Color.Gray;
            Ticket.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ticket.Location = new Point(49, 243);
            Ticket.Name = "Ticket";
            Ticket.Size = new Size(185, 185);
            Ticket.TabIndex = 0;
            Ticket.Text = "티켓 구매";
            Ticket.UseVisualStyleBackColor = false;
            // 
            // Cancle
            // 
            Cancle.BackColor = Color.Gray;
            Cancle.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Cancle.Location = new Point(165, 466);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(185, 64);
            Cancle.TabIndex = 0;
            Cancle.Text = "예매 취소";
            Cancle.UseVisualStyleBackColor = false;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Time.Location = new Point(210, 85);
            Time.Name = "Time";
            Time.Size = new Size(78, 32);
            Time.TabIndex = 1;
            Time.Text = "label1";
            // 
            // Time2
            // 
            Time2.AutoSize = true;
            Time2.Location = new Point(229, 135);
            Time2.Name = "Time2";
            Time2.Size = new Size(39, 15);
            Time2.TabIndex = 2;
            Time2.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(524, 701);
            Controls.Add(Time2);
            Controls.Add(Time);
            Controls.Add(Ticket);
            Controls.Add(Cancle);
            Controls.Add(Print);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Print;
        private Button Ticket;
        private Button Cancle;
        private Label Time;
        private Label Time2;
        private System.Windows.Forms.Timer timer1;
    }
}