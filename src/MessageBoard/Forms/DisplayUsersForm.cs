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
        #region Constructor
        public DisplayUsersForm()
        {
            InitializeComponent();
            _controller = new DisplayUsersController(this);
           
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
                    UserDetailsForm userDetails = new UserDetailsForm(userID);
                    userDetails.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        #endregion
    }
}
