using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Deck
    {
        [Required]
        public int? ID { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]

        public string DeckName { get; set; }

        public int? UserID { get; set; }

        public Deck() { }

        public Deck(int id, string deckName, int? userID)
        {
            this.ID = id;
            this.DeckName = deckName;
            this.UserID = userID; 
        }
    }
}