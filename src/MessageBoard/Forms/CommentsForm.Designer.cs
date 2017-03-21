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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
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
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPost
            // 
            this.panelPost.Controls.Add(this.xtraScrollableControl1);
            this.panelPost.Controls.Add(this.lblDate);
            this.panelPost.Controls.Add(this.lblAuthor);
            this.panelPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPost.Location = new System.Drawing.Point(0, 0);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(571, 83);
            this.panelPost.TabIndex = 2;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.lblPost);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(145, 5);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(422, 72);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // lblPost
            // 
            this.lblPost.Location = new System.Drawing.Point(3, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(21, 13);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "Post";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(5, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(5, 5);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(33, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // panelCommnets
            // 
            this.panelCommnets.Controls.Add(this.xtraScrollableControl);
            this.panelCommnets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommnets.Location = new System.Drawing.Point(0, 83);
            this.panelCommnets.Name = "panelCommnets";
            this.panelCommnets.Size = new System.Drawing.Size(571, 379);
            this.panelCommnets.TabIndex = 3;
            // 
            // xtraScrollableControl
            // 
            this.xtraScrollableControl.Controls.Add(this.ucComments);
            this.xtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl.Name = "xtraScrollableControl";
            this.xtraScrollableControl.Size = new System.Drawing.Size(567, 375);
            this.xtraScrollableControl.TabIndex = 0;
            // 
            // ucComments
            // 
            this.ucComments.Location = new System.Drawing.Point(0, 3);
            this.ucComments.Name = "ucComments";
            this.ucComments.Size = new System.Drawing.Size(549, 397);
            this.ucComments.TabIndex = 0;
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.Controls.Add(this.btnReplyPost);
            this.pnlbuttons.Controls.Add(this.btnBack);
            this.pnlbuttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbuttons.Location = new System.Drawing.Point(0, 462);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(571, 50);
            this.pnlbuttons.TabIndex = 4;
            // 
            // btnReplyPost
            // 
            this.btnReplyPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplyPost.Location = new System.Drawing.Point(473, 15);
            this.btnReplyPost.Name = "btnReplyPost";
            this.btnReplyPost.Size = new System.Drawing.Size(93, 25);
            this.btnReplyPost.TabIndex = 2;
            this.btnReplyPost.Text = "Reply Post";
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 508);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.panelCommnets);
            this.Controls.Add(this.panelPost);
            this.MaximizeBox = false;
            this.Name = "CommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelPost)).EndInit();
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
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
    }
}