﻿namespace QuanLyCuaHangDienThoai.User_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachhangthanthiet));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureDSHH = new System.Windows.Forms.PictureBox();
            this.btnSuaAnh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDong = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhsachhanghoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuonghieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatxu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGianhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            // pictureDSHH
            // 
            this.pictureDSHH.Location = new System.Drawing.Point(155, 89);
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
            this.btnSuaAnh.Location = new System.Drawing.Point(26, 196);
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
            this.btnThemAnh.Location = new System.Drawing.Point(26, 127);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(123, 50);
            this.btnThemAnh.TabIndex = 7;
            this.btnThemAnh.Text = "Thêm Ảnh";
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
            // gcDanhsachhanghoa
            // 
            this.gcDanhsachhanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhsachhanghoa.Location = new System.Drawing.Point(-49, 478);
            this.gcDanhsachhanghoa.MainView = this.gridView1;
            this.gcDanhsachhanghoa.Name = "gcDanhsachhanghoa";
            this.gcDanhsachhanghoa.Size = new System.Drawing.Size(995, 198);
            this.gcDanhsachhanghoa.TabIndex = 10;
            this.gcDanhsachhanghoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // ucKhachhangthanthiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDanhsachhanghoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureDSHH);
            this.Controls.Add(this.btnSuaAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucKhachhangthanthiet";
            this.Size = new System.Drawing.Size(973, 679);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDSHH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureDSHH;
        private DevExpress.XtraEditors.SimpleButton btnSuaAnh;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnThemDong;
        private DevExpress.XtraGrid.GridControl gcDanhsachhanghoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn colMahang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenhang;
        private DevExpress.XtraGrid.Columns.GridColumn colThuonghieu;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatxu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colGianhap;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaban;
    }
}
