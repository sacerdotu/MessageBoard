using DevExpress.XtraGrid.Columns;
using MessageBoard.Forms;

namespace MessageBoard.Translate
{
    public class TranslateGridColumn : GridColumn, ITranslatable
    {
        public string TranslateName { get; set; }

        public void Translate(BaseForm form)
        {
        }
    }
}
