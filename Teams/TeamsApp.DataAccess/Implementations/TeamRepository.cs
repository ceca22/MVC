using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamsApp.DataAccess.Interfaces;
using TeamsApp.Domain.Models;

namespace TeamsApp.DataAccess.Implementations
{
    public class TeamRepository:ITeamRepository
    {
        private readonly TeamsAppDbContext _db;

        public TeamRepository(TeamsAppDbContext db)
        {
            _db = db;
        }
        public int DeleteById(int id)
        {
            Team team = _db.Teams.SingleOrDefault(x => x.Id == id);

            if (team == null)
            {
                return -1;
            }
            _db.Teams.Remove(team);
            _db.SaveChanges();
            return id;
        }

        public List<Team> GetAll()
        {
            return _db.Teams.ToList();

        }

        public Team GetById(int id)
        {
            return _db.Teams.FirstOrDefault(x => x.Id == id);

        }

        public Team Insert(Team entity)
        {
            
            _db.Teams.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Update(Team entity)
        {
            Team team = _db.Teams.FirstOrDefault(x => x.Id == entity.Id);
            if (team != null)
            {
                team.Name = entity.Name;
                team.Stadium = entity.Stadium;
                team.City = entity.City;
                team.YearOfEstablishment = entity.YearOfEstablishment;

                _db.Teams.Update(team);
                _db.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public Team GetTeamByName(string name)
        {
            return _db.Teams.FirstOrDefault(x => x.Name == name);
        }
    }
}
