﻿using Digital_Pocket_Monster.Models;
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
        IDataAccessLayerCards collection;

        public DeckBuilderController(IDataAccessLayerDecks inDB, IDataAccessLayerCards inCDB)
        {
            decksDAL = inDB;
            collection = inCDB;
        }

        public IActionResult DeckBuilding()
        {
            ViewBag.cardsInDeck = cardsInDeck;
            ViewBag.digiEggs = digiEggs;
            ViewBag.cardCollection = collection.showCardsNonUser();
            return View("DeckBuilding", decksDAL.getDeck(1));
        }
        public IActionResult FilterCards(string color, string cardType, int? level, string name, string cardNumber, int? id,
            string digiColor, int? playCost, int? cardPower, string race, string attribute,
            string stageLevel, string rarity, bool showOwned)
        {
            return View("DeckBuilding", collection.filterCards(color, cardType, level, name, cardNumber, id, digiColor, playCost, cardPower,
                race, attribute, stageLevel, rarity, showOwned));
        }

        [HttpPost]
        public IActionResult AddCard(string cardNumber)
        {
            bool canAdd = true;
            Card cardBeingAdded = decksDAL.getCard(cardNumber);

            if (decksDAL.getCardAmount(cardBeingAdded.CardNumber) >= 4)
            {
                canAdd = false;
            }

            if (cardBeingAdded.CardType == "Digitama" && digiEggs < 5 && canAdd)
            {
                digiEggs++;
            }
            else
            {
                canAdd = false;
            }

            if (canAdd && cardsInDeck < 55)
            {
                decksDAL.addCard(1, cardBeingAdded);
                cardsInDeck++;
            }

            return Redirect("DeckBuilding");
        }

        [HttpPost]
        public IActionResult RemoveCard(string cardNumber)
        {
            Card cardBeingRemoved = decksDAL.getCard(cardNumber);
            if(cardBeingRemoved.CardType == "Digitama")
            {
                digiEggs--;
            }

            decksDAL.removeCard(1, cardBeingRemoved);
            cardsInDeck--;

            return Redirect("DeckBuilding");
        }

    }
}
