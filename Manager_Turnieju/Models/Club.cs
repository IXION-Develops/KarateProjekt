using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Coach { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }
    }
}
