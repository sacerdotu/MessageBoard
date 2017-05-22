using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MessageBoardController.Interfaces
{
    public interface ICommentsForm
    {
        PictureEdit ImgPost { get; }
        void DisplayComments(CommentDTO comments, int x, int y, bool visibility);
        int UcWidth { get; set; }
        void ShowNotification(AlertInfo alertInfo);
    }
}
