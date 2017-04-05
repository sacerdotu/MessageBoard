using DevExpress.Tutorials.Controls;
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
        private PostDTO _post;

        #region Properties
        public RichTextBoxEx RtbComment
        {
            get { return rtbComment; }
        }
        #endregion

        #region Constructor
        public AddCommentsForm()
        {
            InitializeComponent();
            _controller = new AddCommentController(this);
        }
        #endregion

        #region btnAddComment
        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddComment(RtbComment.Text);
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

    }
}
