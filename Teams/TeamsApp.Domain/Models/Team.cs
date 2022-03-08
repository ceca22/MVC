using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsApp.Domain.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public int YearOfEstablishment { get; set; }
        public string History { get; set; }
    }
}
