using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MessageBoardController;
using MessageBoardController.Interfaces;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using DevExpress.XtraGrid.Views.Base;
using MessageBoardController.Constants;

namespace MessageBoard.Forms
{
    public partial class DisplayUsersForm : Form, IDisplayUsersForm
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

        #region FormLoad
        private void UsersForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
        }
        #endregion

        #region GridLayout
        private void GridLayout()
        {
           
        }
        #endregion

        #region DisplayUsersClick
        private void grdDisplayUsers_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                int userID = _controller.GetUserID(e);
                if (userID > 0)
                {
                    UserDetailsForm userDetails = new UserDetailsForm(userID);
                    userDetails.Show();
                    this.Close();
                }
                else
                {
                    return;
                }
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
            catch(Exception)
            {
                XtraMessageBox.Show(Constants.CouldNotSaveChanges);
            }   
        }
        #endregion

        #region RowUpdate
        private void viewDisplayUsers_RowUpdated(object sender, RowObjectEventArgs e)
        {
            _controller.ModifiedUsers(e);
        }
        #endregion
    }
}
