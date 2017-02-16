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

namespace MessageBoard.Forms
{
    public partial class ChangePasswordForm : Form, IChangePasswordForm
    {
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
        private string _username;
        ChangePasswordController _controller;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(string username)
            :this()
        {
            _username = username;
            _controller = new ChangePasswordController(this);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtPassword.Text == TxtConfirmPassword.Text)
                {
                    _controller.GeneratePassword(_username);
                }
                else
                {
                    XtraMessageBox.Show("Please insert password again");
                    TxtPassword.Text = String.Empty;
                    TxtConfirmPassword.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
                Logger.Error(ex.Message);
            }
        }
    }
}
