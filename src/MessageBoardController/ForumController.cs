using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class ForumController
    {
        private IService1 _service;
        private IForumForm _form;

        public ForumController(IForumForm form)
        {
            _form = form;
            _service = new Service1Client();
        }
        public void LoadForm()
        {
            try
            {
                _form.GrdDisplayPosts.DataSource = _service.FillPostsGrid().Keys.ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
    }
}
