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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPost = new DevExpress.XtraEditors.SimpleButton();
            this.grdDisplayPosts = new DevExpress.XtraGrid.GridControl();
            this.viewDisplayPosts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPostText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPublished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCommentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCommentDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMainMenu = new DevExpress.XtraBars.Bar();
            this.barMenu = new DevExpress.XtraBars.BarSubItem();
            this.barChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barChangeProfilePicture = new DevExpress.XtraBars.BarButtonItem();
            this.barUserInformations = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.grdDisplayPosts.Location = new System.Drawing.Point(0, 28);
            this.grdDisplayPosts.MainView = this.viewDisplayPosts;
            this.grdDisplayPosts.Name = "grdDisplayPosts";
            this.grdDisplayPosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCommentDate});
            this.grdDisplayPosts.Size = new System.Drawing.Size(716, 276);
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
            this.colLastCommentDate});
            this.viewDisplayPosts.GridControl = this.grdDisplayPosts;
            this.viewDisplayPosts.Name = "viewDisplayPosts";
            this.viewDisplayPosts.OptionsView.ShowAutoFilterRow = true;
            this.viewDisplayPosts.OptionsView.ShowGroupPanel = false;
            this.viewDisplayPosts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewDisplayPosts_RowClick);
            this.viewDisplayPosts.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.viewDisplayPosts_CustomRowCellEdit);
            // 
            // colPostText
            // 
            this.colPostText.DisplayFormat.FormatString = "d";
            this.colPostText.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPostText.FieldName = "PostText";
            this.colPostText.Name = "colPostText";
            this.colPostText.OptionsColumn.AllowEdit = false;
            this.colPostText.OptionsColumn.ReadOnly = true;
            this.colPostText.Visible = true;
            this.colPostText.VisibleIndex = 0;
            // 
            // colIsPublished
            // 
            this.colIsPublished.FieldName = "IsPublished";
            this.colIsPublished.Name = "colIsPublished";
            this.colIsPublished.OptionsColumn.AllowEdit = false;
            this.colIsPublished.OptionsColumn.ReadOnly = true;
            this.colIsPublished.Visible = true;
            this.colIsPublished.VisibleIndex = 1;
            // 
            // colCreationDate
            // 
            this.colCreationDate.Caption = "Post creation date";
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.OptionsColumn.AllowEdit = false;
            this.colCreationDate.OptionsColumn.ReadOnly = true;
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.Caption = "Full Name";
            this.colName.FieldName = "tblUser.FullName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "tblUser.Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.AllowEdit = false;
            this.colUsername.OptionsColumn.ReadOnly = true;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 4;
            // 
            // colLastCommentDate
            // 
            this.colLastCommentDate.Caption = "Last Comment Date";
            this.colLastCommentDate.DisplayFormat.FormatString = "d";
            this.colLastCommentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastCommentDate.FieldName = "LastCommentDate";
            this.colLastCommentDate.GroupFormat.FormatString = "d";
            this.colLastCommentDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastCommentDate.Name = "colLastCommentDate";
            this.colLastCommentDate.OptionsColumn.AllowEdit = false;
            this.colLastCommentDate.OptionsColumn.ReadOnly = true;
            this.colLastCommentDate.Visible = true;
            this.colLastCommentDate.VisibleIndex = 5;
            // 
            // repCommentDate
            // 
            this.repCommentDate.AutoHeight = false;
            this.repCommentDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCommentDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCommentDate.Name = "repCommentDate";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMainMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMenu,
            this.barChangePassword,
            this.barUserInformations,
            this.barChangeProfilePicture});
            this.barManager1.MainMenu = this.barMainMenu;
            this.barManager1.MaxItemId = 4;
            // 
            // barMainMenu
            // 
            this.barMainMenu.BarName = "Main menu";
            this.barMainMenu.DockCol = 0;
            this.barMainMenu.DockRow = 0;
            this.barMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMainMenu.FloatLocation = new System.Drawing.Point(430, 137);
            this.barMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMenu)});
            this.barMainMenu.OptionsBar.AllowQuickCustomization = false;
            this.barMainMenu.OptionsBar.DisableCustomization = true;
            this.barMainMenu.OptionsBar.DrawDragBorder = false;
            this.barMainMenu.OptionsBar.UseWholeRow = true;
            this.barMainMenu.Text = "Main menu";
            // 
            // barMenu
            // 
            this.barMenu.Caption = "Menu";
            this.barMenu.Id = 0;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barChangePassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.barChangeProfilePicture),
            new DevExpress.XtraBars.LinkPersistInfo(this.barUserInformations)});
            this.barMenu.Name = "barMenu";
            // 
            // barChangePassword
            // 
            this.barChangePassword.Caption = "Change Password";
            this.barChangePassword.Id = 1;
            this.barChangePassword.Name = "barChangePassword";
            this.barChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barChangePassword_ItemClick);
            // 
            // barChangeProfilePicture
            // 
            this.barChangeProfilePicture.Caption = "Change Profile Picture";
            this.barChangeProfilePicture.Id = 3;
            this.barChangeProfilePicture.Name = "barChangeProfilePicture";
            this.barChangeProfilePicture.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barChangeProfilePicture_ItemClick);
            // 
            // barUserInformations
            // 
            this.barUserInformations.Caption = "User Informations";
            this.barUserInformations.Id = 2;
            this.barUserInformations.Name = "barUserInformations";
            this.barUserInformations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUserInformations_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(716, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 378);
            this.barDockControlBottom.Size = new System.Drawing.Size(716, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 356);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(716, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 356);
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 378);
            this.Controls.Add(this.grdDisplayPosts);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ForumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForumForm";
            this.Load += new System.EventHandler(this.ForumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repCommentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCommentDate;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barMainMenu;
        private DevExpress.XtraBars.BarSubItem barMenu;
        private DevExpress.XtraBars.BarButtonItem barChangePassword;
        private DevExpress.XtraBars.BarButtonItem barUserInformations;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barChangeProfilePicture;
    }
}