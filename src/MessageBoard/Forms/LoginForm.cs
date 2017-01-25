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

namespace MessageBoard
{
    public partial class LoginForm : Form, ILoginForm
    {
        LoginController _controller;
        log4net.ILog log;
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
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hplRegister_Click(object sender, EventArgs e)
        {
            
                RegisterForm register = new RegisterForm();
                register.Show();
                this.Hide();
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = _controller.ValidateLogin(TxtUsername.EditValue.ToString(), TxtPassword.EditValue.ToString());

                if (validation == true)
                {
                    XtraMessageBox.Show("Success!");
                }
                else
                {
                    XtraMessageBox.Show("Wrong Username or Password");
                }
            }
            catch (EndpointNotFoundException ex)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
                log.Error(ex.Message);           
            }
            catch (NullReferenceException ex)
            {
                XtraMessageBox.Show(Constants.ExceptionNullObjReference);
                log.Error(ex.Message);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }
    }
}
