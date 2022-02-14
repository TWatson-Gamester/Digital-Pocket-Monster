using Digital_Pocket_Monster.Models;
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
            new Card("Frisbeemon 9", "bitch", "purple", 69, "9001", "meme.png")
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
