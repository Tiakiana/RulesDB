using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    class Engine
    {
        private Database games = new Database();

        public void DisplayMenu()
        {
            
        }

        public void GetTop10(ref ListBox box)
        {
            IEnumerable<string> select = games.gameList.Select(x => x.Title);
            List<string> data = select.ToList();
            box.DataSource = data;
        }

        public List<Game> Search(string input)
        {
            IEnumerable<Game> data;
            List<Game> result = new List<Game>() { };

            // Search Title
            data = games.gameList.Where(x => x.Title.Contains(input));
            result = data.ToList();
            if(result.Count > 0)
            {
                return result;
            }

            // Search Author
            data = games.gameList.Where(x => x.Author.Contains(input));
            result = data.ToList();
            if(result.Count > 0)
            {
                return result;
            }

            return new List<Game>() { };
        }

        public void AddGame(string title, Game.GameType type, string author, string desc)
        {
            // Check exist title
            if (title.Length > 1 && games.gameList.Exists(x => x.Title == title))
            {
                throw new Error("Title is already exist", 1);
            }
            // Check author
            if (author.Length < 3)
            {
                throw new Error("Too short Author's name", 2);
            }
            // Check description
            if (desc.Length < 4)
            {
                throw new Error("Too short description", 3);
            }

            Game data = new Game(title, type, author, desc);
            games.gameList.Add(data);
        }

        public void AddGame(string title, Game.GameType type, string author, string desc, string require)
        {
            // Check exist title
            if (title.Length > 1 && games.gameList.Exists(x => x.Title == title))
            {
                throw new Error("Title is already exist", 1);
            }
            // Check author
            if (author.Length < 3)
            {
                throw new Error("Too short Author's name", 2);
            }
            // Check description
            if (desc.Length < 4)
            {
                throw new Error("Too short description", 3);
            }

            Game data = new Game(title, type, author, desc, require);
            games.gameList.Add(data);
        }

        public void EditGame(int index, string title)
        {
            if(games.gameList[index] != null)
            {
                Game data = games.gameList.ElementAt(index);
                data.Title = title;
                data.EditDate = DateTime.Now;
                games.gameList.Add(data);
            }
        }
        public void EditGame(int index, string title, string author)
        {
            if (games.gameList[index] != null)
            {
                Game data = games.gameList.ElementAt(index);
                data.Title = title;
                data.Author = author;
                data.EditDate = DateTime.Now;
                games.gameList.Add(data);
            }
        }
        public void EditGame(int index, string title, string author, string desc)
        {
            if (games.gameList[index] != null)
            {
                Game data = games.gameList.ElementAt(index);
                data.Title = title;
                data.Author = author;
                data.Description = desc;
                data.EditDate = DateTime.Now;
                games.gameList.Add(data);
            }
        }
        public void EditGame(int index, string title, string author, string desc, string require)
        {
            if (games.gameList[index] != null)
            {
                Game data = games.gameList.ElementAt(index);
                data.Title = title;
                data.Author = author;
                data.Description = desc;
                data.Requirement = require;
                data.EditDate = DateTime.Now;
                games.gameList.Add(data);
            }
        }
        public void EditGame(int index, Game.GameType type, string title, string author, string desc, string require)
        {
            Game data = games.gameList.ElementAt(index);
            data.Title = title;
            data.Type = type;
            data.Author = author;
            data.Description = desc;
            data.Requirement = require;
            data.EditDate = DateTime.Now;
            games.gameList.Add(data);
        }

        public void RemoveGame(int index)
        {
            games.gameList.RemoveAt(index);
        }

    }
}
