using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace AbstractFActory.AbstractFactory
{
    public class UpgradeMazeGame: MazeFactory
    {
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            var aMaze = mazeFactory.MakeMaze();
            var r1 = mazeFactory.MakeRoom(1);
            var r2 = mazeFactory.MakeRoom(2);
            var theDoor = mazeFactory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, mazeFactory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, mazeFactory.MakeWall());
            r1.SetSide(Direction.West, mazeFactory.MakeWall());

            r2.SetSide(Direction.North, mazeFactory.MakeWall());
            r2.SetSide(Direction.East, mazeFactory.MakeWall());
            r2.SetSide(Direction.South, mazeFactory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            r1.Enter();
            theDoor.Open = true;
            theDoor.Enter();
            r2.Enter();
            theDoor.Open = false;
            theDoor.Enter();
            Console.WriteLine();

            return aMaze;
        }
    }
}
