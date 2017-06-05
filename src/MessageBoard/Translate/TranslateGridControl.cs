using DevExpress.XtraGrid;
using System;
using System.Linq;
using MessageBoard.Forms;
using MessageBoardController.AppGlobalVariables;

namespace MessageBoard.Translate
{
    public class TranslateGridControl : GridControl, ITranslatable
    {
        public void Translate(BaseForm form)
        {
            foreach (TranslateGridColumn column in ((TranslateGridView)this.MainView).Columns)
            {
                string ctrlName = form.Name + this.Name + column.Name;
                var translation = AppGlobalVariables.Instance.Translations.FirstOrDefault(x => x.TranslationKey == ctrlName && x.LanguageName == AppGlobalVariables.Instance.CurrentLanguage);
                if (translation != null && !String.IsNullOrEmpty(translation.Translation))
                {
                    column.Caption = translation.Translation.Trim();
                }
            }
        }
    }
}
