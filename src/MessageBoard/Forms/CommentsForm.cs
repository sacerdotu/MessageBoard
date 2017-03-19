using DevExpress.XtraEditors;
using MessageBoard.UserControlls;
using MessageBoardController;
using MessageBoardController.Constants;
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
            :this()
        {
            _controller = new CommentsController(this, post);
            lblPost.Text = post.PostText;
            lblAuthor.Text = post.tblUser.Username;
            lblDate.Text = post.CreationDate.ToString();
        }

        #endregion

        #region Properties
        ucComment UcComment
        {
            get { return uccomment; }
        }
        #endregion

        #region LoadForm
        private void CommentsForm_Load(object sender, EventArgs e)
        {
            try
            {
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
    }
}
