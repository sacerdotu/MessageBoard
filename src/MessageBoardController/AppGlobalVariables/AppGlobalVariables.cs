using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.AppGlobalVariables
{
    public class AppGlobalVariables
    {
        private static AppGlobalVariables instance;

        private AppGlobalVariables() { }

        public static AppGlobalVariables Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppGlobalVariables();
                }
                return instance;
            }
        }
        public int UserID { get; set; }
        public int CommentID { get; set; }
        public int PostID { get; set; }
    }
}
