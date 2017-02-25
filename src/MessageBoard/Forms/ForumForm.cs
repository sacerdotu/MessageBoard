using DevExpress.XtraEditors;
using MessageBoardCommon;
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
    public partial class ForumForm : Form
    {
        private string _username;
        public ForumForm()
        {
            InitializeComponent();
        }
        public ForumForm(string username)
            :this()
        {
            _username = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(_username);
            form.Show();
            this.Close();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            AddPostForm form = new AddPostForm(_username);
            form.Show();
        }
    }
}
