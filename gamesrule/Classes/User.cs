using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace gamesrule
{
    class User
    {
        private static int currentID = 1;
        private static byte[] inKey;
        private static byte[] Key
        {
            get
            {
                if(inKey == null)
                {
                    string word = "Hello world";
                    SHA256Managed sha = new SHA256Managed();
                    inKey = sha.ComputeHash(Encoding.ASCII.GetBytes(word));
                }
                return inKey;
            }
            set
            {
                if(value.Length == 32)
                {
                    inKey = value;
                }
                else
                {
                    throw new Exception(String.Format("Inavlid byte[] size, given ({0})", value.Length));
                }
            }
        }

        public int ID;
        public string Username;
        public string Name;

        public User()
        {
            this.ID = currentID;
            currentID++;
        }

        public User(string username)
        {
            this.ID = currentID;
            currentID++;
            this.Username = username.ToLower();
        }

        public User(string username, string name)
        {
            this.ID = currentID;
            currentID++;
            this.Username = username.ToLower();
            this.Name = name;
        }

        public User(int id, string username, string name)
        {
            this.ID = id;
            this.Username = username.ToLower();
            this.Name = name;
            currentID++;
        }

        public void Login(string username, string password)
        {

        }
        
    }
}
