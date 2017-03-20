namespace MessageBoard.Forms
{
    partial class DisplayUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayUsersForm));
            this.grdDisplayUsers = new DevExpress.XtraGrid.GridControl();
            this.viewDisplayUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdministrator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repIsAdministrator = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colAccountCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.lblViewUsers = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDisplayUsers
            // 
            this.grdDisplayUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDisplayUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdDisplayUsers.Location = new System.Drawing.Point(0, 54);
            this.grdDisplayUsers.MainView = this.viewDisplayUsers;
            this.grdDisplayUsers.Margin = new System.Windows.Forms.Padding(4);
            this.grdDisplayUsers.Name = "grdDisplayUsers";
            this.grdDisplayUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repIsAdministrator,
            this.repIsActive});
            this.grdDisplayUsers.Size = new System.Drawing.Size(949, 288);
            this.grdDisplayUsers.TabIndex = 0;
            this.grdDisplayUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDisplayUsers});
            // 
            // viewDisplayUsers
            // 
            this.viewDisplayUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colFirstName,
            this.colLastName,
            this.colUsername,
            this.colCountry,
            this.colCity,
            this.colFunction,
            this.colIsAdministrator,
            this.colIsActive,
            this.colAccountCreationDate});
            this.viewDisplayUsers.GridControl = this.grdDisplayUsers;
            this.viewDisplayUsers.Name = "viewDisplayUsers";
            this.viewDisplayUsers.OptionsView.ShowAutoFilterRow = true;
            this.viewDisplayUsers.OptionsView.ShowGroupPanel = false;
            this.viewDisplayUsers.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdDisplayUsers_RowClick);
            this.viewDisplayUsers.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.viewDisplayUsers_RowUpdated);
            // 
            // colUserID
            // 
            this.colUserID.Caption = "User ID";
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.OptionsColumn.AllowEdit = false;
            this.colUserID.OptionsColumn.ReadOnly = true;
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            this.colUserID.Width = 76;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.OptionsColumn.ReadOnly = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 94;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.OptionsColumn.ReadOnly = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 88;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.AllowEdit = false;
            this.colUsername.OptionsColumn.ReadOnly = true;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 3;
            this.colUsername.Width = 95;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.OptionsColumn.ReadOnly = true;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 4;
            this.colCountry.Width = 94;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.OptionsColumn.ReadOnly = true;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            this.colCity.Width = 80;
            // 
            // colFunction
            // 
            this.colFunction.Caption = "Function";
            this.colFunction.FieldName = "Function";
            this.colFunction.Name = "colFunction";
            this.colFunction.OptionsColumn.AllowEdit = false;
            this.colFunction.OptionsColumn.ReadOnly = true;
            this.colFunction.Visible = true;
            this.colFunction.VisibleIndex = 6;
            this.colFunction.Width = 93;
            // 
            // colIsAdministrator
            // 
            this.colIsAdministrator.Caption = "Administrator";
            this.colIsAdministrator.ColumnEdit = this.repIsAdministrator;
            this.colIsAdministrator.FieldName = "IsAdministrator";
            this.colIsAdministrator.Name = "colIsAdministrator";
            this.colIsAdministrator.OptionsColumn.AllowEdit = false;
            this.colIsAdministrator.OptionsColumn.ReadOnly = true;
            this.colIsAdministrator.Visible = true;
            this.colIsAdministrator.VisibleIndex = 7;
            // 
            // repIsAdministrator
            // 
            this.repIsAdministrator.AutoHeight = false;
            this.repIsAdministrator.Name = "repIsAdministrator";
            this.repIsAdministrator.PictureChecked = ((System.Drawing.Image)(resources.GetObject("repIsAdministrator.PictureChecked")));
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Active";
            this.colIsActive.ColumnEdit = this.repIsActive;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 8;
            this.colIsActive.Width = 40;
            // 
            // repIsActive
            // 
            this.repIsActive.AutoHeight = false;
            this.repIsActive.Name = "repIsActive";
            this.repIsActive.PictureChecked = ((System.Drawing.Image)(resources.GetObject("repIsActive.PictureChecked")));
            // 
            // colAccountCreationDate
            // 
            this.colAccountCreationDate.Caption = "Account Creation Date";
            this.colAccountCreationDate.FieldName = "AccountCreationDate";
            this.colAccountCreationDate.Name = "colAccountCreationDate";
            this.colAccountCreationDate.OptionsColumn.AllowEdit = false;
            this.colAccountCreationDate.OptionsColumn.ReadOnly = true;
            this.colAccountCreationDate.Visible = true;
            this.colAccountCreationDate.VisibleIndex = 9;
            this.colAccountCreationDate.Width = 195;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 392);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnSaveChanges.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Appearance.Options.UseBackColor = true;
            this.btnSaveChanges.Appearance.Options.UseFont = true;
            this.btnSaveChanges.Appearance.Options.UseForeColor = true;
            this.btnSaveChanges.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSaveChanges.Location = new System.Drawing.Point(749, 392);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(187, 42);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblViewUsers
            // 
            this.lblViewUsers.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewUsers.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblViewUsers.Appearance.Options.UseFont = true;
            this.lblViewUsers.Appearance.Options.UseForeColor = true;
            this.lblViewUsers.Location = new System.Drawing.Point(390, 2);
            this.lblViewUsers.Name = "lblViewUsers";
            this.lblViewUsers.Size = new System.Drawing.Size(199, 45);
            this.lblViewUsers.TabIndex = 12;
            this.lblViewUsers.Text = "View users";
            // 
            // DisplayUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 447);
            this.Controls.Add(this.lblViewUsers);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grdDisplayUsers);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayUsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDisplayUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDisplayUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDisplayUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdministrator;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repIsAdministrator;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCreationDate;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private DevExpress.XtraEditors.LabelControl lblViewUsers;
        // private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}