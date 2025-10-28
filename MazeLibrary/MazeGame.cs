using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary;

namespace MazeLibrary
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var cMaze = new Maze();
            var room1 = new Room(1);
            var room2 = new Room(2);
            var door = new Door(room1, room2);

            cMaze.AddRoom(room1);
            cMaze.AddRoom(room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door);

            return cMaze;
        }
    }
}
