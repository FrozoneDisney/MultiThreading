using System;
using System.Collections.Generic;

namespace MultiThreadingTest
{
    public enum CardColor
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        private CardColor _color;
        private CardValue _value;

        public Card(CardColor _color, CardValue _value)
        {
            this._color = _color;
            this._value = _value;
        }

        public string GetCardInfo()
        {
            return string.Format("{0} of {1}",_value, _color);
        }

    }
}