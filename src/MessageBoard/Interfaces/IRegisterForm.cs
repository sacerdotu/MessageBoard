using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard
{
    public interface IRegisterForm
    {
        ucUserInformations UcUserInformations { get; }
    }
}
