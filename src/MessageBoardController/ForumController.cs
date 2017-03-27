﻿using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageBoardController
{
    public class ForumController
    {
        private IMessageBoardService _service;
        private IForumForm _form;
        PostDTO _post = new PostDTO();
        //List<PostDTO> postsList = new List<PostDTO>();

        #region Constructor
        public ForumController(IForumForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            try
            {
                List<PostDTO> list = new List<PostDTO>();
                list = _service.FillPostsGrid();
                _form.GrdDisplayPosts.DataSource = list;
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region IsAdministrator
        public void IsAdministrator(int userID)
        {
            try
            {
                bool isAdministrator = _service.IsAdministrator(userID);
                if (isAdministrator == false)
                {
                    _form.HideUserDetailsBar();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region GetPost
        public void GetPost(DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                
                for (int i = 0; i < _form.ViewDisplayPosts.RowCount; i++)
                {
                    if (e.Clicks == 2)
                    {
                        _post = (PostDTO)_form.ViewDisplayPosts.GetFocusedRow();
                        AppGlobalVariables.AppGlobalVariables.Instance.PostID = _post.PostID;
                    }
                }
                if (_post.PostID > 0)
                {
                    
                    _form.LoadCommentsForm(_post);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion
    }
}
