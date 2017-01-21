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
    }
}
