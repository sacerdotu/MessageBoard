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
            this.btnAddPost = new DevExpress.XtraEditors.SimpleButton();
            this.lblAddPost = new DevExpress.XtraEditors.LabelControl();
            this.rtbPost = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.SuspendLayout();
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
            this.btnAddPost.Location = new System.Drawing.Point(116, 240);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(187, 40);
            this.btnAddPost.TabIndex = 2;
            this.btnAddPost.Text = "Add";
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // lblAddPost
            // 
            this.lblAddPost.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPost.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddPost.Appearance.Options.UseFont = true;
            this.lblAddPost.Appearance.Options.UseForeColor = true;
            this.lblAddPost.Location = new System.Drawing.Point(82, 12);
            this.lblAddPost.Name = "lblAddPost";
            this.lblAddPost.Size = new System.Drawing.Size(251, 45);
            this.lblAddPost.TabIndex = 14;
            this.lblAddPost.Text = "Add new post";
            // 
            // rtbPost
            // 
            this.rtbPost.Location = new System.Drawing.Point(82, 63);
            this.rtbPost.Name = "rtbPost";
            this.rtbPost.Size = new System.Drawing.Size(251, 151);
            this.rtbPost.TabIndex = 15;
            this.rtbPost.Text = "";
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 292);
            this.Controls.Add(this.rtbPost);
            this.Controls.Add(this.lblAddPost);
            this.Controls.Add(this.btnAddPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddPost;
        private DevExpress.XtraEditors.LabelControl lblAddPost;
        private DevExpress.Tutorials.Controls.RichTextBoxEx rtbPost;
    }
}