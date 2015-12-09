namespace QuanLyCuaHangDienThoai.User_control
{
    partial class ucDanhsachhanghoa
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
            System.Windows.Forms.Label cameraLabel;
            System.Windows.Forms.Label cauhinhLabel;
            System.Windows.Forms.Label kichthuocLabel;
            System.Windows.Forms.Label mausacLabel;
            System.Windows.Forms.Label ramLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhsachhanghoa));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhsachhanghoa = new DevExpress.XtraGrid.GridControl();
            this.bdnDanhsachhanghoa = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuonghieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatxu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGianhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.mausacTextBox = new System.Windows.Forms.TextBox();
            this.kichthuocTextBox = new System.Windows.Forms.TextBox();
            this.cauhinhTextBox = new System.Windows.Forms.TextBox();
            this.cameraTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaAnh = new DevExpress.XtraEditors.SimpleButton();
            this.pictureDSHH = new System.Windows.Forms.PictureBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            cameraLabel = new System.Windows.Forms.Label();
            cauhinhLabel = new System.Windows.Forms.Label();
            kichthuocLabel = new System.Windows.Forms.Label();
            mausacLabel = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDanhsachhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraLabel
            // 
            cameraLabel.AutoSize = true;
            cameraLabel.Location = new System.Drawing.Point(27, 57);
            cameraLabel.Name = "cameraLabel";
            cameraLabel.Size = new System.Drawing.Size(46, 13);
            cameraLabel.TabIndex = 0;
            cameraLabel.Text = "Camera:";
            // 
            // cauhinhLabel
            // 
            cauhinhLabel.AutoSize = true;
            cauhinhLabel.Location = new System.Drawing.Point(24, 31);
            cauhinhLabel.Name = "cauhinhLabel";
            cauhinhLabel.Size = new System.Drawing.Size(49, 13);
            cauhinhLabel.TabIndex = 2;
            cauhinhLabel.Text = "Cauhinh:";
            // 
            // kichthuocLabel
            // 
            kichthuocLabel.AutoSize = true;
            kichthuocLabel.Location = new System.Drawing.Point(15, 107);
            kichthuocLabel.Name = "kichthuocLabel";
            kichthuocLabel.Size = new System.Drawing.Size(58, 13);
            kichthuocLabel.TabIndex = 4;
            kichthuocLabel.Text = "Kichthuoc:";
            // 
            // mausacLabel
            // 
            mausacLabel.AutoSize = true;
            mausacLabel.Location = new System.Drawing.Point(25, 133);
            mausacLabel.Name = "mausacLabel";
            mausacLabel.Size = new System.Drawing.Size(48, 13);
            mausacLabel.TabIndex = 6;
            mausacLabel.Text = "Mausac:";
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Location = new System.Drawing.Point(41, 81);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(32, 13);
            ramLabel.TabIndex = 8;
            ramLabel.Text = "Ram:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(995, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(285, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(436, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH KHO HÀNG";
            // 
            // gcDanhsachhanghoa
            // 
            this.gcDanhsachhanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhsachhanghoa.DataSource = this.bdnDanhsachhanghoa;
            this.gcDanhsachhanghoa.Location = new System.Drawing.Point(0, 419);
            this.gcDanhsachhanghoa.MainView = this.gridView1;
            this.gcDanhsachhanghoa.Name = "gcDanhsachhanghoa";
            this.gcDanhsachhanghoa.Size = new System.Drawing.Size(995, 198);
            this.gcDanhsachhanghoa.TabIndex = 1;
            this.gcDanhsachhanghoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdnDanhsachhanghoa
            // 
            this.bdnDanhsachhanghoa.DataSource = typeof(DataAccess.Danhsachhanghoa);
            this.bdnDanhsachhanghoa.PositionChanged += new System.EventHandler(this.bdnDanhsachhanghoa_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstt,
            this.colMahang,
            this.colTenhang,
            this.colThuonghieu,
            this.colXuatxu,
            this.colSoluong,
            this.colGianhap,
            this.colGiaban});
            this.gridView1.GridControl = this.gcDanhsachhanghoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colstt
            // 
            this.colstt.Caption = "STT";
            this.colstt.FieldName = "stt";
            this.colstt.Name = "colstt";
            this.colstt.Visible = true;
            this.colstt.VisibleIndex = 0;
            // 
            // colMahang
            // 
            this.colMahang.Caption = "Mã Hàng";
            this.colMahang.FieldName = "Mahang";
            this.colMahang.Name = "colMahang";
            this.colMahang.Visible = true;
            this.colMahang.VisibleIndex = 1;
            // 
            // colTenhang
            // 
            this.colTenhang.Caption = "Tên Hàng";
            this.colTenhang.FieldName = "Tenhang";
            this.colTenhang.Name = "colTenhang";
            this.colTenhang.Visible = true;
            this.colTenhang.VisibleIndex = 2;
            // 
            // colThuonghieu
            // 
            this.colThuonghieu.Caption = "Thương Hiệu";
            this.colThuonghieu.FieldName = "Thuonghieu";
            this.colThuonghieu.Name = "colThuonghieu";
            this.colThuonghieu.Visible = true;
            this.colThuonghieu.VisibleIndex = 3;
            // 
            // colXuatxu
            // 
            this.colXuatxu.Caption = "Xuất Xứ";
            this.colXuatxu.FieldName = "Xuatxu";
            this.colXuatxu.Name = "colXuatxu";
            this.colXuatxu.Visible = true;
            this.colXuatxu.VisibleIndex = 4;
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Số Lượng";
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 5;
            // 
            // colGianhap
            // 
            this.colGianhap.Caption = "Giá Nhập";
            this.colGianhap.FieldName = "Gianhap";
            this.colGianhap.Name = "colGianhap";
            this.colGianhap.Visible = true;
            this.colGianhap.VisibleIndex = 6;
            // 
            // colGiaban
            // 
            this.colGiaban.Caption = "Giá Bán";
            this.colGiaban.FieldName = "Giaban";
            this.colGiaban.Name = "colGiaban";
            this.colGiaban.Visible = true;
            this.colGiaban.VisibleIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(ramLabel);
            this.groupBox1.Controls.Add(this.ramTextBox);
            this.groupBox1.Controls.Add(mausacLabel);
            this.groupBox1.Controls.Add(this.mausacTextBox);
            this.groupBox1.Controls.Add(kichthuocLabel);
            this.groupBox1.Controls.Add(this.kichthuocTextBox);
            this.groupBox1.Controls.Add(cauhinhLabel);
            this.groupBox1.Controls.Add(this.cauhinhTextBox);
            this.groupBox1.Controls.Add(cameraLabel);
            this.groupBox1.Controls.Add(this.cameraTextBox);
            this.groupBox1.Location = new System.Drawing.Point(692, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Sản Phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ramTextBox
            // 
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdnDanhsachhanghoa, "Ram", true));
            this.ramTextBox.Location = new System.Drawing.Point(79, 78);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(191, 20);
            this.ramTextBox.TabIndex = 9;
            // 
            // mausacTextBox
            // 
            this.mausacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdnDanhsachhanghoa, "Mausac", true));
            this.mausacTextBox.Location = new System.Drawing.Point(79, 130);
            this.mausacTextBox.Name = "mausacTextBox";
            this.mausacTextBox.Size = new System.Drawing.Size(191, 20);
            this.mausacTextBox.TabIndex = 7;
            // 
            // kichthuocTextBox
            // 
            this.kichthuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdnDanhsachhanghoa, "Kichthuoc", true));
            this.kichthuocTextBox.Location = new System.Drawing.Point(79, 104);
            this.kichthuocTextBox.Name = "kichthuocTextBox";
            this.kichthuocTextBox.Size = new System.Drawing.Size(191, 20);
            this.kichthuocTextBox.TabIndex = 5;
            // 
            // cauhinhTextBox
            // 
            this.cauhinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdnDanhsachhanghoa, "Cauhinh", true));
            this.cauhinhTextBox.Location = new System.Drawing.Point(79, 28);
            this.cauhinhTextBox.Name = "cauhinhTextBox";
            this.cauhinhTextBox.Size = new System.Drawing.Size(191, 20);
            this.cauhinhTextBox.TabIndex = 3;
            // 
            // cameraTextBox
            // 
            this.cameraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdnDanhsachhanghoa, "Camera", true));
            this.cameraTextBox.Location = new System.Drawing.Point(79, 54);
            this.cameraTextBox.Name = "cameraTextBox";
            this.cameraTextBox.Size = new System.Drawing.Size(191, 20);
            this.cameraTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnThemDong);
            this.groupBox2.Location = new System.Drawing.Point(5, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 61);
            this.groupBox2.TabIndex = 3;
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
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(11, 107);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(123, 50);
            this.btnThemAnh.TabIndex = 4;
            this.btnThemAnh.Text = "Thêm Ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // btnSuaAnh
            // 
            this.btnSuaAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaAnh.Appearance.Options.UseFont = true;
            this.btnSuaAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaAnh.Image")));
            this.btnSuaAnh.Location = new System.Drawing.Point(11, 176);
            this.btnSuaAnh.Name = "btnSuaAnh";
            this.btnSuaAnh.Size = new System.Drawing.Size(123, 51);
            this.btnSuaAnh.TabIndex = 4;
            this.btnSuaAnh.Text = "Sửa Ảnh";
            this.btnSuaAnh.Click += new System.EventHandler(this.btnSuaAnh_Click);
            // 
            // pictureDSHH
            // 
            this.pictureDSHH.Location = new System.Drawing.Point(140, 69);
            this.pictureDSHH.Name = "pictureDSHH";
            this.pictureDSHH.Size = new System.Drawing.Size(290, 278);
            this.pictureDSHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDSHH.TabIndex = 5;
            this.pictureDSHH.TabStop = false;
            // 
            // DataGV
            // 
            this.DataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Location = new System.Drawing.Point(972, 244);
            this.DataGV.Name = "DataGV";
            this.DataGV.Size = new System.Drawing.Size(10, 10);
            this.DataGV.TabIndex = 6;
            // 
            // ucDanhsachhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.pictureDSHH);
            this.Controls.Add(this.btnSuaAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDanhsachhanghoa);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDanhsachhanghoa";
            this.Size = new System.Drawing.Size(995, 604);
            this.Load += new System.EventHandler(this.ucDanhsachhanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDanhsachhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhsachhanghoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdnDanhsachhanghoa;
        private System.Windows.Forms.TextBox mausacTextBox;
        private System.Windows.Forms.TextBox kichthuocTextBox;
        private System.Windows.Forms.TextBox cauhinhTextBox;
        private System.Windows.Forms.TextBox cameraTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn colMahang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenhang;
        private DevExpress.XtraGrid.Columns.GridColumn colThuonghieu;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatxu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colGianhap;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaban;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnThemDong;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.SimpleButton btnSuaAnh;
        private System.Windows.Forms.PictureBox pictureDSHH;
        private System.Windows.Forms.DataGridView DataGV;
    }
}
