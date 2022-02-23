using Digital_Pocket_Monster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Interface
{
    interface IDataAccessLayerDecks
    {
        IEnumerable<Deck> showDecks();
        void addDeck(Deck deck);
        void removeDeck(int? id);
        Deck getDeck(int? id);
        void removeCard(int? deckId, int? cardId);
        void addCard(int? id, Card card);
    }
}
