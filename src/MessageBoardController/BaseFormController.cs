using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class BaseFormController
    {
        private IBaseForm _form;
        private IMessageBoardService _service;

        public BaseFormController(IBaseForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }

        public void FormLoad()
        {
            if(AppGlobalVariables.AppGlobalVariables.Instance.GetTranslations)
            {
                AppGlobalVariables.AppGlobalVariables.Instance.Translations = _service.GetTranslations();
            }
        }
    }
}
