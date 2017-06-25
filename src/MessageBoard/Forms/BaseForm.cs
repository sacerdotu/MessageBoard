using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoard.Translate;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.AppGlobalVariables;
using MessageBoardController.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
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

        #region LoadForm
        public void BaseForm_Load(Form form)
        {
            _form = form;
            Translate();
        }
        #endregion

        #region Translate
        public void Translate()
        {
            try
            {
                GetTranslations();
                List<TranslationDTO> translations = AppGlobalVariables.Instance.Translations;

                List<Control> formControls = new List<Control>();
                formControls = GetAllControls(_form.Controls, formControls);
                foreach (var control in formControls)
                {
                    if(control is ITranslatable)
                    {
                        ((ITranslatable)control).Translate(this);
                    }
                    //MethodInfo method = control.GetType().GetMethod("Translate", BindingFlags.Public | BindingFlags.Instance);
                    //if(method != null)
                    //method.Invoke(control, new object[] { this });
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
            }
        }
        #endregion

        #region TranslateMenu
        public void TranslateMenu(BarManager barManager)
        {
            try
            {
                if (barManager is ITranslatable)
                {
                    ((ITranslatable)barManager).Translate(this);
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
            }

        }
        #endregion

        #region GetAllControls
        private List<Control> GetAllControls(Control.ControlCollection controls, List<Control> controlList)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren && !(control is GridControl))
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
        #endregion

        #region AddAllControls
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
                        if (control is GridControl)
                        {
                            GridControl gridControl = (GridControl)control;
                            foreach (GridColumn column in ((GridView)gridControl.MainView).Columns)
                            {
                                AddControls.Add(formName + control.Name + column.Name, column.Caption);
                            }
                        }
                    }
                }

                // add menu controls
                AddControls.Add("ForumFormbarMenu", "Menu");
                AddControls.Add("ForumFormbarChangePassword", "Change Password");
                AddControls.Add("ForumFormbarChangeProfilePicture", "Change Profile Picture");
                AddControls.Add("ForumFormbarUserInformation", "User Information");
                AddControls.Add("ForumFormbarLanguage", "Language");
                AddControls.Add("ForumFormbarEnglish", "English");
                AddControls.Add("ForumFormbarFrench", "French");
                AddControls.Add("ForumFormbarSyncLanguage", "Sync Language");
                AddControls.Add("ForumFormbarReports", "Reports");


                return AddControls;
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                return null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                return null;
            }
        }
        #endregion

        #region GetTranslations
        public void GetTranslations()
        {
            try
            {
                if (AppGlobalVariables.Instance.GetTranslations)
                {
                    _controller.GetTranslations();
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
            }
        }
        #endregion
    }
}
