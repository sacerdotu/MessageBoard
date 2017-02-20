using DevExpress.XtraEditors;
using MessageBoard.Forms;
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
    public partial class MainForm : Form, IMainForm
    {
        MainController _mainController;
        private string _username;
        public SimpleButton BtnDisplayUsers
        {
            get { return btnDisplayUsers; }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string username)
            :this()
        {
            _username = username;
            _mainController = new MainController(this, _username);
        }

        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsersForm displayForm = new DisplayUsersForm(_username);
            displayForm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _mainController.IsAdministrator();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
                Logger.Error(ex.Message);
            }
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePasswordForm form = new ChangePasswordForm(_username);
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(ex.Message);
            }
            
        }
    }
}
