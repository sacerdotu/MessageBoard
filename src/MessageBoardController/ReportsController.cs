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
        public List<ReportResponseDTO> GetReport(ReportRequestDTO request)
        {
            try
            {
                List<ReportResponseDTO> response = new List<ReportResponseDTO>();
                response = _service.GetReport(request);
                return response;
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                throw ex;
            }
        }
        #endregion
    }
}
