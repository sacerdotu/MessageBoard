﻿using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace MessageBoardController
{
    public class RegisterController
    {
        #region Members
        private IRegisterForm _form;
        private IMessageBoardService _service;
        #endregion

        #region Constructors
        public RegisterController(IRegisterForm form)
        {
            InstanceContext context = new InstanceContext(new Proxy());
            _form = form;
            _service = new MessageBoardServiceClient(context);
        }

        public RegisterController()
        { }
        #endregion

        #region RegisterUser
        public void RegisterUser(string password, string confirmPassword)
        {
            try
            {
                bool success = false;
                if (!String.IsNullOrEmpty(password) && (password == confirmPassword))
                {
                    UserDTO user = new UserDTO();
                    user.FirstName = _form.TxtFirstName.EditValue.ToString();
                    user.LastName = _form.TxtLastName.EditValue.ToString();
                    user.Country = _form.TxtCountry.EditValue.ToString();
                    user.City = _form.TxtCity.EditValue.ToString();
                    user.Function = _form.CmbFunction.EditValue.ToString();
                    user.Username = _form.TxtUsername.EditValue.ToString();
                    user.ProfileImage = ConvertImage.ImageToByteArray(_form.ImgProfilePicture.Image);
                    user.PasswordSalt = HashHelper.GetSalt();
                    user.PasswordHash = HashHelper.GetHash(_form.TxtPassword.EditValue.ToString(), user.PasswordSalt);
                    user.IsActive = true;
                    user.IsAdministrator = false;
                    user.AccountCreationDate = DateTime.Now;

                    success = _service.InsertNewUser(user);
                }
                if (success)
                {
                    _form.AccountCreated();
                }
                else
                {
                    _form.FillAllFields();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw new MessageBoardException("", ex);
            }
        }


        #endregion

    }
}
