using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.Interfaces
{
    public interface ILoginForm
    {
        void InsertPasswordAgain();
        void LoadMainForm();
        TextEdit TxtUsername { get; }
        TextEdit TxtPassword { get; }
    }
}
