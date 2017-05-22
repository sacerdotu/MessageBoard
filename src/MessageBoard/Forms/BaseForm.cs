using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
                    if (control is GridControl)
                    {
                        GridControl gridControl = (GridControl)control;
                        foreach (GridColumn column in ((GridView)gridControl.MainView).Columns)
                        {
                            string ctrlName = _form.Name + control.Name + column.Name;
                            TranslationDTO translation = translations.FirstOrDefault(x => x.TranslationKey == ctrlName);
                            if (translation != null)
                            {
                                column.Caption = translation.Translation.Trim();
                            }
                        }
                    }
                    else
                    {
                        string ctrlName = _form.Name + control.Name;
                        TranslationDTO translation = translations.FirstOrDefault(x => x.TranslationKey == ctrlName);
                        if (translation != null)
                        {
                            control.Text = translation.Translation.Trim();
                        }
                    }
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TranslateMenu
        public void TranslateMenu(BarItems barItem)
        {
            try
            {
                List<TranslationDTO> translations = AppGlobalVariables.Instance.Translations;
                foreach (BarItem item in barItem)
                {
                    string ctrlName = _form.Name + item.Name;
                    TranslationDTO translation = translations.FirstOrDefault(x => x.TranslationKey == ctrlName);
                    if (translation != null)
                    {
                        item.Caption = translation.Translation.Trim();
                    }
                }
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region GetAllControls
        private List<Control> GetAllControls(Control.ControlCollection controls, List<Control> controlList)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren && !(control is DevExpress.XtraGrid.GridControl))
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
            }
        }
        #endregion


    }
}
