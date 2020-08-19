using System;
using System.Collections.Generic;
using System.Linq;


namespace Module19.QueryAndManipulateDataAndObjectsByUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            static IEnumerable<string> Suits()
            {
                yield return "clubs";
                yield return "diamonds";
                yield return "hearts";
                yield return "spades";
            }

            static IEnumerable<string> Ranks()
            {
                yield return "two";
                yield return "three";
                yield return "four";
                yield return "five";
                yield return "six";
                yield return "seven";
                yield return "eight";
                yield return "nine";
                yield return "ten";
                yield return "jack";
                yield return "queen";
                yield return "king";
                yield return "ace";
            }
            //var startingDeck = from s in Suits()
            //                   from r in Ranks()
            //                   select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            //foreach (var card in startingDeck)
            //{
            //    Console.WriteLine(card);
            //}

            // 52 cards in a deck, so 52 / 2 = 26
            //var top = startingDeck.Take(26);
            //var bottom = startingDeck.Skip(26);
            //foreach (var itemTop in top)
            //{
            //    Console.WriteLine(itemTop.Rank);
            //}
            //foreach (var itemBottom in bottom)
            //{
            //    Console.WriteLine(itemBottom.Rank);
            //}
            var startingDeck = Suits().SelectMany(
                suit => Ranks().Select(
                    rank => new { Suit = suit, Rank = rank }));

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }
    }
}
//offical doc: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq