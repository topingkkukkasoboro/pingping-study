namespace mdiproject.user
{
    partial class UserForm
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
            this.사용자관리 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectemail = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbaddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.eamil = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.사용자 = new System.Windows.Forms.GroupBox();
            this.사용자관리.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 사용자관리
            // 
            this.사용자관리.BackColor = System.Drawing.Color.LightCyan;
            this.사용자관리.Controls.Add(this.label4);
            this.사용자관리.Controls.Add(this.selectemail);
            this.사용자관리.Controls.Add(this.select);
            this.사용자관리.Controls.Add(this.delete);
            this.사용자관리.Controls.Add(this.update);
            this.사용자관리.Controls.Add(this.insert);
            this.사용자관리.Controls.Add(this.label3);
            this.사용자관리.Controls.Add(this.tbaddr);
            this.사용자관리.Controls.Add(this.label2);
            this.사용자관리.Controls.Add(this.tbpassword);
            this.사용자관리.Controls.Add(this.label1);
            this.사용자관리.Controls.Add(this.tbname);
            this.사용자관리.Controls.Add(this.eamil);
            this.사용자관리.Controls.Add(this.tbemail);
            this.사용자관리.Dock = System.Windows.Forms.DockStyle.Left;
            this.사용자관리.Font = new System.Drawing.Font("나눔스퀘어OTF ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사용자관리.ForeColor = System.Drawing.Color.Black;
            this.사용자관리.Location = new System.Drawing.Point(0, 0);
            this.사용자관리.Name = "사용자관리";
            this.사용자관리.Size = new System.Drawing.Size(141, 461);
            this.사용자관리.TabIndex = 0;
            this.사용자관리.TabStop = false;
            this.사용자관리.Text = "사용자관리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-Mail?";
            // 
            // selectemail
            // 
            this.selectemail.Location = new System.Drawing.Point(12, 272);
            this.selectemail.Name = "selectemail";
            this.selectemail.Size = new System.Drawing.Size(110, 26);
            this.selectemail.TabIndex = 13;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.ForeColor = System.Drawing.Color.Black;
            this.select.Location = new System.Drawing.Point(12, 308);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(110, 29);
            this.select.TabIndex = 11;
            this.select.Text = "SELECT";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(12, 423);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 29);
            this.delete.TabIndex = 10;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(12, 384);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 29);
            this.update.TabIndex = 9;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Transparent;
            this.insert.ForeColor = System.Drawing.Color.Black;
            this.insert.Location = new System.Drawing.Point(12, 345);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(110, 29);
            this.insert.TabIndex = 8;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADDR";
            // 
            // tbaddr
            // 
            this.tbaddr.Location = new System.Drawing.Point(12, 206);
            this.tbaddr.Name = "tbaddr";
            this.tbaddr.Size = new System.Drawing.Size(110, 26);
            this.tbaddr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(12, 154);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(110, 26);
            this.tbpassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(12, 103);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(110, 26);
            this.tbname.TabIndex = 2;
            // 
            // eamil
            // 
            this.eamil.AutoSize = true;
            this.eamil.ForeColor = System.Drawing.Color.Black;
            this.eamil.Location = new System.Drawing.Point(12, 31);
            this.eamil.Name = "eamil";
            this.eamil.Size = new System.Drawing.Size(57, 18);
            this.eamil.TabIndex = 1;
            this.eamil.Text = "E-Mail";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(12, 52);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(110, 26);
            this.tbemail.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.사용자);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("나눔스퀘어OTF ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 461);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(646, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // 사용자
            // 
            this.사용자.Location = new System.Drawing.Point(5, 4);
            this.사용자.Name = "사용자";
            this.사용자.Size = new System.Drawing.Size(662, 452);
            this.사용자.TabIndex = 1;
            this.사용자.TabStop = false;
            this.사용자.Text = "사용자";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.사용자관리);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.사용자관리.ResumeLayout(false);
            this.사용자관리.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 사용자관리;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selectemail;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbaddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label eamil;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox 사용자;
    }
}