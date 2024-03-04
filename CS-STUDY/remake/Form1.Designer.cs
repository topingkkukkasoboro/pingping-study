namespace miniproject
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
            btn_gomain = new Button();
            SuspendLayout();
            // 
            // btn_gomain
            // 
            btn_gomain.BackColor = Color.White;
            btn_gomain.FlatAppearance.BorderColor = Color.White;
            btn_gomain.FlatAppearance.MouseDownBackColor = Color.White;
            btn_gomain.FlatAppearance.MouseOverBackColor = Color.White;
            btn_gomain.FlatStyle = FlatStyle.Flat;
            btn_gomain.Font = new Font("맑은 고딕", 30F);
            btn_gomain.Location = new Point(0, 0);
            btn_gomain.Name = "btn_gomain";
            btn_gomain.Size = new Size(585, 855);
            btn_gomain.TabIndex = 0;
            btn_gomain.Text = "화면 터치";
            btn_gomain.UseVisualStyleBackColor = false;
            btn_gomain.Click += btn_gomain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_gomain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_gomain;
    }
}
