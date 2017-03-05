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
                var user = _service.CheckUserAndPassword(username);
                if (user != null)
                {
                    string generatedPassword = HashHelper.GetHash(password, user.PasswordSalt);
                    if (generatedPassword != null && generatedPassword == user.PasswordHash)
                    {
                        return user.UserID;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw;
            }
        }
        #endregion

    }
}
