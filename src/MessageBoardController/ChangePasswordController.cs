using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class ChangePasswordController
    {
        IService1 _service;
        IChangePasswordForm _form;
        public ChangePasswordController()
        {

        }
        public ChangePasswordController(IChangePasswordForm form)
        {
            _form = form;
            _service = new Service1Client();
        }

        public void GeneratePassword(string username)
        {
            try
            {
                UserDTO user = new UserDTO();
                string _password = _form.TxtPassword.Text;
                user.PasswordSalt = HashHelper.GetSalt();
                user.PasswordHash = HashHelper.GetHash(_password, user.PasswordSalt);
                user.Username = username;
                _service.ChangePassword(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
