﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Data
{
    public class DecksDAL : IDataAccessLayerDecks
    {
        private CardsDAL cdal;
        private IdentityContext db;
        public int numOfCards;

        public DecksDAL(IdentityContext indb)
        {
            this.db = indb;
        }

        public void addCard(int? deckId, Card card)
        {
            Deck foundDeck = getDeck(deckId);

            if(foundDeck != null)
            {
                numOfCards++;
                db.Add(card);
                db.SaveChanges();
            }
        }

        public void addDeck(Deck deck)
        {
            if (deck.ID >= 5) return;
            db.Add(deck);
            db.SaveChanges();
        }

        public Card getCard(string cardNumber)
        {
            Card card = cdal.getCard(cardNumber);
            return card;
        }

        public List<Card> getCardsInDeck(int? deckId, Card card)
        {
            Deck foundDeck = getDeck(deckId);
            Card theCard;
            List<Card> cardArray = new List<Card>();
            int arrayIndex = 0;

            if (foundDeck != null)
            {
                foreach (var cardValue in db.Cards.Where(c => c.DeckID == foundDeck.ID).ToList())
                {
                    theCard = getCard(card.CardNumber);
                    cardArray[arrayIndex] = theCard;
                    arrayIndex++;
                }
                return cardArray;
            }
            return null;
        }

        public Deck getDeck(int? id)
        {
            Deck foundDeck = null;

            if(id != null)
            {
                db.Decks.ToList().ForEach(d =>
                {
                    if(d.ID == id)
                    {
                        foundDeck = d;
                    }
                });
            }
            return foundDeck;
        }

        public int getCardAmount(string cardNumber)
        {
            Card foundCard = getCard(cardNumber);
            int cardAmount = 0;
            foreach (var cardValue in db.Cards.Where(c => c.CardNumber == foundCard.CardNumber).ToList())
            {
                cardAmount++;
            }

            return cardAmount;
        }

        public void removeCard(int? deckId, Card card)
        {
            Deck foundDeck = getDeck(deckId);
            Card foundCard = getCard(card.CardNumber);

            if (foundDeck != null)
            {
                if (foundCard != null)
                {
                    db.Cards.Remove(foundCard);
                    db.SaveChanges();
                }
            }
        }

        public void removeDeck(int? id)
        {
            Deck foundDeck = getDeck(id);
            if (foundDeck != null)
            {
                db.Remove(foundDeck);
                db.SaveChanges();
            }
        }

        public IEnumerable<Deck> showDecks(string userId)
        {
            return db.Decks.Where(m => m.UserID == userId).ToList();
        }

    }
}
