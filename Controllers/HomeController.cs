﻿using Digital_Pocket_Monster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static List<Card> cardList = new List<Card>()
        {
            new Card("Frisbeemon 1", "bitch", "purple", 69, "9001", "meme.png"), 
            new Card("Frisbeemon 2", "bitch", "purple", 69, "9001", "meme.png"), 
            new Card("Frisbeemon 3", "bitch", "purple", 69, "9001", "meme.png"), 
            new Card("Frisbeemon 4", "bitch", "purple", 69, "9001", "meme.png"), 
            new Card("Frisbeemon 5", "bitch", "purple", 69, "9001", "meme.png"), 
            new Card("Frisbeemon 6", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 7", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 8", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 9", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 10", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 11", "bitch", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 12", "bitch", "purple", 69, "9001", "meme.png")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Collection()
        {
            return View(cardList);
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult DeckBuilding()
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
