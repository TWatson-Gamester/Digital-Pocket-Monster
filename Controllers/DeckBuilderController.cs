using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Data;
using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Controllers
{
    public class DeckBuilderController : Controller
    {
        private int digiEggs = 0;
        private int cardsInDeck = 0;
        private DecksDAL decksDAL;

        public IActionResult DeckBuilding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCard(string cardNumber)
        {
            bool canAdd = true;
            Card cardBeingAdded = decksDAL.getCard(cardNumber);
/*
            if(decksDAL.getCard(cardNumber) >= 4){
                canAdd = false;
             }*/

            if(cardBeingAdded.CardType == "Digitama" && digiEggs < 5 && canAdd)
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

            return View("DeckBuilder");
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

            return View("DeckBuilder");
        }

    }
}
