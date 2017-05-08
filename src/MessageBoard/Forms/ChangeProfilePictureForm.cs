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
    public partial class ChangeProfilePictureForm : BaseForm, IChangeProfilePictureForm
    {
        #region Members
        ChangeProfilePictureController _controller;
        #endregion

        #region Properties
        public PictureEdit ImgProfilePicture
        {
            get { return imgProfilePicture; }
            set {; }
        }
        #endregion

        #region Constructor
        public ChangeProfilePictureForm()
        {
            InitializeComponent();
            _controller = new ChangeProfilePictureController(this, AppGlobalVariables.Instance.UserID);
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

                    var newWidth = ImgProfilePicture.Width;
                    var newHeight = ImgProfilePicture.Height;

                    var newImage = new Bitmap(newWidth, newHeight);

                    using (var graphics = Graphics.FromImage(newImage))
                        graphics.DrawImage(initialImage, 0, 0, newWidth, newHeight);
                    ImgProfilePicture.Image = newImage;
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.ChangeProfilePicture();
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region LoadForm
        private void ChangeProfilePictureForm_Load(object sender, EventArgs e)
        {
            try
            {
                _controller.GetProfilePicture();
                BaseForm_Load(this);
                lblChangeProfilePicture.Location = new POINT(this.Width / 2 - lblChangeProfilePicture.Width / 2, lblChangeProfilePicture.Location.Y); 

            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region PressEscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
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
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                return false;
            }
        }
        #endregion
    }
}
