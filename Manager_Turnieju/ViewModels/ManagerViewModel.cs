using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class ManagerViewModel : Conductor<object>
    {
        public readonly PlayersViewModel _playersFrameViewModel;

        public ManagerViewModel(PlayersViewModel playersFrameViewModel)
        {
            _playersFrameViewModel = playersFrameViewModel;
        }

        public void Click_Turniej()
        {
            throw new NotImplementedException();
        }

        public void btn_Zawodnik()
        {
            foreach (var item in GetChildren())
            {
                _playersFrameViewModel.DeactivateItem((item as Conductor<object>)?.ActiveItem, true);
            }
            ActivateItem(_playersFrameViewModel);

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
