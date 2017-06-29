using MessageBoard.Translate;

namespace MessageBoard.Forms
{
    partial class ReportsForm
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
            this.grdReport = new DevExpress.XtraGrid.GridControl();
            this.viewReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNrOfPosts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNrOfComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateStartDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblSortBy = new DevExpress.XtraEditors.LabelControl();
            this.lblStartDate = new DevExpress.XtraEditors.LabelControl();
            this.lblEndDate = new DevExpress.XtraEditors.LabelControl();
            this.chkPosts = new DevExpress.XtraEditors.CheckEdit();
            this.chkComments = new DevExpress.XtraEditors.CheckEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPosts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkComments.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReport
            // 
            this.grdReport.Location = new System.Drawing.Point(202, 12);
            this.grdReport.MainView = this.viewReport;
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(587, 303);
            this.grdReport.TabIndex = 0;
            this.grdReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewReport});
            // 
            // viewReport
            // 
            this.viewReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colFullName,
            this.colUsername,
            this.colCountry,
            this.colCity,
            this.colNrOfPosts,
            this.colNrOfComments});
            this.viewReport.GridControl = this.grdReport;
            this.viewReport.Name = "viewReport";
            this.viewReport.OptionsView.ShowAutoFilterRow = true;
            this.viewReport.OptionsView.ShowGroupPanel = false;
            // 
            // colUserID
            // 
            this.colUserID.Caption = "UserID";
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Name";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 2;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 3;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            // 
            // colNrOfPosts
            // 
            this.colNrOfPosts.Caption = "Posts";
            this.colNrOfPosts.FieldName = "NrOfPosts";
            this.colNrOfPosts.Name = "colNrOfPosts";
            this.colNrOfPosts.Visible = true;
            this.colNrOfPosts.VisibleIndex = 5;
            // 
            // colNrOfComments
            // 
            this.colNrOfComments.Caption = "Comments";
            this.colNrOfComments.FieldName = "NrOfComments";
            this.colNrOfComments.Name = "colNrOfComments";
            this.colNrOfComments.Visible = true;
            this.colNrOfComments.VisibleIndex = 6;
            // 
            // dateStartDate
            // 
            this.dateStartDate.EditValue = null;
            this.dateStartDate.Location = new System.Drawing.Point(11, 118);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate.Size = new System.Drawing.Size(100, 20);
            this.dateStartDate.TabIndex = 4;
            // 
            // dateEndDate
            // 
            this.dateEndDate.EditValue = null;
            this.dateEndDate.Location = new System.Drawing.Point(11, 176);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDate.Size = new System.Drawing.Size(100, 20);
            this.dateEndDate.TabIndex = 5;
            // 
            // lblSortBy
            // 
            this.lblSortBy.Location = new System.Drawing.Point(13, 12);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(39, 13);
            this.lblSortBy.TabIndex = 6;
            this.lblSortBy.Text = "Sort by:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(11, 98);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(49, 13);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(13, 156);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(43, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End date";
            // 
            // chkPosts
            // 
            this.chkPosts.Location = new System.Drawing.Point(11, 32);
            this.chkPosts.Name = "chkPosts";
            this.chkPosts.Properties.Caption = "Posts";
            this.chkPosts.Size = new System.Drawing.Size(75, 19);
            this.chkPosts.TabIndex = 9;
            this.chkPosts.CheckedChanged += new System.EventHandler(this.chkPosts_CheckedChanged);
            // 
            // chkComments
            // 
            this.chkComments.Location = new System.Drawing.Point(11, 58);
            this.chkComments.Name = "chkComments";
            this.chkComments.Properties.Caption = "Comments";
            this.chkComments.Size = new System.Drawing.Size(75, 19);
            this.chkComments.TabIndex = 10;
            this.chkComments.CheckedChanged += new System.EventHandler(this.chkComments_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Location = new System.Drawing.Point(11, 347);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 42);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBack.Location = new System.Drawing.Point(602, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 401);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkComments);
            this.Controls.Add(this.chkPosts);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.dateEndDate);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.grdReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPosts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkComments.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private DevExpress.XtraGrid.GridControl gridControl1;
        //private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private DevExpress.XtraEditors.LabelControl lblSortBy;
        //private DevExpress.XtraEditors.CheckEdit chkPosts;
        //private DevExpress.XtraEditors.CheckEdit chkComments;
        //private DevExpress.XtraEditors.DateEdit dateEdit1;
        //private DevExpress.XtraEditors.DateEdit dateEdit2;
        //private DevExpress.XtraEditors.LabelControl lblStartDate;
        //private DevExpress.XtraEditors.LabelControl lblEndDate;
        //private DevExpress.XtraEditors.SimpleButton btnSearch;
        //private DevExpress.XtraEditors.SimpleButton btnBack;

        private DevExpress.XtraGrid.GridControl grdReport;
        private DevExpress.XtraGrid.Views.Grid.GridView viewReport;
        //private TranslateLabel lblSortBy;
        //private TranslateCheckEdit chkPosts;
        //private TranslateCheckEdit chkComments;
        private DevExpress.XtraEditors.DateEdit dateStartDate;
        private DevExpress.XtraEditors.DateEdit dateEndDate;
        private DevExpress.XtraEditors.LabelControl lblSortBy;
        private DevExpress.XtraEditors.LabelControl lblStartDate;
        private DevExpress.XtraEditors.LabelControl lblEndDate;
        private DevExpress.XtraEditors.CheckEdit chkPosts;
        private DevExpress.XtraEditors.CheckEdit chkComments;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colNrOfPosts;
        private DevExpress.XtraGrid.Columns.GridColumn colNrOfComments;
        //private TranslateLabel lblStartDate;
        //private TranslateLabel lblEndDate;
        //private TranslateButton btnSearch;
        //private TranslateButton btnBack;
    }
}