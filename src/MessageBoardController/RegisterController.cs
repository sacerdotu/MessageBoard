using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.ServiceReference;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MessageBoardController
{
    public class RegisterController
    {
        #region Members
        private IRegisterForm _form;
        private IService1 _service;
        #endregion

        #region Constructors
        public RegisterController(IRegisterForm form)
        {
            _form = form;
            _service = new Service1Client();
        }

        public RegisterController()
        { }
        #endregion

        #region RegisterUser
        public void RegisterUser()
        {
            try
            {
                UserDTO user = new UserDTO();
                user.FirstName = _form.TxtFirstName.EditValue.ToString();
                user.LastName = _form.TxtLastName.EditValue.ToString();
                user.Country = _form.TxtCountry.EditValue.ToString();
                user.City = _form.TxtCity.EditValue.ToString();
                user.Function = _form.CmbFunction.EditValue.ToString();
                user.Username = _form.TxtUsername.EditValue.ToString();
                user.PasswordSalt = HashHelper.GetSalt();
                user.PasswordHash = HashHelper.GetHash(_form.TxtPassword.EditValue.ToString(), user.PasswordSalt);
                _service.InsertNewUser(user);
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
