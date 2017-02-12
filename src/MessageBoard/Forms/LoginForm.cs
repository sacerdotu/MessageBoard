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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region btnClose
        private void hplRegister_Click(object sender, EventArgs e)
        {
                RegisterForm register = new RegisterForm();
                register.Show();
                this.Hide();
        }
        #endregion

        #region btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = _controller.ValidateLogin(TxtUsername.EditValue.ToString(), TxtPassword.EditValue.ToString());

                if (validation == true)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                    
                }
                else
                {
                    XtraMessageBox.Show("Wrong Username or Password");
                }
            }
            catch (EndpointNotFoundException ex)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
                Logger.Error(ex.Message);           
            }
            catch (NullReferenceException ex)
            {
                XtraMessageBox.Show(Constants.ExceptionNullObjReference);
                Logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(ex.Message);
            }
        }
        #endregion
    }
}
