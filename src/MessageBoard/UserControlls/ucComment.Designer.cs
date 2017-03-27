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
            this.richCommentContent = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.btnQuote = new DevExpress.XtraEditors.SimpleButton();
            this.pnlInfoComment = new DevExpress.XtraEditors.PanelControl();
            this.imgProfilePicture = new DevExpress.XtraEditors.PictureEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).BeginInit();
            this.grpComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfoComment)).BeginInit();
            this.pnlInfoComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpComment
            // 
            this.grpComment.Appearance.BackColor = System.Drawing.Color.White;
            this.grpComment.Appearance.Options.UseBackColor = true;
            this.grpComment.Controls.Add(this.richCommentContent);
            this.grpComment.Controls.Add(this.btnQuote);
            this.grpComment.Controls.Add(this.pnlInfoComment);
            this.grpComment.Location = new System.Drawing.Point(2, 3);
            this.grpComment.Name = "grpComment";
            this.grpComment.Size = new System.Drawing.Size(541, 181);
            this.grpComment.TabIndex = 0;
            this.grpComment.Text = "Date";
            // 
            // richCommentContent
            // 
            this.richCommentContent.Location = new System.Drawing.Point(172, 24);
            this.richCommentContent.Name = "richCommentContent";
            this.richCommentContent.Size = new System.Drawing.Size(339, 122);
            this.richCommentContent.TabIndex = 3;
            this.richCommentContent.Text = "";
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(436, 152);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Quote";
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // pnlInfoComment
            // 
            this.pnlInfoComment.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlInfoComment.Appearance.Options.UseBackColor = true;
            this.pnlInfoComment.Controls.Add(this.imgProfilePicture);
            this.pnlInfoComment.Controls.Add(this.lblUsername);
            this.pnlInfoComment.Location = new System.Drawing.Point(0, 23);
            this.pnlInfoComment.Name = "pnlInfoComment";
            this.pnlInfoComment.Size = new System.Drawing.Size(166, 123);
            this.pnlInfoComment.TabIndex = 0;
            // 
            // imgProfilePicture
            // 
            this.imgProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProfilePicture.Enabled = false;
            this.imgProfilePicture.Location = new System.Drawing.Point(5, 20);
            this.imgProfilePicture.Name = "imgProfilePicture";
            this.imgProfilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgProfilePicture.Properties.ZoomAccelerationFactor = 1D;
            this.imgProfilePicture.Size = new System.Drawing.Size(100, 96);
            this.imgProfilePicture.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(6, 1);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // ucComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpComment);
            this.Name = "ucComment";
            this.Size = new System.Drawing.Size(543, 184);
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).EndInit();
            this.grpComment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfoComment)).EndInit();
            this.pnlInfoComment.ResumeLayout(false);
            this.pnlInfoComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpComment;
        private DevExpress.XtraEditors.PanelControl pnlInfoComment;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.SimpleButton btnQuote;
        private DevExpress.XtraEditors.PictureEdit imgProfilePicture;
        private DevExpress.Tutorials.Controls.RichTextBoxEx richCommentContent;
    }
}
