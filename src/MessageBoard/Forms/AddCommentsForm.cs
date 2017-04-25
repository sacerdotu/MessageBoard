using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
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
    public partial class AddCommentsForm : Form , IAddCommentsForm
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

    }
}
