using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class DisplayUsersController
    {
        private IDisplayUsersForm _form;
        private IService1 _service;
        public DisplayUsersController(IDisplayUsersForm form)
        {
            _form = form;
            _service = new Service1Client();
        }
        public void LoadForm()
        {
            try
            {
                _form.GrdDisplayUsers.DataSource = _service.FillUsersGrid();
            }
            catch (Exception ex)
            {

                throw ex;
            }  
        }
        public int GetUserID(DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int userID = -1;
                for (int i = 0; i < _form.ViewDisplayUsers.RowCount; i++)
                {
                    if (e.Clicks == 2)
                    {
                        userID = ((UserDTO)_form.ViewDisplayUsers.GetFocusedRow()).UserID;
                    }
                }
                return userID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

    

