using GOD_V2.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM
{
    internal class Game
    {
        public Category? gamecategory {  get; set; }
        public bool Gamemode {  get; set; }

        public List<string> Teams = new List<string>();

        private static Game currentgame { get; set; }

        private Game()
        {
            
        }

        public static void CreateGame()
        {
            Game game = new Game();
            currentgame = game;
        }

        public static void SetCategory(Category category)
        {
            currentgame.gamecategory = category;
        }
        public static void SetGamemode(bool gamemode)
        {
            //true = Guess
            //False = Portray
            currentgame.Gamemode = gamemode;
        }
        
        public static Game GetGame()
        {
            return currentgame;
        }
    }
}
