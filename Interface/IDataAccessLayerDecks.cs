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
        IEnumerable<Deck> saveDeck(string deckName);
        void removeDeck(int? id);
        Deck getDeck(int? id);
        void removeCard(int? id);
        void addCard(Card card);
    }
}
