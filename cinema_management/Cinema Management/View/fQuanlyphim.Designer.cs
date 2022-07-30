
namespace PBL3_GiaBao.View
{
    partial class fQuanlyphim
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pickImageBtn = new System.Windows.Forms.Button();
            this.btQLLoaiPhim = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.deletePhim = new System.Windows.Forms.Button();
            this.EditPhim = new System.Windows.Forms.Button();
            this.addPhim = new System.Windows.Forms.Button();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phimImageBox = new System.Windows.Forms.PictureBox();
            this.ListPhimDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDinhDang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phimImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPhimDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.SaveBtn.Location = new System.Drawing.Point(293, 601);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(93, 34);
            this.SaveBtn.TabIndex = 28;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(104, 356);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(281, 25);
            this.txtMoTa.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 362);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mô Tả";
            // 
            // pickImageBtn
            // 
            this.pickImageBtn.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickImageBtn.Location = new System.Drawing.Point(104, 472);
            this.pickImageBtn.Name = "pickImageBtn";
            this.pickImageBtn.Size = new System.Drawing.Size(37, 27);
            this.pickImageBtn.TabIndex = 25;
            this.pickImageBtn.Text = "...";
            this.pickImageBtn.UseVisualStyleBackColor = true;
            this.pickImageBtn.Click += new System.EventHandler(this.pickImageBtn_Click);
            // 
            // btQLLoaiPhim
            // 
            this.btQLLoaiPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btQLLoaiPhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLLoaiPhim.Location = new System.Drawing.Point(249, 276);
            this.btQLLoaiPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btQLLoaiPhim.Name = "btQLLoaiPhim";
            this.btQLLoaiPhim.Size = new System.Drawing.Size(136, 29);
            this.btQLLoaiPhim.TabIndex = 22;
            this.btQLLoaiPhim.Text = "Quản lí thể loại";
            this.btQLLoaiPhim.UseVisualStyleBackColor = false;
            this.btQLLoaiPhim.Click += new System.EventHandler(this.btQLLoaiPhim_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(220, 601);
            this.close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 34);
            this.close.TabIndex = 21;
            this.close.Text = "Đóng";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // deletePhim
            // 
            this.deletePhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePhim.Location = new System.Drawing.Point(151, 601);
            this.deletePhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deletePhim.Name = "deletePhim";
            this.deletePhim.Size = new System.Drawing.Size(65, 34);
            this.deletePhim.TabIndex = 20;
            this.deletePhim.Text = "Xóa";
            this.deletePhim.UseVisualStyleBackColor = true;
            this.deletePhim.Click += new System.EventHandler(this.deletePhim_Click);
            // 
            // EditPhim
            // 
            this.EditPhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPhim.Location = new System.Drawing.Point(83, 601);
            this.EditPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditPhim.Name = "EditPhim";
            this.EditPhim.Size = new System.Drawing.Size(64, 34);
            this.EditPhim.TabIndex = 19;
            this.EditPhim.Text = "Sửa";
            this.EditPhim.UseVisualStyleBackColor = true;
            this.EditPhim.Click += new System.EventHandler(this.EditPhim_Click);
            // 
            // addPhim
            // 
            this.addPhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhim.Location = new System.Drawing.Point(9, 601);
            this.addPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addPhim.Name = "addPhim";
            this.addPhim.Size = new System.Drawing.Size(70, 34);
            this.addPhim.TabIndex = 18;
            this.addPhim.Text = "Thêm";
            this.addPhim.UseVisualStyleBackColor = true;
            this.addPhim.Click += new System.EventHandler(this.addPhim_Click);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbTheLoai.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(104, 276);
            this.cbbTheLoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(121, 25);
            this.cbbTheLoai.TabIndex = 17;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(293, 206);
            this.btClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(92, 29);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiLuong.Location = new System.Drawing.Point(312, 433);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(71, 25);
            this.txtThoiLuong.TabIndex = 13;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.Location = new System.Drawing.Point(104, 316);
            this.txtDaoDien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(281, 25);
            this.txtDaoDien.TabIndex = 12;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(104, 241);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(281, 25);
            this.txtTenPhim.TabIndex = 11;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(104, 205);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(121, 25);
            this.txtMaPhim.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 478);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hình ảnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đạo diễn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phim";
            // 
            // phimImageBox
            // 
            this.phimImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phimImageBox.Location = new System.Drawing.Point(86, 3);
            this.phimImageBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phimImageBox.Name = "phimImageBox";
            this.phimImageBox.Size = new System.Drawing.Size(225, 180);
            this.phimImageBox.TabIndex = 0;
            this.phimImageBox.TabStop = false;
            // 
            // ListPhimDataGridView
            // 
            this.ListPhimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPhimDataGridView.Location = new System.Drawing.Point(439, 12);
            this.ListPhimDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListPhimDataGridView.Name = "ListPhimDataGridView";
            this.ListPhimDataGridView.RowHeadersWidth = 51;
            this.ListPhimDataGridView.RowTemplate.Height = 24;
            this.ListPhimDataGridView.Size = new System.Drawing.Size(1046, 648);
            this.ListPhimDataGridView.TabIndex = 5;
            this.ListPhimDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPhimDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtManHinh);
            this.panel1.Controls.Add(this.txtDinhDang);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.startDatePicker);
            this.panel1.Controls.Add(this.endDatePicker);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pickImageBtn);
            this.panel1.Controls.Add(this.btQLLoaiPhim);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.deletePhim);
            this.panel1.Controls.Add(this.EditPhim);
            this.panel1.Controls.Add(this.addPhim);
            this.panel1.Controls.Add(this.cbbTheLoai);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.txtQuocGia);
            this.panel1.Controls.Add(this.txtNSX);
            this.panel1.Controls.Add(this.txtThoiLuong);
            this.panel1.Controls.Add(this.txtDaoDien);
            this.panel1.Controls.Add(this.txtTenPhim);
            this.panel1.Controls.Add(this.txtMaPhim);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phimImageBox);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 648);
            this.panel1.TabIndex = 4;
            // 
            // txtDinhDang
            // 
            this.txtDinhDang.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinhDang.Location = new System.Drawing.Point(105, 433);
            this.txtDinhDang.Name = "txtDinhDang";
            this.txtDinhDang.Size = new System.Drawing.Size(120, 25);
            this.txtDinhDang.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Định Dạng";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(151, 513);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 25);
            this.startDatePicker.TabIndex = 32;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(151, 557);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 25);
            this.endDatePicker.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ngày Kết Thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Ngày Khởi Chiếu";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocGia.Location = new System.Drawing.Point(297, 397);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(110, 25);
            this.txtQuocGia.TabIndex = 15;
            // 
            // txtNSX
            // 
            this.txtNSX.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSX.Location = new System.Drawing.Point(105, 396);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(120, 25);
            this.txtNSX.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quốc gia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Năm sản xuất";
            // 
            // txtManHinh
            // 
            this.txtManHinh.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManHinh.Location = new System.Drawing.Point(300, 472);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(110, 25);
            this.txtManHinh.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(229, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Màn hình";
            // 
            // fQuanlyphim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 672);
            this.Controls.Add(this.ListPhimDataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQuanlyphim";
            this.Text = "fQuanlyphim";
            ((System.ComponentModel.ISupportInitialize)(this.phimImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPhimDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button pickImageBtn;
        private System.Windows.Forms.Button btQLLoaiPhim;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button deletePhim;
        private System.Windows.Forms.Button EditPhim;
        private System.Windows.Forms.Button addPhim;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox phimImageBox;
        private System.Windows.Forms.DataGridView ListPhimDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDinhDang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtManHinh;
    }
}