namespace QuanLyCuaHangDienThoai.User_control
{
    partial class ucTinnhanAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTinnhanAd));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bdsTinnhanAd = new System.Windows.Forms.BindingSource(this.components);
            this.gcTinnhanAd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatinnhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTieude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoigui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaygui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTinnhanAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTinnhanAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(437, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 45);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "TIN NHẮN ";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(103, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1046, 78);
            this.panelControl1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Location = new System.Drawing.Point(3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 78);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // bdsTinnhanAd
            // 
            this.bdsTinnhanAd.DataSource = typeof(DataAccess.TinnhanAd);
            // 
            // gcTinnhanAd
            // 
            this.gcTinnhanAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTinnhanAd.DataSource = this.bdsTinnhanAd;
            this.gcTinnhanAd.Location = new System.Drawing.Point(0, 172);
            this.gcTinnhanAd.MainView = this.gridView1;
            this.gcTinnhanAd.Name = "gcTinnhanAd";
            this.gcTinnhanAd.Size = new System.Drawing.Size(1043, 347);
            this.gcTinnhanAd.TabIndex = 12;
            this.gcTinnhanAd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstt,
            this.colMatinnhan,
            this.colTieude,
            this.colNoidung,
            this.colNguoigui,
            this.colNgaygui});
            this.gridView1.GridControl = this.gcTinnhanAd;
            this.gridView1.Name = "gridView1";
            // 
            // colstt
            // 
            this.colstt.FieldName = "stt";
            this.colstt.Name = "colstt";
            this.colstt.Visible = true;
            this.colstt.VisibleIndex = 0;
            // 
            // colMatinnhan
            // 
            this.colMatinnhan.FieldName = "Matinnhan";
            this.colMatinnhan.Name = "colMatinnhan";
            this.colMatinnhan.Visible = true;
            this.colMatinnhan.VisibleIndex = 1;
            // 
            // colTieude
            // 
            this.colTieude.FieldName = "Tieude";
            this.colTieude.Name = "colTieude";
            this.colTieude.Visible = true;
            this.colTieude.VisibleIndex = 2;
            // 
            // colNoidung
            // 
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 3;
            // 
            // colNguoigui
            // 
            this.colNguoigui.FieldName = "Nguoigui";
            this.colNguoigui.Name = "colNguoigui";
            this.colNguoigui.Visible = true;
            this.colNguoigui.VisibleIndex = 4;
            // 
            // colNgaygui
            // 
            this.colNgaygui.FieldName = "Ngaygui";
            this.colNgaygui.Name = "colNgaygui";
            this.colNgaygui.Visible = true;
            this.colNgaygui.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(15, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Trả lời";
            // 
            // ucTinnhanAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcTinnhanAd);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucTinnhanAd";
            this.Size = new System.Drawing.Size(1046, 519);
            this.Load += new System.EventHandler(this.ucTinnhanAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTinnhanAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTinnhanAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource bdsTinnhanAd;
        private DevExpress.XtraGrid.GridControl gcTinnhanAd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn colMatinnhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTieude;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoigui;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaygui;
    }
}
