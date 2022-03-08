using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApp.Domain.Models;
using TeamsApp.Models;
using TeamsApp.Services.Services.Implementations;
using TeamsApp.Services.Services.Interfaces;

namespace TeamsApp.Controllers
{
    
    public class PlayerController : Controller
    {
        private readonly IService<Player> _playerService;
        private readonly ITeamService _teamService;



        public PlayerController(IService<Player> playerService, ITeamService teamService)
        {
            _playerService = playerService;
            _teamService = teamService;
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
        public IActionResult Index(int teamId)
        {
            var firstName = Request.Form["fistName"];
            var lastName = Request.Form["lastName"];
            var date = Request.Form["date"];
            var value = Request.Form["value"];

            PlayerViewModel model = new PlayerViewModel() { FirstName = firstName, LastName = lastName, DateOfBirth = Convert.ToDateTime(date), Value = Int32.Parse(value), TeamId = teamId };

            return RedirectToAction("FindTeam", model);
        }

        [HttpPost]
        public ActionResult AddPlayer(PlayerViewModel model)
        {
            Team team = _teamService.GetById(model.TeamId);
            Player player = new Player() { Id = model.Id, FirstName = model.FirstName, LastName = model.LastName, DateOfBirth = model.DateOfBirth, Value = model.Value, Team = team};
            _playerService.Add(player);
            TeamViewModel teamViewModel = new TeamViewModel()
            {
                Id = team.Id,
                Name = team.Name,
                City = team.City,
                Stadium = team.Stadium,
                History = team.History,
                YearOfEstablishment = team.YearOfEstablishment
            };

            
            return View( model);
        }

    }
}
