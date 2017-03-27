using DevExpress.XtraEditors;
using MessageBoard.UserControlls;
using MessageBoardController;
using MessageBoardController.Constants;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class CommentsForm : Form, ICommentsForm
    {
        private CommentsController _controller;

        #region Constructors
        public CommentsForm()
        {
            InitializeComponent();
            this.ucComments.ParentForm = this;
        }
        public CommentsForm(PostDTO post)
            : this()
        {
            _controller = new CommentsController(this, post);
            lblPost.Text = post.PostText;
            lblAuthor.Text = post.tblUser.Username;
            lblDate.Text = post.CreationDate.ToString();
        }

        #endregion

        #region Properties
        
        public XtraScrollableControl ScrCommentControl
        {
            get
            {
                return xtraScrollableControl;
            }
        }
        public GroupControl GrpComment
        {
            get
            {
                return ucComments.GrpComment;
            }
        }

        public LabelControl LblUsername
        {
            get { return ucComments.LblUsername; }
        }

        public PictureEdit ImgProfilePicture
        {
            get { return ucComments.ImgProfilePicture; }
        }

        public SimpleButton BtnQuote
        {
            get { return ucComments.BtnQuote; }
        }
        #endregion

        #region LoadForm
        private void CommentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                ScrCommentControl.Controls.Clear();
                _controller.LoadForm();
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
            }
        }
        #endregion

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region DisplayComments
        public void DisplayComments(CommentDTO comment, int x, int y)
        {
            try
            {                                    
                ucComment uc = new ucComment();
                uc.GrpComment.Text = comment.CreationDate.ToString();
                uc.LblUsername.Text = comment.tblUser.Username;
                uc.RichCommentContent.Text = comment.CommentContent;
                uc.ImgProfilePicture.Image = ConvertImage.ByteArrayToImage(comment.tblUser.ProfileImage);
                uc.CommentID = comment.CommentID;
                ScrCommentControl.Controls.Add(uc);
                uc.Location = new Point(x, 3 + uc.Height * y);
                uc.Size = new Size(544 - x, 184);
                uc.GrpComment.Size = new Size(544 - x, 184);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

        #region GetCommentID
        public void GetCommentID()
        {
            //int commentID = uc.CommentID;
        }
        #endregion
    }
}
