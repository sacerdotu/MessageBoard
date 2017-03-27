using MessageBoardController.AppGlobalVariables;
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
    public class AddCommentController
    {
        private IMessageBoardService _service;
        private IAddCommentsForm _form;
        #region Constructor
        public AddCommentController(IAddCommentsForm form)
        {
            try
            {
                _service = new MessageBoardServiceClient();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region AddComment
        public void AddComment(string comment)
        {
            CommentDTO addComment = new CommentDTO();
            addComment.CommentContent = comment;
            addComment.CreationDate = DateTime.Now;
            addComment.IsBlocked = false;
            addComment.PostID = AppGlobalVariables.AppGlobalVariables.Instance.PostID;
            addComment.UserID = AppGlobalVariables.AppGlobalVariables.Instance.UserID;
            addComment.MainComment = AppGlobalVariables.AppGlobalVariables.Instance.CommentID;
            bool result = _service.AddComment(addComment);
        }
        #endregion
    }
}
