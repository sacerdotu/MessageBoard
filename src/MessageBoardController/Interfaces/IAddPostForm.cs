using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoardController.Interfaces
{
    public interface IAddPostForm
    {
        RichTextBox RtbPost { get; }
        PictureEdit ImgPost { get; }
        void PostWasAdded();
    }
}
