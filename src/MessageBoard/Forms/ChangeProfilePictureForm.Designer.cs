namespace MessageBoard.Forms
{
    partial class ChangeProfilePictureForm
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
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.lblChangeProfilePicture = new DevExpress.XtraEditors.LabelControl();
            this.imgProfilePicture = new DevExpress.XtraEditors.PictureEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Appearance.Options.UseBackColor = true;
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Appearance.Options.UseForeColor = true;
            this.btnBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(139, 210);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(139, 34);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblChangeProfilePicture
            // 
            this.lblChangeProfilePicture.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeProfilePicture.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblChangeProfilePicture.Appearance.Options.UseFont = true;
            this.lblChangeProfilePicture.Appearance.Options.UseForeColor = true;
            this.lblChangeProfilePicture.Location = new System.Drawing.Point(10, 12);
            this.lblChangeProfilePicture.Name = "lblChangeProfilePicture";
            this.lblChangeProfilePicture.Size = new System.Drawing.Size(409, 45);
            this.lblChangeProfilePicture.TabIndex = 27;
            this.lblChangeProfilePicture.Text = "Change profile picture";
            // 
            // imgProfilePicture
            // 
            this.imgProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProfilePicture.Location = new System.Drawing.Point(139, 86);
            this.imgProfilePicture.Name = "imgProfilePicture";
            this.imgProfilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgProfilePicture.Properties.ZoomAccelerationFactor = 1D;
            this.imgProfilePicture.Size = new System.Drawing.Size(139, 118);
            this.imgProfilePicture.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(139, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 34);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangeProfilePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 323);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.imgProfilePicture);
            this.Controls.Add(this.lblChangeProfilePicture);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeProfilePictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeProfilePictureForm";
            this.Load += new System.EventHandler(this.ChangeProfilePictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LabelControl lblChangeProfilePicture;
        private DevExpress.XtraEditors.PictureEdit imgProfilePicture;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}