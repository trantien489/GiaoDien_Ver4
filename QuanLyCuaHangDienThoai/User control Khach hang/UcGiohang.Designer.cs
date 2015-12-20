namespace QuanLyCuaHangDienThoai.User_control_Khach_hang
{
    partial class UcGiohang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcGiohang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bdsGiohang = new System.Windows.Forms.BindingSource(this.components);
            this.bdsHinhanh = new System.Windows.Forms.BindingSource(this.components);
            this.gcGiohang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureGioHang = new System.Windows.Forms.PictureBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(972, 63);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(373, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "GIỎ HÀNG";
            // 
            // bdsGiohang
            // 
            this.bdsGiohang.DataSource = typeof(DataAccess.Giohang);
            this.bdsGiohang.PositionChanged += new System.EventHandler(this.bdsGiohang_PositionChanged);
            // 
            // bdsHinhanh
            // 
            this.bdsHinhanh.DataSource = typeof(DataAccess.HinhAnh);
            // 
            // gcGiohang
            // 
            this.gcGiohang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGiohang.DataSource = this.bdsGiohang;
            this.gcGiohang.Location = new System.Drawing.Point(3, 389);
            this.gcGiohang.MainView = this.gridView1;
            this.gcGiohang.Name = "gcGiohang";
            this.gcGiohang.Size = new System.Drawing.Size(966, 200);
            this.gcGiohang.TabIndex = 3;
            this.gcGiohang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMahang,
            this.colTenhang,
            this.colGiaban});
            this.gridView1.GridControl = this.gcGiohang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colMahang
            // 
            this.colMahang.Caption = "Mã Hàng";
            this.colMahang.FieldName = "Mahang";
            this.colMahang.Name = "colMahang";
            this.colMahang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Mahang", "Số Lượng Sản Phẩm: {0}")});
            this.colMahang.Visible = true;
            this.colMahang.VisibleIndex = 0;
            // 
            // colTenhang
            // 
            this.colTenhang.Caption = "Tên Hàng";
            this.colTenhang.FieldName = "Tenhang";
            this.colTenhang.Name = "colTenhang";
            this.colTenhang.Visible = true;
            this.colTenhang.VisibleIndex = 1;
            // 
            // colGiaban
            // 
            this.colGiaban.Caption = "Giá Bán";
            this.colGiaban.FieldName = "Giaban";
            this.colGiaban.Name = "colGiaban";
            this.colGiaban.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Giaban", "Tổng Cộng: {0:0.##}")});
            this.colGiaban.Visible = true;
            this.colGiaban.VisibleIndex = 2;
            // 
            // pictureGioHang
            // 
            this.pictureGioHang.Location = new System.Drawing.Point(19, 69);
            this.pictureGioHang.Name = "pictureGioHang";
            this.pictureGioHang.Size = new System.Drawing.Size(394, 314);
            this.pictureGioHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGioHang.TabIndex = 4;
            this.pictureGioHang.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(429, 332);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 51);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DataGV
            // 
            this.DataGV.AutoGenerateColumns = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.hinhanhDataGridViewImageColumn});
            this.DataGV.DataSource = this.bdsHinhanh;
            this.DataGV.Location = new System.Drawing.Point(881, 69);
            this.DataGV.Name = "DataGV";
            this.DataGV.Size = new System.Drawing.Size(86, 15);
            this.DataGV.TabIndex = 6;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(698, 101);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(269, 186);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "ĐẶT HÀNG";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(96, 114);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 52);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "OK";
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(55, 73);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(173, 24);
            this.cmb.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(9, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(256, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chọn hình thức thanh toán";
            // 
            // UcGiohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureGioHang);
            this.Controls.Add(this.gcGiohang);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcGiohang";
            this.Size = new System.Drawing.Size(972, 592);
            this.Load += new System.EventHandler(this.UcGiohang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsGiohang;
        private System.Windows.Forms.BindingSource bdsHinhanh;
        private DevExpress.XtraGrid.GridControl gcGiohang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMahang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenhang;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaban;
        private System.Windows.Forms.PictureBox pictureGioHang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhanhDataGridViewImageColumn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmb;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
