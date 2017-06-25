using MessageBoardCommon;
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
        #endregion

        #region Constructor
        public ReportsForm()
        {
            InitializeComponent();
        }
        #endregion

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            BaseForm_Load(this);
        }

        private void chkPosts_CheckedChanged(object sender, EventArgs e)
        {
            chkComments.Checked = !chkPosts.Checked;
        }

        private void chkComments_CheckedChanged(object sender, EventArgs e)
        {
            chkPosts.Checked = !chkComments.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            request = new ReportRequestDTO();
            request.RequestForComment = chkComments.Checked;
            request.RequestForPost = chkPosts.Checked;
            request.StartDate = (DateTime)dateStartDate.EditValue;
            request.EndDate = (DateTime)dateEndDate.EditValue;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ForumForm form = new ForumForm();
            form.Show();
            this.Close();
        }
    }
}
