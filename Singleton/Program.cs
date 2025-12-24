using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using AbstractFActory.AbstractFactory;
using MazeLibrary;
using Singleton.Singleton;

namespace Program
{
    class ProgramSingleton
    {
        static void Main(string[] args)
        {
            try
            {
                UpgradeMazeGame game = new UpgradeMazeGame();

                MazeFactory mazeSingleton = MazeSingletonFactory.Instance();
                game.CreateMaze(mazeSingleton);

                MazeFactory mazeSingletonTwo = MazeSingletonFactory.Instance();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
