using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Tutorials.Controls;
using MessageBoard.Forms;

namespace MessageBoard.UserControlls
{
    public partial class ucComment : UserControl
    {
        public ucComment()
        {
            InitializeComponent();
        }
        public CommentsForm ParentForm { get; set; }
        public int CommentID { get; set; }
        public GroupControl GrpComment
        {
            get { return grpComment; }
        }
        public LabelControl LblUsername
        {
            get { return lblUsername; }
        }
        public RichTextBoxEx RichCommentContent
        {
            get { return richCommentContent; }
        }
        public PictureEdit ImgProfilePicture
        {
            get { return imgProfilePicture; }
        }
        public SimpleButton BtnQuote
        {
            get { return btnQuote; }
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            
        }
    }
}
