﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApp.Models
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public int YearOfEstablishment { get; set; }
        public string History { get; set; }
    }
}
