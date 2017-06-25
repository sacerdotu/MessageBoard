using DevExpress.XtraBars;
using MessageBoard.Forms;
using MessageBoardController.AppGlobalVariables;
using System.Linq;

namespace MessageBoard.Translate
{
    public class TranslateBarManager : BarManager, ITranslatable
    {
        public void Translate(BaseForm form)
        {
            foreach (BarItem item in Items)
            {
                string ctrlName = form.Name + item.Name;
                var translation = AppGlobalVariables.Instance.Translations.FirstOrDefault(x => x.TranslationKey == ctrlName);
                if (translation != null)
                {
                    item.Caption = translation.Translation.Trim();
                }
            }
        }
    }
}
