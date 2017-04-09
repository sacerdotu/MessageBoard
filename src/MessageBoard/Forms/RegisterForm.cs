using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        RegisterController _controller;
        
        #region Properties
        public TextEdit TxtFirstName
        {
            get { return ucUserInformations.TxtFirstName; }
        }

        public TextEdit TxtLastName
        {
            get { return ucUserInformations.TxtLastName; }
        }

        public TextEdit TxtCountry
        {
            get { return ucUserInformations.TxtCountry; }
        }

        public ComboBoxEdit CmbFunction
        {
            get { return ucUserInformations.CmbFunction; }
        }
        public TextEdit TxtCity
        {
            get { return ucUserInformations.TxtCity; }
        }

        public TextEdit TxtUsername
        {
            get { return ucUserInformations.TxtUsername; }
        }

        public TextEdit TxtPassword
        {
            get { return ucUserInformations.TxtPassword; }
        }

        public TextEdit TxtConfirmPassword
        {
            get { return ucUserInformations.TxtConfirmPassword; }
        }
        public CheckEdit IsAdministrator
        {
            get { return ucUserInformations.ChkAdministrator; }
        }
        public CheckEdit IsActive
        {
            get { return ucUserInformations.ChkActive; }
        }
        public DateEdit AccountCreationDate
        {
            get { return ucUserInformations.DateRegisterDate; }
        }
        public LabelControl lblRegisterDate
        {
            get { return ucUserInformations.LblRegisterDate; }
        }

        public PictureEdit ImgProfilePicture
        {
            get { return ucUserInformations.ImgProfilePicture; }
        }
        #endregion

        #region Constructor
        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
            TxtConfirmPassword.KeyDown += TxtConfirmPassword_KeyDown;
        }
        #endregion

        #region EnterKeyEvent
        private void TxtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterUser(sender, e);
            }
        }
        #endregion

        #region RegisterUserButton
        private void RegisterUser(object sender, EventArgs e)
        {
            try
            {
                _controller.RegisterUser(Convert.ToString(TxtPassword.EditValue), Convert.ToString(TxtConfirmPassword.EditValue));
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
        }
        #endregion

        #region AccountCreated
        public void AccountCreated()
        {
            XtraMessageBox.Show(Constants.AccountCreated);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        #endregion

        #region InsertPasswordsAgain
        public void FillAllFields()
        {
            XtraMessageBox.Show(Constants.FillAllFields);
            TxtPassword.Text = string.Empty;
            TxtConfirmPassword.Text = string.Empty;
        }
        #endregion

        #region Load
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            IsAdministrator.Visible = false;
            IsActive.Visible = false;
            AccountCreationDate.Visible = false;
            lblRegisterDate.Visible = false;
        }
        #endregion

        #region BackButton
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
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
