using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;

namespace MessageBoardController
{
    public class MyCallBack : IMessageBoardServiceCallback
    {
        MessageBoardServiceClient proxy;
        public void ShowNotification(CommentDTO comment)
        {

        }

        public void CallService()
        {
            InstanceContext context = new InstanceContext(this);
            proxy = new MessageBoardServiceClient(context);
            var user = proxy.CheckUserAndPassword("Andrei");
        }
    }
}
