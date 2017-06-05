using DevExpress.XtraEditors;
using MessageBoard.Forms;
using MessageBoardController.AppGlobalVariables;
using System;
using System.Linq;

namespace MessageBoard.Translate
{
    public class TranslateLabel : LabelControl , ITranslatable
    {
        public void Translate(BaseForm form)
        {
            var translation = AppGlobalVariables.Instance.Translations.FirstOrDefault(x => x.TranslationKey == form.Name + this.Name && x.LanguageName == AppGlobalVariables.Instance.CurrentLanguage);
            if (translation != null && !String.IsNullOrEmpty(translation.Translation))
            {
                this.Text = translation.Translation.Trim();
            }
        }

    }
}
