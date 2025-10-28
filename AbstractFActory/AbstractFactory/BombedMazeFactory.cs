using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFActory.AbstractFactory
{
    public class BombedMazeFactory: MazeFactory
    {
        public bool active = false;
        public BombedMazeFactory()
        {
            Console.WriteLine("Создана BombedMazeFactory");
        }
        public override Room MakeRoom(int n) => new RoomWithBomb(n, active);
        public override Door MakeDoor(Room r1, Room r2) => new DoorWithBomb(r1, r2);
    }
}
