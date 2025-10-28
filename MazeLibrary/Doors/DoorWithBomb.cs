using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class DoorWithBomb:Door
    {
            public DoorWithBomb(Room r1, Room r2) : base(r1, r2) { }
            public override void Enter()
            {
                if (Open)
                    Console.WriteLine("Вы прошли через дверь, потому что разминировали бомбу.");
                else
                    Console.WriteLine("Вы не смогли разминировать бомбу.");
        }
    }
}
