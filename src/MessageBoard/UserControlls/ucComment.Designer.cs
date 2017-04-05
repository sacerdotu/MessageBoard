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
            this.imgProfilePicture = new DevExpress.XtraEditors.PictureEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.richCommentContent = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.btnQuote = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpComment)).BeginInit();
            this.grpComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfoComment)).BeginInit();
            this.pnlInfoComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpComment
            // 
            this.grpComment.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpComment.Appearance.Options.UseBackColor = true;
            this.grpComment.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.grpComment.Controls.Add(this.pnlInfoComment);
            this.grpComment.Controls.Add(this.richCommentContent);
            this.grpComment.Controls.Add(this.btnQuote);
            this.grpComment.Location = new System.Drawing.Point(0, 3);
            this.grpComment.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.grpComment.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grpComment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grpComment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grpComment.Name = "grpComment";
            this.grpComment.Size = new System.Drawing.Size(541, 184);
            this.grpComment.TabIndex = 0;
            this.grpComment.Text = "Date";
            // 
            // pnlInfoComment
            // 
            this.pnlInfoComment.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlInfoComment.Appearance.Options.UseBackColor = true;
            this.pnlInfoComment.Controls.Add(this.imgProfilePicture);
            this.pnlInfoComment.Controls.Add(this.lblUsername);
            this.pnlInfoComment.Location = new System.Drawing.Point(5, 24);
            this.pnlInfoComment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlInfoComment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlInfoComment.Name = "pnlInfoComment";
            this.pnlInfoComment.Size = new System.Drawing.Size(166, 122);
            this.pnlInfoComment.TabIndex = 0;
            // 
            // imgProfilePicture
            // 
            this.imgProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProfilePicture.Enabled = false;
            this.imgProfilePicture.Location = new System.Drawing.Point(0, 22);
            this.imgProfilePicture.Name = "imgProfilePicture";
            this.imgProfilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgProfilePicture.Properties.ZoomAccelerationFactor = 1D;
            this.imgProfilePicture.Size = new System.Drawing.Size(100, 95);
            this.imgProfilePicture.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(6, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // richCommentContent
            // 
            this.richCommentContent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richCommentContent.Location = new System.Drawing.Point(172, 24);
            this.richCommentContent.Name = "richCommentContent";
            this.richCommentContent.Size = new System.Drawing.Size(339, 122);
            this.richCommentContent.TabIndex = 3;
            this.richCommentContent.Text = "";
            // 
            // btnQuote
            // 
            this.btnQuote.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnQuote.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnQuote.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnQuote.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnQuote.Appearance.Options.UseBackColor = true;
            this.btnQuote.Appearance.Options.UseBorderColor = true;
            this.btnQuote.Appearance.Options.UseFont = true;
            this.btnQuote.Appearance.Options.UseForeColor = true;
            this.btnQuote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnQuote.Location = new System.Drawing.Point(436, 152);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Quote";
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // ucComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
