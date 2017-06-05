using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using static DevExpress.Office.PInvoke.Win32;

namespace MessageBoard.Forms
{
    public partial class AddPostForm : BaseForm, IAddPostForm
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
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
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
            try
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
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
            }
        }
        #endregion

        #region LoadForm
        private void AddPostForm_Load(object sender, EventArgs e)
        {
            BaseForm_Load(this);
            lblAddPost.Location = new POINT(this.Width / 2 - lblAddPost.Width / 2, lblAddPost.Location.Y);
        }
        #endregion
    }
}
