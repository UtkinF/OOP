using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class BombedWall: Wall
    {
        public BombedWall() { }
        public bool Damage { get; set; }
        public override void Enter()
        {
            Console.WriteLine("Вы в стене, поврежденной взрывом!");
        }
    }
}
