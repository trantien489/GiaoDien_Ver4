namespace QuanLyCuaHangDienThoai.User_control
{
    partial class ucDanhsachsukien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhsachsukien));
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayketthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaybatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhsachsukien = new DevExpress.XtraGrid.GridControl();
            this.bdsDanhsachsukien = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachsukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachsukien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nội dung";
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 6;
            // 
            // colNgayketthuc
            // 
            this.colNgayketthuc.Caption = "Ngày kết thúc";
            this.colNgayketthuc.FieldName = "Ngayketthuc";
            this.colNgayketthuc.Name = "colNgayketthuc";
            this.colNgayketthuc.Visible = true;
            this.colNgayketthuc.VisibleIndex = 4;
            // 
            // colNgaybatdau
            // 
            this.colNgaybatdau.Caption = "Ngày bắt đầu";
            this.colNgaybatdau.FieldName = "Ngaybatdau";
            this.colNgaybatdau.Name = "colNgaybatdau";
            this.colNgaybatdau.Visible = true;
            this.colNgaybatdau.VisibleIndex = 3;
            // 
            // colTensukien
            // 
            this.colTensukien.Caption = "Tên sự kiện";
            this.colTensukien.FieldName = "Tensukien";
            this.colTensukien.Name = "colTensukien";
            this.colTensukien.Visible = true;
            this.colTensukien.VisibleIndex = 2;
            // 
            // colMasukien
            // 
            this.colMasukien.Caption = "Mã sự kiện";
            this.colMasukien.FieldName = "Masukien";
            this.colMasukien.Name = "colMasukien";
            this.colMasukien.Visible = true;
            this.colMasukien.VisibleIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMasukien,
            this.colTensukien,
            this.colNgaybatdau,
            this.colNgayketthuc,
            this.colSale,
            this.colNoidung});
            this.gridView1.GridControl = this.gcDanhsachsukien;
            this.gridView1.Name = "gridView1";
            // 
            // colSale
            // 
            this.colSale.Caption = "Sale off";
            this.colSale.FieldName = "Sale";
            this.colSale.Name = "colSale";
            this.colSale.Visible = true;
            this.colSale.VisibleIndex = 5;
            // 
            // gcDanhsachsukien
            // 
            this.gcDanhsachsukien.DataSource = this.bdsDanhsachsukien;
            this.gcDanhsachsukien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDanhsachsukien.Location = new System.Drawing.Point(0, 141);
            this.gcDanhsachsukien.MainView = this.gridView1;
            this.gcDanhsachsukien.Name = "gcDanhsachsukien";
            this.gcDanhsachsukien.Size = new System.Drawing.Size(1078, 397);
            this.gcDanhsachsukien.TabIndex = 9;
            this.gcDanhsachsukien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDanhsachsukien
            // 
            this.bdsDanhsachsukien.DataSource = typeof(DataAccess.Danhsachsukien);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnThemDong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 460);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH SỰ KIỆN";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1078, 78);
            this.panelControl1.TabIndex = 7;
            // 
            // ucDanhsachsukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDanhsachsukien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDanhsachsukien";
            this.Size = new System.Drawing.Size(1078, 538);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachsukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachsukien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayketthuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaybatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colTensukien;
        private DevExpress.XtraGrid.Columns.GridColumn colMasukien;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSale;
        private DevExpress.XtraGrid.GridControl gcDanhsachsukien;
        private System.Windows.Forms.BindingSource bdsDanhsachsukien;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnThemDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
