using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApp.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Value { get; set; }
        public int TeamId { get; set; }

        public TeamViewModel Team { get; set; }
    }
}
