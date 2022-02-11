using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Data 
{
    public class CardsDAL : IDataAccessLayer
    {
        public void addCard(Card card)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> filterCards(string color, string cardType, int level)
        {
            throw new NotImplementedException();
        }

        public Card getCard(int? id)
        {
            throw new NotImplementedException();
        }

        public void removeCard(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> searchCards(string searchCard)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> showCards()
        {
            throw new NotImplementedException();
        }
    }
}
