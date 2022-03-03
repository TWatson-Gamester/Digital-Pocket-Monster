using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Data;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Interface
{
    public interface IDataAccessLayerCards
    {
        IEnumerable<Card> showCardsUsers(string userId);
        IEnumerable<Card> showCardsNonUser();
        IEnumerable<Card> searchCards(string searchCard);
        IEnumerable<Card> filterCards(string color, string cardType, int? level, string name, string cardNumber, int? id, string digiColor, int? playCost, int? cardPower, string race, string attribute,
            string stageLevel, string rarity, bool showOwned);
        Card getCard(string cardNumber);
        int getCardAmount(string cardNumber);
        void removeCard(string cardNumber);
        void addCard(Card card);
        // add to the methods so that they take in the UserID - Tobie
    }
}
