namespace QuanLyBanHang
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.bnSua = new System.Windows.Forms.Button();
            this.bnTK = new System.Windows.Forms.Button();
            this.bnThoat = new System.Windows.Forms.Button();
            this.lbtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaChatLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenChatLieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 609);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bnThem
            // 
            this.bnThem.Location = new System.Drawing.Point(45, 396);
            this.bnThem.Name = "bnThem";
            this.bnThem.Size = new System.Drawing.Size(80, 40);
            this.bnThem.TabIndex = 2;
            this.bnThem.Text = "Thêm";
            this.bnThem.UseVisualStyleBackColor = true;
            this.bnThem.Click += new System.EventHandler(this.bnThem_Click);
            // 
            // bnXoa
            // 
            this.bnXoa.Location = new System.Drawing.Point(182, 396);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(80, 40);
            this.bnXoa.TabIndex = 3;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.UseVisualStyleBackColor = true;
            this.bnXoa.Click += new System.EventHandler(this.bnXoa_Click);
            // 
            // bnSua
            // 
            this.bnSua.Location = new System.Drawing.Point(323, 396);
            this.bnSua.Name = "bnSua";
            this.bnSua.Size = new System.Drawing.Size(80, 40);
            this.bnSua.TabIndex = 4;
            this.bnSua.Text = "Sửa";
            this.bnSua.UseVisualStyleBackColor = true;
            this.bnSua.Click += new System.EventHandler(this.bnSua_Click);
            // 
            // bnTK
            // 
            this.bnTK.Location = new System.Drawing.Point(466, 396);
            this.bnTK.Name = "bnTK";
            this.bnTK.Size = new System.Drawing.Size(120, 40);
            this.bnTK.TabIndex = 5;
            this.bnTK.Text = "Tìm kiếm";
            this.bnTK.UseVisualStyleBackColor = true;
            this.bnTK.Click += new System.EventHandler(this.bnTK_Click);
            // 
            // bnThoat
            // 
            this.bnThoat.Location = new System.Drawing.Point(636, 396);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(80, 40);
            this.bnThoat.TabIndex = 6;
            this.bnThoat.Text = "Thoát";
            this.bnThoat.UseVisualStyleBackColor = true;
            this.bnThoat.Click += new System.EventHandler(this.bnThoat_Click);
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Font = new System.Drawing.Font("SVN-Journey", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext.Location = new System.Drawing.Point(226, 9);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(281, 72);
            this.lbtext.TabIndex = 7;
            this.lbtext.Text = "Danh sách chất liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã chất liệu: ";
            // 
            // tbMaChatLieu
            // 
            this.tbMaChatLieu.Location = new System.Drawing.Point(171, 117);
            this.tbMaChatLieu.Name = "tbMaChatLieu";
            this.tbMaChatLieu.Size = new System.Drawing.Size(150, 29);
            this.tbMaChatLieu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên chất liệu:";
            // 
            // tbTenChatLieu
            // 
            this.tbTenChatLieu.Location = new System.Drawing.Point(510, 117);
            this.tbTenChatLieu.Name = "tbTenChatLieu";
            this.tbTenChatLieu.Size = new System.Drawing.Size(200, 29);
            this.tbTenChatLieu.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 478);
            this.Controls.Add(this.tbTenChatLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaChatLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.bnThoat);
            this.Controls.Add(this.bnTK);
            this.Controls.Add(this.bnSua);
            this.Controls.Add(this.bnXoa);
            this.Controls.Add(this.bnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.Button bnXoa;
        private System.Windows.Forms.Button bnSua;
        private System.Windows.Forms.Button bnTK;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaChatLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenChatLieu;
    }
}

