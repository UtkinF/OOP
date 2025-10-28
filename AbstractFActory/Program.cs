using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFActory.AbstractFactory;
using MazeLibrary;

namespace AbstractFactory
{
    public  class Program
    {
        static void Main(string[] args)
        {
            UpgradeMazeGame game = new UpgradeMazeGame();

            SimpleMazeFactory simpleMazeFactory = new SimpleMazeFactory();
            game.CreateMaze(simpleMazeFactory);

            EnchantedMazeFactory enchantedMazeFactory = new EnchantedMazeFactory();
            game.CreateMaze(enchantedMazeFactory);

            BombedMazeFactory bombedMazeFactory = new BombedMazeFactory();
            game.CreateMaze(bombedMazeFactory);

            Console.ReadKey();
        }
    }
}
