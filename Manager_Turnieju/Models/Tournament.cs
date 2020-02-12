using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public List<Player> Players {get;set;}
        public List<Referee> Referees { get; set; }
        public List<Operator> Operators { get; set; }
    }
}
