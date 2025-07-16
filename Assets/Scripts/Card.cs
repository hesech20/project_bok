using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bookofkarma {
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public CardType cardType;
        public CardClass cardClass;
        public CardFaction cardFaction;
        public int cardCost;


        public enum CardType
        {
            Attack,
            Defense,
            Support,
        }

        public enum CardFaction
        {
            Order,
            Academy,
            Mercinary,
        }

        public enum CardClass
        {
            Priest,
            ShadowDisciple,
            Shaman,
            Inventor,
            Mechanic,
            Alchemist,
            Warrior,
            Rogue,
            Survivalist,
        }
    }
}
