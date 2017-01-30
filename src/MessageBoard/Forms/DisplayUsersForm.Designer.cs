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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDisplayUsers
            // 
            this.grdDisplayUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDisplayUsers.Location = new System.Drawing.Point(0, 0);
            this.grdDisplayUsers.MainView = this.gridView1;
            this.grdDisplayUsers.Name = "grdDisplayUsers";
            this.grdDisplayUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repIsAdministrator,
            this.repIsActive});
            this.grdDisplayUsers.Size = new System.Drawing.Size(662, 270);
            this.grdDisplayUsers.TabIndex = 0;
            this.grdDisplayUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.GridControl = this.grdDisplayUsers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUserID
            // 
            this.colUserID.Caption = "User ID";
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.OptionsColumn.AllowEdit = false;
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.AllowEdit = false;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 3;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 4;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            // 
            // colFunction
            // 
            this.colFunction.Caption = "Function";
            this.colFunction.FieldName = "Function";
            this.colFunction.Name = "colFunction";
            this.colFunction.OptionsColumn.AllowEdit = false;
            this.colFunction.Visible = true;
            this.colFunction.VisibleIndex = 6;
            // 
            // colIsAdministrator
            // 
            this.colIsAdministrator.Caption = "Administrator";
            this.colIsAdministrator.ColumnEdit = this.repIsAdministrator;
            this.colIsAdministrator.FieldName = "IsAdministrator";
            this.colIsAdministrator.Name = "colIsAdministrator";
            this.colIsAdministrator.OptionsColumn.AllowEdit = false;
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
            this.colIsActive.OptionsColumn.AllowEdit = false;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 8;
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
            this.colAccountCreationDate.Visible = true;
            this.colAccountCreationDate.VisibleIndex = 9;
            // 
            // DisplayUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 270);
            this.Controls.Add(this.grdDisplayUsers);
            this.Name = "DisplayUsersForm";
            this.Text = "DisplayUsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIsActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDisplayUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}