namespace miniproject.admin
{
    partial class AdminMain
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F);
            label1.Location = new Point(89, 351);
            label1.Name = "label1";
            label1.Size = new Size(415, 67);
            label1.TabIndex = 0;
            label1.Text = "관리자 메인 화면";
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 853);
            Controls.Add(label1);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}