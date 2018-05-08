﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle(int times = 1)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (Cards.Count > 0)
            {
                int randomIndex = random.Next(0, Cards.Count);
                TempList.Add(Cards[randomIndex]);
                Cards.RemoveAt(randomIndex);
            }
            Cards = TempList;
        }



        public List<Card> Cards { get; set; }
    }
}
