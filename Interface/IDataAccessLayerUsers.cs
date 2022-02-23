using Digital_Pocket_Monster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Interface
{
    interface IDataAccessLayerUsers
    {
        IEnumerable<Deck> showDecks(string userId);
        Deck getDeck(int? id);
    }
}
