using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard.Forms
{
    public partial class BaseForm : Form, IBaseForm
    {
        private Form _form;
        private BaseFormController _controller;

        #region Constructor
        public BaseForm()
        {
            InitializeComponent();
            _controller = new BaseFormController(this);
        }
        #endregion

        public void BaseForm_Load(Form form)
        {
            _form = form;
        }

        public void Translate()
        {
            List<TranslationDTO> translations = AppGlobalVariables.Instance.Translations;

            List<Control> formControls = new List<Control>();
            formControls = GetAllControls(_form.Controls, formControls);
            foreach (var control in formControls)
            {
                if (control is DevExpress.XtraGrid.GridControl)
                {

                }
                else
                {
                    TranslationDTO translation = translations.FirstOrDefault(x => x.RowKey == control.Name && x.FormName == _form.Name);
                    if (translation != null)
                    {
                        control.Text = translation.ControlName;
                    }
                }
            }
        }

        private List<Control> GetAllControls(Control.ControlCollection controls, List<Control> controlList)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                {
                    GetAllControls(control.Controls, controlList);
                }
                else
                {
                    controlList.Add(control);
                }
            }
            return controlList;
        }

        public Dictionary<String, String> AddAllControls()
        {
            try
            {
                Dictionary<String, String> AddControls = new Dictionary<string, string>();
                foreach (var formName in AppGlobalVariables.Instance.Forms)
                {
                    var formType = Assembly.GetExecutingAssembly().GetTypes()
        .Where(a => (a.BaseType == typeof(Form) || a.BaseType == typeof(BaseForm)) && a.Name == formName)
        .FirstOrDefault();
                    Form form = (Form)formType.InvokeMember(formName,
                          BindingFlags.Public | BindingFlags.Instance |
                          BindingFlags.CreateInstance, null, null, new Form[] { });
                    List<Control> controls = new List<Control>();
                    controls = GetAllControls(form.Controls, controls);
                    foreach (Control control in controls)
                    {
                        if (!String.IsNullOrEmpty(control.Text))
                        {
                            AddControls.Add(formName + control.Name, control.Text);
                        }
                    }

                }
                return AddControls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetControls()
        {
            _controller.GetControls();
        }
    }
}
