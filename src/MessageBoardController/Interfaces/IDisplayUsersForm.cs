using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.Interfaces
{
    public interface IDisplayUsersForm
    {
        GridControl GrdDisplayUsers { get; }
        GridView ViewDisplayUsers { get; }
        void LoadUserDetailsForm();
    }
}
