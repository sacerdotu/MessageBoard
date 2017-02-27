using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageBoardController
{
    public class ForumController
    {
        private IService1 _service;
        private IForumForm _form;
        Dictionary<PostDTO, DateTime?> postsDictionary = new Dictionary<PostDTO, DateTime?>();

        public ForumController(IForumForm form)
        {
            _form = form;
            _service = new Service1Client();
        }
        public void LoadForm()
        {
            try
            {
                postsDictionary = _service.FillPostsGrid();
                _form.GrdDisplayPosts.DataSource = postsDictionary.Keys.ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }

        public void viewDisplayPosts_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.Column.FieldName == "CommentDate" && e.IsGetData)
                {
                    PostDTO post = (PostDTO)e.Row;
                    foreach (var item in postsDictionary)
                    {
                        if (((PostDTO)item.Key).PostID == post.PostID)
                        {
                            e.Value = item.Value;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
    }
}
