using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Interface
{
    public interface IDataAccessLayer
    {
        IEnumerable<Card> showCards();
        IEnumerable<Card> searchCards(string searchCard);
        IEnumerable<Card> filterCards(string color, string cardType, int? level, string name);
        Card getCard(int? id);
        void removeCard(int? id);
        void addCard(Card card);

    }
}
