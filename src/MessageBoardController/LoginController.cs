using MessageBoardController.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MessageBoardDTO;
using MessageBoardController.HelperClasses;
using MessageBoardCommon;
using MessageBoardController.MessageBoardService;

namespace MessageBoardController
{
    public class LoginController
    {
        private int _userID;
        private ILoginForm _form;
        private IMessageBoardService _service;

        #region Constructor
        public LoginController(ILoginForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region ValidateLogin
        public int ValidateLogin(string username, string password)
        {
            try
            {
                if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
                {
                    _form.UsernameAndPasswordAreNull();
                    _userID = 0;
                }
                else if (String.IsNullOrEmpty(username))
                {
                    _form.UsernameIsNull();
                    _userID = 0;
                }
                else if (String.IsNullOrEmpty(password))
                {
                    _form.PasswordIsNull();
                    _userID = 0;
                }
                else
                {
                    var user = _service.CheckUserAndPassword(username);
                    if (user != null)
                    {
                        string generatedPassword = HashHelper.GetHash(password, user.PasswordSalt);
                        if (generatedPassword != null && generatedPassword == user.PasswordHash)
                        {
                            _userID = user.UserID;
                        }
                        else
                        {
                            _userID = -1;
                        }
                    }
                    else
                    {
                        _userID = -1;
                    }
                }
                return _userID;
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw;
            }
        }
        #endregion

        #region CheckUserID
        public void CheckUserID()
        {
            if(_userID > 0)
            {
                _form.LoadForumForm();
            }
            else if(_userID == -1)
            {
                _form.InsertPasswordAgain();
            }
        }
        #endregion

    }
}
