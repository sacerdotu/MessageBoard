using DevExpress.XtraEditors;
using MessageBoardCommon;
using MessageBoardController;
using MessageBoardController.Interfaces;
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
    public partial class ReportsForm : BaseForm, IReportsForm
    {
        #region Members
        ReportRequestDTO request;
        ReportsController _controller;
        List<ReportResponseDTO> reportResponse;
        #endregion

        #region Constructor
        public ReportsForm()
        {
            _controller = new ReportsController(this);
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            BaseForm_Load(this);
        }
        #endregion

        #region chkPosts_CheckedChanged
        private void chkPosts_CheckedChanged(object sender, EventArgs e)
        {
            if(chkComments.Checked)
                chkComments.Checked = !chkPosts.Checked;
        }
        #endregion

        #region chkComments_CheckedChanged
        private void chkComments_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPosts.Checked)
            {
                chkPosts.Checked = !chkComments.Checked;
            }

        }
        #endregion

        #region SearchButton
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                grdReport.DataSource = null;
                reportResponse = new List<ReportResponseDTO>();
                request = new ReportRequestDTO();
                request.RequestForComment = chkComments.Checked;
                request.RequestForPost = chkPosts.Checked;
                if (dateStartDate.EditValue == null)
                {
                    request.StartDate = System.DateTime.MinValue;
                }
                else
                {
                    request.StartDate = (DateTime)dateStartDate.EditValue;
                }
                if (dateEndDate.EditValue == null)
                {
                    request.EndDate = DateTime.MaxValue;
                }
                else
                {
                    request.EndDate = (DateTime)dateEndDate.EditValue;
                }
                grdReport.DataSource = _controller.GetReport(request);
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

        #region BackButton
        private void btnBack_Click(object sender, EventArgs e)
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
        #endregion

        #region PressEscKey
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
            {
                if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
                {
                    ForumForm form = new ForumForm();
                    form.Show();
                    this.Close();
                    return true;
                }
                return base.ProcessDialogKey(keyData);
            }
            catch (MessageBoardException ex)
            {
                ex.WriteErrorMessage();
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message + "\n" + "Stacktrace: " + ex.StackTrace);
                return false;
            }
        }
        #endregion
    }
}
