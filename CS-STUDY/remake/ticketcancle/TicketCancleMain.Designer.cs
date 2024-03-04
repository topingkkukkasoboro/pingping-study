namespace miniproject.ticketcancle
{
    partial class TicketCancleMain
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
            btn_goHome = new Button();
            btn_phoneNum = new Button();
            btn_tkNum = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(140, 666);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(300, 113);
            btn_goHome.TabIndex = 10;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // btn_phoneNum
            // 
            btn_phoneNum.Font = new Font("맑은 고딕", 25F);
            btn_phoneNum.Location = new Point(321, 266);
            btn_phoneNum.Name = "btn_phoneNum";
            btn_phoneNum.Size = new Size(200, 350);
            btn_phoneNum.TabIndex = 9;
            btn_phoneNum.Text = "전화\r\n번호\r\n취소";
            btn_phoneNum.UseVisualStyleBackColor = true;
            btn_phoneNum.Click += btn_phoneNum_Click;
            // 
            // btn_tkNum
            // 
            btn_tkNum.Font = new Font("맑은 고딕", 25F);
            btn_tkNum.Location = new Point(61, 266);
            btn_tkNum.Name = "btn_tkNum";
            btn_tkNum.Size = new Size(200, 350);
            btn_tkNum.TabIndex = 8;
            btn_tkNum.Text = "예매\r\n번호\r\n취소";
            btn_tkNum.UseVisualStyleBackColor = true;
            btn_tkNum.Click += btn_tkNum_Click;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 74);
            label1.Name = "label1";
            label1.Size = new Size(400, 146);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TicketCancleMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_goHome);
            Controls.Add(btn_phoneNum);
            Controls.Add(btn_tkNum);
            Controls.Add(label1);
            Name = "TicketCancleMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketCancleMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_goHome;
        private Button btn_phoneNum;
        private Button btn_tkNum;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}