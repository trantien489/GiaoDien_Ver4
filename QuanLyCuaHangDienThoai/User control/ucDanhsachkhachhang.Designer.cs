namespace QuanLyCuaHangDienThoai.User_control
{
    partial class ucDanhsachkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhsachkhachhang));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Makhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tenkhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capbac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hinhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pictureDSHH = new System.Windows.Forms.PictureBox();
            this.btnSuaAnh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 443);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(866, 217);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.num,
            this.Makhachhang,
            this.Tenkhachhang,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Cmnd,
            this.Sdt,
            this.Capbac,
            this.Hinhanh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // num
            // 
            this.num.Caption = "STT";
            this.num.Name = "num";
            this.num.Visible = true;
            this.num.VisibleIndex = 0;
            // 
            // Makhachhang
            // 
            this.Makhachhang.Caption = "Mã khách hàng";
            this.Makhachhang.Name = "Makhachhang";
            this.Makhachhang.Visible = true;
            this.Makhachhang.VisibleIndex = 1;
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.Caption = "Tên khách hàng";
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.Visible = true;
            this.Tenkhachhang.VisibleIndex = 2;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Caption = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Visible = true;
            this.Ngaysinh.VisibleIndex = 3;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Caption = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Visible = true;
            this.Gioitinh.VisibleIndex = 4;
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 5;
            // 
            // Cmnd
            // 
            this.Cmnd.Caption = "CMND";
            this.Cmnd.Name = "Cmnd";
            this.Cmnd.Visible = true;
            this.Cmnd.VisibleIndex = 6;
            // 
            // Sdt
            // 
            this.Sdt.Caption = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            this.Sdt.Visible = true;
            this.Sdt.VisibleIndex = 7;
            // 
            // Capbac
            // 
            this.Capbac.Caption = "Cấp bậc";
            this.Capbac.Name = "Capbac";
            this.Capbac.Visible = true;
            this.Capbac.VisibleIndex = 8;
            // 
            // Hinhanh
            // 
            this.Hinhanh.Caption = "Hình ảnh";
            this.Hinhanh.Name = "Hinhanh";
            this.Hinhanh.Visible = true;
            this.Hinhanh.VisibleIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnThemDong);
            this.groupBox2.Location = new System.Drawing.Point(21, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(391, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 42);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(283, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
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
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(151, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm Mới";
            // 
            // pictureDSHH
            // 
            this.pictureDSHH.Location = new System.Drawing.Point(167, 72);
            this.pictureDSHH.Name = "pictureDSHH";
            this.pictureDSHH.Size = new System.Drawing.Size(290, 278);
            this.pictureDSHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDSHH.TabIndex = 8;
            this.pictureDSHH.TabStop = false;
            // 
            // btnSuaAnh
            // 
            this.btnSuaAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaAnh.Appearance.Options.UseFont = true;
            this.btnSuaAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaAnh.Image")));
            this.btnSuaAnh.Location = new System.Drawing.Point(38, 144);
            this.btnSuaAnh.Name = "btnSuaAnh";
            this.btnSuaAnh.Size = new System.Drawing.Size(123, 51);
            this.btnSuaAnh.TabIndex = 6;
            this.btnSuaAnh.Text = "Sửa Ảnh";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(37, 75);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(123, 50);
            this.btnThemAnh.TabIndex = 7;
            this.btnThemAnh.Text = "Thêm Ảnh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(869, 63);
            this.panelControl1.TabIndex = 9;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(222, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(486, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // ucDanhsachkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pictureDSHH);
            this.Controls.Add(this.btnSuaAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridControl1);
            this.Name = "ucDanhsachkhachhang";
            this.Size = new System.Drawing.Size(869, 660);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn num;
        private DevExpress.XtraGrid.Columns.GridColumn Makhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn Tenkhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn Ngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn Gioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn Cmnd;
        private DevExpress.XtraGrid.Columns.GridColumn Sdt;
        private DevExpress.XtraGrid.Columns.GridColumn Capbac;
        private DevExpress.XtraGrid.Columns.GridColumn Hinhanh;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemDong;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.PictureBox pictureDSHH;
        private DevExpress.XtraEditors.SimpleButton btnSuaAnh;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
