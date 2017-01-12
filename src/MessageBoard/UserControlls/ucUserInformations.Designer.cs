namespace MessageBoard
{
    partial class ucUserInformations
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
            DevExpress.XtraEditors.PictureEdit imgProfilePicture;
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.lblCountry = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.lblFunction = new DevExpress.XtraEditors.LabelControl();
            this.cmbFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblProfilePicture = new DevExpress.XtraEditors.LabelControl();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblConfirmPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            imgProfilePicture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(imgProfilePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProfilePicture
            // 
            imgProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            imgProfilePicture.Location = new System.Drawing.Point(98, 239);
            imgProfilePicture.Name = "imgProfilePicture";
            imgProfilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            imgProfilePicture.Properties.ZoomAccelerationFactor = 1D;
            imgProfilePicture.Size = new System.Drawing.Size(100, 91);
            imgProfilePicture.TabIndex = 12;
            imgProfilePicture.EditValueChanged += new System.EventHandler(this.peProfilePicture_EditValueChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(98, 117);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(98, 155);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(13, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(13, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(13, 120);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(39, 13);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(13, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(19, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblFunction
            // 
            this.lblFunction.Location = new System.Drawing.Point(11, 202);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(41, 13);
            this.lblFunction.TabIndex = 9;
            this.lblFunction.Text = "Function";
            // 
            // cmbFunction
            // 
            this.cmbFunction.Location = new System.Drawing.Point(98, 199);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFunction.Properties.Items.AddRange(new object[] {
            "Developer",
            "QA",
            "System Administrator",
            "Other"});
            this.cmbFunction.Size = new System.Drawing.Size(100, 20);
            this.cmbFunction.TabIndex = 11;
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.Location = new System.Drawing.Point(13, 275);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(66, 13);
            this.lblProfilePicture.TabIndex = 13;
            this.lblProfilePicture.Text = "Profile picture";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(250, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(250, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Location = new System.Drawing.Point(250, 118);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(86, 13);
            this.lblConfirmPassword.TabIndex = 16;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(351, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(351, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(351, 112);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 19;
            // 
            // ucUserInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblProfilePicture);
            this.Controls.Add(imgProfilePicture);
            this.Controls.Add(this.cmbFunction);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ucUserInformations";
            this.Size = new System.Drawing.Size(489, 370);
            this.Load += new System.EventHandler(this.ucUserInformations_Load);
            ((System.ComponentModel.ISupportInitialize)(imgProfilePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtCountry;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.LabelControl lblCountry;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.LabelControl lblFunction;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFunction;
        private DevExpress.XtraEditors.LabelControl lblProfilePicture;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
    }
}
