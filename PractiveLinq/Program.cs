using System;
using System.Collections.Generic;
using System.Linq;

namespace PractiveLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Order the list of games by length of the game name.

            var videoGames = new List<string>()
            { "mario kart", "mario party superstars", "donkey kong", "mortal kombat", "sonic the hedgehog" };
            
            var nameLength = videoGames.OrderBy(name => name.Length).ThenBy(name => name);
            
            foreach (var name in nameLength)
                Console.WriteLine(name);

            Console.WriteLine();

            var namefilter = videoGames.Where(name => name.Contains("k"));
            foreach (var name in namefilter)
                Console.WriteLine(name);
       

            Console.WriteLine($"\n{videoGames.Count()}");

           
           







        }
    }
}
