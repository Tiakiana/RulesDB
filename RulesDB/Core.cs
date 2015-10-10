using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    static class Core
    {
        public static Engine AppController = new Engine();
        public static Form CurrentForm;
        private static Random noise = new Random();

        public static void Initialize()
        {
            // Generate games
            GenerateGames();

            // Ordering Form to be show at first
            
        }


        private static void DoTop10()
        {

        }

        private static void GenerateGames()
        {
            AppController.AddGame("Test 1", Game.GameType.Child, "Test", "Hello world 1");
            AppController.AddGame("Test 2", Game.GameType.Child, "Test", "Hello world 2");
            AppController.AddGame("Test 3", Game.GameType.Child, "Test", "Hello world 3");
            AppController.AddGame("Test 4", Game.GameType.Child, "Test", "Hello world 4");
            AppController.AddGame("Test 5", Game.GameType.Child, "Test", "Hello world 5");
            AppController.AddGame("Test 6", Game.GameType.Child, "Test", "Hello world 6");
            AppController.AddGame("Test 7", Game.GameType.Child, "Test", "Hello world 7");
            AppController.AddGame("Test 8", Game.GameType.Child, "Test", "Hello world 8");
            AppController.AddGame("Test 9", Game.GameType.Child, "Test", "Hello world 9");
            AppController.AddGame("Test 10", Game.GameType.Child, "Test", "Hello world 10");
        }
    }
}
