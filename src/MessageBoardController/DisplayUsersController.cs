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
            
            _form.GrdDisplayUsers.DataSource = _service.FillUsersGrid();
        }
    }
}

    

