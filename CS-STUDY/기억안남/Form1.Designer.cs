namespace WinFormsApp1
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
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.MenuBar;
            button2.Location = new Point(284, 363);
            button2.Name = "button2";
            button2.Size = new Size(86, 34);
            button2.TabIndex = 1;
            button2.Text = "조회";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Font = new Font("나눔스퀘어OTF ExtraBold", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.MenuBar;
            button3.Location = new Point(624, 363);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 2;
            button3.Text = "조회";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 304);
            listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(316, 304);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(42, 363);
            button1.Name = "button1";
            button1.Size = new Size(119, 55);
            button1.TabIndex = 5;
            button1.Text = "잘못했어요";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
