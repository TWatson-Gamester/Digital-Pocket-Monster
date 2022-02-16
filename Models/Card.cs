using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Card
    {
        [Required] [Column(TypeName = "varchar(25)")]
        public string name { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string cardType { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string color { get; set; }
        [Required]
        public int level { get; set; }
        [Required] [Column(TypeName = "varchar(20)")]
        public string cardNumber { get; set; }
        [Required] [Column(TypeName = "varchar(75)")]
        public string image { get; set; }
        // rest of the card info needed - Tobie
        [Required]
        public int ID { get; set; }
        [Required] [Column(TypeName = "varchar(250)")]
        public string cardDescription { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string digivolveColor { get; set; }
        [Required]
        public int playCost { get; set; }
        [Required]
        public int cardPower { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string race { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string attribute { get; set; }
        [Required] [Column(TypeName = "varchar(10)")]
        public string stageLevel { get; set; }
        [Required] [Column(TypeName = "varchar(15)")]
        public string rarity { get; set; }
        [Required]
        public int amountOwned { get; set; } = 0;
        private int packID { get; set; }
        private int? deckID { get; set; }

        public Card() {}

        public Card(string name, string cardType, string color, int level, string cardNumber, string image)
        {
            this.name = name;
            this.cardType = cardType;
            this.color = color;
            this.level = level;
            this.cardNumber = cardNumber;
            this.image = image;
        }

        public Card(string name, string cardType, string color, int level, string cardNumber, string image, 
                    int id, string digiColor, int playCost, int cardPower, string race, string attribute, 
                    string stageLevel, string rarity, int amountOwned, int pack, int? deck = null)
        {
            this.name = name;
            this.cardType = cardType;
            this.color = color;
            this.level = level;
            this.cardNumber = cardNumber;
            this.image = image;
            this.ID = id;
            this.digivolveColor = digiColor;
            this.playCost = playCost;
            this.cardPower = cardPower;
            this.race = race;
            this.attribute = attribute;
            this.stageLevel = stageLevel;
            this.rarity = rarity;
            this.amountOwned = amountOwned;
            this.packID = pack;
            this.deckID = deck; // might of done the deck part wrong ???
        }

        public override string ToString()
        {
            return $"{name} - {cardType} - {color} - {level} - {cardNumber}";
        }
    }
}
