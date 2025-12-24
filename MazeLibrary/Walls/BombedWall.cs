using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class BombedWall: Wall
    {
        private bool _Damage { get; set; }
        public BombedWall() { }

        public BombedWall(BombedWall otherBombedWall)
        {
            _Damage = otherBombedWall._Damage;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы в стене, поврежденной взрывом!");
        }

        public override Wall Clone()
        {
            Console.WriteLine("Вы клонировали стену с бомбой");
            return new BombedWall(this);
        }
    }
}
