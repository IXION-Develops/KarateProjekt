using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class ManagerViewModel : Screen
    {
        readonly PlayersFrameViewModel _playersFrameViewModel;
        public ManagerViewModel(PlayersFrameViewModel playersFrameViewModel)
        {
            _playersFrameViewModel = playersFrameViewModel;
        }

        public void Click_Turniej()
        {
            throw new NotImplementedException();
        }

        public void Click_Zawodnik()
        {
            //ActivateItem(_playersFrameViewModel);
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
