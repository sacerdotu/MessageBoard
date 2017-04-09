using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
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

        #region Constructor
        public AddPostController(IAddPostForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region AddPost
        public void AddPost(int userID)
        {
            try
            {
                PostDTO addPost = new PostDTO();
                addPost.UserID = userID;
                addPost.PostText = _form.RtbPost.Text;
                addPost.PostImage = ConvertImage.ImageToByteArray(_form.ImgPost.Image);
                addPost.IsPublished = true;
                addPost.CreationDate = DateTime.Now;
                if (_service.AddNewPost(addPost) == true)
                {
                    _form.PostWasAdded();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw new MessageBoardException("", ex);
            }
        }
        #endregion

    }
}
