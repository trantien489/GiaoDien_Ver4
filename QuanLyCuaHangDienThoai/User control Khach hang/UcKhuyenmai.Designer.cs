namespace QuanLyCuaHangDienThoai.User_control_Khach_hang
{
    partial class UcKhuyenmai
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bdsDanhsachsukien = new System.Windows.Forms.BindingSource(this.components);
            this.gcDanhsachsukien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaybatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayketthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachsukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachsukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 78);
            this.panelControl1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(234, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(473, 45);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "THÔNG TIN KHUYẾN MÃI";
            // 
            // bdsDanhsachsukien
            // 
            this.bdsDanhsachsukien.DataSource = typeof(DataAccess.Danhsachsukien);
            // 
            // gcDanhsachsukien
            // 
            this.gcDanhsachsukien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhsachsukien.DataSource = this.bdsDanhsachsukien;
            this.gcDanhsachsukien.Location = new System.Drawing.Point(0, 180);
            this.gcDanhsachsukien.MainView = this.gridView1;
            this.gcDanhsachsukien.Name = "gcDanhsachsukien";
            this.gcDanhsachsukien.Size = new System.Drawing.Size(905, 259);
            this.gcDanhsachsukien.TabIndex = 10;
            this.gcDanhsachsukien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMasukien,
            this.colTensukien,
            this.colNgaybatdau,
            this.colNgayketthuc});
            this.gridView1.GridControl = this.gcDanhsachsukien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colMasukien
            // 
            this.colMasukien.Caption = "Mã sự kiện";
            this.colMasukien.FieldName = "Masukien";
            this.colMasukien.Name = "colMasukien";
            this.colMasukien.Visible = true;
            this.colMasukien.VisibleIndex = 1;
            // 
            // colTensukien
            // 
            this.colTensukien.Caption = "Tên sự kiện";
            this.colTensukien.FieldName = "Tensukien";
            this.colTensukien.Name = "colTensukien";
            this.colTensukien.Visible = true;
            this.colTensukien.VisibleIndex = 2;
            // 
            // colNgaybatdau
            // 
            this.colNgaybatdau.Caption = "Ngày bắt đầu";
            this.colNgaybatdau.FieldName = "Ngaybatdau";
            this.colNgaybatdau.Name = "colNgaybatdau";
            this.colNgaybatdau.Visible = true;
            this.colNgaybatdau.VisibleIndex = 3;
            // 
            // colNgayketthuc
            // 
            this.colNgayketthuc.Caption = "Ngày kết thúc";
            this.colNgayketthuc.FieldName = "Ngayketthuc";
            this.colNgayketthuc.Name = "colNgayketthuc";
            this.colNgayketthuc.Visible = true;
            this.colNgayketthuc.VisibleIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDanhsachsukien, "Noidung", true));
            this.textEdit1.Location = new System.Drawing.Point(97, 102);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(568, 22);
            this.textEdit1.TabIndex = 11;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nội Dung";
            // 
            // UcKhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gcDanhsachsukien);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcKhuyenmai";
            this.Size = new System.Drawing.Size(905, 439);
            this.Load += new System.EventHandler(this.UcKhuyenmai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhsachsukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachsukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsDanhsachsukien;
        private DevExpress.XtraGrid.GridControl gcDanhsachsukien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMasukien;
        private DevExpress.XtraGrid.Columns.GridColumn colTensukien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaybatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayketthuc;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
    }
}
