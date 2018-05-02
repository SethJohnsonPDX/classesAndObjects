using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame() { Dealer = "Seth", Name = "Twenty-One" };
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            //    Deck deck = new Deck();
            //    deck.Shuffle(3);

            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " Of " + card.Suit);

            //    }
            //    Console.WriteLine(deck.Cards.Count);
            //    Console.ReadLine();
        }

        //public static deck shuffle(deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = shuffle.deck();
        //    }

        //    return deck;
        //}

    }
}
