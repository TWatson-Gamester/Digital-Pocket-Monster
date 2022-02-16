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
        private static List<Card> cardList = new List<Card>()
        {
            new Card("Frisbeemon 1", "norm", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 2", "crazy", "purple", 69, "9001", "meme.png"),
            new Card("Gomamon", "Cool", "Blue", 3, "BT1-030", "Gommamon_Placeholder.png"),
            new Card("Frisbeemon 4", "hey", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 5", "crazy", "purple", 69, "9001", "meme.png"),
            new Card("Gomamon", "Cool", "Blue", 3, "BT1-030", "Gommamon_Placeholder.png"),
            new Card("Frisbeemon 6", "norm", "purple", 69, "9001", "meme.png"),
            new Card("Frisbeemon 7", "norm", "purple", 69, "9001", "meme.png"),
            new Card("Gomamon", "Cool", "Blue", 3, "BT1-030", "Gommamon_Placeholder.png"),
            new Card("Frisbeemon 8", "hey", "purple", 69, "9001", "meme.png"),
            new Card("Ghost", "OHNO", "purple", 69, "9001", "meme.png")
        };


        public void addCard(Card card)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> filterCards(string color, string cardType, int? level, string name)
        {
            List<Card> tmpCards = new List<Card>();

            bool colorCheck = color != null;
            bool typeCheck = cardType != null;
            bool levelCheck = level != null;
            bool nameCheck = name != null;

            foreach(var c in cardList)
            {
                if((!colorCheck || c.color.ToUpper().Contains(color.ToUpper())) && (!typeCheck || (c.cardType.ToUpper().Contains(cardType.ToUpper()))) && (!level.HasValue || c.level == level.Value ) && (!nameCheck || c.name.ToUpper().Contains(name.ToUpper())))
                {
                    tmpCards.Add(c);
                }
            }
            return tmpCards;
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
            if(string.IsNullOrEmpty(searchCard))
            {
                return cardList;
            }

            List<Card> tmpCards = new List<Card>();
            foreach(var c in cardList)
            {
                if(c.name.ToUpper().Contains(searchCard.ToUpper()))
                {
                    tmpCards.Add(c);
                }
            }
            return tmpCards;
        }

        public IEnumerable<Card> showCards()
        {
            return cardList;
        }
    }
}
