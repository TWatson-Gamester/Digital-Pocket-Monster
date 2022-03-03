﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Data 
{
    public class CardsDAL : IDataAccessLayerCards
    {

        private IdentityContext db;
        
        public CardsDAL(IdentityContext indb)
        {
            this.db = indb;
        }


        public void addCard(string cardNumber)
        {
            var cardToChange = getCard(cardNumber);
            cardToChange.AmountOwned++;
            db.SaveChanges();
        }

        public void removeCard(string cardNumber)
        {
            var cardToChange = getCard(cardNumber);
            if(cardToChange.AmountOwned != 0)
            {
                cardToChange.AmountOwned--;
                db.SaveChanges();
            }
        }

        public IEnumerable<Card> filterCards(string color, string cardType, int? level, string name, string cardNumber, int? id,
            string digiColor, int? playCost, int? cardPower, string race, string attribute,
            string stageLevel, string rarity, bool showOwned)
        {
            IQueryable<Card> query = db.Cards;

            if(!string.IsNullOrWhiteSpace(color))
            {
                query = query.Where(c => c.Color.ToLower().Equals(color.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(cardType))
            {
                query = query.Where(c => c.CardType.ToLower().Equals(cardType.ToLower()));
            }
            if(level.HasValue)
            {
                query = query.Where(c => c.Level == level.Value);
            }
            if(!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(c => c.Name.ToLower().Contains(name.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(cardNumber))
            {
                query = query.Where(c => c.CardNumber.ToLower().Equals(cardNumber.ToLower()));
            }
            if(id.HasValue)
            {
                query = query.Where(c => c.ID == id.Value);
            }
            if(!string.IsNullOrWhiteSpace(digiColor))
            {
                query = query.Where(c => c.DigivolveColor.ToLower().Equals(digiColor.ToLower()));
            }
            if(playCost.HasValue)
            {
                query = query.Where(c => c.PlayCost == playCost.Value);
            }
            if(cardPower.HasValue)
            {
                query = query.Where(c => c.CardPower == cardPower.Value);
            }
            if(!string.IsNullOrWhiteSpace(race))
            {
                query = query.Where(c => c.Race.ToLower().Equals(race.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(attribute))
            {
                query = query.Where(c => c.Attribute.ToLower().Equals(attribute.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(stageLevel))
            {
                query = query.Where(c => c.StageLevel.ToLower().Equals(stageLevel.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(rarity))
            {
                query = query.Where(c => c.Rarity.ToLower().Equals(rarity.ToLower()));
            }
            if(showOwned)
            {
                query = query.Where(c => c.AmountOwned > 0);
            }

            return query.ToList();

           
        }

        public Card getCard(string cardNumber)
        {
            IQueryable<Card> query = db.Cards;

            if (!string.IsNullOrWhiteSpace(cardNumber))
            {
                query = query.Where(cn => cn.CardNumber.ToLower().Equals(cardNumber.ToLower()));
            }

            return query.ToArray()[0];
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

        public IEnumerable<Card> searchCards(string searchCard)
        {
            return db.Cards.Where(c => c.Name.ToLower().Contains(searchCard.ToLower())).ToList();

        }

        public IEnumerable<Card> showCardsUsers(string userId)
        {
            return db.Cards.Where(m => m.UserID == userId).ToList();
        }

        public IEnumerable<Card> showCardsNonUser()
        {
            return db.Cards.ToList();
        }

        public void UpdateCards(Card card)
        {
            db.Update(card);
            db.SaveChanges();
        }
    }
}
