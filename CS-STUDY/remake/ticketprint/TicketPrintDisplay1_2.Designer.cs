namespace miniproject.ticketprint
{
    partial class TicketPrintDisplay1_2
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
            btn_print = new Button();
            btn_goPre = new Button();
            btn_goHome = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_print
            // 
            btn_print.Font = new Font("맑은 고딕", 25F);
            btn_print.Location = new Point(171, 482);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(247, 86);
            btn_print.TabIndex = 16;
            btn_print.Text = "출력";
            btn_print.UseVisualStyleBackColor = true;
            btn_print.Click += btn_print_Click;
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(32, 665);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 15;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(308, 665);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 14;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 75);
            label1.Name = "label1";
            label1.Size = new Size(400, 146);
            label1.TabIndex = 13;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TicketPrintDisplay1_2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_print);
            Controls.Add(btn_goPre);
            Controls.Add(btn_goHome);
            Controls.Add(label1);
            Name = "TicketPrintDisplay1_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketPrintDisplay1_2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_print;
        private Button btn_goPre;
        private Button btn_goHome;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}