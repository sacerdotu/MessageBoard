using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System.ServiceModel;
using System.Threading;
using MessageBoardController.Interfaces;

namespace MessageBoardController
{
    public class Proxy : IMessageBoardServiceCallback
    {
        MessageBoardServiceClient _proxy;
        ICommentsForm _form;

        public Proxy()
        { }

        public Proxy(ICommentsForm form)
        {
            _form = form;
        }

        public void ShowNotification(CommentDTO comment)
        {
            AppGlobalVariables.AppGlobalVariables.Instance.NrOfNewComments++;
            ThreadStart thStart = new ThreadStart(_form.ShowNotification);
            Thread th = new Thread(thStart);
            var blabla = comment;
        }
        public void CreateProxy()
        {
            InstanceContext context = new InstanceContext(this);
            _proxy = new MessageBoardServiceClient(context);
            var response = _proxy.CheckUserAndPassword("Andrei");
        }
    }
}
