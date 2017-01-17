using MessageBoardController.ServiceReference;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoardController
{
    public class RegisterController
    {
        private IRegisterForm _form;
        private IService1 _service;
        public RegisterController(IRegisterForm form)
        {
            _form = form;
            _service = new Service1Client();
        }


        public void RegisterUser()
        {
            try
            {
                UserDTO user = new UserDTO();
                user.FirstName = _form.TxtFirstName.EditValue.ToString();
                user.LastName = _form.TxtLastName.EditValue.ToString();
                user.Username = _form.TxtUsername.EditValue.ToString();
                user.PasswordHash = _form.TxtPassword.EditValue.ToString();
                _service.InsertNewUser(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
