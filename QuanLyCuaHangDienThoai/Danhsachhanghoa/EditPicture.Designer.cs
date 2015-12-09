namespace QuanLyCuaHangDienThoai
{
    partial class EditPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPicture));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btbOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtimage = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(157, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btbOpenFile
            // 
            this.btbOpenFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOpenFile.Appearance.Options.UseFont = true;
            this.btbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btbOpenFile.Image")));
            this.btbOpenFile.Location = new System.Drawing.Point(32, 336);
            this.btbOpenFile.Name = "btbOpenFile";
            this.btbOpenFile.Size = new System.Drawing.Size(115, 45);
            this.btbOpenFile.TabIndex = 6;
            this.btbOpenFile.Text = "Open File";
            this.btbOpenFile.Click += new System.EventHandler(this.btbOpenFile_Click);
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(2, 362);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(21, 20);
            this.txtimage.TabIndex = 4;
            this.txtimage.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(26, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 321);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // EditPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 385);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btbOpenFile);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.pictureBox);
            this.Name = "EditPicture";
            this.Text = "Sửa Ảnh";
            this.Load += new System.EventHandler(this.EditPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btbOpenFile;
        private System.Windows.Forms.TextBox txtimage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}