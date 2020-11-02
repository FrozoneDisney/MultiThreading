using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreadingTest
{
    public class Player
    {
        List<Card> currentCards = new List<Card>();
        


        

        public void DrawCard(List<Card> deck, Object Locked)
        {

            lock (Locked)
            {
                currentCards.Add(deck[0]);
                deck.Remove(deck[0]);
                Console.Write("Attempting to draw card.... ");
                Thread.Sleep(2000);
                Console.WriteLine("drew {0}", currentCards[0].GetCardInfo());

            }
            
        }
    }
}