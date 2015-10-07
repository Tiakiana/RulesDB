using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    class Engine
    {
        private Database games = new Database();

        public List<Game> Search(string title, string type, string author, string desc)
        {
            
        }

        public void AddGame(string title, Game.Type type, string author, string desc, string require)
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
        }

        public void EditGame(int index, string title)
        {

        }
        public void EditGame(int index, string title, string author)
        {

        }
        public void EditGame(int index, string title, string author, string desc)
        {

        }
        public void EditGame(int index, string title, string author, string desc, string require)
        {

        }
        public void EditGame(int index, Game.Type type, string title, string author, string desc, string require)
        {

        }

        public void RemoveGame(int index)
        {
            games.gameList.RemoveAt(index);
        }

    }
}
