using DevExpress.XtraPrinting.HtmlExport.Native;
using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class BaseFormController
    {
        private IMessageBoardService _service;
        private IBaseForm _form;
        //private Dictionary<string, string> _getControls = new Dictionary<string, string>();
        //private Dictionary<string, string> _translatedControls = new Dictionary<string, string>();

        public BaseFormController(IBaseForm form)
        {
            _service = new MessageBoardServiceClient();
            _form = form;
        }

        //#region GetControls
        //public void GetControls()
        //{
        //    _getControls = _form.AddAllControls();
        //    TranslateControls();
        //}
        //#endregion

        //#region TranslateControls()
        //public void TranslateControls()
        //{
        //    foreach (KeyValuePair<string, string> control in _getControls)
        //    {
        //        string translate = TranslateHelper.Translate(control.Value, "English", "French");
        //        _translatedControls.Add(control.Key, translate);
        //    }
        //    InsertTranslations();
        //}
        //#endregion

        //#region InsertTranslations
        //public void InsertTranslations()
        //{
        //    if(_translatedControls != null && _translatedControls.Count > 0)
        //    {
        //        _service.InsertTranslations(_translatedControls, "English");
        //    }
        //}
        //#endregion

        #region GetTranslations
        public void GetTranslations()
        {
            AppGlobalVariables.AppGlobalVariables.Instance.Translations = _service.GetTranslations(AppGlobalVariables.AppGlobalVariables.Instance.CurrentLanguage);
        }
        #endregion
    }
}
