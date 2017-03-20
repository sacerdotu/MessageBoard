namespace MessageBoard.Forms
{
    partial class AddPostForm
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
            this.rtbPost = new System.Windows.Forms.RichTextBox();
            this.btnAddPost = new DevExpress.XtraEditors.SimpleButton();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // rtbPost
            // 
            this.rtbPost.Font = new System.Drawing.Font("Verdana", 16F);
            this.rtbPost.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbPost.Location = new System.Drawing.Point(61, 72);
            this.rtbPost.MaxLength = 160;
            this.rtbPost.Name = "rtbPost";
            this.rtbPost.Size = new System.Drawing.Size(287, 162);
            this.rtbPost.TabIndex = 1;
            this.rtbPost.Text = "";
            // 
            // btnAddPost
            // 
            this.btnAddPost.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnAddPost.Appearance.Font = new System.Drawing.Font("Verdana", 16F);
            this.btnAddPost.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddPost.Appearance.Options.UseBackColor = true;
            this.btnAddPost.Appearance.Options.UseFont = true;
            this.btnAddPost.Appearance.Options.UseForeColor = true;
            this.btnAddPost.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAddPost.Location = new System.Drawing.Point(107, 240);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(187, 40);
            this.btnAddPost.TabIndex = 2;
            this.btnAddPost.Text = "Add";
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Appearance.Options.UseForeColor = true;
            this.lblLogin.Location = new System.Drawing.Point(82, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(251, 45);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Add new post";
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 292);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.rtbPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbPost;
        private DevExpress.XtraEditors.SimpleButton btnAddPost;
        private DevExpress.XtraEditors.LabelControl lblLogin;
    }
}