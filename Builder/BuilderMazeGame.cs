using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderMazeGame
    {
        public Maze CreateMaze(IMazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();
            mazeBuilder.BuildRoom(1);
            mazeBuilder.BuildRoom(2);
            mazeBuilder.BuildDoor(1, 2);
            return mazeBuilder.GetMaze();
        }
        public Maze CreateComplexMaze(IMazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();
            for (int i = 1; i <= 10; i++)
            {
                mazeBuilder.BuildRoom(i);
            }
            return mazeBuilder.GetMaze();
        }
    }
}
