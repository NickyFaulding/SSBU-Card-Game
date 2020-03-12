using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Player
    {
        Hero[] hand = new Hero[3];
        Heros deck = new Heros();

        public Player(Heros newDeck)
        {
            this.deck = newDeck;
        }

        public void InitialiseHand()
        {
            int handSize = hand.Length;

            for (int i = 0; i < handSize; i++)
            {
                hand[i] = deck.DrawRandomHero();
            }
        }

        public int GetTotalHealth()
        {
            int totalHP;

            totalHP = hand[0].GetHealth() + hand[1].GetHealth() + hand[2].GetHealth();

            return totalHP;
        }

        public Hero GetHand(int whichCard)
        {
            return hand[whichCard];
        }
    }
}