﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class ManagerViewModel : Conductor<object>
    {
        public ManagerViewModel()
        {

        }

        public void Click_Turniej()
        {
            throw new NotImplementedException();
        }

        public void Click_Zawodnik()
        {
            ActivateItem(new PlayersFrameViewModel());
        }

        public void Click_Sędzia()
        {
            throw new NotImplementedException();
        }

        public void Click_()
        {
            throw new NotImplementedException();
        }
    }
}
