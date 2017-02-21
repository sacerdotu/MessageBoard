using MessageBoardController.Interfaces;
using MessageBoardController.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class AddPostController
    {
        private IAddPostForm _form;
        private IService1 _service;
        private string _username;
        public AddPostController(IAddPostForm form, string username)
        {
            _form = form;
            _service = new Service1Client();
            _username = username;
        }
        public void AddPost()
        {
            List<string> addPost = new List<string>();
            addPost.Add(_username);
            addPost.Add(_form.RtbPost.Text);
            _service.AddNewPost(addPost);
        }
    }
}
