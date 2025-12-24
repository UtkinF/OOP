using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb: Room
    {
        protected bool _active;
        protected int RoomNo { get; }

        public RoomWithBomb(int roomNo, bool active):base(roomNo){}

        public RoomWithBomb(int number) : base(number)
        {
            _active = true;
        }

        public RoomWithBomb(RoomWithBomb otherRoom) : base(otherRoom)
        {
            _active = otherRoom._active;
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в #{RoomNumber} комнату аккуратно");
        }

        public override Room Clone()
        {
            Console.WriteLine("Вы клонировали комнату с бомбой");
            return new RoomWithBomb(this);
        }
    }
}
