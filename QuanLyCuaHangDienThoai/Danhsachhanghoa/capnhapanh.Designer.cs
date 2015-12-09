namespace QuanLyCuaHangDienThoai
{
    partial class capnhapanh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(capnhapanh));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtimage = new System.Windows.Forms.TextBox();
            this.btbOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(20, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 318);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(4, 355);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(21, 20);
            this.txtimage.TabIndex = 1;
            this.txtimage.Visible = false;
            // 
            // btbOpenFile
            // 
            this.btbOpenFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOpenFile.Appearance.Options.UseFont = true;
            this.btbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btbOpenFile.Image")));
            this.btbOpenFile.Location = new System.Drawing.Point(30, 334);
            this.btbOpenFile.Name = "btbOpenFile";
            this.btbOpenFile.Size = new System.Drawing.Size(123, 48);
            this.btbOpenFile.TabIndex = 2;
            this.btbOpenFile.Text = "Open File";
            this.btbOpenFile.Click += new System.EventHandler(this.btbOpenFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(159, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // capnhapanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 386);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btbOpenFile);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.pictureBox);
            this.Name = "capnhapanh";
            this.Text = "Cập nhập ảnh mới";
            this.Load += new System.EventHandler(this.capnhapanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtimage;
        private DevExpress.XtraEditors.SimpleButton btbOpenFile;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}