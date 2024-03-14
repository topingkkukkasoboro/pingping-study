namespace mdiproject.todo
{
    partial class TodoForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.finish_datepicker = new System.Windows.Forms.DateTimePicker();
            this.content_tb = new System.Windows.Forms.TextBox();
            this.userIdx_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.title_tb);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.finish_datepicker);
            this.panel2.Controls.Add(this.content_tb);
            this.panel2.Controls.Add(this.userIdx_combobox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(587, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 611);
            this.panel2.TabIndex = 1;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(94, 131);
            this.title_tb.Multiline = true;
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(156, 21);
            this.title_tb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finish_datepicker
            // 
            this.finish_datepicker.Location = new System.Drawing.Point(21, 520);
            this.finish_datepicker.Name = "finish_datepicker";
            this.finish_datepicker.Size = new System.Drawing.Size(235, 21);
            this.finish_datepicker.TabIndex = 8;
            // 
            // content_tb
            // 
            this.content_tb.Location = new System.Drawing.Point(21, 254);
            this.content_tb.Multiline = true;
            this.content_tb.Name = "content_tb";
            this.content_tb.Size = new System.Drawing.Size(235, 214);
            this.content_tb.TabIndex = 7;
            // 
            // userIdx_combobox
            // 
            this.userIdx_combobox.FormattingEnabled = true;
            this.userIdx_combobox.Location = new System.Drawing.Point(94, 80);
            this.userIdx_combobox.Name = "userIdx_combobox";
            this.userIdx_combobox.Size = new System.Drawing.Size(156, 20);
            this.userIdx_combobox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(17, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "FinishDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(17, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "할일입력";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(287, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 611);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(113, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 611);
            this.panel1.TabIndex = 0;
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox userIdx_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker finish_datepicker;
        private System.Windows.Forms.TextBox content_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox title_tb;
    }
}