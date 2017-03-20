using DevExpress.XtraGrid.Views.Base;
using MessageBoardCommon;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class DisplayUsersController
    {
        private IDisplayUsersForm _form;
        private IMessageBoardService _service;
        List<UserDTO> _users = new List<UserDTO>();
        private int _userID;

        #region Constructor
        public DisplayUsersController(IDisplayUsersForm form)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
        }
        #endregion

        #region LoadForm
        public void LoadForm()
        {
            try
            {
                _form.GrdDisplayUsers.DataSource = _service.FillUsersGrid();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }  
        }
        #endregion

        #region SaveChanges
        public bool SaveChanges()
        {
            try
            {
                if (_service.UpdateIsActive(_users) == true)
                {
                    _users.Clear();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                return false;
            }
        }
        #endregion

        #region GetUserID
        public void GetUserID(DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _userID = -1;

                for (int i = 0; i < _form.ViewDisplayUsers.RowCount; i++)
                {
                    if (e.Clicks == 2)
                    {
                        _userID = ((UserDTO)_form.ViewDisplayUsers.GetFocusedRow()).UserID;
                    }
                }
                CheckUserID();
            }
            catch (Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region CheckUserID
        public void CheckUserID()
        {
            if(_userID > 0)
            {
                _form.LoadUserDetailsForm();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region ModifiedUsers
        public void ModifiedUsers(RowObjectEventArgs e)
        {
            try
            {
                UserDTO user = (UserDTO)e.Row;
                var item = _users.FirstOrDefault(x => x.UserID == user.UserID);
                if (item == null)
                {
                    _users.Add(user);
                }
                else
                {
                    item.IsActive = user.IsActive;
                }
            }
            catch(Exception ex)
            {
                Logger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + ex.Message);
                throw ex;
            }     
        }
        #endregion
    }
}

    

