using System;
using System.Collections.Generic;
using System.Text;
using TeamsApp.DataAccess.Interfaces;
using TeamsApp.Domain.Models;
using TeamsApp.Services.Services.Interfaces;

namespace TeamsApp.Services.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public void Add(Team entity)
        {
            string year = entity.YearOfEstablishment.ToString();
            if (year.Length != 4)
            {
                throw new Exception();
            }
            _teamRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _teamRepository.DeleteById(id);

        }

        public List<Team> GetAll()
        {
            return _teamRepository.GetAll();
        }

        public Team GetById(int id)
        {
            return _teamRepository.GetById(id);
        }

        public Team GetTeamByName(string name)
        {
            return _teamRepository.GetTeamByName(name);
        }

        public void Update(Team entity)
        {
            if(entity.City == null || entity.Name == null || entity.Stadium == null || entity.YearOfEstablishment == 0 || entity.History == null)
                throw new ArgumentNullException("Cannot be null");

            _teamRepository.Update(entity);
        }

        
    }
}
