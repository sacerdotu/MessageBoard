using DevExpress.XtraEditors;
using MessageBoard;
using MessageBoardController;
using MessageBoard.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoardController.Interfaces;
using System.ServiceModel;
using MessageBoardController.HelperClasses;
using MessageBoardController.Constants;
using MessageBoardCommon;
using MessageBoardController.AppGlobalVariables;

namespace MessageBoard
{
    public partial class LoginForm : Form, ILoginForm
    {
        LoginController _controller;

        #region Properties
        public TextEdit TxtUsername
        {
            get
            {
                return txtUsername;
            }
        }

        public TextEdit TxtPassword
        {
            get
            {
                return txtPassword;
            }
        }
        #endregion

        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
            _controller = new LoginController(this);
        }
        #endregion

        #region Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Register
        private void hplRegister_Click(object sender, EventArgs e)
        {
                RegisterForm register = new RegisterForm();
                register.Show();
                this.Hide();
        }
        #endregion

        #region LoadMainForm
        public void LoadMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        #endregion

        #region InsertPasswordAgain
        public void InsertPasswordAgain()
        {
            XtraMessageBox.Show("Wrong Username or Password");
            Logger.Information("Failed login attempt: Username is: {0} and Password is {1}", TxtUsername.Text, TxtPassword.Text);
            TxtPassword.Text = string.Empty;
            TxtUsername.Text = string.Empty;
        }
        #endregion

        #region btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                AppGlobalVariables.Instance.UserID = _controller.ValidateLogin(TxtUsername.EditValue.ToString(), TxtPassword.EditValue.ToString());
                _controller.CheckUserID();
            }
            catch (EndpointNotFoundException)
            {
                XtraMessageBox.Show(Constants.ExceptionService);           
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.CouldNotLogIn);
            }
        }
        #endregion

        #region txtPasswordKeyDown
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        #endregion
    }
}
