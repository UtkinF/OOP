using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze(){}
        List<Room> _rooms = new List<Room>();
        public Maze(Maze otherroom)
        {
            _rooms = otherroom._rooms;
        }
        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public Room RoomNo(int number)
        {
            for (int i = 0; i < _rooms.Count; i++)
            {
                if (_rooms[i].RoomNumber == number)
                    return _rooms[i];
            }
            return null;
        }
    }
}
