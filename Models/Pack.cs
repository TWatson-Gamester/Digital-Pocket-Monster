using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Pack
    {
        public int ID { get; set; }
        public string packName { get; set; }

        public Pack() { }

        public Pack(int id, string packName)
        {
            this.ID = id;
            this.deckName = packName;
        }
    }
}