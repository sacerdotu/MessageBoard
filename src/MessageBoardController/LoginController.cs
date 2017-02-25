using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MessageBoardDTO;
using MessageBoardController.HelperClasses;
using MessageBoardCommon;

namespace MessageBoardController
{
    public class LoginController
    {
        private ILoginForm _form;
        private IService1 _service;
        public LoginController(ILoginForm form)
        {
            _form = form;
            _service = new Service1Client();
        }

        #region ValidateLogin
        public bool ValidateLogin(string username, string password)
        {
            try
            {
                var user = _service.CheckUserAndPassword(username);
                if (user != null)
                {
                    string generatedPassword = HashHelper.GetHash(password, user.PasswordSalt);
                    if (generatedPassword != null && generatedPassword == user.PasswordHash)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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
