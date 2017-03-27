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
        List<CommentDTO> _sortedComments = new List<CommentDTO>();
        #endregion

        #region Constructor
        public CommentsController(ICommentsForm form, PostDTO post)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
            _post = post;
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            SortComments();
            DisplayComments();
        }
        #endregion

        #region GetSortedComments
        public void SortComments()
        {
            try
            {
                List<CommentDTO> comments = new List<CommentDTO>();
                comments = _service.GetCommentsForPostID(_post.PostID);

                foreach (var comment in comments)
                {
                    if (!_sortedComments.Exists(x => x == comment))
                    {
                        if (comment.MainComment == null)
                        {
                            _sortedComments.Add(comment);
                            var find = comments.FindAll(x => x.MainComment == comment.CommentID);
                            if (find != null && find.Count > 0)
                            {
                                find.ForEach(x => _sortedComments.Add(x));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region
        public void DisplayComments()
        {
            try
            {
                List<CommentDTO> comments = _sortedComments;
                int currentComment = 0;
                foreach (var comment in comments)
                {
                    if (comment.MainComment == null)
                    {
                        _form.DisplayComments(comment, 0, currentComment);
                    }
                    else
                    {
                        _form.DisplayComments(comment, 20, currentComment);
                    }
                    currentComment++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
