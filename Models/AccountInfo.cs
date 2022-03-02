using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class AccountInfo
    {
        [Required]
        public int Id { get; set; }
        [Required] [Column(TypeName = "varchar(15)")]
        public string Name { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string CardID { get; set; }
        [Required] [Column(TypeName = "varchar(50)")]
        public string DeckID { get; set; }
        [Required] [Column(TypeName = "varchar(100)")]
        public string IdentityID { get; set; }

        public AccountInfo() { }

        public AccountInfo(int id, string name, string cardId, string deckId, string identityId)
        {
            this.Id = id;
            this.Name = name;
            this.CardID = cardId;
            this.DeckID = deckId;
            this.IdentityID = identityId; 
        }
    }
}