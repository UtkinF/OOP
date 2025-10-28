using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;

namespace MazeLibrary.Doors
{
    public class Door: MapSite
    {
        public bool Open;
        Room room1, room2;
        public Door(Room r1, Room r2)
        {
            room1 = r1;
            room2 = r2;
            Open = false;
        }
        public override void Enter()
        {
            if (Open)
            {
                Console.WriteLine($"Вы прошли через дверь между {room1.RoomNumber} и {room2.RoomNumber} комнатой");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
    }
}
