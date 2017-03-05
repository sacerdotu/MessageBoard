﻿using DevExpress.Data.Filtering;
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

        ForumController _controller;
        private string _username;
        public ForumForm()
        {
            InitializeComponent();
        }
        public ForumForm(string username)
            :this()
        {
            _username = username;
            _controller = new ForumController(this);
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

        private void ForumForm_Load(object sender, EventArgs e)
        {
            _controller.LoadForm();
            
        }

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
    }
}
