﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsApp.Domain.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Value { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
