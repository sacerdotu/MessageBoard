using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors;
using MessageBoard.UserControlls;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardDTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class CommentsForm : BaseForm, ICommentsForm
    {
        private CommentsController _controller;
        Proxy _proxy;

        #region Constructors
        public CommentsForm()
        {
            InitializeComponent();
            if (!AppGlobalVariables.Instance.IsForTranslation)
            {
                _controller = new CommentsController(this, AppGlobalVariables.Instance.Post);
            }
            _proxy = new Proxy(this);
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

        public int UcWidth
        { get; set; }

        #endregion

        #region LoadForm
        private void CommentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                ScrCommentControl.Controls.Clear();
                RichPostContent.Text = AppGlobalVariables.Instance.Post.PostText;
                lblAuthor.Text = AppGlobalVariables.Instance.Post.tblUser.Username;
                lblDate.Text = AppGlobalVariables.Instance.Post.CreationDate.ToString();
                ImgPost.Image = AppGlobalVariables.Instance.Post.PostImage != null ? ConvertImage.ByteArrayToImage(AppGlobalVariables.Instance.Post.PostImage) : null;
                _controller.LoadForm();
                BaseForm_Load(this);
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
                uc.Size = new Size(UcWidth - x, 190);
                uc.GrpComment.Size = new Size(UcWidth - 3 - x, 190);
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
            AddCommentsForm form = new AddCommentsForm(false);
            form.Show();
            this.Close();
        }
        #endregion

        #region btnEsc
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
            {
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

        private void btnReplyPost_Click(object sender, EventArgs e)
        {
            AddCommentsForm form = new AddCommentsForm(true);
            form.Show();
            this.Close();
        }

        #region ShowNotification
        public void ShowNotification()
        {
            try
            {
                if(AppGlobalVariables.Instance.NrOfNewComments == 1)
                {
                    lblNewComments.Text = String.Format("There is 1 new comment");
                }
                if(AppGlobalVariables.Instance.NrOfNewComments > 1)
                {
                    lblNewComments.Text = String.Format("There are {0} new comments", AppGlobalVariables.Instance.NrOfNewComments);
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
