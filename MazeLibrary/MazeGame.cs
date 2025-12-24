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
            var r1 = new Room(1);
            var r2 = new Room(2);
            var door = new Door(r1, r2);

            cMaze.AddRoom(r1);
            cMaze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, door);

            return cMaze;
        }
    }
}
