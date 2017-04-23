using DevExpress.XtraEditors;
using MessageBoardController;
using MessageBoard.Forms;
using System;
using System.Windows.Forms;
using MessageBoardController.Interfaces;
using MessageBoardCommon;
using MessageBoardController.AppGlobalVariables;

namespace MessageBoard
{
    public partial class LoginForm : BaseForm, ILoginForm
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
            : base()
        {
            AppGlobalVariables.Instance.GetTranslations = true;
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
        public void LoadForumForm()
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Hide();
        }
        #endregion

        #region InsertPasswordAgain
        public void InsertPasswordAgain()
        {
            XtraMessageBox.Show("Wrong Username or Password!");
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
                AppGlobalVariables.Instance.UserID = _controller.ValidateLogin(Convert.ToString(TxtUsername.EditValue), Convert.ToString(TxtPassword.EditValue));
                _controller.CheckUserID();
            }
            catch (MessageBoardException ex)
            {       
                ex.WriteErrorMessage();
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

        #region UsernameIsNull
        public void UsernameIsNull()
        {
            XtraMessageBox.Show(Constants.UsernameIsNull);
        }
        #endregion

        #region PasswordIsNull
        public void PasswordIsNull()
        {
            XtraMessageBox.Show(Constants.PasswordIsNull);
        }
        #endregion

        #region UsernameAndPasswordAreNull
        public void UsernameAndPasswordAreNull()
        {
            XtraMessageBox.Show(Constants.UsernameAndPasswordAreNull);
        }
        #endregion

        #region LoadForm
        private void LoginForm_Load(object sender, EventArgs e)
        {
            TxtUsername.Focus();
            BaseForm_Load(this);
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
