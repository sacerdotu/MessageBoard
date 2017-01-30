using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MessageBoardController;
using MessageBoardController.Interfaces;
using DevExpress.XtraGrid;

namespace MessageBoard.Forms
{
    public partial class DisplayUsersForm : Form, IDisplayUsersForm
    {
        public GridControl GrdDisplayUsers
        {
            get
            {
                return grdDisplayUsers;
            }
        }
        DisplayUsersController _controller;
        public DisplayUsersForm()
        {
            InitializeComponent();
            _controller = new DisplayUsersController(this);
           
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
        }
        #region GridLayout
        private void GridLayout()
        {
           
        }
        #endregion
    }
}
