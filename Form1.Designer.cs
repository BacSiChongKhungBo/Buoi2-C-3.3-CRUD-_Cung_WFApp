namespace Buoi2_C_3._3__CRUD__Cung_WFApp
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
            lblMasach = new Label();
            lblTen = new Label();
            lblTacgia = new Label();
            lblNhaxuatban = new Label();
            lblGiatien = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtMasach = new TextBox();
            txtTen = new TextBox();
            txtTacgia = new TextBox();
            txtGiatien = new TextBox();
            cbxNhaxuatban = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            lblTimkiem = new Label();
            txtTimkiem = new TextBox();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // lblMasach
            // 
            lblMasach.AutoSize = true;
            lblMasach.Location = new Point(48, 23);
            lblMasach.Name = "lblMasach";
            lblMasach.Size = new Size(51, 15);
            lblMasach.TabIndex = 0;
            lblMasach.Text = "Mã sách";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(48, 48);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(25, 15);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // lblTacgia
            // 
            lblTacgia.AutoSize = true;
            lblTacgia.Location = new Point(48, 82);
            lblTacgia.Name = "lblTacgia";
            lblTacgia.Size = new Size(44, 15);
            lblTacgia.TabIndex = 2;
            lblTacgia.Text = "Tác Giả";
            // 
            // lblNhaxuatban
            // 
            lblNhaxuatban.AutoSize = true;
            lblNhaxuatban.Location = new Point(45, 115);
            lblNhaxuatban.Name = "lblNhaxuatban";
            lblNhaxuatban.Size = new Size(78, 15);
            lblNhaxuatban.TabIndex = 3;
            lblNhaxuatban.Text = "Nhà xuất bản";
            // 
            // lblGiatien
            // 
            lblGiatien.AutoSize = true;
            lblGiatien.Location = new Point(45, 143);
            lblGiatien.Name = "lblGiatien";
            lblGiatien.Size = new Size(47, 15);
            lblGiatien.TabIndex = 4;
            lblGiatien.Text = "Giá tiền";
            // 
            // txtMasach
            // 
            txtMasach.Location = new Point(146, 12);
            txtMasach.Margin = new Padding(3, 2, 3, 2);
            txtMasach.Name = "txtMasach";
            txtMasach.Size = new Size(263, 23);
            txtMasach.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(146, 43);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(263, 23);
            txtTen.TabIndex = 6;
            // 
            // txtTacgia
            // 
            txtTacgia.Location = new Point(146, 76);
            txtTacgia.Margin = new Padding(3, 2, 3, 2);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(263, 23);
            txtTacgia.TabIndex = 7;
            // 
            // txtGiatien
            // 
            txtGiatien.Location = new Point(146, 138);
            txtGiatien.Margin = new Padding(3, 2, 3, 2);
            txtGiatien.Name = "txtGiatien";
            txtGiatien.Size = new Size(263, 23);
            txtGiatien.TabIndex = 8;
            // 
            // cbxNhaxuatban
            // 
            cbxNhaxuatban.FormattingEnabled = true;
            cbxNhaxuatban.Location = new Point(146, 112);
            cbxNhaxuatban.Margin = new Padding(3, 2, 3, 2);
            cbxNhaxuatban.Name = "cbxNhaxuatban";
            cbxNhaxuatban.Size = new Size(263, 23);
            cbxNhaxuatban.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(510, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 36);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(510, 43);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(510, 82);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 33);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(510, 119);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 36);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblTimkiem
            // 
            lblTimkiem.AutoSize = true;
            lblTimkiem.Location = new Point(42, 184);
            lblTimkiem.Name = "lblTimkiem";
            lblTimkiem.Size = new Size(56, 15);
            lblTimkiem.TabIndex = 14;
            lblTimkiem.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(156, 184);
            txtTimkiem.Margin = new Padding(3, 2, 3, 2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(266, 23);
            txtTimkiem.TabIndex = 15;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(42, 220);
            dtgView.Margin = new Padding(3, 2, 3, 2);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(578, 141);
            dtgView.TabIndex = 16;
            dtgView.CellClick += dtgView_CellClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 394);
            Controls.Add(dtgView);
            Controls.Add(txtTimkiem);
            Controls.Add(lblTimkiem);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbxNhaxuatban);
            Controls.Add(txtGiatien);
            Controls.Add(txtTacgia);
            Controls.Add(txtTen);
            Controls.Add(txtMasach);
            Controls.Add(lblGiatien);
            Controls.Add(lblNhaxuatban);
            Controls.Add(lblTacgia);
            Controls.Add(lblTen);
            Controls.Add(lblMasach);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasach;
        private Label lblTen;
        private Label lblTacgia;
        private Label lblNhaxuatban;
        private Label lblGiatien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtMasach;
        private TextBox txtTen;
        private TextBox txtTacgia;
        private TextBox txtGiatien;
        private ComboBox cbxNhaxuatban;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnClear;
        private Label lblTimkiem;
        private TextBox txtTimkiem;
        private DataGridView dtgView;
    }
}