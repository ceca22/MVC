using System;
using System.Collections.Generic;
using System.Text;
using TeamsApp.Domain.Models;

namespace TeamsApp.DataAccess.Interfaces
{
    public interface ITeamRepository:IRepository<Team>
    {
        Team GetTeamByName(string name);
    }
}
