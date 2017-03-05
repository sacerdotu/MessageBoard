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
using DevExpress.XtraEditors.Repository;
using System.IO;

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
        public LabelControl LblProfilePicture
        {
            get { return lblProfilePicture; }
        }
        public PictureEdit ImgProfilePicture
        {
            get { return imgProfilePicture; }
        }
        public LabelControl LblUsername
        {
            get { return lblUsername; }
        }
        public LabelControl LblPassword
        {
            get { return lblPassword; }
        }
        public LabelControl LblConfirmPassword
        {
            get { return lblConfirmPassword; }
        }

        public SimpleButton BtnBrowse
        {
            get { return btnBrowse; }
        }
        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            openFile.Title = "Select picture";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string picture = openFile.FileName.ToString();
                var initialImage = Image.FromFile(openFile.FileName);

                var newWidth = imgProfilePicture.Width;
                var newHeight = imgProfilePicture.Height;

                var newImage = new Bitmap(newWidth, newHeight);

                using (var graphics = Graphics.FromImage(newImage))
                    graphics.DrawImage(initialImage, 0, 0, newWidth, newHeight);
                imgProfilePicture.Image = newImage;              
            }
        }
    }
}