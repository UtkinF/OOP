using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();
        public Maze(){}

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
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return _rooms.FirstOrDefault(x => x.RoomNumber == number);
        }

        public Maze Clone()
        {
            return new Maze(this);
        }
    }
}
