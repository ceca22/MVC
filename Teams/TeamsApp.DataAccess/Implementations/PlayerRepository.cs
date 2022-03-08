using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamsApp.DataAccess.Interfaces;
using TeamsApp.Domain.Models;

namespace TeamsApp.DataAccess.Implementations
{
    public class PlayerRepository:IRepository<Player>
    {
        private readonly TeamsAppDbContext _db;

        public PlayerRepository(TeamsAppDbContext db)
        {
            _db = db;
        }
        public int DeleteById(int id)
        {
            Player player = _db.Players.SingleOrDefault(x => x.Id == id);

            if (player == null)
            {
                return -1;
            }
            _db.Players.Remove(player);
            return id;

        }

        public List<Player> GetAll()
        {
            return _db.Players
                .Include(x=>x.Team)
                .ToList();

        }

        public Player GetById(int id)
        {
            return _db.Players.Include(x=>x.Team).FirstOrDefault(x => x.Id == id);
        }

        public Player Insert(Player entity)
        {
            
            _db.Players.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Update(Player entity)
        {
            Player player = _db.Players.FirstOrDefault(x => x.Id == entity.Id);
            if (player != null)
            {
                player.FirstName = entity.FirstName;
                player.LastName = entity.LastName;
                player.DateOfBirth = entity.DateOfBirth;
                player.Value = entity.Value;

                _db.Players.Update(player);
            }

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
