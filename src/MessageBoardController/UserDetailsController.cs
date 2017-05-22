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
    public class UserDetailsController
    {
        #region Members
        private IUserDetailsForm _form;
        private IMessageBoardService _service;
        private int _userID;
        #endregion

        #region Constructor
        public UserDetailsController(IUserDetailsForm form, int userID)
        {
            _form = form;
            InstanceContext context = new InstanceContext(new Proxy());
            _service = new MessageBoardServiceClient(context);
            _userID = userID;
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            try
            {
                UserDTO userDetails = _service.GetUserDetails(_userID);
                _form.TxtFirstName.EditValue = userDetails.FirstName;
                _form.TxtLastName.EditValue = userDetails.LastName;
                _form.TxtCountry.EditValue = userDetails.Country;
                _form.TxtCity.EditValue = userDetails.City;
                _form.IsActive.EditValue = userDetails.IsActive;
                _form.IsAdministrator.EditValue = userDetails.IsAdministrator;
                _form.CmbFunction.EditValue = userDetails.Function;
                _form.AccountCreationDate.EditValue = userDetails.AccountCreationDate;
                if (userDetails.ProfileImage != null)
                {
                    _form.ImgProfilePicture.Image = ConvertImage.ByteArrayToImage(userDetails.ProfileImage);
                }
                DisableFormControls();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw new MessageBoardException(ex.Message, ex);
            }
        }
        #endregion

        #region DisableFormControls
        public void DisableFormControls()
        {
            try
            {
                _form.TxtFirstName.ReadOnly = true;
                _form.TxtLastName.ReadOnly = true;
                _form.TxtCountry.ReadOnly = true;
                _form.TxtCity.ReadOnly = true;
                _form.IsActive.ReadOnly = true;
                _form.IsAdministrator.ReadOnly = true;
                _form.CmbFunction.ReadOnly = true;
                _form.AccountCreationDate.ReadOnly = true;
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
