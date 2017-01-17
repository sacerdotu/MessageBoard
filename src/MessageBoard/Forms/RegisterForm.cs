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
        RegisterController _controller;
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
        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController(this);
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            _controller.RegisterUser();
        }


    }
}
