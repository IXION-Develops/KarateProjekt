using Caliburn.Micro;
using Manager_Turnieju.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.ViewModels
{
    public class PlayersFrameViewModel : Screen
    {
        private readonly PlayerMockRepository _playerMockRepository;
        public PlayersFrameViewModel(PlayerMockRepository playerMockRepository)
        {
            _playerMockRepository = playerMockRepository;
        }
    }
}
