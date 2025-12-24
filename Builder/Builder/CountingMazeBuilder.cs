using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class CountingMazeBuilder : IMazeBuilder
    {
        private int rooms;
        private int doors;

        public CountingMazeBuilder()
        {
            rooms = doors = 0;
        }

        public void BuildRoom(int roomNumber)
        {
            rooms++;
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            doors++;
        }

        public void GetCounts(out int _rooms, out int _doors)
        {
            _rooms = rooms;
            _doors = doors;
        }
    }
}
