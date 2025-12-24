using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using static Builder.Builder.CreateDirection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Builder.Builder
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _maze;

        public StandardMazeBuilder()
        {
            Console.WriteLine("Вы создали фабрику");
            _maze = new Maze();
        }

        public void BuildRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            var room = new Room(n);
            _maze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
            Console.WriteLine($"Вы построили комнату №{n}");
        }

        public void BuildDoor(int n1, int n2)
        {
            var room1 = _maze.RoomNo(n1);
            var room2 = _maze.RoomNo(n2);

            var door = new Door(room1, room2);
            var dirFrom1To2 = CommonWall(room1, room2);
            var dirFrom2To1 = Opposite(dirFrom1To2);

            room1.SetSide(dirFrom1To2, door);
            room2.SetSide(dirFrom2To1, door);
            Console.WriteLine($"Вы построили дверь между комнатам №{room1.RoomNumber} и №{room2.RoomNumber}");
        }

        public Maze GetMaze()
        {
            return _maze;
        }
    }
}
