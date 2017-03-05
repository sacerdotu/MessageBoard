using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class AddPostController
    {
        private IAddPostForm _form;
        private IMessageBoardService _service;
        private string _username;
        public AddPostController(IAddPostForm form, string username)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
            _username = username;
        }

        #region AddPost
        public void AddPost()
        {
            try
            {
                List<string> addPost = new List<string>();
                addPost.Add(_username);
                addPost.Add(_form.RtbPost.Text);
                _service.AddNewPost(addPost);
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
