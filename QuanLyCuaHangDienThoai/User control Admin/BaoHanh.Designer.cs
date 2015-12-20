namespace QuanLyCuaHangDienThoai.User_control_Admin
{
    partial class BaoHanh
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_suco = new DevExpress.XtraEditors.LabelControl();
            this.lbl_masp = new DevExpress.XtraEditors.LabelControl();
            this.text_masp = new DevExpress.XtraEditors.TextEdit();
            this.text_suco = new DevExpress.XtraEditors.TextEdit();
            this.dateTime_thoidiem = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_masp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_suco.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(675, 63);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(125, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BẢO HÀNH";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(195, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Thời điểm xảy ra sự cố :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // lbl_suco
            // 
            this.lbl_suco.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suco.Location = new System.Drawing.Point(20, 153);
            this.lbl_suco.Name = "lbl_suco";
            this.lbl_suco.Size = new System.Drawing.Size(55, 19);
            this.lbl_suco.TabIndex = 12;
            this.lbl_suco.Text = "Sự cố :";
            // 
            // lbl_masp
            // 
            this.lbl_masp.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masp.Location = new System.Drawing.Point(20, 88);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(118, 19);
            this.lbl_masp.TabIndex = 13;
            this.lbl_masp.Text = "Mã sản phẩm :";
            // 
            // text_masp
            // 
            this.text_masp.Location = new System.Drawing.Point(287, 90);
            this.text_masp.Name = "text_masp";
            this.text_masp.Size = new System.Drawing.Size(283, 20);
            this.text_masp.TabIndex = 14;
            // 
            // text_suco
            // 
            this.text_suco.Location = new System.Drawing.Point(287, 142);
            this.text_suco.Name = "text_suco";
            this.text_suco.Size = new System.Drawing.Size(283, 20);
            this.text_suco.TabIndex = 15;
            this.text_suco.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // dateTime_thoidiem
            // 
            this.dateTime_thoidiem.Location = new System.Drawing.Point(287, 208);
            this.dateTime_thoidiem.Name = "dateTime_thoidiem";
            this.dateTime_thoidiem.Size = new System.Drawing.Size(283, 20);
            this.dateTime_thoidiem.TabIndex = 16;
            // 
            // BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTime_thoidiem);
            this.Controls.Add(this.text_suco);
            this.Controls.Add(this.text_masp);
            this.Controls.Add(this.lbl_masp);
            this.Controls.Add(this.lbl_suco);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BaoHanh";
            this.Size = new System.Drawing.Size(675, 305);
            this.Load += new System.EventHandler(this.BaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_masp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_suco.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_suco;
        private DevExpress.XtraEditors.LabelControl lbl_masp;
        private DevExpress.XtraEditors.TextEdit text_masp;
        private DevExpress.XtraEditors.TextEdit text_suco;
        private System.Windows.Forms.DateTimePicker dateTime_thoidiem;
    }
}
