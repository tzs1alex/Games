using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
    internal class GameLibrary
    {
        List<Game> Games = new List<Game>();

        public void AddGame(Game Game)
        {
            Games.Add(Game);
            Console.WriteLine("Game is added.");
        }

        public void Print()
        {
            foreach (var item in Games)
            {
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("Genre: " + item.genre);
                Console.WriteLine("Price: " + item.price);
                Console.WriteLine("Rating: " + item.rating);
                Console.WriteLine();
            }
        }

        public void PrintGamesbyGenre(string genre)
        {
            foreach (var item in Games)
            {
                if (item.genre == genre)
                {
                    Console.WriteLine(item.name);
                }
            }
        }

        public void PrintGamesbyName(string name)
        {
            bool found = false;

            foreach (var item in Games)
            {
                if (item.name == name)
                {
                    Console.WriteLine("Name: " + item.name);
                    Console.WriteLine("Genre: " + item.genre);
                    Console.WriteLine("Price: " + item.price);
                    Console.WriteLine("Rating: " + item.rating);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Game is not found");
            }
        }

        public void FindHighestRate()
        {
            if (Games.Count == 0)
            {
                Console.WriteLine("No Games");
                return;
            }

            Game Highest = Games[0];

            foreach (var item in Games)
            {
                if (item.rating > Highest.rating)
                {
                    Highest = item;
                }
            }

            Console.WriteLine("Highest rated game:");
            Console.WriteLine(Highest.name);
            Console.WriteLine(Highest.genre);
            Console.WriteLine(Highest.price);
            Console.WriteLine(Highest.rating);
        }

        public void FindCheapestGame()
        {
            if (Games.Count == 0)
            {
                Console.WriteLine("No Games");
                return;
            }

            Game Cheapest = Games[0];

            foreach (var item in Games)
            {
                if (item.price < Cheapest.price)
                {
                    Cheapest = item;
                }
            }

            Console.WriteLine("Cheapest game:");
            Console.WriteLine(Cheapest.name);
            Console.WriteLine(Cheapest.genre);
            Console.WriteLine(Cheapest.price);
            Console.WriteLine(Cheapest.rating);
        }

        public void DeletingGames()
        {
            Console.WriteLine("Enter game:");
            string Game1 = Console.ReadLine();

            for (int i = 0; i < Games.Count; i++)
            {
                if (Games[i].name == Game1)
                {
                    Games.RemoveAt(i);
                    Console.WriteLine("Game deleted!");
                    return;
                }
            }

            Console.WriteLine("Game is not found");
        }

        public void ChangingRating()
        {
            Console.WriteLine("Enter game:");
            string Game1 = Console.ReadLine();

            Console.WriteLine("Enter new rating:");
            double newRating = double.Parse(Console.ReadLine());

            foreach (var item in Games)
            {
                if (item.name == Game1)
                {
                    item.rating = newRating;
                    Console.WriteLine("Rating changed!");
                    return;
                }
            }

            Console.WriteLine("Game is not found");
        }

        public void GamesUnderPrice()
        {
            Console.WriteLine("Enter maximum price:");
            double maxPrice = double.Parse(Console.ReadLine());

            foreach (var item in Games)
            {
                if (item.price <= maxPrice)
                {
                    Console.WriteLine(item.name + " - " + item.price);
                }
            }
        }
    }
}
