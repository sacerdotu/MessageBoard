using MessageBoardCommon;
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
            _service = new MessageBoardServiceClient();
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
                DisableForm();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region DisableForm
        public void DisableForm()
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
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion
    }
}
