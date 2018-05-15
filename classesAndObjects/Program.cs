using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here is some text.";
            File.WriteAllText(@"C:\Users\Student\Desktop\Logs\Log.txt", text);
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();







            //    Deck deck = new Deck();

            //    int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //    List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //    Card card = new Card();
            //    card.Suit = Suit.Clubs;
            //    int underlyingValue = Convert.ToInt32(Suit.Diamonds);

            //    OPERATOR OVERLOADING //
            //    Game game = new TwentyOneGame();
            //    game.Players = new List<Player>();
            //    Player player = new Player();
            //    player.Name = "Jesse";
            //    game = game + player;

            //    TwentyOneGame game = new TwentyOneGame() { Dealer = "Seth", Name = "Twenty-One" };
            //    game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //    game.ListPlayers();
            //    Console.ReadLine();

            //    Deck deck = new Deck();
            //    deck.Shuffle(3);

            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " Of " + card.Suit);

            //    }
            //    Console.WriteLine(deck.Cards.Count);
            //    Console.ReadLine();
            //}

            //public static deck shuffle(deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = shuffle.deck();
            //    }

            //    return deck;
        }

    }
}
