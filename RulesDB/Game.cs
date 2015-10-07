using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    class Game
    {
        public int ID;
        public int Views = 0;
        public string Title;
        public enum Type {Child = 0, Drink = 1};
        public DateTime CreateDate;
        public DateTime EditDate;
        public string Author;
        public string Description;
        public string Requirement;
    }
}
