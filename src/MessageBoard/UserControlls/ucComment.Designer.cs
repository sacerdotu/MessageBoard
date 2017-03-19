namespace MessageBoard.UserControlls
{
    partial class ucComment
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
            this.grpComment = new DevExpress.XtraEditors.GroupControl();
            this.pnlInfoComment = new DevExpress.XtraEditors.PanelControl();
            this.pnlCommentContent = new DevExpress.XtraEditors.PanelControl();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.btnQuote = new DevExpress.XtraEditors.SimpleButton();
            this.lblCommentContent = new DevExpress.XtraEditors.LabelControl();
            this.imgProfilePicture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).BeginInit();
            this.grpComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfoComment)).BeginInit();
            this.pnlInfoComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommentContent)).BeginInit();
            this.pnlCommentContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpComment
            // 
            this.grpComment.Controls.Add(this.btnQuote);
            this.grpComment.Controls.Add(this.pnlCommentContent);
            this.grpComment.Controls.Add(this.pnlInfoComment);
            this.grpComment.Location = new System.Drawing.Point(3, 3);
            this.grpComment.Name = "grpComment";
            this.grpComment.Size = new System.Drawing.Size(539, 383);
            this.grpComment.TabIndex = 0;
            this.grpComment.Text = "Date";
            // 
            // pnlInfoComment
            // 
            this.pnlInfoComment.Controls.Add(this.imgProfilePicture);
            this.pnlInfoComment.Controls.Add(this.lblUsername);
            this.pnlInfoComment.Location = new System.Drawing.Point(0, 23);
            this.pnlInfoComment.Name = "pnlInfoComment";
            this.pnlInfoComment.Size = new System.Drawing.Size(166, 326);
            this.pnlInfoComment.TabIndex = 0;
            // 
            // pnlCommentContent
            // 
            this.pnlCommentContent.Controls.Add(this.lblCommentContent);
            this.pnlCommentContent.Location = new System.Drawing.Point(172, 23);
            this.pnlCommentContent.Name = "pnlCommentContent";
            this.pnlCommentContent.Size = new System.Drawing.Size(360, 326);
            this.pnlCommentContent.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(6, 1);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(464, 355);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Quote";
            // 
            // lblCommentContent
            // 
            this.lblCommentContent.Location = new System.Drawing.Point(5, 5);
            this.lblCommentContent.Name = "lblCommentContent";
            this.lblCommentContent.Size = new System.Drawing.Size(87, 13);
            this.lblCommentContent.TabIndex = 1;
            this.lblCommentContent.Text = "Comment Content";
            // 
            // imgProfilePicture
            // 
            this.imgProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProfilePicture.Enabled = false;
            this.imgProfilePicture.Location = new System.Drawing.Point(5, 20);
            this.imgProfilePicture.Name = "imgProfilePicture";
            this.imgProfilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgProfilePicture.Properties.ZoomAccelerationFactor = 1D;
            this.imgProfilePicture.Size = new System.Drawing.Size(100, 96);
            this.imgProfilePicture.TabIndex = 1;
            // 
            // ucComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpComment);
            this.Name = "ucComment";
            this.Size = new System.Drawing.Size(545, 389);
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).EndInit();
            this.grpComment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfoComment)).EndInit();
            this.pnlInfoComment.ResumeLayout(false);
            this.pnlInfoComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommentContent)).EndInit();
            this.pnlCommentContent.ResumeLayout(false);
            this.pnlCommentContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpComment;
        private DevExpress.XtraEditors.PanelControl pnlCommentContent;
        private DevExpress.XtraEditors.PanelControl pnlInfoComment;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.SimpleButton btnQuote;
        private DevExpress.XtraEditors.LabelControl lblCommentContent;
        private DevExpress.XtraEditors.PictureEdit imgProfilePicture;
    }
}
