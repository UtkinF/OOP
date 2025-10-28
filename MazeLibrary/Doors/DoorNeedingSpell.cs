using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;

namespace MazeLibrary.Doors
{
    public class DoorNeedingSpell: Door
    {
        public DoorNeedingSpell(Room r1, Room r2):base (r1,r2) { }
        public override void Enter()
        {
            if (Open)
                Console.WriteLine($"Вы вошли в дверь, требующую заклинание для открытия.");
            else
                Console.WriteLine("Для прохода в дверь нужен другой спел.");
        }
    }
}
