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

        DisplayUsersController _controller;
        string _username;
        #region Constructor
        public DisplayUsersForm()
        {
            InitializeComponent();
            _controller = new DisplayUsersController(this);
           
        }
        public DisplayUsersForm(string username)
            :this()
        {
            _username = username;
        }
        #endregion

        #region Methods
        private void UsersForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
        }
        #region GridLayout
        private void GridLayout()
        {
           
        }
        #endregion
        private void grdDisplayUsers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int userID = _controller.GetUserID(e);
                if (userID > 0)
                {
                    UserDetailsForm userDetails = new UserDetailsForm(userID, _username);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(_username);
            mainForm.Show();
            this.Close();
        }
        #endregion

        #region SaveChanges
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.SaveChanges();
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
