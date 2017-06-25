﻿using MessageBoard.Translate;

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
            this.btnBack = new MessageBoard.Translate.TranslateButton();
            this.btnAddPost = new MessageBoard.Translate.TranslateButton();
            this.grdDisplayPosts = new MessageBoard.Translate.TranslateGridControl();
            this.viewDisplayPosts = new MessageBoard.Translate.TranslateGridView();
            this.colPostText = new MessageBoard.Translate.TranslateGridColumn();
            this.repPostText = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colIsPublished = new MessageBoard.Translate.TranslateGridColumn();
            this.colCreationDate = new MessageBoard.Translate.TranslateGridColumn();
            this.colName = new MessageBoard.Translate.TranslateGridColumn();
            this.colUsername = new MessageBoard.Translate.TranslateGridColumn();
            this.colLastCommentDate = new MessageBoard.Translate.TranslateGridColumn();
            this.repCommentDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barManager1 = new MessageBoard.Translate.TranslateBarManager();
            this.barMainMenu = new DevExpress.XtraBars.Bar();
            this.barMenu = new DevExpress.XtraBars.BarSubItem();
            this.barChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barChangeProfilePicture = new DevExpress.XtraBars.BarButtonItem();
            this.barUserInformation = new DevExpress.XtraBars.BarButtonItem();
            this.barLanguage = new DevExpress.XtraBars.BarSubItem();
            this.barEnglish = new DevExpress.XtraBars.BarCheckItem();
            this.barFrench = new DevExpress.XtraBars.BarCheckItem();
            this.barSyncLanguage = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barReports = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPostText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 412);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPost.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnAddPost.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddPost.Appearance.Options.UseBackColor = true;
            this.btnAddPost.Appearance.Options.UseFont = true;
            this.btnAddPost.Appearance.Options.UseForeColor = true;
            this.btnAddPost.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAddPost.Location = new System.Drawing.Point(755, 412);
            this.btnAddPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(187, 40);
            this.btnAddPost.TabIndex = 1;
            this.btnAddPost.Text = "Add post";
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // grdDisplayPosts
            // 
            this.grdDisplayPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDisplayPosts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdDisplayPosts.Location = new System.Drawing.Point(0, 34);
            this.grdDisplayPosts.MainView = this.viewDisplayPosts;
            this.grdDisplayPosts.Margin = new System.Windows.Forms.Padding(4);
            this.grdDisplayPosts.Name = "grdDisplayPosts";
            this.grdDisplayPosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCommentDate,
            this.repPostText});
            this.grdDisplayPosts.Size = new System.Drawing.Size(955, 340);
            this.grdDisplayPosts.TabIndex = 2;
            this.grdDisplayPosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDisplayPosts});
            // 
            // viewDisplayPosts
            // 
            this.viewDisplayPosts.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.viewDisplayPosts.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.viewDisplayPosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPostText,
            this.colIsPublished,
            this.colCreationDate,
            this.colName,
            this.colUsername,
            this.colLastCommentDate});
            this.viewDisplayPosts.GridControl = this.grdDisplayPosts;
            this.viewDisplayPosts.Name = "viewDisplayPosts";
            this.viewDisplayPosts.OptionsView.RowAutoHeight = true;
            this.viewDisplayPosts.OptionsView.ShowAutoFilterRow = true;
            this.viewDisplayPosts.OptionsView.ShowGroupPanel = false;
            this.viewDisplayPosts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewDisplayPosts_RowClick);
            this.viewDisplayPosts.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.viewDisplayPosts_CustomRowCellEdit);
            // 
            // colPostText
            // 
            this.colPostText.AppearanceCell.Options.UseTextOptions = true;
            this.colPostText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPostText.Caption = "Post Text";
            this.colPostText.ColumnEdit = this.repPostText;
            this.colPostText.DisplayFormat.FormatString = "d";
            this.colPostText.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPostText.FieldName = "PostText";
            this.colPostText.Name = "colPostText";
            this.colPostText.OptionsColumn.AllowEdit = false;
            this.colPostText.OptionsColumn.ReadOnly = true;
            this.colPostText.TranslateName = null;
            this.colPostText.Visible = true;
            this.colPostText.VisibleIndex = 0;
            // 
            // repPostText
            // 
            this.repPostText.Name = "repPostText";
            this.repPostText.ShowCaretInReadOnly = false;
            // 
            // colIsPublished
            // 
            this.colIsPublished.Caption = "Is Published";
            this.colIsPublished.FieldName = "IsPublished";
            this.colIsPublished.Name = "colIsPublished";
            this.colIsPublished.OptionsColumn.AllowEdit = false;
            this.colIsPublished.OptionsColumn.ReadOnly = true;
            this.colIsPublished.TranslateName = null;
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
            this.colCreationDate.TranslateName = null;
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
            this.colName.TranslateName = null;
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
            this.colUsername.TranslateName = null;
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
            this.colLastCommentDate.TranslateName = null;
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
            this.barUserInformation,
            this.barChangeProfilePicture,
            this.barButtonItem1,
            this.barToolbarsListItem1,
            this.barLanguage,
            this.barButtonItem2,
            this.barEnglish,
            this.barFrench,
            this.barSyncLanguage,
            this.barReports});
            this.barManager1.MainMenu = this.barMainMenu;
            this.barManager1.MaxItemId = 16;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barUserInformation),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLanguage),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSyncLanguage),
            new DevExpress.XtraBars.LinkPersistInfo(this.barReports)});
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
            // barUserInformation
            // 
            this.barUserInformation.Caption = "User Information";
            this.barUserInformation.Id = 2;
            this.barUserInformation.Name = "barUserInformation";
            this.barUserInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUserInformations_ItemClick);
            // 
            // barLanguage
            // 
            this.barLanguage.Caption = "Language";
            this.barLanguage.Id = 10;
            this.barLanguage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEnglish),
            new DevExpress.XtraBars.LinkPersistInfo(this.barFrench)});
            this.barLanguage.Name = "barLanguage";
            // 
            // barEnglish
            // 
            this.barEnglish.Caption = "English";
            this.barEnglish.Id = 12;
            this.barEnglish.Name = "barEnglish";
            this.barEnglish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEnglish_ItemClick);
            // 
            // barFrench
            // 
            this.barFrench.Caption = "French";
            this.barFrench.Id = 13;
            this.barFrench.Name = "barFrench";
            this.barFrench.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFrench_ItemClick);
            // 
            // barSyncLanguage
            // 
            this.barSyncLanguage.Caption = "Sync Language";
            this.barSyncLanguage.Id = 14;
            this.barSyncLanguage.Name = "barSyncLanguage";
            this.barSyncLanguage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSyncLanguage_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(955, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 465);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(955, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(955, 22);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "Language";
            this.barToolbarsListItem1.Id = 9;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barReports
            // 
            this.barReports.Caption = "Reports";
            this.barReports.Id = 15;
            this.barReports.Name = "barReports";
            this.barReports.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barReports_ItemClick);
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 465);
            this.Controls.Add(this.grdDisplayPosts);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForumForm";
            this.Load += new System.EventHandler(this.ForumForm_Load);
            this.Shown += new System.EventHandler(this.ForumForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPostText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCommentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TranslateButton btnBack;
        private TranslateButton btnAddPost;
        private TranslateGridControl grdDisplayPosts;
        private TranslateGridView viewDisplayPosts;
        private TranslateGridColumn colPostText;
        private TranslateGridColumn colIsPublished;
        private TranslateGridColumn colCreationDate;
        private TranslateGridColumn colName;
        private TranslateGridColumn colUsername;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repCommentDate;
        private TranslateGridColumn colLastCommentDate;
        private TranslateBarManager barManager1;
        private DevExpress.XtraBars.Bar barMainMenu;
        private DevExpress.XtraBars.BarSubItem barMenu;
        private DevExpress.XtraBars.BarButtonItem barChangePassword;
        private DevExpress.XtraBars.BarButtonItem barUserInformation;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barChangeProfilePicture;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repPostText;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barLanguage;
        private DevExpress.XtraBars.BarCheckItem barEnglish;
        private DevExpress.XtraBars.BarCheckItem barFrench;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barSyncLanguage;
        private DevExpress.XtraBars.BarButtonItem barReports;
    }
}