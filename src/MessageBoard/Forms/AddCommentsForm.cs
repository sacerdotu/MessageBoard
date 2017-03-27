using DevExpress.Tutorials.Controls;
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
    public partial class AddCommentsForm : Form , IAddCommentsForm
    {
        AddCommentController _controller;
        public RichTextBoxEx RtbComment
        {
            get { return rtbComment; }
        }
        
        public AddCommentsForm()
        {
            InitializeComponent();
            _controller = new AddCommentController(this);
        }

        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            _controller.AddComment(RtbComment.Text);
        }
    }
}
