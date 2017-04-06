namespace MessageBoard.Forms
{
    partial class CommentsForm
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.panelPost = new DevExpress.XtraEditors.PanelControl();
            this.imgPost = new DevExpress.XtraEditors.PictureEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.richPostContent = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.lblPost = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthor = new DevExpress.XtraEditors.LabelControl();
            this.panelCommnets = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ucComments = new MessageBoard.UserControlls.ucComment();
            this.pnlbuttons = new DevExpress.XtraEditors.PanelControl();
            this.btnReplyPost = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelPost)).BeginInit();
            this.panelPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPost.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCommnets)).BeginInit();
            this.panelCommnets.SuspendLayout();
            this.xtraScrollableControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlbuttons)).BeginInit();
            this.pnlbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBack.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseBorderColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBack.Location = new System.Drawing.Point(6, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPost
            // 
            this.panelPost.Appearance.BackColor = System.Drawing.Color.Teal;
            this.panelPost.Appearance.Options.UseBackColor = true;
            this.panelPost.Controls.Add(this.imgPost);
            this.panelPost.Controls.Add(this.xtraScrollableControl1);
            this.panelPost.Controls.Add(this.lblDate);
            this.panelPost.Controls.Add(this.lblAuthor);
            this.panelPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPost.Location = new System.Drawing.Point(0, 0);
            this.panelPost.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelPost.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(571, 141);
            this.panelPost.TabIndex = 2;
            // 
            // imgPost
            // 
            this.imgPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgPost.Location = new System.Drawing.Point(5, 39);
            this.imgPost.Name = "imgPost";
            this.imgPost.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgPost.Properties.ZoomAccelerationFactor = 1D;
            this.imgPost.Size = new System.Drawing.Size(100, 96);
            this.imgPost.TabIndex = 4;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.Teal;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.richPostContent);
            this.xtraScrollableControl1.Controls.Add(this.lblPost);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(145, 5);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(422, 130);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // richPostContent
            // 
            this.richPostContent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richPostContent.Location = new System.Drawing.Point(0, 34);
            this.richPostContent.Name = "richPostContent";
            this.richPostContent.Size = new System.Drawing.Size(400, 96);
            this.richPostContent.TabIndex = 1;
            this.richPostContent.Text = "";
            // 
            // lblPost
            // 
            this.lblPost.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPost.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPost.Appearance.Options.UseBackColor = true;
            this.lblPost.Appearance.Options.UseFont = true;
            this.lblPost.Appearance.Options.UseForeColor = true;
            this.lblPost.Location = new System.Drawing.Point(0, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(40, 23);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "Post";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Location = new System.Drawing.Point(5, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(27, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblAuthor.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Appearance.Options.UseFont = true;
            this.lblAuthor.Appearance.Options.UseForeColor = true;
            this.lblAuthor.Location = new System.Drawing.Point(5, 5);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // panelCommnets
            // 
            this.panelCommnets.Controls.Add(this.xtraScrollableControl);
            this.panelCommnets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommnets.Location = new System.Drawing.Point(0, 141);
            this.panelCommnets.Name = "panelCommnets";
            this.panelCommnets.Size = new System.Drawing.Size(571, 326);
            this.panelCommnets.TabIndex = 3;
            // 
            // xtraScrollableControl
            // 
            this.xtraScrollableControl.Appearance.BackColor = System.Drawing.Color.Teal;
            this.xtraScrollableControl.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl.Controls.Add(this.ucComments);
            this.xtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl.Name = "xtraScrollableControl";
            this.xtraScrollableControl.Size = new System.Drawing.Size(567, 322);
            this.xtraScrollableControl.TabIndex = 0;
            // 
            // ucComments
            // 
            this.ucComments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucComments.CommentID = 0;
            this.ucComments.Location = new System.Drawing.Point(-2, 26);
            this.ucComments.Name = "ucComments";
            this.ucComments.Size = new System.Drawing.Size(569, 195);
            this.ucComments.TabIndex = 0;
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.Appearance.BackColor = System.Drawing.Color.Teal;
            this.pnlbuttons.Appearance.Options.UseBackColor = true;
            this.pnlbuttons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pnlbuttons.Controls.Add(this.btnReplyPost);
            this.pnlbuttons.Controls.Add(this.btnBack);
            this.pnlbuttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbuttons.Location = new System.Drawing.Point(0, 467);
            this.pnlbuttons.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlbuttons.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(571, 46);
            this.pnlbuttons.TabIndex = 4;
            // 
            // btnReplyPost
            // 
            this.btnReplyPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplyPost.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnReplyPost.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnReplyPost.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyPost.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReplyPost.Appearance.Options.UseBackColor = true;
            this.btnReplyPost.Appearance.Options.UseBorderColor = true;
            this.btnReplyPost.Appearance.Options.UseFont = true;
            this.btnReplyPost.Appearance.Options.UseForeColor = true;
            this.btnReplyPost.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnReplyPost.Location = new System.Drawing.Point(472, 11);
            this.btnReplyPost.Name = "btnReplyPost";
            this.btnReplyPost.Size = new System.Drawing.Size(93, 25);
            this.btnReplyPost.TabIndex = 2;
            this.btnReplyPost.Text = "Reply Post";
            this.btnReplyPost.Click += new System.EventHandler(this.btnReplyPost_Click);
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 508);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.panelCommnets);
            this.Controls.Add(this.panelPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelPost)).EndInit();
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPost.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCommnets)).EndInit();
            this.panelCommnets.ResumeLayout(false);
            this.xtraScrollableControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlbuttons)).EndInit();
            this.pnlbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.PanelControl panelPost;
        private DevExpress.XtraEditors.PanelControl panelCommnets;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblAuthor;
        private DevExpress.XtraEditors.LabelControl lblPost;
        private UserControlls.ucComment ucComments;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl pnlbuttons;
        private DevExpress.XtraEditors.SimpleButton btnReplyPost;
        private DevExpress.XtraEditors.PictureEdit imgPost;
        private DevExpress.Tutorials.Controls.RichTextBoxEx richPostContent;
    }
}