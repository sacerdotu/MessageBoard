using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Constants;
using MessageBoardController.Interfaces;
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
    public partial class AddPostForm : Form, IAddPostForm
    {
        AddPostController _controller;

        #region Properties
        public RichTextBox RtbPost
        {
            get { return rtbPost; }
        }
        public AddPostForm()
        {
            InitializeComponent();
            _controller = new AddPostController(this);
        }
        #endregion

        #region AddPostClick
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddPost(AppGlobalVariables.Instance.UserID);
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.AddPostFailed);
            }
        }
        #endregion

        #region PostWasAdded
        public void PostWasAdded()
        {
            XtraMessageBox.Show(Constants.Success);
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
        #endregion
    }
}
