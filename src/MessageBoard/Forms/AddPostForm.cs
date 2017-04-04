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

        public PictureEdit ImgPost
        {
            get { return imgPost; }
        }
        #endregion

        #region Constructor
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

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                ForumForm form = new ForumForm();
                form.Show();
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

        #region btnBrowse
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            openFile.Title = "Select picture";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string picture = openFile.FileName.ToString();
                var initialImage = Image.FromFile(openFile.FileName);

                var newWidth = ImgPost.Width;
                var newHeight = ImgPost.Height;

                var newImage = new Bitmap(newWidth, newHeight);

                using (var graphics = Graphics.FromImage(newImage))
                    graphics.DrawImage(initialImage, 0, 0, newWidth, newHeight);
                ImgPost.Image = newImage;
            }
        }
        #endregion
    }
}
