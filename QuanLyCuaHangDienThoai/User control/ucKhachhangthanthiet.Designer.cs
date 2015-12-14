namespace QuanLyCuaHangDienThoai.User_control
{
    partial class ucKhachhangthanthiet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sdtLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label cmndLabel;
            System.Windows.Forms.Label diachiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachhangthanthiet));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureDSKH = new System.Windows.Forms.PictureBox();
            this.btnSuaAnh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDong = new DevExpress.XtraEditors.SimpleButton();
            this.bdsDanhsachkhachhang = new System.Windows.Forms.BindingSource(this.components);
            this.bdsHinhanh = new System.Windows.Forms.BindingSource(this.components);
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmndTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.gcDanhsachkhachhang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMakhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapbac = new DevExpress.XtraGrid.Columns.GridColumn();
            sdtLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            cmndLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sdtLabel
            // 
            sdtLabel.AutoSize = true;
            sdtLabel.Location = new System.Drawing.Point(34, 78);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new System.Drawing.Size(29, 13);
            sdtLabel.TabIndex = 6;
            sdtLabel.Text = "SĐT";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(6, 23);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(56, 13);
            ngaysinhLabel.TabIndex = 4;
            ngaysinhLabel.Text = "Ngày Sinh";
            // 
            // cmndLabel
            // 
            cmndLabel.AutoSize = true;
            cmndLabel.Location = new System.Drawing.Point(23, 109);
            cmndLabel.Name = "cmndLabel";
            cmndLabel.Size = new System.Drawing.Size(39, 13);
            cmndLabel.TabIndex = 2;
            cmndLabel.Text = "CMND";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(20, 49);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(41, 13);
            diachiLabel.TabIndex = 0;
            diachiLabel.Text = "Địa Chỉ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(973, 63);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(117, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(728, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH KHÁCH HÀNG THÂN THIẾT";
            // 
            // pictureDSKH
            // 
            this.pictureDSKH.Location = new System.Drawing.Point(155, 89);
            this.pictureDSKH.Name = "pictureDSKH";
            this.pictureDSKH.Size = new System.Drawing.Size(290, 278);
            this.pictureDSKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDSKH.TabIndex = 8;
            this.pictureDSKH.TabStop = false;
            // 
            // btnSuaAnh
            // 
            this.btnSuaAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaAnh.Appearance.Options.UseFont = true;
            this.btnSuaAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaAnh.Image")));
            this.btnSuaAnh.Location = new System.Drawing.Point(26, 196);
            this.btnSuaAnh.Name = "btnSuaAnh";
            this.btnSuaAnh.Size = new System.Drawing.Size(123, 51);
            this.btnSuaAnh.TabIndex = 6;
            this.btnSuaAnh.Text = "Sửa Ảnh";
            this.btnSuaAnh.Click += new System.EventHandler(this.btnSuaAnh_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(26, 127);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(123, 50);
            this.btnThemAnh.TabIndex = 7;
            this.btnThemAnh.Text = "Thêm Ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnThemDong);
            this.groupBox2.Location = new System.Drawing.Point(26, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 61);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(384, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 42);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(289, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(153, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThemDong
            // 
            this.btnThemDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDong.Appearance.Options.UseFont = true;
            this.btnThemDong.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDong.Image")));
            this.btnThemDong.Location = new System.Drawing.Point(6, 13);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(128, 42);
            this.btnThemDong.TabIndex = 0;
            this.btnThemDong.Text = "Thêm Dòng";
            this.btnThemDong.Click += new System.EventHandler(this.btnThemDong_Click);
            // 
            // bdsDanhsachkhachhang
            // 
            this.bdsDanhsachkhachhang.DataSource = typeof(DataAccess.Danhsachkhachhang);
            this.bdsDanhsachkhachhang.PositionChanged += new System.EventHandler(this.bdsDanhsachkhachhang_PositionChanged);
            // 
            // bdsHinhanh
            // 
            this.bdsHinhanh.DataSource = typeof(DataAccess.HinhAnh);
            // 
            // DataGV
            // 
            this.DataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGV.AutoGenerateColumns = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.hinhanhDataGridViewImageColumn});
            this.DataGV.DataSource = this.bdsHinhanh;
            this.DataGV.Location = new System.Drawing.Point(947, 220);
            this.DataGV.Name = "DataGV";
            this.DataGV.Size = new System.Drawing.Size(13, 17);
            this.DataGV.TabIndex = 21;
            this.DataGV.Visible = false;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "Mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mahang";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            // 
            // hinhanhDataGridViewImageColumn
            // 
            this.hinhanhDataGridViewImageColumn.DataPropertyName = "Hinhanh";
            this.hinhanhDataGridViewImageColumn.HeaderText = "Hinhanh";
            this.hinhanhDataGridViewImageColumn.Name = "hinhanhDataGridViewImageColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(sdtLabel);
            this.groupBox1.Controls.Add(this.sdtTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhDateTimePicker);
            this.groupBox1.Controls.Add(cmndLabel);
            this.groupBox1.Controls.Add(this.cmndTextBox);
            this.groupBox1.Controls.Add(diachiLabel);
            this.groupBox1.Controls.Add(this.diachiTextBox);
            this.groupBox1.Location = new System.Drawing.Point(694, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 144);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDanhsachkhachhang, "Sdt", true));
            this.sdtTextBox.Location = new System.Drawing.Point(66, 75);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(200, 20);
            this.sdtTextBox.TabIndex = 7;
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDanhsachkhachhang, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(66, 19);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 5;
            // 
            // cmndTextBox
            // 
            this.cmndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDanhsachkhachhang, "Cmnd", true));
            this.cmndTextBox.Location = new System.Drawing.Point(66, 106);
            this.cmndTextBox.Name = "cmndTextBox";
            this.cmndTextBox.Size = new System.Drawing.Size(200, 20);
            this.cmndTextBox.TabIndex = 3;
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDanhsachkhachhang, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(66, 46);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(200, 20);
            this.diachiTextBox.TabIndex = 1;
            // 
            // gcDanhsachkhachhang
            // 
            this.gcDanhsachkhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhsachkhachhang.DataSource = this.bdsDanhsachkhachhang;
            this.gcDanhsachkhachhang.Location = new System.Drawing.Point(0, 461);
            this.gcDanhsachkhachhang.MainView = this.gridView1;
            this.gcDanhsachkhachhang.Name = "gcDanhsachkhachhang";
            this.gcDanhsachkhachhang.Size = new System.Drawing.Size(973, 218);
            this.gcDanhsachkhachhang.TabIndex = 19;
            this.gcDanhsachkhachhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMakhachhang,
            this.colTenkhachhang,
            this.colGioitinh,
            this.colTaikhoan,
            this.colMatkhau,
            this.colCapbac});
            this.gridView1.GridControl = this.gcDanhsachkhachhang;
            this.gridView1.Name = "gridView1";
            // 
            // colMakhachhang
            // 
            this.colMakhachhang.Caption = "Mã Khách Hàng";
            this.colMakhachhang.FieldName = "Makhachhang";
            this.colMakhachhang.Name = "colMakhachhang";
            this.colMakhachhang.Visible = true;
            this.colMakhachhang.VisibleIndex = 0;
            // 
            // colTenkhachhang
            // 
            this.colTenkhachhang.Caption = "Tên Khách Hàng";
            this.colTenkhachhang.FieldName = "Tenkhachhang";
            this.colTenkhachhang.Name = "colTenkhachhang";
            this.colTenkhachhang.Visible = true;
            this.colTenkhachhang.VisibleIndex = 1;
            // 
            // colGioitinh
            // 
            this.colGioitinh.Caption = "Giới Tính";
            this.colGioitinh.FieldName = "Gioitinh";
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Visible = true;
            this.colGioitinh.VisibleIndex = 2;
            // 
            // colTaikhoan
            // 
            this.colTaikhoan.Caption = "Tài Khoản";
            this.colTaikhoan.FieldName = "Taikhoan";
            this.colTaikhoan.Name = "colTaikhoan";
            this.colTaikhoan.Visible = true;
            this.colTaikhoan.VisibleIndex = 3;
            // 
            // colMatkhau
            // 
            this.colMatkhau.Caption = "Mật Khẩu";
            this.colMatkhau.FieldName = "Matkhau";
            this.colMatkhau.Name = "colMatkhau";
            this.colMatkhau.Visible = true;
            this.colMatkhau.VisibleIndex = 4;
            // 
            // colCapbac
            // 
            this.colCapbac.Caption = "Cấp Bậc";
            this.colCapbac.FieldName = "Capbac";
            this.colCapbac.Name = "colCapbac";
            this.colCapbac.Visible = true;
            this.colCapbac.VisibleIndex = 5;
            // 
            // ucKhachhangthanthiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDanhsachkhachhang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureDSKH);
            this.Controls.Add(this.btnSuaAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucKhachhangthanthiet";
            this.Size = new System.Drawing.Size(973, 679);
            this.Load += new System.EventHandler(this.ucKhachhangthanthiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureDSKH;
        private DevExpress.XtraEditors.SimpleButton btnSuaAnh;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnThemDong;
        private System.Windows.Forms.BindingSource bdsDanhsachkhachhang;
        private System.Windows.Forms.BindingSource bdsHinhanh;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhanhDataGridViewImageColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.TextBox cmndTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private DevExpress.XtraGrid.GridControl gcDanhsachkhachhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMakhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colGioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colMatkhau;
        private DevExpress.XtraGrid.Columns.GridColumn colCapbac;
    }
}
