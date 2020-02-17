using Caliburn.Micro;
using Manager_Turnieju.Data;
using Manager_Turnieju.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Manager_Turnieju.ViewModels
{
    public class PlayersFrameViewModel : Conductor<object>
    {
        private readonly IPlayerRepository<Player> _playerMockRepository;
        private readonly AddPlayerViewModel _addPlayerViewModel;
        private readonly ManagerViewModel _managerViewModel;

        public PlayersFrameViewModel(IPlayerRepository<Player> playerMockRepository, AddPlayerViewModel addPlayerViewModel)
        {
            _playerMockRepository = playerMockRepository;
            _addPlayerViewModel = addPlayerViewModel;
        }
        public List<Player> Players => _playerMockRepository.GetAll() as List<Player>;

        public void btn_Dodaj()
        {
            ActivateItem(_addPlayerViewModel);
            DeactivateItem(this, true);
        }

        public void DeactivateFrame(object frame)
        {
            DeactivateItem(frame, true);
        }
    }
}
