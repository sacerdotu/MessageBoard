using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoardController.Interfaces
{
    public interface IUserDetailsForm
    {
        TextEdit TxtFirstName { get; }
        TextEdit TxtLastName { get; }
        TextEdit TxtCountry { get; }
        TextEdit TxtCity { get; }
        ComboBoxEdit CmbFunction { get; }
        CheckEdit IsAdministrator { get; }
        CheckEdit IsActive { get; }
        DateEdit AccountCreationDate { get; }
    }
}
