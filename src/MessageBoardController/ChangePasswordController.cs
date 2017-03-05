using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
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
        IMessageBoardService _service;
        IChangePasswordForm _form;

        #region Constructor
        public ChangePasswordController(IChangePasswordForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region GeneratePassword
        public bool GeneratePassword(int userID)
        {
            try
            {
                UserDTO user = new UserDTO();
                string _password = _form.TxtPassword.Text;
                user.PasswordSalt = HashHelper.GetSalt();
                user.PasswordHash = HashHelper.GetHash(_password, user.PasswordSalt);
                user.UserID = userID;
                if(_service.ChangePassword(user) == true)
                {
                    return true;
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
