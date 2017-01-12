using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        public ucUserInformations UcUserInformations
        {
            get { return ucUserInformations; } 
        }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            
        }


    }
}
