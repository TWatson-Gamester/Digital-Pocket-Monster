using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Card : IComparable
    {
        [MaxLength(450)]
        public string UserID { get; set; }

        [Required] [Column(TypeName = "varchar(25)")]
        public string Name { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string CardType { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string Color { get; set; }
        [Required]
        public int Level { get; set; }
        [Required] [Column(TypeName = "varchar(20)")]
        public string CardNumber { get; set; }
        [Required] [Column(TypeName = "varchar(75)")]
        public string Image { get; set; }
        // rest of the card info needed - Tobie
        [Required]
        public int ID { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string DigivolveColor { get; set; }
        [Required]
        public int PlayCost { get; set; }
        [Required]
        public int CardPower { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string Race { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string Attribute { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string StageLevel { get; set; }
        [Required] [Column(TypeName = "varchar(15)")]
        public string Rarity { get; set; }
        [Required]
        public int AmountOwned { get; set; } = 0;
        public int PackID { get; set; }
        public int? DeckID { get; set; }

        public Card() {}

        public Card(string name, string cardType, string color, int level, string cardNumber, string image, 
                    int id, string digiColor, int playCost, int cardPower, string race, string attribute, 
                    string stageLevel, string rarity, int amountOwned, int pack, int? deck = null)
        {
            this.Name = name;
            this.CardType = cardType;
            this.Color = color;
            this.Level = level;
            this.CardNumber = cardNumber;
            this.Image = image;
            this.ID = id;
            this.DigivolveColor = digiColor;
            this.PlayCost = playCost;
            this.CardPower = cardPower;
            this.Race = race;
            this.Attribute = attribute;
            this.StageLevel = stageLevel;
            this.Rarity = rarity;
            this.AmountOwned = amountOwned;
            this.PackID = pack;
            this.DeckID = deck; // might of done the deck part wrong ???
        }

        public override string ToString()
        {
            return $"{Name} - {CardType} - {Color} - {Level} - {CardNumber}";
        }

        public int CompareTo(object obj)
        {
            Card testingCard = (Card)obj;
            return ID.CompareTo(testingCard.ID);
        }
    }
}
