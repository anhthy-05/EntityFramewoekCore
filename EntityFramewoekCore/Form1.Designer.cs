using EntityFramewoekCore;

namespace EntityFramewoekCore
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
            dgvSinhVien = new DataGridView();
            btnTaiLai = new Button();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLoc = new Button();
            label2 = new Label();
            label3 = new Label();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(0, 247);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(798, 195);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = SystemColors.ScrollBar;
            btnTaiLai.Location = new Point(440, 187);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(159, 29);
            btnTaiLai.TabIndex = 1;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(144, 106);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(246, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(517, 106);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(231, 27);
            txtDiem.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 106);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 4;
            label1.Text = "Họ tên :";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.InactiveCaption;
            btnThem.Location = new Point(42, 187);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.InactiveCaption;
            btnSua.Location = new Point(173, 187);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.InactiveCaption;
            btnXoa.Location = new Point(296, 187);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = SystemColors.ScrollBar;
            btnLoc.Location = new Point(616, 187);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(159, 29);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "Lọc SV đạt";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLocDat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 22);
            label2.Name = "label2";
            label2.Size = new Size(454, 41);
            label2.TabIndex = 9;
            label2.Text = "QUẢN LÝ SINH VIÊN - EF CORE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(452, 107);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 10;
            label3.Text = "Điểm :";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoEllipsis = true;
            lblTrangThai.AutoSize = true;
            lblTrangThai.BackColor = Color.SandyBrown;
            lblTrangThai.Location = new Point(108, 464);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 20);
            lblTrangThai.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(lblTrangThai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoc);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(btnTaiLai);
            Controls.Add(dgvSinhVien);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button btnTaiLai;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLoc;
        private Label label2;
        private Label label3;
        private Label lblTrangThai;
    }
}
