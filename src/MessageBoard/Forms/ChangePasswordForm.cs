using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using System;
using System.Windows.Forms;
using static DevExpress.Office.PInvoke.Win32;

namespace MessageBoard.Forms
{
    public partial class ChangePasswordForm : BaseForm, IChangePasswordForm
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
            LoadForm();
        }
        #endregion

        #region ChangePasswordClick
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.GeneratePassword(AppGlobalVariables.Instance.UserID, Convert.ToString(TxtPassword.EditValue), Convert.ToString(TxtConfirmPassword.EditValue));
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
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

        #region EscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
            {
                if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
                {
                    ForumForm form = new ForumForm();
                    form.Show();
                    this.Close();
                }
                return base.ProcessDialogKey(keyData);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                return false;
            }
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            BaseForm_Load(this);
            lblChangePassword.Location = new POINT(this.Width / 2 - lblChangePassword.Width / 2, lblChangePassword.Location.Y);
        }
        #endregion
    }
}
