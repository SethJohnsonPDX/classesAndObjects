﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects
{
    class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
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
