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

        #region GetSalt
        public string GetSalt()
        {
            int minSaltLength = 4;
            int maxSaltLength = 16;

            byte[] SaltBytes = null;
            Random r = new Random();
            int SaltLength = r.Next(minSaltLength, maxSaltLength);
            SaltBytes = new byte[SaltLength];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetNonZeroBytes(SaltBytes);
            string result = Convert.ToBase64String(SaltBytes);
            rng.Dispose();

            return result;
        }
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
                user.PasswordSalt = GetSalt();
                user.PasswordHash = HashHelper.GetHash(_form.TxtPassword.EditValue.ToString(), user.PasswordSalt);
                _service.InsertNewUser(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
}
