using DevExpress.XtraEditors;
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
        #endregion
        public UserDetailsForm()
        {
            InitializeComponent();
        }
        public UserDetailsForm(int UserID)
            :this()
        {
           int userID = UserID;
        }
    }
}
