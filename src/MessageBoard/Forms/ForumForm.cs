using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Constants;
using MessageBoardController.Interfaces;
using MessageBoardDTO;
using System;
using System.Collections;
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
    public partial class ForumForm : Form, IForumForm
    {
        ForumController _controller;
 
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
                return barUserInformations;
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
            _controller.LoadForm();
            _controller.IsAdministrator(AppGlobalVariables.Instance.UserID);
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

        #region LoadCommnetsForm
        public void LoadCommentsForm(PostDTO post)
        {
            CommentsForm postComments = new CommentsForm(post);
            postComments.Show();
            this.Close();
        }
        #endregion

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}
