using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Data
{
    public class DecksDAL : IDataAccessLayerDecks
    {
        //deck list, add card/remove card, save decks, delete the deck, NO FILTER OR SEARCH, name deck
        private static List<Deck> deckList = new List<Deck>()
        {

        };

        public void addCard(Card card)
        {
            int id;
            getDeck(id);

            if(id != null)
            {

            }
        }

        public Deck getDeck(int? id)
        {
            return deckList.ToList();
        }

        public void removeCard(int? id)
        {
            throw new NotImplementedException();
        }

        public void removeDeck(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deck> saveDeck(string deckName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deck> showDecks()
        {
            throw new NotImplementedException();
        }
    }
}
