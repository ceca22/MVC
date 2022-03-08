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
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IService<Player> _playerService;
        // GET: TeamController

        public TeamController(ITeamService teamService, IService<Player> playerService)
        {
            _teamService = teamService;
            _playerService = playerService;
        }

        [HttpGet]
        public ActionResult Index() { 
        
            TeamViewModel team = new TeamViewModel();
            return View("AddTeam", team);
        }



        [HttpPost]
        public IActionResult Index(TeamViewModel model)
        {
            return RedirectToAction("AddTeam", new { name = model.Name, city = model.City, stadium = model.Stadium, yearOfEstablishment = model.YearOfEstablishment, history = model.History });
        }

        
        public ActionResult AddTeam(string name, string city, string stadium, int yearOfEstablishment, string history)
        {
            Team team = new Team() { Name = name, City = city, Stadium = stadium, YearOfEstablishment = yearOfEstablishment, History = history};
            _teamService.Add(team);

            TeamViewModel teamViewModel = new TeamViewModel() { Name = name, City = city, Stadium = stadium, YearOfEstablishment = yearOfEstablishment, History = history };
            return View(teamViewModel);
        }

        

        [HttpGet]
        public ActionResult<List<Team>> GetAllTeams()
        {
            List<Team> teams = _teamService.GetAll().ToList();
            var teamsViewModel = new TeamsViewModel();
            teamsViewModel.Teams = new List<TeamViewModel>();

            // mapping
            foreach (var team in teams)
            {
                teamsViewModel.Teams.Add(new TeamViewModel()
                {
                    Id=team.Id,
                    Name = team.Name,
                    City = team.City,
                    Stadium = team.Stadium,
                    YearOfEstablishment = team.YearOfEstablishment,
                    History = team.History
                });
            }

            return View("Teams", teamsViewModel);
        }


        [HttpGet]
        public ActionResult<Team> GetTeamByName(string name)
        {
            Team team = _teamService.GetTeamByName(name);

            var teamViewModel = new TeamViewModel()
            {
                Id = team.Id,
                Name = team.Name,
                City = team.City,
                Stadium = team.Stadium,
                YearOfEstablishment = team.YearOfEstablishment,
                History = team.History
            };

            List<Player> players = _playerService.GetAll();
            
            
            List<PlayerViewModel> playersViewM = new List<PlayerViewModel>();
            foreach (Player player in players)
            {
                playersViewM.Add(new PlayerViewModel()
                {
                    Id = player.Id,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    DateOfBirth = player.DateOfBirth,
                    Value = player.Value
                });
            }
            PlayersViewModel playersViewModel = new PlayersViewModel() { Team = teamViewModel, Players = playersViewM };
            return View("FindTeam", playersViewModel);

        }

        // GET: TeamController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _teamService.Delete(id);
            
            List<Team> teams = _teamService.GetAll().ToList();
            var teamsViewModel = new TeamsViewModel();
            teamsViewModel.Teams = new List<TeamViewModel>();

            // mapping
            foreach (var team in teams)
            {
                teamsViewModel.Teams.Add(new TeamViewModel()
                {
                    Id = team.Id,
                    Name = team.Name,
                    City = team.City,
                    Stadium = team.Stadium,
                    YearOfEstablishment = team.YearOfEstablishment,
                    History = team.History
                });
            }
            return View("Teams", teamsViewModel);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View("Search");
        }

        [HttpPost]
        public IActionResult Search(FindTeamByNameViewModel model)
        {

            return RedirectToAction("getTeamByName", new { name = model.Name });
        }
        
    }
}
