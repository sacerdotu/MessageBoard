using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoardDTO;
using DevExpress.XtraEditors;

namespace MessageBoard
{
    public partial class ucUserInformations : UserControl
    {
        public ucUserInformations()
        {
            InitializeComponent();
        }

        private void ucUserInformations_Load(object sender, EventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void peProfilePicture_EditValueChanged(object sender, EventArgs e)
        {

        }
        #region Properties
        public TextEdit TxtFirstName
        {
            get { return txtFirstName; }
        }

        public TextEdit TxtLastName
        {
            get { return txtLastName; }
        }

        public TextEdit TxtCountry
        {
            get { return txtCountry; }
        }

        public TextEdit TxtCity
        {
            get { return txtCity; }
        }

        public TextEdit TxtUsername
        {
            get { return txtUsername; }
        }

        public TextEdit TxtPassword
        {
            get { return txtPassword; }
        }

        public TextEdit TxtConfirmPassword
        {
            get { return txtConfirmPassword; }
        }

        public ComboBoxEdit CmbFunction
        {
            get { return cmbFunction; }
        }
        public DateEdit DateRegisterDate
        {
            get { return dateRegisterDate; }
        }
        public CheckEdit ChkAdministrator
        {
            get { return chkAdministrator; }
        }
        public CheckEdit ChkActive
        {
            get { return chkActive; }
        }
        public LabelControl LblRegisterDate
        {
            get { return lblRegisterDate; }
        }
            #endregion
        }
}