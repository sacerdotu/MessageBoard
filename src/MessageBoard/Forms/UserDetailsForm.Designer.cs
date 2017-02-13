namespace MessageBoard
{
    partial class UserDetailsForm
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
            this.ucUserInformations1 = new MessageBoard.ucUserInformations();
            this.SuspendLayout();
            // 
            // ucUserInformations1
            // 
            this.ucUserInformations1.Location = new System.Drawing.Point(12, 12);
            this.ucUserInformations1.Name = "ucUserInformations1";
            this.ucUserInformations1.Size = new System.Drawing.Size(489, 370);
            this.ucUserInformations1.TabIndex = 0;
            this.ucUserInformations1.Load += new System.EventHandler(this.ucUserInformations1_Load);
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 385);
            this.Controls.Add(this.ucUserInformations1);
            this.Name = "UserDetailsForm";
            this.Text = "UserDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ucUserInformations ucUserInformations1;
    }
}