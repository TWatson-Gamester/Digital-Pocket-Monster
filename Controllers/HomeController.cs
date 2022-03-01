using Digital_Pocket_Monster.Models;
using Digital_Pocket_Monster.Data;
using Digital_Pocket_Monster.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Digital_Pocket_Monster.Controllers
{
    //[Authorize] //if we want to force people to log in 
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        IDataAccessLayerCards dal;
        public HomeController (IDataAccessLayerCards indal)
        {
            dal = indal;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Deck()
        {
            return View();
        }
        public IActionResult Collection()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier); // wacky id 
            string email = User.FindFirstValue(ClaimTypes.Email); // gets email 
            string name = User.FindFirstValue(ClaimTypes.Name); //returns user@user.com/en-us/aspnet/core/security/authentication/identity-configuration

            return View(dal.showCards(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }

        public IActionResult SeachCards(string srchKeyTerms)
        {
            
            return View("Collection", dal.searchCards(srchKeyTerms));
        }

        public IActionResult FilterCards(string color, string cardType, int? level, string name, string cardNumber, int? id,
            string digiColor, int? playCost, int? cardPower, string race, string attribute,
            string stageLevel, string rarity, bool showOwned)
        {
            return View("Collection", dal.filterCards(color, cardType, level, name , cardNumber, id, digiColor, playCost, cardPower,
                race, attribute, stageLevel, rarity)); 
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Database()
        {
            return Redirect("https://digimoncard.dev/");
        }

        public IActionResult Store()
        {
            return Redirect("https://www.tcgplayer.com/search/digimon-card-game/product?productLineName=digimon-card-game&view=grid&page=1");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //To Edit the Profile Later - Currently just returns you to the Home Page
        public IActionResult EditProfile()
        {
            return View("Index");
        }

        //To Change the Profile's Password - Currently just returns you to the Home Page
        public IActionResult ChangePassword()
        {
            return View("Index");
        }

        //To Delete a Users Account Later - Currently just returns you to the Home Page
        public IActionResult DeleteAccount()
        {
            return View("Index");
        }
    }
}
