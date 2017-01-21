using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MessageBoardDTO;

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

        public bool ValidateLogin(string username, string password)
        {
            RegisterController checkHash = new RegisterController();
            var user = _service.CheckUserAndPassword(username);
            string generatedPassword = checkHash.GetHash(password, user.PasswordSalt);
            if (generatedPassword == user.PasswordHash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
