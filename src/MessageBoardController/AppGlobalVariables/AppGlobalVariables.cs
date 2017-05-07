using MessageBoardCommon;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoardController.AppGlobalVariables
{
    public class AppGlobalVariables
    {
        private static AppGlobalVariables instance;
        private static List<string> _forms = new List<string>();
        private static List<Control> _controls = new List<Control>();
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
        public bool GetTranslations { get; set; }
        public PostDTO Post { get; set; }
        public List<TranslationDTO> Translations { get; set; }

        public List<Control> Controls
        {
            get
            {
                return _controls;
            }
            set
            {
                _controls = value;
            }
        }
        public List<String> Forms
        {
            get
            {
                return _forms;
            }
            set
            {
                _forms = value;
            }
        }

        public bool IsForTranslation { get; set; }
        public bool FirstEntry { get; set; }
        public String CurrentLanguage { get; set; }
        public String NextLanguage { get; set; }

        public void GetForms()
        {
            Forms.Add(Constants.AddCommentsForm);
            Forms.Add(Constants.ChangePasswordForm);
            Forms.Add(Constants.ChangeProfilePictureForm);
            Forms.Add(Constants.CommentsForm);
            Forms.Add(Constants.DisplayUsersForm);
            Forms.Add(Constants.ForumForm);
            Forms.Add(Constants.LoginForm);
            Forms.Add(Constants.RegisterForm);
            Forms.Add(Constants.UserDetailsForm);
        }
    }
}
