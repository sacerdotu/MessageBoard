using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
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

namespace MessageBoard
{
    public partial class UserDetailsForm : Form, IUserDetailsForm
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
        #endregion

        public UserDetailsForm()
        {
            InitializeComponent();
        }
        public UserDetailsForm(int userID)
            :this()
        {
            _controller = new UserDetailsController(this, userID);
        }

        private void ucUserInformations1_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
            LblUsername.Visible = false;
            LblPassword.Visible = false;
            LblConfirmPassword.Visible = false;
            TxtConfirmPassword.Visible = false;
            TxtPassword.Visible = false;
            TxtUsername.Visible = false;
        }
    }
}
