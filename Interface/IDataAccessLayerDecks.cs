using Digital_Pocket_Monster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Interface
{
    public interface IDataAccessLayerDecks
    {
        IEnumerable<Deck> showDecks(string userId);
        void addDeck(Deck deck);
        void removeDeck(int? id);
        Deck getDeck(int? id);
        List<Card> getCardsInDeck(int? deckId, Card card);
        void removeCard(int? deckId, int? cardId);
        void addCard(int? id, Card card);
        Card getCard(string cardNumber);
    }
}
