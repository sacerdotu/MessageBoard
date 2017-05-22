using MessageBoardCommon;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            InstanceContext context = new InstanceContext(new Proxy());
            _service = new MessageBoardServiceClient(context);
            _form = form;
        }
        #endregion

        #region AddComment
        public void AddComment(string comment, bool mainComment)
        {
            try
            {
                CommentDTO addComment = new CommentDTO();
                addComment.CommentContent = comment;
                addComment.CreationDate = DateTime.Now;
                addComment.IsBlocked = false;
                addComment.PostID = AppGlobalVariables.AppGlobalVariables.Instance.PostID;
                addComment.UserID = AppGlobalVariables.AppGlobalVariables.Instance.UserID;
                if (!mainComment)
                {
                    addComment.MainComment = AppGlobalVariables.AppGlobalVariables.Instance.CommentID;
                }
                else
                {
                    addComment.MainComment = null;
                }
                bool result = _service.AddComment(addComment);
                if (result)
                {
                    _form.Success();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }

        }
        #endregion
    }
}