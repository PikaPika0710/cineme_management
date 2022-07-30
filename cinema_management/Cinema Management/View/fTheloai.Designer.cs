
namespace PBL3_GiaBao.View
{
    partial class fTheloai
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
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.LoaiPhimDataGridView = new System.Windows.Forms.DataGridView();
            this.theLoaitxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maLoaiPhim = new System.Windows.Forms.Label();
            this.maLoaiPhimtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhimDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(184, 136);
            this.btDong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(56, 37);
            this.btDong.TabIndex = 19;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(101, 136);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(56, 37);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(20, 136);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(56, 37);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // LoaiPhimDataGridView
            // 
            this.LoaiPhimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoaiPhimDataGridView.Location = new System.Drawing.Point(278, 25);
            this.LoaiPhimDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoaiPhimDataGridView.Name = "LoaiPhimDataGridView";
            this.LoaiPhimDataGridView.RowHeadersWidth = 51;
            this.LoaiPhimDataGridView.RowTemplate.Height = 24;
            this.LoaiPhimDataGridView.Size = new System.Drawing.Size(403, 189);
            this.LoaiPhimDataGridView.TabIndex = 16;
            // 
            // theLoaitxt
            // 
            this.theLoaitxt.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theLoaitxt.Location = new System.Drawing.Point(101, 71);
            this.theLoaitxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.theLoaitxt.Name = "theLoaitxt";
            this.theLoaitxt.Size = new System.Drawing.Size(154, 27);
            this.theLoaitxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thể loại";
            // 
            // maLoaiPhim
            // 
            this.maLoaiPhim.AutoSize = true;
            this.maLoaiPhim.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLoaiPhim.Location = new System.Drawing.Point(16, 33);
            this.maLoaiPhim.Name = "maLoaiPhim";
            this.maLoaiPhim.Size = new System.Drawing.Size(106, 19);
            this.maLoaiPhim.TabIndex = 21;
            this.maLoaiPhim.Text = "Mã Loại Phim";
            // 
            // maLoaiPhimtxt
            // 
            this.maLoaiPhimtxt.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLoaiPhimtxt.Location = new System.Drawing.Point(155, 33);
            this.maLoaiPhimtxt.Name = "maLoaiPhimtxt";
            this.maLoaiPhimtxt.Size = new System.Drawing.Size(100, 27);
            this.maLoaiPhimtxt.TabIndex = 20;
            // 
            // fTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 238);
            this.Controls.Add(this.maLoaiPhim);
            this.Controls.Add(this.maLoaiPhimtxt);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.LoaiPhimDataGridView);
            this.Controls.Add(this.theLoaitxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTheloai";
            this.Text = "fTheloai";
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhimDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView LoaiPhimDataGridView;
        private System.Windows.Forms.TextBox theLoaitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maLoaiPhim;
        private System.Windows.Forms.TextBox maLoaiPhimtxt;
    }
}