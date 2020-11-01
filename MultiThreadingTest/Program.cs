using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace MultiThreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = CardDeck();
            Shuffle(deck);
            Player p1 = new Player();
            Player p2 = new Player();

            Thread t1 = new Thread(() => p1.DrawCard(deck));
            Thread t2 = new Thread(() => p2.DrawCard(deck));
            t1.Start();
            t2.Start();
            

    }

        

        public static List<Card> CardDeck()
        {
            List<Card> cardArray = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cardArray.Add(new Card((CardColor)i, (CardValue)j));
                }
            }

            return cardArray;
        }

        public static void Shuffle(List<Card> ts)
        {
            var rng = new Random();
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = rng.Next(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }


    }
}
