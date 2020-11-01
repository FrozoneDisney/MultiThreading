using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreadingTest
{
    public class Player
    {
        List<Card> currentCards = new List<Card>();
        


        

        public void DrawCard(List<Card> deck)
        {

            
            
                currentCards.Add(deck[0]);
                deck.Remove(deck[0]);
                Console.WriteLine("Player drew {0}", currentCards[0].GetCardInfo());
            
            
        }
    }
}