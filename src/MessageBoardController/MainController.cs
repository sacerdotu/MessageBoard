using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class MainController
    {
        private IService1 _service;
        private IMainForm _form;
        private string _username;

        #region Constructor
        public MainController(IMainForm form, string username)
        {
            _username = username;
            _form = form;
            _service = new Service1Client();
        }
        #endregion

        #region IsAdministrator
        public void IsAdministrator()
        {
            try
            {
                bool isAdministrator = _service.IsAdministrator(_username);
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
                throw ex;
            }    
        }
        #endregion
    }
}
