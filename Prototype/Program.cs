using MazeLibrary;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazePrototype.MazePrototype;
using AbstractFactory;
using AbstractFActory.AbstractFactory;

namespace ProgramPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            UpgradeMazeGame game = new UpgradeMazeGame();

            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new Room(1), new Door(new Room(2), new Room(3)));
            Maze maze = game.CreateMaze(simpleMazeFactory);

            MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(new Maze(), new BombedWall(), new RoomWithBomb(8), new Door(new RoomWithBomb(2), new RoomWithBomb(10)));
            Maze bombedmaze = game.CreateMaze(bombedMazeFactory);

            MazePrototypeFactory enchantedMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new EnchantedRoom(12), new Door(new EnchantedRoom(7), new EnchantedRoom(9)));
            Maze enchantedmaze = game.CreateMaze(enchantedMazeFactory);

            Console.ReadKey();
        }
    }
}
