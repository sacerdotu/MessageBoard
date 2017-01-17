using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoardDTO;
using DevExpress.XtraEditors;

namespace MessageBoardController
{
    public interface IRegisterForm
    {
        TextEdit TxtFirstName { get; }
        TextEdit TxtLastName { get; }
        TextEdit TxtCountry { get; }
        TextEdit TxtCity { get; }
        TextEdit TxtUsername { get; }
        TextEdit TxtPassword { get; }
        TextEdit TxtConfirmPassword { get; }
    }
}
