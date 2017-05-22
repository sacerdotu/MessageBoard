using DevExpress.XtraEditors;
using MessageBoard.Forms;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Interfaces;
using System;
using System.Windows.Forms;

namespace MessageBoard
{
    public partial class UserDetailsForm : BaseForm, IUserDetailsForm
    {
        UserDetailsController _controller;

        #region Properties
        public TextEdit TxtFirstName
        {
            get { return ucUserInformations1.TxtFirstName; }
        }

        public TextEdit TxtLastName
        {
            get { return ucUserInformations1.TxtLastName; }
        }

        public TextEdit TxtCountry
        {
            get { return ucUserInformations1.TxtCountry; }
        }

        public ComboBoxEdit CmbFunction
        {
            get { return ucUserInformations1.CmbFunction; }
        }
        public TextEdit TxtCity
        {
            get { return ucUserInformations1.TxtCity; }
        }
        public CheckEdit IsAdministrator
        {
            get { return ucUserInformations1.ChkAdministrator; }
        }
        public CheckEdit IsActive
        {
            get { return ucUserInformations1.ChkActive; }
        }
        public DateEdit AccountCreationDate
        {
            get { return ucUserInformations1.DateRegisterDate; }
        }
        public TextEdit TxtUsername
        {
            get { return ucUserInformations1.TxtUsername; }
        }

        public TextEdit TxtPassword
        {
            get { return ucUserInformations1.TxtPassword; }
        }

        public TextEdit TxtConfirmPassword
        {
            get { return ucUserInformations1.TxtConfirmPassword; }
        }
        public LabelControl LblProfilePicture
        {
            get { return ucUserInformations1.LblProfilePicture; }
        }
        public PictureEdit ImgProfilePicture
        {
            get { return ucUserInformations1.ImgProfilePicture; }
        }
        public LabelControl LblUsername
        {
            get { return ucUserInformations1.LblUsername; }
        }
        public LabelControl LblPassword
        {
            get { return ucUserInformations1.LblPassword; }
        }
        public LabelControl LblConfirmPassword
        {
            get { return ucUserInformations1.LblConfirmPassword; }
        }

        public SimpleButton BtnBrowse
        {
            get { return ucUserInformations1.BtnBrowse; }
        }
        #endregion

        #region Constructors
        public UserDetailsForm()
        {
            InitializeComponent();
        }
        public UserDetailsForm(int userID)
            :this()
        {
            _controller = new UserDetailsController(this, userID);
        }
        #endregion

        #region LoadUserControl
        private void ucUserInformations1_Load(object sender, EventArgs e)
        {
            try
            {
                _controller.LoadForm();
                LblUsername.Visible = false;
                LblPassword.Visible = false;
                LblConfirmPassword.Visible = false;
                TxtConfirmPassword.Visible = false;
                TxtPassword.Visible = false;
                TxtUsername.Visible = false;
                BtnBrowse.Visible = false;
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            DisplayUsersForm form = new DisplayUsersForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region LoadForm
        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            BaseForm_Load(this);
        }
        #endregion
    }
}
