
namespace PBL3_GiaBao.View
{
    partial class fAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.btTaoTK = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btXoaTK = new System.Windows.Forms.Button();
            this.btDoiTK = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDTK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PassWord:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(148, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(126, 31);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(148, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 31);
            this.txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(583, 84);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(174, 31);
            this.txtPass.TabIndex = 6;
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Location = new System.Drawing.Point(737, 18);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(114, 31);
            this.txtLoaiTK.TabIndex = 7;
            // 
            // btTaoTK
            // 
            this.btTaoTK.Location = new System.Drawing.Point(28, 331);
            this.btTaoTK.Name = "btTaoTK";
            this.btTaoTK.Size = new System.Drawing.Size(191, 40);
            this.btTaoTK.TabIndex = 8;
            this.btTaoTK.Text = "Tạo Tài Khoản";
            this.btTaoTK.UseVisualStyleBackColor = true;
            this.btTaoTK.Click += new System.EventHandler(this.btTaoTK_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(867, 331);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(136, 40);
            this.btDong.TabIndex = 9;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(975, 184);
            this.dataGridView1.TabIndex = 10;
            // 
            // btXoaTK
            // 
            this.btXoaTK.Location = new System.Drawing.Point(603, 331);
            this.btXoaTK.Name = "btXoaTK";
            this.btXoaTK.Size = new System.Drawing.Size(186, 40);
            this.btXoaTK.TabIndex = 12;
            this.btXoaTK.Text = "Xóa Tài Khoản";
            this.btXoaTK.UseVisualStyleBackColor = true;
            this.btXoaTK.Click += new System.EventHandler(this.btXoaTK_Click);
            // 
            // btDoiTK
            // 
            this.btDoiTK.Location = new System.Drawing.Point(300, 331);
            this.btDoiTK.Name = "btDoiTK";
            this.btDoiTK.Size = new System.Drawing.Size(196, 40);
            this.btDoiTK.TabIndex = 13;
            this.btDoiTK.Text = "Sửa Tài Khoản";
            this.btDoiTK.UseVisualStyleBackColor = true;
            this.btDoiTK.Click += new System.EventHandler(this.btSuaTK_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(909, 75);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 42);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã TK";
            // 
            // txtIDTK
            // 
            this.txtIDTK.Location = new System.Drawing.Point(402, 21);
            this.txtIDTK.Name = "txtIDTK";
            this.txtIDTK.Size = new System.Drawing.Size(135, 31);
            this.txtIDTK.TabIndex = 16;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 401);
            this.Controls.Add(this.txtIDTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDoiTK);
            this.Controls.Add(this.btXoaTK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btTaoTK);
            this.Controls.Add(this.txtLoaiTK);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.Load += new System.EventHandler(this.fAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.Button btTaoTK;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btXoaTK;
        private System.Windows.Forms.Button btDoiTK;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDTK;
    }
}