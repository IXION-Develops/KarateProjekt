using Caliburn.Micro;
using Manager_Turnieju.Data;
using Manager_Turnieju.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class PlayersFrameViewModel : Screen
    {
        private readonly IPlayerRepository<Player> _playerMockRepository;
        public PlayersFrameViewModel(IPlayerRepository<Player> playerMockRepository)
        {
            _playerMockRepository = playerMockRepository;
        }

        public List<Player> Players => _playerMockRepository.GetAll() as List<Player>;
    }
}
