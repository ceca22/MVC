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

        [HttpGet]
        public ActionResult Index()
        {

            PlayerViewModel player = new PlayerViewModel();
            return View("FindTeam", player);
        }



        [HttpPost]
        public IActionResult Index(PlayerViewModel model)
        {
            return RedirectToAction("FindTeam", new { Id = model.Id, FirstName = model.FirstName, LastName = model.LastName, DateOfBirth = model.DateOfBirth, Value = model.Value });
        }


        public ActionResult AddPlayer(int id, string firstName, string lastName, DateTime dateOfBirth, int value)
        {
            Player player = new Player() { Id = id, FirstName = firstName, LastName = lastName, DateOfBirth = dateOfBirth, Value = value };
            _playerService.Add(player);

            PlayerViewModel playerViewModel = new PlayerViewModel() { Id = id, FirstName = firstName, LastName = lastName, DateOfBirth = dateOfBirth, Value = value };
            return View(playerViewModel);
        }

    }
}
