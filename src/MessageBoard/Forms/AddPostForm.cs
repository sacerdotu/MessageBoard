using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Constants;
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
    public partial class AddPostForm : Form, IAddPostForm
    {
        AddPostController _controller;
        private string _username;
        public RichTextBox RtbPost
        {
            get { return rtbPost; }
        }
        public AddPostForm()
        {
            InitializeComponent();
        }
        public AddPostForm(string username)
            :this()
        {
            _username = username;
            _controller = new AddPostController(this, _username);
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddPost();

            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
            }
            
        }
    }
}
