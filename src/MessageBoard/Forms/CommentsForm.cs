using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors;
using MessageBoard.UserControlls;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
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
        private PostDTO _post;

        #region Constructors
        public CommentsForm()
        {
            InitializeComponent();
            _controller = new CommentsController(this, AppGlobalVariables.Instance.Post);
            RichPostContent.Text = AppGlobalVariables.Instance.Post.PostText;
            lblAuthor.Text = AppGlobalVariables.Instance.Post.tblUser.Username;
            lblDate.Text = AppGlobalVariables.Instance.Post.CreationDate.ToString();
            ImgPost.Image = AppGlobalVariables.Instance.Post.PostImage != null ? ConvertImage.ByteArrayToImage(AppGlobalVariables.Instance.Post.PostImage) : null;
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

        public PictureEdit ImgPost
        {
            get { return imgPost; }
        }

        public RichTextBoxEx RichPostContent
        {
            get { return richPostContent; }
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
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
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
        public void DisplayComments(CommentDTO comment, int x, int y, bool visibility)
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
                uc.BtnQuote.Visible = visibility;
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region AddNewComment
        public void AddNewComment()
        {
            AddCommentsForm form = new AddCommentsForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region btnEsc
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try {
                if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
                {
                    ForumForm form = new ForumForm();
                    form.Show();
                    this.Close();
                }
                return base.ProcessDialogKey(keyData);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                return false;
            }
        }
        #endregion
    }
}
