using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesrule
{
    public class Game
    {
        private static int currentID = 0;
        public enum Category { Child, Drink };

        public int ID;
        public int UserID;
        public Category Type;
        public string Name;
        public string Description;
        public string Requirement;
        public DateTime Publish;

        public Game(Category type)
        {
            this.ID = currentID;
            currentID++;
            this.Type = type;
            this.UserID = 1;
            this.Publish = DateTime.Now;
        }
        public Game(Category type, string name)
        {
            this.ID = currentID;
            currentID++;
            this.Type = type;
            this.Name = name;
            this.UserID = 1;
            this.Publish = DateTime.Now;
        }
        public Game(Category type, string name, string desc)
        {
            this.ID = currentID;
            currentID++;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.UserID = 1;
            this.Publish = DateTime.Now;
        }

        public Game(Category type, string name, string desc, string requirement)
        {
            this.ID = currentID;
            currentID++;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.Requirement = requirement;
            this.UserID = 1;
            this.Publish = DateTime.Now;
        }

        public Game(Category type, int id, string name, string desc, string requirement)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.Requirement = requirement;
            this.UserID = 1;
            this.Publish = DateTime.Now;
        }

        public Game(Category type, int id, string name, string desc, string requirement, int userid)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.Requirement = requirement;
            this.UserID = userid;
            this.Publish = DateTime.Now;
        }

        public Game(Category type, int id, string name, string desc, string requirement, DateTime publish)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.Requirement = requirement;
            this.UserID = 1;
            this.Publish = publish;
        }

        public Game(Category type, int id, string name, string desc, string requirement, int userid, DateTime publish)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;
            this.Description = desc;
            this.Requirement = requirement;
            this.UserID = userid;
            this.Publish = publish;
        }
    }
}
