using DevExpress.XtraGrid.Views.Grid;
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
                //postsList = _service.FillPostsGrid();
                _form.GrdDisplayPosts.DataSource = _service.FillPostsGrid();
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
