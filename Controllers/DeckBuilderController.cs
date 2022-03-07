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
        private static int digiEggs = 0;
        private static int cardsInDeck = 0;
        IDataAccessLayerDecks decksDAL;
        IDataAccessLayerCards collection;
        private static List<Card> deck = new List<Card>();

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
            ViewBag.Deck = deck;
            return View(); //decksDAL.getDeck(1)
        }

        [HttpPost]
        public IActionResult AddCard(string cardNumber)
        {
            bool canAdd = true;
            Card cardBeingAdded = decksDAL.getCard(cardNumber);

            if (getCardAmount(cardBeingAdded.CardNumber) == 4)
            {
                canAdd = false;
            }

            if (cardBeingAdded.CardType == "Digitama" && canAdd)
            {
                if (digiEggs < 5)
                {
                    digiEggs++;
                }
                else
                {
                    canAdd = false;
                }
            }


            if (canAdd && cardsInDeck < 55)
            {
                //decksDAL.addCard(1, cardBeingAdded);
                deck.Add(cardBeingAdded);
                deck.Sort();
                cardsInDeck++;
            }

            return Redirect("DeckBuilding");
        }

        [HttpPost]
        public IActionResult RemoveCard(string cardNumber)
        {
            Card cardBeingRemoved = decksDAL.getCard(cardNumber);
            if (doesDeckContainCard(cardNumber))
            {
                if (cardBeingRemoved.CardType == "Digitama")
                {
                    digiEggs--;
                }

                //decksDAL.removeCard(1, cardBeingRemoved);
                foreach(Card card in deck)
                {
                    if(card.CardNumber == cardNumber)
                    {
                        deck.Remove(card);
                        deck.Sort();
                        break;
                    }
                }
                cardsInDeck--;
            }

            return Redirect("DeckBuilding");
        }

        private int getCardAmount(string CardNumber)
        {
            int cardCount = 0;

            foreach(Card card in deck)
            {
                if(card.CardNumber == CardNumber)
                {
                    cardCount++;
                }
            }

            return cardCount;
        }

        private bool doesDeckContainCard(string CardNumber)
        {
            bool containsCard = false;
            foreach(Card card in deck)
            {
                if(card.CardNumber == CardNumber)
                {
                    containsCard = true;
                    break;
                }
            }

            return containsCard;
        }

    }
}
