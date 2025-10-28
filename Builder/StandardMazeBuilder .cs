using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using static Builder.CreateDirection;

namespace Builder
{
    public class StandardMazeBuilder: IMazeBuilder
    {
        private Maze maze; 
        public StandardMazeBuilder()
        {
            Console.WriteLine("Вы создали фабрику");
            maze = new Maze();
        }
        public void BuildRoom(int n)
        {
            var room = new Room(n);
            maze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
        }
        public void BuildDoor(int n1,int n2)
        {
            var room1 = maze.RoomNo(n1);
            var room2 = maze.RoomNo(n2);

            var door = new Door(room1, room2);
            var dirFrom1To2 = CommonWall(room1, room2);
            var dirFrom2To1 = Opposite(dirFrom1To2);

            room1.SetSide(dirFrom1To2, door);
            room2.SetSide(dirFrom2To1, door);
        }

        public Maze GetMaze()
        {
            return maze;
        }
    }
}
