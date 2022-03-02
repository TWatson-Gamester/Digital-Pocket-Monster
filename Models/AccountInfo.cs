using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class AccountInfo : Areas.Identity.Pages.Account.ExternalLoginModel.InputModel
    {
        [Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int CardID { get; set; }
        [Column(TypeName = "int")]
        public int DeckID { get; set; }
        [Column(TypeName = "nvarchar(450)")]
        public string IdentityID { get; set; }

        public AccountInfo() { }

        public AccountInfo(int id, string name, int cardId, int deckId, string identityId)
        {
            this.Id = id;
            this.Name = name;
            this.CardID = cardId;
            this.DeckID = deckId;
            this.IdentityID = identityId; 
        }
    }
}