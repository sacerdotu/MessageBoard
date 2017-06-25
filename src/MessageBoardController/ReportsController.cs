using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class ReportsController
    {
        #region Members
        private IReportsForm _form;
        private IMessageBoardService _service;
        #endregion

        #region Constructor
        public ReportsController(IReportsForm form)
        {
            InstanceContext context = new InstanceContext(new Proxy());
            _form = form;
            _service = new MessageBoardServiceClient(context);
        }
        #endregion

        #region
        public void GetReport(ReportRequestDTO request)
        {
            ReportResponseDTO response = new ReportResponseDTO();
            //response = _service.GetReport(request);
        }
        #endregion
    }
}
