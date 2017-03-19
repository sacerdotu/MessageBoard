using DevExpress.XtraEditors;
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

namespace MessageBoard.Forms
{
    public partial class ChangePasswordForm : Form, IChangePasswordForm
    {
        ChangePasswordController _controller;

        #region Properties
        public TextEdit TxtPassword
        {
            get { return txtPassword; }
        }
        public TextEdit TxtConfirmPassword
        {
            get
            {
                return txtConfirmPassword;
            }
        }
        #endregion

        #region Constructor
        public ChangePasswordForm()
        {
            InitializeComponent();
            _controller = new ChangePasswordController(this);
        }
        #endregion

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region ChangePasswordClick
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                    _controller.GeneratePassword(AppGlobalVariables.Instance.UserID, Convert.ToString(TxtPassword.EditValue), Convert.ToString(TxtConfirmPassword.EditValue));
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
            }
        }
        #endregion

        #region PasswordWasChanged
        public void PasswordWasChanged()
        {
            XtraMessageBox.Show("Password was changed!");
        }
        #endregion

        #region InsertPasswordAgain
        public void InsertPasswordAgain()
        {
            XtraMessageBox.Show("Please insert passwords again");
            TxtPassword.Text = String.Empty;
            TxtConfirmPassword.Text = String.Empty;
        }
        #endregion

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                ForumForm form = new ForumForm();
                form.Show();
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}
