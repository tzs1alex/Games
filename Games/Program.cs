namespace Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLibrary library = new GameLibrary();

            bool running = true;

            while (running)
            {
                Console.WriteLine("===== GAME LIBRARY =====");
                Console.WriteLine("1. Add game");
                Console.WriteLine("2. Show all games");
                Console.WriteLine("3. Search by genre");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Find highest rating");
                Console.WriteLine("6. Find cheapest game");
                Console.WriteLine("7. Delete game");
                Console.WriteLine("8. Change rating");
                Console.WriteLine("9. Games under price");
                Console.WriteLine("10. Exit");
                Console.WriteLine("========================");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter game name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Enter price: ");
                        double price = double.Parse(Console.ReadLine());

                        Console.Write("Enter rating: ");
                        double rating = double.Parse(Console.ReadLine());

                        Game game = new Game(name, genre, price, rating);
                        library.AddGame(game);
                        break;

                    case 2:
                        library.Print();
                        break;

                    case 3:
                        Console.Write("Enter genre: ");
                        string searchGenre = Console.ReadLine();

                        library.PrintGamesbyGenre(searchGenre);
                        break;

                    case 4:
                        Console.Write("Enter game name: ");
                        string searchName = Console.ReadLine();

                        library.PrintGamesbyName(searchName);
                        break;

                    case 5:
                        library.FindHighestRate();
                        break;

                    case 6:
                        library.FindCheapestGame();
                        break;

                    case 7:
                        library.DeletingGames();
                        break;

                    case 8:
                        library.ChangingRating();
                        break;

                    case 9:
                        library.GamesUnderPrice();
                        break;

                    case 10:
                        running = false;
                        Console.WriteLine("Program ended.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine();
            }
        }
    
    }
}
