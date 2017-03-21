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
                _controller.LoadForm();
                DisplayComments();
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
        public void DisplayComments()
        {
            try
            {
                List<CommentDTO> comments = new List<CommentDTO>();
                comments = _controller.GetSortedComments;
                ScrCommentControl.Controls.Clear();
                int currentComment = 0;
                //ucComment[] uc = new ucComment[comments.Count];
                foreach (var comment in comments)
                {
                    ucComment uc = new ucComment();
                    uc.GrpComment.Text = comment.CreationDate.ToString();
                    uc.LblUsername.Text = comment.tblUser.Username;
                    uc.RichCommentContent.Text = comment.CommentContent;
                    uc.ImgProfilePicture.Image = ConvertImage.ByteArrayToImage(comment.tblUser.ProfileImage);
                    ScrCommentControl.Controls.Add(uc);
                    if (comment.MainComment == null)
                    {
                        uc.Location = new Point(0, 3 + uc.Height * currentComment);
                    }
                    else
                    {
                        uc.Location = new Point(20, 3 + uc.Height * currentComment);
                    }
                    currentComment++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        #endregion
    }
}
