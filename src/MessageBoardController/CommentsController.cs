using DevExpress.XtraBars.Alerter;
using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
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
        private int _lastCommentID;
        #endregion

        #region Constructor
        public CommentsController(ICommentsForm form, PostDTO post)
        {
            _form = form;
            InstanceContext context = new InstanceContext(new Proxy());
            _service = new MessageBoardServiceClient(context);
            _post = post;
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            SortComments();
            DisplayComments();
            StartNotifications();
        }
        #endregion

        #region GetSortedComments
        public void SortComments()
        {
            try
            {
                List<CommentDTO> comments = new List<CommentDTO>();
                comments = _service.GetCommentsForPostID(_post.PostID);
                _lastCommentID = comments.Max(x => x.CommentID);

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
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region DisplayComments
        public void DisplayComments()
        {
            try
            {
                List<CommentDTO> comments = _sortedComments;
                int currentComment = 0;
                if (comments.Count == 1)
                {
                    _form.UcWidth = 640;
                    _form.DisplayComments(comments[0], 0, 0, true);
                    return;
                }
                _form.UcWidth = 623;
                foreach (var comment in comments)
                {
                    if (comment.MainComment == null)
                    {
                        _form.DisplayComments(comment, 0, currentComment, true);
                    }
                    else
                    {
                        _form.DisplayComments(comment, 20, currentComment, false);
                    }
                    currentComment++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region Notifications
        private Timer _notificationPopUpTimer;
        private int _checkNotificationsInterval = 6000;
        private List<Int64> _shownNotifications = new List<long>();
        private List<CommentDTO> _notifications;
        private AlertControl _alertControl = new AlertControl();


        #region StartNotifications
        public void StartNotifications()
        {
            if (_checkNotificationsInterval != 0)
            {
                _notificationPopUpTimer = new Timer(NotificationPopUpTimer_Tick, null,
                                                    _checkNotificationsInterval,
                                                    _checkNotificationsInterval);
            }
        }
        #endregion

        #region LoadNotificationPopUpSettings
        private void NotificationPopUpTimer_Tick(object state)
        {
            try
            {
                _notificationPopUpTimer.Change(Timeout.Infinite, Timeout.Infinite);
                _notifications = _service.GetInsertedCommentsNotifications(_lastCommentID, _post.PostID, AppGlobalVariables.AppGlobalVariables.Instance.UserID);
                _lastCommentID = _notifications.Max(x => x.CommentID);
                ShowNotifications();
                _notificationPopUpTimer.Change(_checkNotificationsInterval, _checkNotificationsInterval);
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region ShowNotifications
        private void ShowNotifications()
        {
            try
            {
                if (_notifications == null)
                {
                    return;
                }
                foreach (var notificationItem in _notifications)
                {
                    if (_shownNotifications.Contains(notificationItem.CommentID))
                        continue;
                    _shownNotifications.Add(notificationItem.CommentID);

                    var alertInfo = new AlertInfo("New Comment", String.Format("The user {0} has added a new comment.", notificationItem.tblUser.Username));
                    alertInfo.Tag = notificationItem;

                    _form.ShowNotification(alertInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion
        #endregion
    }
}
