using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamsApp.DataAccess.Interfaces;
using TeamsApp.Domain.Models;
using TeamsApp.Services.Services.Interfaces;

namespace TeamsApp.Services.Services.Implementations
{
    public class PlayerService : IService<Player>
    {
        private readonly IRepository<Player> _playerRepository;

        public PlayerService(IRepository<Player> playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public void Add(Player entity)
        {
            _playerRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _playerRepository.DeleteById(id);


        }

        public List<Player> GetAll()
        {
            List<Player> players = _playerRepository.GetAll();
            return players;
        }

        public Player GetById(int id)
        {
            return _playerRepository.GetById(id);

        }

        public void Update(Player entity)
        {
            if (entity.FirstName == null || entity.LastName == null || entity.DateOfBirth == null || entity.Value == 0)
                throw new ArgumentNullException("Cannot be null");
            _playerRepository.Update(entity);

        }
    }
}
