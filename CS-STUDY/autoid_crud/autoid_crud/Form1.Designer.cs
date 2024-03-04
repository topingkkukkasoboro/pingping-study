namespace autoid_crud
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchName = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete.Location = new System.Drawing.Point(650, 73);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(142, 31);
            this.delete.TabIndex = 2;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.update.Location = new System.Drawing.Point(502, 73);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(142, 31);
            this.update.TabIndex = 3;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FirstName.Location = new System.Drawing.Point(16, 14);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(112, 23);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LastName.Location = new System.Drawing.Point(16, 50);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(109, 23);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "LastName";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Gender.Location = new System.Drawing.Point(16, 83);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(83, 23);
            this.Gender.TabIndex = 6;
            this.Gender.Text = "Gender";
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FirstnameTextBox.Location = new System.Drawing.Point(146, 10);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(158, 31);
            this.FirstnameTextBox.TabIndex = 7;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LastNameTextBox.Location = new System.Drawing.Point(146, 48);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(158, 31);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select.Location = new System.Drawing.Point(650, 34);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(142, 31);
            this.select.TabIndex = 10;
            this.select.Text = "select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // searchtext
            // 
            this.searchtext.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchtext.Location = new System.Drawing.Point(354, 34);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(290, 31);
            this.searchtext.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBox1.Location = new System.Drawing.Point(146, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 20);
            this.comboBox1.TabIndex = 12;
            // 
            // SearchName
            // 
            this.SearchName.AutoSize = true;
            this.SearchName.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchName.Location = new System.Drawing.Point(357, 8);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(138, 23);
            this.SearchName.TabIndex = 13;
            this.SearchName.Text = "SearchName";
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insert.Location = new System.Drawing.Point(354, 73);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(142, 30);
            this.insert.TabIndex = 14;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.select);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstnameTextBox);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SearchName;
        private System.Windows.Forms.Button insert;
    }
}

