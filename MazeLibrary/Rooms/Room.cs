using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MazeLibrary.Rooms
{
    public class Room: MapSite
    {
        public int RoomNumber { get; set; }
        protected MapSite[] _sides = new MapSite[4];

        public Room(Room r1)
        {
            RoomNumber = r1.RoomNumber;
            _sides = new MapSite[4];
            for (int i = 0; i < 4; i++)
            {
                _sides[i] = r1._sides[i].Clone();
            }
        }

        public Room(int roomNo)
        {
            RoomNumber = roomNo;
            if (roomNo <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            SetSide(Direction.North, new Wall());
            SetSide(Direction.South, new Wall());
            SetSide(Direction.East, new Wall());
            SetSide(Direction.West, new Wall());
        }

        public void Initialize(int number)
        {
            Console.WriteLine($"Вы изменили № комнаты на {number}");
            RoomNumber = number;
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction directon, MapSite site)
        {
            _sides[(int)directon] = site;
        }

        public override void Enter()
        {
           Console.WriteLine($"Вы вошли в #{RoomNumber} комнату");
        }

        public override MapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную комнату");
            return new Room(this);
        }
    }
}
