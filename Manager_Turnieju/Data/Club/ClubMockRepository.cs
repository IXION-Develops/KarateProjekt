using System;
using System.Collections.Generic;
using System.Text;
using Manager_Turnieju.Models;
using System.Linq;


namespace Manager_Turnieju.Data
{
    class ClubMockRepository : IClubRepository<Club>
    {
        private List<Club> _clubsList;

        public ClubMockRepository()
        {
            _clubsList = new List<Club>{
                new Club()
                {
                    Id = 0,Name="Karate 1"

                },
                new Club()
                {
                    Id = 1,Name="Karate 2"

                }
            };
        }
        public void Add(Club model)
        {
            model.Id = NextID();
            _clubsList.Add(model);
        }

        public void Delete(int id)
        {
            var toRemove = _clubsList.SingleOrDefault(x => x.Id == id);
            _clubsList.Remove(toRemove);
        }

        public void Edit(Club model)
        {
            var toEdit = _clubsList.SingleOrDefault(x => x.Id == model.Id);
            toEdit = model;
        }

        public Club Get(int id)
        {
            return _clubsList.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Club> GetAll()
        {
            return _clubsList;
        }
        private int NextID()
        {
            return _clubsList.Select(x => x.Id).Max() + 1;
        }
    }
}
