namespace QuanLyCuaHangDienThoai.User_control_Admin
{
    partial class ucLienHe
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
            this.lbl_diachi = new DevExpress.XtraEditors.LabelControl();
            this.lbl_dt = new DevExpress.XtraEditors.LabelControl();
            this.lbl_email = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(976, 63);
            this.panelControl1.TabIndex = 10;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(276, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(153, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "LIÊN HỆ";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(12, 88);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(399, 19);
            this.lbl_diachi.TabIndex = 11;
            this.lbl_diachi.Text = "Địa chỉ : 80/10 CMT8.Phường 3 . Quận 10.TPHCM";
            this.lbl_diachi.Click += new System.EventHandler(this.lbl_lienhe_Click);
            // 
            // lbl_dt
            // 
            this.lbl_dt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dt.Location = new System.Drawing.Point(12, 136);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(210, 19);
            this.lbl_dt.TabIndex = 12;
            this.lbl_dt.Text = "Điện thoại : 01262532557";
            // 
            // lbl_email
            // 
            this.lbl_email.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 185);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(225, 19);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email : tientran@gmail.com";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(535, 83);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(255, 121);
            this.pictureEdit1.TabIndex = 14;
            // 
            // ucLienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucLienHe";
            this.Size = new System.Drawing.Size(976, 347);
            this.Load += new System.EventHandler(this.ucLienHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_diachi;
        private DevExpress.XtraEditors.LabelControl lbl_dt;
        private DevExpress.XtraEditors.LabelControl lbl_email;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
