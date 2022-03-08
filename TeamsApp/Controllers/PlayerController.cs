using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApp.Domain.Models;
using TeamsApp.Models;
using TeamsApp.Services.Services.Interfaces;

namespace TeamsApp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IService<Player> _playerService;
        

        public PlayerController(IService<Player> playerService)
        {
            _playerService = playerService;
        }

        // GET: PlayerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _playerService.Delete(id);

            List<Player> players = _playerService.GetAll().ToList();
            var playersViewModel = new PlayersViewModel();
            playersViewModel.Players = new List<PlayerViewModel>();

            // mapping
            foreach (var player in players)
            {
                playersViewModel.Players.Add(new PlayerViewModel()
                {
                    Id = player.Id,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    DateOfBirth = player.DateOfBirth,
                    Value = player.Value
                });
            }
            return View("FindTeam", playersViewModel);
        }


    }
}
