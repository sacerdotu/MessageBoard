using MessageBoard;
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
        IService1 _service;
        public RegisterController(IRegisterForm form)
        {
            _form = form;
        }
        
        public void RegisterUser()
        {
            try
            {
                UserDTO user = new UserDTO();
                user.FirstName = _form.UcUserInformations.TxtFirstName.ToString();
                user.LastName = _form.UcUserInformations.TxtLastName.ToString();
                user.Username = _form.UcUserInformations.TxtUsername.ToString();
                user.PasswordHash = _form.UcUserInformations.TxtPassword.ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
