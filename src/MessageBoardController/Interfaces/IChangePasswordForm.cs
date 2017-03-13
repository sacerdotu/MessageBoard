using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.Interfaces
{
    public interface IChangePasswordForm
    {
        TextEdit TxtPassword { get; }
        TextEdit TxtConfirmPassword { get; }
        void PasswordWasChanged();
        void InsertPasswordAgain();

    }
}
