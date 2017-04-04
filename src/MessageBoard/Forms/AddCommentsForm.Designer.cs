namespace MessageBoard.Forms
{
    partial class AddCommentsForm
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
            this.btnAddNewComment = new DevExpress.XtraEditors.SimpleButton();
            this.lblAddComment = new DevExpress.XtraEditors.LabelControl();
            this.rtbComment = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // btnAddNewComment
            // 
            this.btnAddNewComment.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnAddNewComment.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewComment.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddNewComment.Appearance.Options.UseBackColor = true;
            this.btnAddNewComment.Appearance.Options.UseFont = true;
            this.btnAddNewComment.Appearance.Options.UseForeColor = true;
            this.btnAddNewComment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAddNewComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewComment.Location = new System.Drawing.Point(146, 246);
            this.btnAddNewComment.Name = "btnAddNewComment";
            this.btnAddNewComment.Size = new System.Drawing.Size(139, 34);
            this.btnAddNewComment.TabIndex = 0;
            this.btnAddNewComment.Text = "Add comment";
            this.btnAddNewComment.Click += new System.EventHandler(this.btnAddNewComment_Click);
            // 
            // lblAddComment
            // 
            this.lblAddComment.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComment.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddComment.Appearance.Options.UseFont = true;
            this.lblAddComment.Appearance.Options.UseForeColor = true;
            this.lblAddComment.Location = new System.Drawing.Point(33, 12);
            this.lblAddComment.Name = "lblAddComment";
            this.lblAddComment.Size = new System.Drawing.Size(345, 45);
            this.lblAddComment.TabIndex = 15;
            this.lblAddComment.Text = "Add new comment";
            // 
            // rtbComment
            // 
            this.rtbComment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbComment.Location = new System.Drawing.Point(12, 63);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(387, 151);
            this.rtbComment.TabIndex = 16;
            this.rtbComment.Text = "";
            // 
            // AddCommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 292);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.lblAddComment);
            this.Controls.Add(this.btnAddNewComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCommentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAddNewComment;
        private DevExpress.XtraEditors.LabelControl lblAddComment;
        private DevExpress.Tutorials.Controls.RichTextBoxEx rtbComment;
    }
}