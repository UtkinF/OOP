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
        private Room _r1;
        private Room _r2;

        public Door(Door otherDoor)
        {
            _r1 = (Room)otherDoor._r1.Clone();
            _r2 = (Room)otherDoor._r2.Clone();
            Open = true;
        }

        public Door(Room r1, Room r2)
        {
            _r1 = r1;
            _r2 = r2;
            Open = false;
        }

        public void Initialize(Room room1, Room room2)
        {
            Console.WriteLine($"Вы изменили комнаты, между которыми находится дверь на комнату №{room1.RoomNumber} и комнату №{room2.RoomNumber}");
            _r1 = room1;
            _r2 = room2;
        }

        public override void Enter()
        {
            if (Open)
            {
                Console.WriteLine($"Вы прошли через дверь между {_r1.RoomNumber} и {_r2.RoomNumber} комнатой");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }

        public override MapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную дверь");
            return new Door(this);
        }
    }
}
