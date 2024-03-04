namespace miniproject
{
    partial class MainDisplay
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_gotk = new Button();
            btn_gotp = new Button();
            btn_gotkCancle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 58);
            label1.Name = "label1";
            label1.Size = new Size(400, 146);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_gotk
            // 
            btn_gotk.Font = new Font("맑은 고딕", 25F);
            btn_gotk.Location = new Point(60, 250);
            btn_gotk.Name = "btn_gotk";
            btn_gotk.Size = new Size(200, 350);
            btn_gotk.TabIndex = 1;
            btn_gotk.Text = "예매";
            btn_gotk.UseVisualStyleBackColor = true;
            btn_gotk.Click += btn_gotk_Click;
            // 
            // btn_gotp
            // 
            btn_gotp.Font = new Font("맑은 고딕", 25F);
            btn_gotp.Location = new Point(320, 250);
            btn_gotp.Name = "btn_gotp";
            btn_gotp.Size = new Size(200, 350);
            btn_gotp.TabIndex = 2;
            btn_gotp.Text = "티켓\r\n출력";
            btn_gotp.UseVisualStyleBackColor = true;
            btn_gotp.Click += btn_gotp_Click;
            // 
            // btn_gotkCancle
            // 
            btn_gotkCancle.Font = new Font("맑은 고딕", 25F);
            btn_gotkCancle.Location = new Point(60, 660);
            btn_gotkCancle.Name = "btn_gotkCancle";
            btn_gotkCancle.Size = new Size(460, 113);
            btn_gotkCancle.TabIndex = 3;
            btn_gotkCancle.Text = "예매 취소";
            btn_gotkCancle.UseVisualStyleBackColor = true;
            btn_gotkCancle.Click += btn_gotkCancle_Click;
            // 
            // MainDisplay
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_gotkCancle);
            Controls.Add(btn_gotp);
            Controls.Add(btn_gotk);
            Controls.Add(label1);
            Name = "MainDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDisplay";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_gotk;
        private Button btn_gotp;
        private Button btn_gotkCancle;
    }
}