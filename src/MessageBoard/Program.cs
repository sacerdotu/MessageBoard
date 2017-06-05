using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppGlobalVariables.Instance.GetTranslations = true;
            AppGlobalVariables.Instance.GetForms();
            AppGlobalVariables.Instance.IsForTranslation = true;
            Application.Run(new LoginForm());          
        }
    }
}
