using Digital_Pocket_Monster.Interface;
using Digital_Pocket_Monster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Data
{
    public class UsersDAL : IDataAccessLayerUsers
    {
        private IdentityContext db;
        public UsersDAL(IdentityContext indb)
        {
            this.db = indb;
        }

        public Deck getDeck(int? id)
        {
            Deck foundDeck = null;

            if (id != null)
            {
                db.Decks.ToList().ForEach(d =>
                {
                    if (d.ID == id)
                    {
                        foundDeck = d;
                    }
                });
            }
            return foundDeck;
        }

        public IEnumerable<Deck> showDecks(string userId)
        {
            return db.Decks.Where(m => m.UserID == userId).ToList();
        }
    }
}
