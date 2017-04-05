using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class MainController
    {
        #region Members
        private IMessageBoardService _service;
        private IMainForm _form;
        #endregion

        #region Constructor
        public MainController(IMainForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region IsAdministrator
        public void IsAdministrator(int userID)
        {
            try
            {
                bool isAdministrator = _service.IsAdministrator(userID);
                if (isAdministrator == true)
                {
                    _form.BtnDisplayUsers.Visible = true;
                }
                else
                {
                    _form.BtnDisplayUsers.Visible = false;
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
