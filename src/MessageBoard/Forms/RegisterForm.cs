using DevExpress.XtraEditors;
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
        #endregion
        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
            TxtConfirmPassword.KeyDown += TxtConfirmPassword_KeyDown;
        }

        private void TxtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    RegisterUser(sender, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            try
            {
                if (TxtPassword.EditValue.ToString() == TxtConfirmPassword.EditValue.ToString())
                {
                    _controller.RegisterUser();
                }
                else
                    XtraMessageBox.Show("Insert password again!");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
