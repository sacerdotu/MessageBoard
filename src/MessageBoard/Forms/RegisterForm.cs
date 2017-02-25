using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Constants;
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
        #region Members
        RegisterController _controller;
        #endregion

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
        #endregion
        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
            TxtConfirmPassword.KeyDown += TxtConfirmPassword_KeyDown;
        }

        private void TxtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterUser(sender, e);
            }
        }

        #region RegisterUserButton
        private void RegisterUser(object sender, EventArgs e)
        {
            try
            {
                if ((TxtPassword.EditValue.ToString() == TxtConfirmPassword.EditValue.ToString()) && TxtConfirmPassword != null)
                {
                    _controller.RegisterUser();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Insert passwords again!");
                    
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.RegistrationFailed);
            }
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
    }
}
