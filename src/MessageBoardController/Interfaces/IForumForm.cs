﻿using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MessageBoardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.Interfaces
{
    public interface IForumForm
    {
        void HideUserDetailsBar();
        GridControl GrdDisplayPosts { get; }
        GridView ViewDisplayPosts { get; }
        void LoadCommentsForm(PostDTO post);
        Dictionary<string, string> GetAllControls();
        void ShowNotification(AlertInfo alertInfo);
    }
}
