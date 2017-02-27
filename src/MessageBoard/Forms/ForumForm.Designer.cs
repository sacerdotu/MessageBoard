namespace MessageBoard.Forms
{
    partial class ForumForm
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
            this.btnAddPost = new DevExpress.XtraEditors.SimpleButton();
            this.grdDisplayPosts = new DevExpress.XtraGrid.GridControl();
            this.viewDisplayPosts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPostText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPublished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(611, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPost.Location = new System.Drawing.Point(611, 310);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(93, 25);
            this.btnAddPost.TabIndex = 1;
            this.btnAddPost.Text = "Add post";
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // grdDisplayPosts
            // 
            this.grdDisplayPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDisplayPosts.Location = new System.Drawing.Point(0, 0);
            this.grdDisplayPosts.MainView = this.viewDisplayPosts;
            this.grdDisplayPosts.Name = "grdDisplayPosts";
            this.grdDisplayPosts.Size = new System.Drawing.Size(716, 304);
            this.grdDisplayPosts.TabIndex = 2;
            this.grdDisplayPosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDisplayPosts});
            // 
            // viewDisplayPosts
            // 
            this.viewDisplayPosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPostText,
            this.colIsPublished,
            this.colCreationDate,
            this.colName,
            this.colUsername,
            this.colCommentDate});
            this.viewDisplayPosts.GridControl = this.grdDisplayPosts;
            this.viewDisplayPosts.Name = "viewDisplayPosts";
            this.viewDisplayPosts.OptionsView.ShowAutoFilterRow = true;
            this.viewDisplayPosts.OptionsView.ShowGroupPanel = false;
            this.viewDisplayPosts.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.viewDisplayPosts_CustomUnboundColumnData);
            // 
            // colPostText
            // 
            this.colPostText.FieldName = "PostText";
            this.colPostText.Name = "colPostText";
            this.colPostText.Visible = true;
            this.colPostText.VisibleIndex = 0;
            // 
            // colIsPublished
            // 
            this.colIsPublished.FieldName = "IsPublished";
            this.colIsPublished.Name = "colIsPublished";
            this.colIsPublished.Visible = true;
            this.colIsPublished.VisibleIndex = 1;
            // 
            // colCreationDate
            // 
            this.colCreationDate.Caption = "Post creation date";
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.Caption = "Full Name";
            this.colName.FieldName = "tblUser.FullName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "tblUser.Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 4;
            // 
            // colCommentDate
            // 
            this.colCommentDate.Caption = "Last comment date";
            this.colCommentDate.FieldName = "CommentDate";
            this.colCommentDate.Name = "colCommentDate";
            this.colCommentDate.OptionsColumn.AllowEdit = false;
            this.colCommentDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colCommentDate.Visible = true;
            this.colCommentDate.VisibleIndex = 5;
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 378);
            this.Controls.Add(this.grdDisplayPosts);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.btnBack);
            this.Name = "ForumForm";
            this.Text = "ForumForm";
            this.Load += new System.EventHandler(this.ForumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnAddPost;
        private DevExpress.XtraGrid.GridControl grdDisplayPosts;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDisplayPosts;
        private DevExpress.XtraGrid.Columns.GridColumn colPostText;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPublished;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colCommentDate;
    }
}