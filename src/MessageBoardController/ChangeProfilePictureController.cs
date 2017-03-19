using MessageBoardController.HelperClasses;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class ChangeProfilePictureController
    {
        private IChangeProfilePictureForm _form;
        private IMessageBoardService _service;
        UserDTO _profilePicture;
        private int _userID;
        #region Constructor
        public ChangeProfilePictureController(IChangeProfilePictureForm form, int userID)
        {
            _form = form;
            _service = new MessageBoardServiceClient();
            _profilePicture = new UserDTO();
            _userID = userID;
        }
        #endregion

        #region ChangeProfilePicture
        public void ChangeProfilePicture()
        {
            
            _profilePicture.ProfileImage = ConvertImage.ImageToByteArray(_form.ImgProfilePicture.Image);
            _profilePicture.UserID = _userID;

            _service.ChangeProfilePicture(_profilePicture);
        }
        #endregion

        #region GetProfilePicture
        public void GetProfilePicture()
        {
            _profilePicture = _service.GetProfilePicture(_userID);

            _form.ImgProfilePicture.Image = ConvertImage.ByteArrayToImage(_profilePicture.ProfileImage);
        }
        #endregion
    }
}
