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

        [MaxLength(450)]
        public string UserID { get; set; }

        [Required] [Column(TypeName = "varchar(25)")]
        public string DeckName { get; set; }

        //public int? UserIDold { get; set; } // this is unnecessary now I think - Tobie 

        public Deck() { }

        public Deck(int id, string deckName) //, int? userID
        {
            this.ID = id;
            this.DeckName = deckName;
            //this.UserID = userID; 
        }
    }
}