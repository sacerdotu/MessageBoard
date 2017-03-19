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

namespace MessageBoard.UserControlls
{
    public partial class ucComment : UserControl
    {
        public ucComment()
        {
            InitializeComponent();
        }

        public GroupControl GrpComment
        {
            get { return grpComment; }
        }
        public LabelControl LblUsername
        {
            get { return lblUsername; }
        }
        public LabelControl LblCommentContent
        {
            get { return lblCommentContent; }
        }
        public PictureEdit ImgProfilePicture
        {
            get { return imgProfilePicture; }
        }
        public SimpleButton BtnQuote
        {
            get { return btnQuote; }
        }
    }
}
