﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Interface
{
    public interface IDataAccessLayer
    {
        IEnumerable<Card> showCards(string userId);
        IEnumerable<Card> searchCards(string searchCard);
        IEnumerable<Card> filterCards(string color, string cardType, int? level, string name, string cardNumber, int? id, string digiColor, int? playCost, int? cardPower, string race, string attribute,
            string stageLevel, string rarity);
        Card getCard(int? id);
        void removeCard(int? id);
        void addCard(Card card);
        // add to the methods so that they take in the UserID - Tobie
    }
}
