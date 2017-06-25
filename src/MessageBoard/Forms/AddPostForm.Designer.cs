using MessageBoard.Translate;

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
            this.btnAddPost = new MessageBoard.Translate.TranslateButton();
            this.lblAddPost = new MessageBoard.Translate.TranslateLabel();
            this.rtbPost = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.lblText = new MessageBoard.Translate.TranslateLabel();
            this.lblImage = new MessageBoard.Translate.TranslateLabel();
            this.imgPost = new DevExpress.XtraEditors.PictureEdit();
            this.btnBrowse = new MessageBoard.Translate.TranslateButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgPost.Properties)).BeginInit();
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
            this.btnAddPost.Location = new System.Drawing.Point(112, 418);
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
            this.lblAddPost.Location = new System.Drawing.Point(117, 12);
            this.lblAddPost.Name = "lblAddPost";
            this.lblAddPost.Size = new System.Drawing.Size(163, 45);
            this.lblAddPost.TabIndex = 14;
            this.lblAddPost.Text = "Add post";
            // 
            // rtbPost
            // 
            this.rtbPost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPost.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbPost.Location = new System.Drawing.Point(12, 105);
            this.rtbPost.Name = "rtbPost";
            this.rtbPost.Size = new System.Drawing.Size(387, 99);
            this.rtbPost.TabIndex = 15;
            this.rtbPost.Text = "";
            // 
            // lblText
            // 
            this.lblText.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblText.Appearance.Options.UseFont = true;
            this.lblText.Appearance.Options.UseForeColor = true;
            this.lblText.Location = new System.Drawing.Point(180, 74);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(46, 25);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Text";
            // 
            // lblImage
            // 
            this.lblImage.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblImage.Appearance.Options.UseFont = true;
            this.lblImage.Appearance.Options.UseForeColor = true;
            this.lblImage.Location = new System.Drawing.Point(170, 212);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(67, 25);
            this.lblImage.TabIndex = 17;
            this.lblImage.Text = "Image";
            // 
            // imgPost
            // 
            this.imgPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgPost.Location = new System.Drawing.Point(129, 248);
            this.imgPost.Name = "imgPost";
            this.imgPost.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgPost.Properties.ZoomAccelerationFactor = 1D;
            this.imgPost.Size = new System.Drawing.Size(139, 118);
            this.imgPost.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Verdana", 16F);
            this.btnBrowse.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Appearance.Options.UseBackColor = true;
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Appearance.Options.UseForeColor = true;
            this.btnBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(112, 372);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(187, 40);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 470);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.imgPost);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.rtbPost);
            this.Controls.Add(this.lblAddPost);
            this.Controls.Add(this.btnAddPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPostForm";
            this.Load += new System.EventHandler(this.AddPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TranslateButton btnAddPost;
        private TranslateLabel lblAddPost;
        private DevExpress.Tutorials.Controls.RichTextBoxEx rtbPost;
        private TranslateLabel lblText;
        private TranslateLabel lblImage;
        private DevExpress.XtraEditors.PictureEdit imgPost;
        private TranslateButton btnBrowse;
    }
}