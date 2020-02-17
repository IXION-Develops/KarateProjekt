using System;
using System.Collections.Generic;
using System.Text;
using Manager_Turnieju.Models;
using System.Linq;

namespace Manager_Turnieju.Data
{
    public class PlayerMockRepository : IPlayerRepository<Player>
    {
        private List<Player> _playersList;

        public PlayerMockRepository()
        {
            _playersList = new List<Player>{ 
                new Player()
                {
                    Id = 0,
                    BirthDate = DateTime.Now,
                    Email = "a@a.pl",
                    Gender = "M",
                    Kata = true,
                    Name = "Jan",
                    Surname="Kowalski",
                    Weight = 90
                },
                new Player()
                {
                    Id = 1,
                    BirthDate = DateTime.Now,
                    Email = "b@b.pl",
                    Gender = "M",
                    Kata = true,
                    Name = "Adam",
                    Surname="Mańka",
                    Weight = 90
                }
            };
        }

     
        public void Add(Player model)
        {
            model.Id = NextID();
            _playersList.Add(model);
        }

        public void Delete(int id)
        {
            var toRemove = _playersList.SingleOrDefault(x => x.Id == id);
            _playersList.Remove(toRemove);
        }

        public void Edit(Player model)
        {
            var toEdit = _playersList.SingleOrDefault(x => x.Id == model.Id);
            toEdit = model;
        }

        public Player Get(int id)
        {
            return _playersList.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return _playersList;
        }
        private int NextID()
        {
            return _playersList.Select(x => x.Id).Max() +1;
        }
    }
}
