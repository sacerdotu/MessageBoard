using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;

namespace MessageBoardController
{
    public class ForumController
    {
        #region Members
        private IMessageBoardService _service;
        private IForumForm _form;
        PostDTO _post = new PostDTO();
        private Dictionary<string, string> _getControls = new Dictionary<string, string>();
        private Dictionary<string, string> _translatedControls = new Dictionary<string, string>();
        private int _lastPostID;
        #endregion

        #region Constructor
        public ForumController(IForumForm form)
        {
            InstanceContext context = new InstanceContext(new Proxy());
            _form = form;
            _service = new MessageBoardServiceClient(context);
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

                _lastPostID = list.Max(x => x.PostID);
                StartNotifications();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
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
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
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
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region SyncTranslations
        public void SyncTranslations(string language)
        {
            try
            {
                _getControls = _form.GetAllControls();
                TranslateControls(language);
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region TranslateControls
        public void TranslateControls(string language)
        {
            foreach (KeyValuePair<string, string> control in _getControls)
            {
                string translate = TranslateHelper.Translate(control.Value, "English", language);
                _translatedControls.Add(control.Key, translate);
            }
            InsertTranslations();
            _translatedControls.Clear();
        }
        #endregion

        #region InsertTranslations
        public void InsertTranslations()
        {
            if (_translatedControls != null && _translatedControls.Count > 0)
            {
                _service.InsertTranslations(_translatedControls, AppGlobalVariables.AppGlobalVariables.Instance.CurrentLanguage);
            }
        }
        #endregion

        #region UpdateUserLanguage
        public void UpdateUserLanguage()
        {
            try
            {
                _service.UpdateUserLanguage(AppGlobalVariables.AppGlobalVariables.Instance.UserID, AppGlobalVariables.AppGlobalVariables.Instance.CurrentLanguage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Notifications
        private System.Threading.Timer _notificationPopUpTimer;
        private int _checkNotificationsInterval = 6000;
        private List<Int64> _shownNotifications = new List<long>();
        private List<PostDTO> _notifications;
        private AlertControl _alertControl = new AlertControl();
        private Int32 _notificationFormDelay = 3;


        #region StartNotifications
        public void StartNotifications()
        {
            if (_checkNotificationsInterval != 0)
            {
                //_checkNotificationsInterval *= 1000;
                _notificationPopUpTimer = new System.Threading.Timer(NotificationPopUpTimer_Tick, null,
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
                _notifications = _service.GetInsertedPostsNotifications(_lastPostID);

                ShowNotifications();
                _notificationPopUpTimer.Change(_checkNotificationsInterval, _checkNotificationsInterval);
            }
            catch (Exception ex)
            {
                //new CtException(AppContext.Instance.GetTranslation(Definitions.ERR_UNKNOWN_ERROR), ex).WriteToLog();
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
                    if (_shownNotifications.Contains(notificationItem.PostID))
                        continue;
                    _shownNotifications.Add(notificationItem.PostID);

                    var alertInfo = new AlertInfo("New Post", String.Format("The user {0} has added a new post.", notificationItem.tblUser.Username));
                    alertInfo.Tag = notificationItem;
                    //if (AppContext.Instance.MainForm.InvokeRequired)
                    //{
                    //    AppContext.Instance.MainForm.Invoke(new System.Action<AlertInfo>(ShowNotification), new object[] { alertInfo });
                    //}

                    _form.ShowNotification(alertInfo);
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #endregion
    }
}
