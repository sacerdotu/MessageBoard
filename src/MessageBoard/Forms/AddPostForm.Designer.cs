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
            this.lblPost = new DevExpress.XtraEditors.LabelControl();
            this.rtbPost = new System.Windows.Forms.RichTextBox();
            this.btnAddPost = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblPost
            // 
            this.lblPost.Location = new System.Drawing.Point(166, 12);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(79, 13);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "Enter your post:";
            // 
            // rtbPost
            // 
            this.rtbPost.Location = new System.Drawing.Point(59, 31);
            this.rtbPost.Name = "rtbPost";
            this.rtbPost.Size = new System.Drawing.Size(287, 52);
            this.rtbPost.TabIndex = 1;
            this.rtbPost.Text = "";
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(166, 89);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(79, 23);
            this.btnAddPost.TabIndex = 2;
            this.btnAddPost.Text = "Add";
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 128);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.rtbPost);
            this.Controls.Add(this.lblPost);
            this.Name = "AddPostForm";
            this.Text = "AddPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPost;
        private System.Windows.Forms.RichTextBox rtbPost;
        private DevExpress.XtraEditors.SimpleButton btnAddPost;
    }
}