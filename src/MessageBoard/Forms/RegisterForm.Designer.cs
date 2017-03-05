namespace MessageBoard.Forms
{
    partial class RegisterForm
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
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.ucUserInformations = new MessageBoard.ucUserInformations();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(470, 347);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.RegisterUser);
            // 
            // ucUserInformations
            // 
            this.ucUserInformations.Location = new System.Drawing.Point(-1, 0);
            this.ucUserInformations.Name = "ucUserInformations";
            this.ucUserInformations.Size = new System.Drawing.Size(489, 370);
            this.ucUserInformations.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 382);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ucUserInformations);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucUserInformations ucUserInformations;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}