namespace _24020
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.글자입력 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.파일쓰기 = new System.Windows.Forms.Button();
            this.불러오기 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 664);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.글자입력);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.파일쓰기);
            this.groupBox1.Controls.Add(this.불러오기);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(339, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 664);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 입력, 출력";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 262);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // 글자입력
            // 
            this.글자입력.AutoSize = true;
            this.글자입력.Location = new System.Drawing.Point(6, 299);
            this.글자입력.Name = "글자입력";
            this.글자입력.Size = new System.Drawing.Size(112, 25);
            this.글자입력.TabIndex = 2;
            this.글자입력.Text = "글자입력";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 35);
            this.textBox1.TabIndex = 1;
            // 
            // 파일쓰기
            // 
            this.파일쓰기.Location = new System.Drawing.Point(4, 514);
            this.파일쓰기.Name = "파일쓰기";
            this.파일쓰기.Size = new System.Drawing.Size(296, 67);
            this.파일쓰기.TabIndex = 0;
            this.파일쓰기.Text = "파일쓰기";
            this.파일쓰기.UseVisualStyleBackColor = true;
            this.파일쓰기.Click += new System.EventHandler(this.파일쓰기_Click);
            // 
            // 불러오기
            // 
            this.불러오기.Location = new System.Drawing.Point(4, 587);
            this.불러오기.Name = "불러오기";
            this.불러오기.Size = new System.Drawing.Size(296, 67);
            this.불러오기.TabIndex = 0;
            this.불러오기.Text = "불러오기";
            this.불러오기.UseVisualStyleBackColor = true;
            this.불러오기.Click += new System.EventHandler(this.불러오기_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(6, 370);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(294, 67);
            this.update.TabIndex = 4;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(6, 443);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(293, 65);
            this.delete.TabIndex = 5;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label 글자입력;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button 파일쓰기;
        private System.Windows.Forms.Button 불러오기;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}

