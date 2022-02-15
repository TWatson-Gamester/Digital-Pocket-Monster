using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Deck
    {
        public int ID { get; set; }
        public string deckName { get; set; }
        public int? userID { get; set; }

        public Deck() { }

        public Deck(int id, string deckName, int? userID)
        {
            this.ID = id;
            this.deckName = deckName;
            this.userID = userID; 
        }
    }
}