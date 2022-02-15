using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Card
    {
        public string name { get; set; }
        public string cardType { get; set; }
        public string color { get; set; }
        public int level { get; set; }
        public string cardNumber { get; set; }
        public string image { get; set; }
        // rest of the card info needed - Tobie
        public int ID { get; set; }
        public string digivolveColor { get; set; }
        public int playCost { get; set; }
        public int cardPower { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public string stageLevel { get; set; }
        public string rarity { get; set; }
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
