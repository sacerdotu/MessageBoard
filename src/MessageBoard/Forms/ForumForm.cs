using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Constants;
using MessageBoardController.Interfaces;
using System;
using System.Collections;
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
    public partial class ForumForm : Form, IForumForm
    {
        ForumController _controller;
 
        #region Properties
        public GridControl GrdDisplayPosts
        {
            get
            {
                return grdDisplayPosts;
            }
        }

        public GridView ViewDisplayPosts
        {
            get
            {
                return viewDisplayPosts;
            }
        }
        #endregion

        #region Constructor
        public ForumForm()
        {
            InitializeComponent();
            _controller = new ForumController(this);
        }
        #endregion

        #region BackClick
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region AddPostClick
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            AddPostForm form = new AddPostForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region LoadForm
        private void ForumForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
        }
        #endregion

        #region CustomUnboundColumnData
        private void viewDisplayPosts_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            try
            {
                _controller.viewDisplayPosts_CustomUnboundColumnData(sender, e);
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Constants.ExceptionService);
            }   
        }
        #endregion

        #region CustomRowCellEdit
        private void viewDisplayPosts_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if(e.RowHandle == GridControl.AutoFilterRowHandle)
            {
                if(e.Column.ColumnType.Name.Equals("DateTime"))
                {
                    e.RepositoryItem = repCommentDate;
                }
            }
        }
        #endregion
    }
}
