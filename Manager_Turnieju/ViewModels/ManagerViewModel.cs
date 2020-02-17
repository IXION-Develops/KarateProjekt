using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class ManagerViewModel : Conductor<object>
    {
        public readonly PlayersFrameViewModel _playersFrameViewModel;

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
           
            LoadFrame(_playersFrameViewModel);
            
        }

        public void Click_Sędzia()
        {
            throw new NotImplementedException();
        }

        public void Click_()
        {
            throw new NotImplementedException();
        }

        public void LoadFrame(object frame)
        {
            
            ActivateItem(frame);
            
        }

        public void DeactivateFrame(object frame)
        {
            DeactivateItem(frame, true);
        }
    }
}
