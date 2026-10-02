using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
    internal class Game
    {
        public string name;
        public string genre;
        public double price;
        public double rating;

        public Game(string name, string genre, double price, double rating)
        {
            this.name = name;
            this.genre = genre;
            this.price = price;
            this.rating = rating;
        }
    }
}
