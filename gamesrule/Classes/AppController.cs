using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace gamesrule
{
    static class AppController
    {
        private static User currentUser;
        private static Random noise = new Random();

        public static List<Game> Search(string query)
        {
            if(Database.Games.Count > 0)
            {
                IEnumerable<Game> games = Database.Games.Where(x => x.Name.ToLower().Contains(query.ToLower()));
                return games.ToList();
            }
            else
            {
                throw new Exception("There is no games");
            }
        }

        public static void ShowGame(Game item)
        {
            
        }

        public static void GetList(List<Game> games, ref ListBox block)
        {
            block.Items.Clear();
            for (int i = 0; i < games.Count; i++)
            {
                Game data = games.ElementAt(i);
                ListBoxItem item = new ListBoxItem();
                item.Content = data.Name;
                block.Items.Add(item);
            }
        }


        public static void AddGame(Game.Category type, string name, string desc)
        {
            if(name.Length < 2)
            {
                throw new ArgumentException("Game's title is too short");
            }
            else if(desc.Length < 2)
            {
                throw new ArgumentException("Description can not be empty");
            }
            else
            {
                Game data = new Game(type, name, desc);
                Database.Games.Add(data);
            }
        }
        public static void AddGame(Game.Category type, string name, string desc, string require)
        {
            if (name.Length < 2)
            {
                throw new ArgumentException("Game's title is too short");
            }
            else if (desc.Length < 2)
            {
                throw new ArgumentException("Description can not be empty");
            }
            else
            {
                Game data = new Game(type, name, desc);
                Database.Games.Add(data);
            }
        }

        public static void EditGame()
        {

        }

        public static void GenerateRandomGame()
        {
            string username = "Player1";
            string author = "Game Player";
            currentUser = new User(username, author);
            Database.Users.Add(currentUser);

            for (int i = 0; i < 10; i++)
            {
                string name = GameNames(i);
                string desc = RandomText();
                Game.Category type = noise.Next(1, 10) < 5 ? Game.Category.Child : Game.Category.Drink;
                Game data = new Game(type, name, desc);
                data.UserID = 1;
                Database.Games.Add(data);
            }
        }

        public static void GenerateRandomGame(bool limit)
        {
            if(limit && Database.Games.Count == 0)
            {
                string username = "Player1";
                string author = "Game Player";
                currentUser = new User(username, author);
                Database.Users.Add(currentUser);

                for (int i = 0; i < 10; i++)
                {
                    string name = GameNames(i);
                    string desc = RandomText();
                    Game.Category type = noise.Next(1, 10) < 5 ? Game.Category.Child : Game.Category.Drink;
                    Game data = new Game(type, name, desc);
                    data.UserID = 1;
                    Database.Games.Add(data);
                }
            }
            else if(!limit)
            {
                string username = "Player1";
                string author = "Game Player";
                currentUser = new User(username, author);
                Database.Users.Add(currentUser);

                for (int i = 0; i < 10; i++)
                {
                    string name = GameNames(i);
                    string desc = RandomText();
                    Game.Category type = noise.Next(1, 10) < 5 ? Game.Category.Child : Game.Category.Drink;
                    Game data = new Game(type, name, desc);
                    data.UserID = 1;
                    Database.Games.Add(data);
                }
            }
        }

        private static string GameNames(int index)
        {
            string[] name = new string[] { "Meya", "Fanger", "Løb", "Poker", "Fodbold", "Jumping", "Magician", "Roller", "Warlock", "Fluffy"};

            try
            {
                return name[index];
            }
            catch (Exception)
            {
                return name[noise.Next(0, name.Length - 1)];
            }
        }
        private static string GameNames()
        {
            string[] name = new string[] { "Meya", "Fanger", "Løb", "Poker", "Fodbold", "Jumping", "Magician" };
            return name[noise.Next(0, name.Length - 1)];
        }

        private static string RandomText()
        {
            string[] txt = { "this", "is", "are", "be", "have", "has", "a", "best", "worst", "game", "player", "max", "adult", "children", "never" };
            string input = GameNames();
            string data = "";
            int size = noise.Next(8, 128);
            int max = txt.Length - 1;
            for (int i = 0; i < size; i++)
            {
                int index = noise.Next(0, max);
                data += txt[index];
                data += " ";
                if ((max / 2) < index)
                {
                    data += input;
                    data += " ";
                }
            }
            string text = data.Substring(0, 1).ToUpper() + data.Substring(1);
            return text.TrimEnd(' ');
        }

        private static string RandomText(string input)
        {
            string[] txt = { "this", "is", "are", "be", "have", "has", "a", "best", "worst", "game", "player", "max", "adult", "children", "never" };
            string data = "";
            int size = noise.Next(8, 128);
            int max = txt.Length - 1;
            for (int i = 0; i < size; i++)
            {
                int index = noise.Next(0, max);
                data += txt[index];
                data += " ";
                if((max / 2) < index)
                {
                    data += input;
                    data += " ";
                }
            }
            string text = data.Substring(0, 1).ToUpper() + data.Substring(1);
            return text.TrimEnd(' ');
        }

        private static string RandomText(int size, string input)
        {
            string[] txt = {"this", "is", "are", "be", "have", "has", "a", "best", "worst", "game", "player", "max", "adult", "children", "never"};
            string data = "";
            int max = txt.Length - 1;
            for (int i = 0; i < size; i++)
            {
                int index = noise.Next(0, max);
                data += txt[index];
                data += " ";
                if ((max / 2) < index)
                {
                    data += input;
                    data += " ";
                }
            }
            string text = data.Substring(0, 1).ToUpper() + data.Substring(1);
            return text.TrimEnd(' ');
        }
    }
}
