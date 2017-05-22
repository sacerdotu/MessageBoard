using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.ServiceModel;

namespace MessageBoardController
{
    public class BaseFormController
    {
        private IMessageBoardService _service;
        private IBaseForm _form;

        public BaseFormController(IBaseForm form)
        {
            InstanceContext context = new InstanceContext(new Proxy());
            _service = new MessageBoardServiceClient(context);
            _form = form;
        }

        #region GetTranslations
        public void GetTranslations()
        {
            try
            {
                AppGlobalVariables.AppGlobalVariables.Instance.Translations = _service.GetTranslations(AppGlobalVariables.AppGlobalVariables.Instance.CurrentLanguage);
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
