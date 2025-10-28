using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary
{
    public class Bomb
    {
        public bool ActiveBomb { get; set; }
        public Bomb(bool active)
        {
            ActiveBomb = active;
        }
    }
}
