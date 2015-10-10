using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    class Game
    {
        private static int currentID = 1;
        public int ID = 1;
        public int Views = 0;
        public string Title;
        public Game.GameType Type = Game.GameType.Child;
        public enum GameType {Child = 0, Drink = 1};
        public DateTime CreateDate = DateTime.Now;
        public DateTime EditDate;
        public string Author;
        public string Description;
        public string Requirement = string.Empty;

        public Game()
        {
            this.ID = currentID;
            currentID++;
        }

        public Game(string title)
        {
            this.ID = currentID;
            currentID++;
            this.Title = title;
        }

        public Game(string title, GameType type)
        {
            this.ID = currentID;
            currentID++;
            this.Title = title;
            this.Type = type;
        }

        public Game(string title, GameType type, string author)
        {
            this.ID = currentID;
            currentID++;
            this.Title = title;
            this.Type = type;
            this.Author = author;
        }

        public Game(string title, GameType type, string author, string desc)
        {
            this.ID = currentID;
            currentID++;
            this.Title = title;
            this.Type = type;
            this.Author = author;
            this.Description = desc;
        }

        public Game(string title, GameType type, string author, string desc, string require)
        {
            this.ID = currentID;
            currentID++;
            this.Title = title;
            this.Type = type;
            this.Author = author;
            this.Description = desc;
            this.Requirement = require;
        }

        public Game(int id, string title, GameType type, string author, string desc, string require)
        {
            this.ID = id;
            this.Title = title;
            this.Type = type;
            this.Author = author;
            this.Description = desc;
            this.Requirement = require;
        }
    }
}
