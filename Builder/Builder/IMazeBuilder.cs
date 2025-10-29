using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
namespace Builder.Builder
{
    public interface IMazeBuilder
    {
        public void BuildMaze() { }
        public void BuildRoom(int roomNumber) { }
        public void BuildDoor(int roomFrom, int roomTo) { }
        public Maze GetMaze()
        {
            return null;
        }
    }
}
