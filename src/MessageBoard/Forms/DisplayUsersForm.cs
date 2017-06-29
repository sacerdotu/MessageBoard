using System;
using DevExpress.XtraEditors;
using MessageBoardController;
using MessageBoardController.Interfaces;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using DevExpress.XtraGrid.Views.Base;
using MessageBoardController.AppGlobalVariables;
using static DevExpress.Office.PInvoke.Win32;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class DisplayUsersForm : BaseForm, IDisplayUsersForm
    {
        DisplayUsersController _controller;

        #region Properties
        public GridControl GrdDisplayUsers
        {
            get
            {
                return grdDisplayUsers;
            }
        }
        public GridView ViewDisplayUsers
        {
            get
            {
                return viewDisplayUsers;
            }
        }
        #endregion

        #region Constructor
        public DisplayUsersForm()
        {
            InitializeComponent();
            _controller = new DisplayUsersController(this);
           
        }
        #endregion

        #region LoadForm
        private void UsersForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
            BaseForm_Load(this);
            lblViewUsers.Location = new POINT(this.Width / 2 - lblViewUsers.Width / 2, lblViewUsers.Location.Y);
        }
        #endregion

        #region DisplayUsersClick
        private void grdDisplayUsers_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                _controller.GetUserID(e);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        public void LoadUserDetailsForm()
        {
            UserDetailsForm userDetails = new UserDetailsForm(AppGlobalVariables.Instance.UserID);
            userDetails.Show();
            this.Close();
        }

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region SaveChanges
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (_controller.SaveChanges() == true)
                {
                    XtraMessageBox.Show("Changes were saved!");
                }
                else
                {
                    XtraMessageBox.Show("Could not save changes!");
                }
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

        #region RowUpdate
        private void viewDisplayUsers_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                _controller.ModifiedUsers(e);
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
    }
}
