using MessageBoardCommon;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            InstanceContext context = new InstanceContext(new Proxy());
            _form = form;
            _service = new MessageBoardServiceClient(context);
        }
        #endregion

        #region GeneratePassword
        public void GeneratePassword(int userID, string password, string confirmPassword)
        {
            try
            {
                if ((!String.IsNullOrEmpty(password)) && (!String.IsNullOrEmpty(confirmPassword)) && password == confirmPassword)
                {
                    UserDTO user = new UserDTO();
                    string _password = _form.TxtPassword.Text;
                    user.PasswordSalt = HashHelper.GetSalt();
                    user.PasswordHash = HashHelper.GetHash(_password, user.PasswordSalt);
                    user.UserID = userID;
                    if (_service.ChangePassword(user) == true)
                    {
                        _form.PasswordWasChanged();
                    }
                }
                else
                {
                    _form.InsertPasswordAgain();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

    }
}
