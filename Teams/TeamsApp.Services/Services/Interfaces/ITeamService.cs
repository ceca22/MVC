using System;
using System.Collections.Generic;
using System.Text;
using TeamsApp.Domain.Models;

namespace TeamsApp.Services.Services.Interfaces
{
    public interface ITeamService:IService<Team>
    {
       Team GetTeamByName(string name);
    }
}
