using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class store
    {

        int maxGames = 4;
        List<Game> showcase = new List<Game>();


        public store()
        {
            showcase.Add(new Game("Daddy simulator", 15f, "How to dad", "real-life"));

            showcase.Add(new Game("Halflife 3", 1000000f, "Best game ever", "sci-fi"));

            showcase.Add(new Game("Hat in Time", 20f, "Super cute", "3D platformer"));
        }



        public void AddGame(Game game)
        {
            if (showcase.Count < maxGames)
                showcase.Add(game);

        }

        public void RemoveGame(Game game)
        {
            if(showcase.Contains(game))
            showcase.Remove(game);
        }


        public void Sell(Game game, User user)
        {
            if (user.wallet >= game.price)
            {
                user.library.Add(game);
                user.wallet -= game.price;
                Console.WriteLine("Congrats you bought" + game.name);
                RemoveGame(game);
            }
            else
                Console.WriteLine("Not Enough money fag!");
        }



    }


    class User
    {
        public float wallet;
        public List<Game> library = new List<Game>();

        public User(float walletFunds)
        {
            wallet = walletFunds;
        }

    }


    class Game
    {
        public string genre;
        public string name;
        public float price;
        public string description;

        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }
    }













    class DLC
    {
        public string game;
        public string name;
        public float price;
        public string description;

        public DLC(string name, float price, string description, string game)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.game = game;
        }
    }
}
