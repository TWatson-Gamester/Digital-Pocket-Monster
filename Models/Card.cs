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

        public Card()
        {

        }

        public Card(string name, string cardType, string color, int level, string cardNumber, string image)
        {
            this.name = name;
            this.cardType = cardType;
            this.color = color;
            this.level = level;
            this.cardNumber = cardNumber;
            this.image = image;
        }
        public override string ToString()
        {
            return $"{name} - {cardType} - {color} - {level} - {cardNumber}";
        }
    }
}
