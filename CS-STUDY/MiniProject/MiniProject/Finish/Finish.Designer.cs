namespace MiniProject.Finish
{
    partial class Finish
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(-1, 1);
            button1.Name = "button1";
            button1.Size = new Size(527, 701);
            button1.TabIndex = 0;
            button1.Text = "발권되었습니다";
            button1.Click += button1_Click;
            // 
            // Finish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(524, 701);
            Controls.Add(button1);
            Name = "Finish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fifnish";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}