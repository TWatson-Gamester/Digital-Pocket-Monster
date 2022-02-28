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
    public class DeckBuilderController : Controller
    {
        private int digiEggs = 0;
        private int cardsInDeck = 0;
        IDataAccessLayerDecks decksDAL;

        public DeckBuilderController(IDataAccessLayerDecks inDB)
        {
            decksDAL = inDB;
        }


        public IActionResult DeckBuilding()
        {
            return View("DeckBuilding", decksDAL.getDeck(1));
        }

        [HttpPost]
        public IActionResult AddCard(string cardNumber)
        {
            bool canAdd = true;
            Card cardBeingAdded = decksDAL.getCard(cardNumber);

/*            if (decksDAL.getCard(cardNumber) >= 4)
            {
                canAdd = false;
            }   Make something that searches and looks for how many of a card there is*/   

            if (cardBeingAdded.CardType == "Digitama" && digiEggs < 5 && canAdd)
            {
                digiEggs++;
            }
            else
            {
                canAdd = false;
            }

            if (canAdd)
            {
                decksDAL.addCard(1, cardBeingAdded);
                cardsInDeck++;
            }

            return View("DeckBuilding", decksDAL.getDeck(1));
        }

        [HttpPost]
        public IActionResult RemoveCard(string cardNumber)
        {
            Card cardBeingRemoved = decksDAL.getCard(cardNumber);
            if(cardBeingRemoved.CardType == "Digitama")
            {
                digiEggs--;
            }

            //decksDAL.removeCard(1, cardBeingRemoved);
            cardsInDeck--;

            return View("DeckBuilding", decksDAL.getDeck(1));
        }

    }
}
