using MessageBoardCommon;
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
    public class CommentsController
    {
        #region Members
        private ICommentsForm _form;
        private IMessageBoardService _service;
        private PostDTO _post;
        #endregion

        #region Constructor
        public CommentsController (ICommentsForm form, PostDTO post)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
            _post = post;
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            try
            {
                List<CommentDTO> comments = new List<CommentDTO>();
                comments = _service.GetCommentsForPostID(_post.PostID);
                List<CommentDTO> sortedComments = new List<CommentDTO>();
                foreach (var comment in comments)
                {
                    if (!sortedComments.Exists(x => x == comment))
                    {
                        if (comment.MainComment == null)
                        {
                            sortedComments.Add(comment);
                            var find = comments.FindAll(x => x.MainComment == comment.CommentID);
                            if (find != null && find.Count > 0)
                            {
                                find.ForEach(x => sortedComments.Add(x));
                            }
                        }
                    }
                }
                DisplayComments(sortedComments);
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region DisplayComments
        public void DisplayComments(List<CommentDTO> comments)
        {
            try
            {

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
