using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApp.Models
{
    public class PlayersViewModel

    {
        public TeamViewModel Team { get; set; }

        public List<PlayerViewModel> Players = new List<PlayerViewModel>();
        public PlayerViewModel PlayerViewModel { get; set; }
    }
}
