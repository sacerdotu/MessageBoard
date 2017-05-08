using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Interfaces;
using System;
using System.Windows.Forms;
using static DevExpress.Office.PInvoke.Win32;

namespace MessageBoard.Forms
{
    public partial class AddCommentsForm : BaseForm, IAddCommentsForm
    {
        AddCommentController _controller;
        bool _mainComment = false;

        #region Properties
        public RichTextBoxEx RtbComment
        {
            get { return rtbComment; }
        }
        #endregion

        #region Constructor
        public AddCommentsForm(bool mainComment)
        {
            _mainComment = mainComment;
            _controller = new AddCommentController(this);
            LoadForm();
        }

        public AddCommentsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region btnAddComment
        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddComment(RtbComment.Text, _mainComment);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                CommentsForm form = new CommentsForm();
                form.Show();
                this.Close();
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

        #region Success
        public void Success()
        {
            XtraMessageBox.Show("Comment was added!");
            CommentsForm form = new CommentsForm();
            form.Show();
            this.Close(); 
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            BaseForm_Load(this);
            lblAddComment.Location = new POINT(this.Width / 2 - lblAddComment.Width / 2, lblAddComment.Location.Y);
        }
        #endregion

    }
}
