using DevExpress.XtraEditors;
using MessageBoard.Forms;
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

namespace MessageBoard
{
    public partial class MainForm : Form, IMainForm
    {
        MainController _mainController;

        #region Properties
        public SimpleButton BtnDisplayUsers
        {
            get { return btnDisplayUsers; }
        }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            _mainController = new MainController(this);
        }
        #endregion

        #region DisplayUsersClick
        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsersForm displayForm = new DisplayUsersForm();
            displayForm.Show();
            this.Close();
        }
        #endregion

        #region MainFormLoad
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _mainController.IsAdministrator(AppGlobalVariables.Instance.UserID);
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
            }
        }
        #endregion

        #region ChangePasswordClick
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region ForumClick
        private void btnForum_Click(object sender, EventArgs e)
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
        #endregion
    }
}
