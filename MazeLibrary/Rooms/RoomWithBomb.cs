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
        private bool active;
        public int RoomNo { get; }
        public RoomWithBomb(int roomNo, bool active): base(roomNo){}

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в #{RoomNumber} комнату аккуратно");
        }
    }
}
