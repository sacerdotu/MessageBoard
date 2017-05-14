using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class ForumForm : BaseForm, IForumForm
    {
        ForumController _controller;
        Proxy _proxy;
 
        #region Properties
        public GridControl GrdDisplayPosts
        {
            get
            {
                return grdDisplayPosts;
            }
        }

        public GridView ViewDisplayPosts
        {
            get
            {
                return viewDisplayPosts;
            }
        }

        public BarButtonItem BarUserInformations
        {
            get
            {
                return barUserInformation;
            }
        } 
        #endregion

        #region Constructor
        public ForumForm()
        {
            InitializeComponent();
            _controller = new ForumController(this);
        }
        #endregion

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region AddPostClick
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            AddPostForm form = new AddPostForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region LoadForm
        private void ForumForm_Load(object sender, EventArgs e)
        {
            try
            {
                _controller.LoadForm();
                _controller.IsAdministrator(AppGlobalVariables.Instance.UserID);
                if(AppGlobalVariables.Instance.CurrentLanguage == "English")
                {
                    barEnglish.Checked = true;
                }
                else
                {
                    barFrench.Checked = true;
                    AppGlobalVariables.Instance.GetTranslations = true;
                }
                BaseForm_Load(this);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region AllowUserDetailsBar
        public void HideUserDetailsBar()
        {
            BarUserInformations.Visibility = BarItemVisibility.Never;
        }
        #endregion

        #region CustomRowCellEdit
        private void viewDisplayPosts_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle == GridControl.AutoFilterRowHandle)
            {
                if (e.Column.ColumnType.Name.Equals("DateTime")||e.Column.Caption.Equals("Last Comment Date"))
                {
                    e.RepositoryItem = repCommentDate;
                }
            }
        }
        #endregion

        #region ChangePasswordClick
        private void barChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region UserInformationsClick
        private void barUserInformations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DisplayUsersForm form = new DisplayUsersForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region ChangeProfilePictureClick
        private void barChangeProfilePicture_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeProfilePictureForm form = new ChangeProfilePictureForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region DisplayCommentsClick
        private void viewDisplayPosts_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                _controller.GetPost(e);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region LoadCommnentsForm
        public void LoadCommentsForm(PostDTO post)
        {
            AppGlobalVariables.Instance.Post = post;
            AppGlobalVariables.Instance.NrOfNewComments = 0;
            CommentsForm postComments = new CommentsForm();
            postComments.Show();
            this.Close();
        }
        #endregion

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
            {
                if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
                {
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

        #region barEnglishButton
        private void barEnglish_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (barFrench.Checked)
            {
                barFrench.Checked = false;
            }
            if (barEnglish.Checked)
            {
                AppGlobalVariables.Instance.CurrentLanguage = "English";
                AppGlobalVariables.Instance.GetTranslations = true;
                Translate();
                TranslateMenu(barManager1.Items);
                _controller.UpdateUserLanguage();
                return;
            }
            barEnglish.Checked = true;
        }
        #endregion

        #region barFrenchButton
        private void barFrench_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (barEnglish.Checked)
            {
                barEnglish.Checked = false;
            }
            if (barFrench.Checked)
            {
                AppGlobalVariables.Instance.CurrentLanguage = "French";
                AppGlobalVariables.Instance.GetTranslations = true;
                Translate();
                TranslateMenu(barManager1.Items);
                _controller.UpdateUserLanguage();
                return;
            }
            barFrench.Checked = true;
        }
        #endregion

        #region btnSyncLanguage
        private void barSyncLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (barFrench.Checked)
            {
                _controller.SyncTranslations("French");
            }
            else
            {
                _controller.SyncTranslations("English");
            }
        }
        #endregion

        #region AddAllControls
        public Dictionary<string,string> GetAllControls()
        {
            Dictionary<string, string> getControls = new Dictionary<string, string>();
            getControls = AddAllControls();
            return getControls;
        }
        #endregion

        private void ForumForm_Shown(object sender, EventArgs e)
        {
            TranslateMenu(barManager1.Items);
        }

        public void ShowNotification()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
