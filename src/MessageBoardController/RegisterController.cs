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
        private IRegisterForm _form;
        private IService1 _service;
        public RegisterController(IRegisterForm form)
        {
            _form = form;
            _service = new Service1Client();
        }

        public string GetHash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        public void RegisterUser()
        {
            try
            {
                UserDTO user = new UserDTO();
                var sha = new SHA1CryptoServiceProvider();
                user.FirstName = _form.TxtFirstName.EditValue.ToString();
                user.LastName = _form.TxtLastName.EditValue.ToString();
                user.Country = _form.TxtCountry.EditValue.ToString();
                user.City = _form.TxtCity.EditValue.ToString();
                user.Function = _form.CmbFunction.EditValue.ToString();
                user.Username = _form.TxtUsername.EditValue.ToString();
                user.PasswordHash = GetHash(_form.TxtPassword.EditValue.ToString());
                _service.InsertNewUser(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
